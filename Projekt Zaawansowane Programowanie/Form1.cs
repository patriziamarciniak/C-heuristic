using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_Zaawansowane_Programowanie
{
    public partial class Form1 : Form
    {
        UserErrors UserErrors = new UserErrors();
        DataTable DTable = new DataTable(); //nowa tebelka danych
        BindingSource SBind = new BindingSource();
        int errors;


        //DataTable Instance = new DataTable();
        //SBind = new BindingSource(); //obiekt 'komunikatora' miedzy DataTable a DataGridView
        //SBind.DataSource = DTable; // 1st lvl connection
        //	dataGridView2.DataSource = SBind; // final connection
        ////DataTable DTable;
        ////BindingSource SBind; //zmienna globalna

        public Form1()
        {
            InitializeComponent();
            fillComponents();

            SBind.DataSource = DTable; // 1st lvl connection
            dataGridViewInput.DataSource = SBind; // final connection



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
            comboBoxSamples.SelectedIndex = 9;
            comboBoxErrors.SelectedIndex = 5;
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

        private void fillTable()
        {
            int columns = DTable.Columns.Count;
            int rows = DTable.Rows.Count;
            Random rnd = new Random();

            console.Text = " ";
            for (int i = 0; i < rows; i++)
            {
                int seqLength = rnd.Next(1, columns + 1);
                int start = rnd.Next(0, columns - seqLength + 1);
                
                /*
                for (int ii = 0; ii < start -1 ; ii++)
                {
                    DTable.Rows[i][ii] = "0";
                }
                */
                for (int ii = start ; ii < start + seqLength ; ii++)
                {
                    DTable.Rows[i][ii] = "1";
                    dataGridViewInput.Rows[i].Cells[ii].Style.BackColor = Color.Olive;
                }
                /*
                for (int ii = start + seqLength - 1; ii < columns; ii++)
                {
                    DTable.Rows[i][ii] = "0";
                }
                */
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
            /*
            foreach (var i in errorsList)
            {
                console.Text = console.Text + i.Item1.ToString() + i.Item2.ToString() + " || ";
            }
            */
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

        public void swapColumn(int a, int b)
        {
            for (int i = 0; i < DTable.Rows.Count; i++)
            {
                if(DTable.Rows[i][Convert.ToString(a)] != DTable.Rows[i][Convert.ToString(b)])
                {
                    String o = Convert.ToString(DTable.Rows[i][Convert.ToString(a)]);
                    DTable.Rows[i][Convert.ToString(a)] = Convert.ToString(DTable.Rows[i][Convert.ToString(b)]);
                    DTable.Rows[i][Convert.ToString(b)] = o;
                }
            }
            Debug.WriteLine(Convert.ToString(a), Convert.ToString(b));
            DTable.Columns[Convert.ToString(b)].ColumnName = "h";
            DTable.Columns[Convert.ToString(a)].ColumnName = Convert.ToString(b);
            DTable.Columns["h"].ColumnName = Convert.ToString(a);



        }

        public void shuffle()
        {
            Random r = new Random();
            for (int i = 0; i < 100; i++)
            {
                int a = r.Next(0, DTable.Columns.Count);
                int b = r.Next(0, DTable.Columns.Count);
                if (a != b)
                {
                    swapColumn(a, b);
                }
        }
            /*
            int[] deck = new int[DTable.Columns.Count];
            for (int i = 0; i < DTable.Columns.Count; i++) {
                deck[i] = i;
                console.Text = console.Text + Convert.ToString(deck[i]);
            }
            Random r = new Random();
            for (int n = deck.Length - 1; n > 0; --n)
            {
                int k = r.Next(n + 1);
                int temp = deck[n];
                deck[n] = deck[k];
                deck[k] = temp;
            }
            console.Text = console.Text + ":::";
            for (int i = 0; i < DTable.Columns.Count; i++)
            {
                console.Text = console.Text + deck[i].ToString();
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
            fillTable();
        }

        private void buttonGenerateErrors_Click(object sender, EventArgs e)
        {
            fillErrors(int.Parse(comboBoxErrors.Text));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // UserErrors.Show();
            clearTable();
            generateEmptyTable(int.Parse(comboBoxPlaces.Text), int.Parse(comboBoxSamples.Text));
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            //swapColumn(8, 9);
            shuffle();
        }

        /*
        public void getUserErrors(string text)
        {
            this.errors = int.Parse(text);
            console.Text = text;
        }
        */
    }
}
