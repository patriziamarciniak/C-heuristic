using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Projekt_Zaawansowane_Programowanie
{
    public partial class Form1 : Form
    {
        DataTable DTable = new DataTable(); 
        BindingSource SBind = new BindingSource();
        List<int> pierwsza = new List<int>();
        List<int> druga = new List<int>();

        public Form1()
        {
            InitializeComponent();
            fillComponents();

            SBind.DataSource = DTable; // 1st lvl connection
            dataGridViewInput.DataSource = SBind; // final connection

            /*
            for (int i = 0; i <=5; i++)
            {
                pierwsza.Add(i);
            }


            druga = pierwsza.Clo
            druga[0] = 222;
            for (int i = 0; i <= 5; i++)
            {
               Debug.WriteLine("pierwsza" + Convert.ToString(pierwsza[i]));
                Debug.WriteLine("druga" + Convert.ToString(pierwsza[i]));
            }
            */

        }

        ///////////////////////////////////////////
        private void fillComponents()
        {
            for (int i = 1; i <= 100; i++)
            {
                this.comboBoxErrors.Items.Add(i);
                this.comboBoxSamples.Items.Add(i);
                this.comboBoxPlaces.Items.Add(i);
            };
            comboBoxPlaces.SelectedIndex = 9;
            comboBoxSamples.SelectedIndex = 6;
            comboBoxErrors.SelectedIndex = 5;
            comboBoxLevel.SelectedIndex = 1;
        }

        private void clearTable()
        {
            List<DataRow> rowsToDelete = new List<DataRow>();
            foreach (DataRow row in DTable.Rows)
            {
                rowsToDelete.Add(row);
            }
            foreach (DataRow row in rowsToDelete)
            {
                DTable.Rows.Remove(row);
            }

            int columns = DTable.Columns.Count;
            for (int i = 0; i < columns ; i++)
            {
               DTable.Columns.Remove(i.ToString());
            }

        }

        private void generateEmptyTable(int columns, int rows)
        {
            Random rnd = new Random();

            for (int i = 0; i < columns; i++)
            {
                DTable.Columns.Add(i.ToString());
            }

            for (int i = 0; i < rows; i++)
            {
                DTable.Rows.Add();
            }

            for (int i = 0; i < rows; i++)
            {
                for (int ii = 0; ii < columns; ii++)
                {
                    DTable.Rows[i][ii] = "0";
                }
            }
        }

        private void fillTable(String level)
        {
            int columns = DTable.Columns.Count;
            int rows = DTable.Rows.Count;
            Random rnd = new Random();
            int seqLength = 0;
            int start;
            int flag;

            for (int i = 0; i < rows; i++)
            {
                switch (level)
                {
                    case "Łatwy":
                        flag = rnd.Next(0, 2);
                        if (flag == 0)
                        {
                            seqLength = rnd.Next(Convert.ToInt32(columns * 0.1), Convert.ToInt32(columns * 0.3));
                        }else
                        {
                            seqLength = rnd.Next(Convert.ToInt32(columns * 0.8), columns);
                        }
                        break;
                    case "Średni":
                        flag = rnd.Next(0, 2);
                        if (flag == 0)
                        {
                            seqLength = rnd.Next(Convert.ToInt32(columns * 0.3), Convert.ToInt32(columns * 0.4));
                        }
                        else
                        {
                            seqLength = rnd.Next(Convert.ToInt32(columns * 0.7), Convert.ToInt32(columns * 0.8));
                        }
                        break;
                    case "Trudny":
                        seqLength = rnd.Next(Convert.ToInt32(columns * 0.4), Convert.ToInt32(columns * 0.7));
                        break;
                }
                start = rnd.Next(0, columns - seqLength + 1);
                
                for (int ii = start ; ii < start + seqLength ; ii++)
                {
                    DTable.Rows[i][ii] = "1";
                    dataGridViewInput.Rows[i].Cells[ii].Style.BackColor = Color.DeepSkyBlue;
                }
            }
        }

        private List<Tuple<int, int>> generateErrors(int errors)
        {
            if (errors > (DTable.Columns.Count * DTable.Rows.Count))
            {
                MessageBox.Show("Podana liczba błędów, przekracza liczbe komórek.");
                //dopisać obsługę błędów
            }
            Random rnd = new Random();
            List<Tuple<int, int>> errorsList = new List<Tuple<int, int>>();

            while (errorsList.Count != errors)
            {
                int col = rnd.Next(0, DTable.Columns.Count);
                int row = rnd.Next(0, DTable.Rows.Count);
                Boolean flag = false;

                foreach (var i in errorsList)
                {
                    if (i.Item1.Equals(row) && i.Item2.Equals(col))
                    {
                        flag = true;
                    }
                }
                if (!flag)
                {
                    errorsList.Add(new Tuple<int, int>(row, col));
                }
            }

            return errorsList;
        }

        private void fillErrors(int errors)
        {
            List<Tuple<int, int>> errorsList = generateErrors(int.Parse(comboBoxErrors.Text));

            int columns = DTable.Columns.Count;
            int rows = DTable.Rows.Count;

            foreach (var i in errorsList)
            {
                if (DTable.Rows[i.Item1][i.Item2].ToString() == "0")
                {
                    DTable.Rows[i.Item1][i.Item2] = "1";
                }
                else
                {
                    DTable.Rows[i.Item1][i.Item2] = "0";
                }
                dataGridViewInput.Rows[i.Item1].Cells[i.Item2].Style.BackColor = Color.Red;
            }
        }

        public void shuffle()
        {
            Random r = new Random();
            for (int i = 0; i < 100; i++)
            {
                int a = r.Next(0, DTable.Columns.Count);
                int b = r.Next(0, DTable.Columns.Count);
                moveColumn(a, b, DTable);
            }
        }

        private void saveToFile()
        {
            DTable.TableName = "Tablica danych";
            DTable.WriteXml("instancja.xml");
            MessageBox.Show("Instancja zapisana do pliku 'bin/debug/instancja.xml'.");
            /*
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Stream s = File.Open(saveFileDialog.FileName, FileMode.CreateNew);
                StreamWriter writer = new StreamWriter(s);
                writer.Write("aaaaasadas");
                writer.Close();
            }
            */
        }

        private void readFile()
        {
            dataGridViewInput.DataSource = null;
            dataGridViewInput.AutoGenerateColumns = true;
            XmlReader xmlFile = XmlReader.Create("instancja.xml", new XmlReaderSettings());
            DataSet data = new DataSet();
            data.ReadXml(xmlFile);
            xmlFile.Close();

            DTable = data.Tables[0];
            SBind = new BindingSource();
            SBind.DataSource = DTable;
            dataGridViewInput.DataSource = SBind;
            /*
            DialogResult result = openFileInput.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileInput.FileName;
                Debug.WriteLine(file); // <-- For debugging use.    
            }
            */
        }

        public void moveColumn(int column, int index, DataTable DTable)
        {
            DTable.Columns[Convert.ToString(column)].SetOrdinal(index);
            /*
            for (int i = 0; i < DTable.Rows.Count; i++)
            {
                for (int ii = 0; ii < DTable.Columns.Count; ii++)
                {
                    if (Convert.ToString(DTable.Rows[i][ii]) == "1")
                        dataGridViewInput.Rows[i].Cells[ii].Style.BackColor = Color.DeepSkyBlue;
                }
            }
            */
        }


        //////////////////////////////////////////////////////////////////////////////////
        //obsługa elementów
        /// /////////////////////////////////////////////////////////////////////////////


        private void buttonGenerateInstance_Click(object sender, EventArgs e)
        {
            clearTable();
            generateEmptyTable( int.Parse(comboBoxPlaces.Text), int.Parse(comboBoxSamples.Text) );
            fillTable(comboBoxLevel.Text);
           // shuffle();
        }

        private void buttonGenerateErrors_Click(object sender, EventArgs e)
        {
            fillErrors(int.Parse(comboBoxErrors.Text));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clearTable();
            generateEmptyTable(int.Parse(comboBoxPlaces.Text), int.Parse(comboBoxSamples.Text));
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            shuffle();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            readFile();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            saveToFile();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //localSearch(1);
            LocalSearch ls = new LocalSearch(DTable);
            ls.Show();
            this.Visible = false;
        }
    }
}
