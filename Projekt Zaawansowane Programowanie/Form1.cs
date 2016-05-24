using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_Zaawansowane_Programowanie
{
    public partial class Form1 : Form
    {
        DataTable DTable = new DataTable(); //nowa tebelka danych
        BindingSource SBind = new BindingSource();


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
            comboBoxPlaces.SelectedIndex = 5;
            comboBoxSamples.SelectedIndex = 5;
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
            for (int i = 1; i <= columns ; i++)
            {
               DTable.Columns.Remove(i.ToString());
            }

        }

        private void generateEmptyTable(int columns, int rows)
        {
            Random rnd = new Random();

            for (int i = 1; i <= columns; i++)
            {
                DTable.Columns.Add(i.ToString());
            }

            for (int i = 1; i <= rows; i++)
            {
                    DTable.Rows.Add();
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
                int start = rnd.Next(1, columns - seqLength + 2);
                
                for (int ii = 0; ii < start -1 ; ii++)
                {
                    DTable.Rows[i][ii] = "0";
                }
                for (int ii = start -1; ii < start + seqLength -1; ii++)
                {
                    DTable.Rows[i][ii] = "1";
                    dataGridViewInput.Rows[i].Cells[ii].Style.BackColor = Color.Olive;
                }
                for (int ii = start + seqLength - 1; ii < columns; ii++)
                {
                    DTable.Rows[i][ii] = "0";
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

/////////////////////////////////////////////

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
    }
}
