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
using System.Threading;


namespace Projekt_Zaawansowane_Programowanie
{
    public partial class Form1 : Form
    {
        DataTable DTable = new DataTable();
        DataTable DTableBest = new DataTable();
        BindingSource SBind = new BindingSource();
        Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
            fillComponents();
            SBind.DataSource = DTable;
            dataGridViewInput.DataSource = SBind;
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
            comboBoxPlaces.SelectedIndex = 29;
            comboBoxSamples.SelectedIndex = 29;
            comboBoxErrors.SelectedIndex = 89;
            comboBoxLevel.SelectedIndex = 1;
        }

        public void clearTable(DataTable DTable)
        {
            List<DataRow> rowsToDelete = new List<DataRow>();
            foreach (DataRow row in DTable.Rows)
                rowsToDelete.Add(row);

            foreach (DataRow row in rowsToDelete)
                DTable.Rows.Remove(row);

            int columns = DTable.Columns.Count;
            for (int i = 0; i < columns; i++)
                DTable.Columns.Remove(i.ToString());

            rowsToDelete.Clear();

        }

        private void generateEmptyTable(int columns, int rows)
        {
            Stopwatch watch = Stopwatch.StartNew();
            
            for (int i = 0; i < columns; i++)
                DTable.Columns.Add(i.ToString());

            for (int i = 0; i < rows; i++)
                DTable.Rows.Add();
            for (int i = 0; i < rows; i++)
            {
                 for (int ii = 0; ii < columns; ii++)
                    DTable.Rows[i][ii] = "0";
            }

            foreach (DataGridViewColumn column in dataGridViewInput.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            watch.Stop();
            var time = watch.ElapsedMilliseconds;
            Debug.WriteLine("czas tworzenia i wypełniania DTable watch:" + Convert.ToString(time/1000.00));

        }

        private void fillTable(String level)
        {
            int columns = DTable.Columns.Count;
            int rows = DTable.Rows.Count;
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
                        } else
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

                for (int ii = start; ii < start + seqLength; ii++)
                {
                    DTable.Rows[i][ii] = "1";
                    dataGridViewInput.Rows[i].Cells[ii].Style.BackColor = Color.DeepSkyBlue;
                }
            }
        }

        private List<Tuple<int, int>> generateErrors(int errors)
        {
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
            for (int i = 0; i < DTable.Columns.Count; i++)
            {
                int a = rnd.Next(0, DTable.Columns.Count);
                int b = rnd.Next(0, DTable.Columns.Count);
                DTable.Columns[Convert.ToString(a)].SetOrdinal(b);
            }
        }

        public void saveToFile(DataTable DTable)
        {
            SaveFileDialog saveFileInput = new SaveFileDialog();
            saveFileInput.ShowDialog();

            if (saveFileInput.FileName != "")
            {
                System.IO.FileStream fs =
                   (System.IO.FileStream)saveFileInput.OpenFile();

                DTable.TableName = "Tablica danych";
                DTable.WriteXml(fs);
                MessageBox.Show("Instancja zapisana do pliku" + Convert.ToString(fs.Name) );
                fs.Close();
            }
        }

        private void readFile()
        {
            dataGridViewInput.DataSource = null;
            dataGridViewInput.AutoGenerateColumns = true;

            if (openFileInput.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamReader sr = new
                System.IO.StreamReader(openFileInput.FileName);
                XmlReader xmlFile = XmlReader.Create(sr, new XmlReaderSettings());
                DataSet data = new DataSet();
                data.ReadXml(xmlFile);
                xmlFile.Close();
                DTable = data.Tables[0];
                SBind = new BindingSource();
                SBind.DataSource = DTable;
                dataGridViewInput.DataSource = SBind;
                sr.Close();
            }
        }


        
        //////////////////////////////////////////////////////////////////////////////////
        //obsługa elementów
        /////////////////////////////////////////////////////////////////////////////////


        private void buttonGenerateInstance_Click(object sender, EventArgs e)
        {
            clearTable(DTable);
            generateEmptyTable(int.Parse(comboBoxPlaces.Text), int.Parse(comboBoxSamples.Text));
            SBind.DataSource = DTable;
            dataGridViewInput.DataSource = SBind;
            fillTable(comboBoxLevel.Text);
        }

        private void buttonGenerateErrors_Click(object sender, EventArgs e)
        {
            fillErrors(int.Parse(comboBoxErrors.Text));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clearTable(DTable);
            generateEmptyTable(int.Parse(comboBoxPlaces.Text), int.Parse(comboBoxSamples.Text));
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            readFile();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            saveToFile(DTable);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            shuffle();
            LocalSearch ls = new LocalSearch(DTable);
            ls.Show();
            this.Visible = false;
        }
    } }

  

