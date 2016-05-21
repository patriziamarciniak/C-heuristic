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
        BindingSource SBind = new BindingSource(); //obiekt 'komunikatora' miedzy DataTable a DataGridView

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
            int columns = DTable.Columns.Count;
            for (int i = 1; i <= columns ; i++)
            {
               DTable.Columns.Remove(i.ToString());
            }
        }

        private void generateEmptyTable(int columns, int rows)
        {
            for (int i = 1; i <= columns; i++)
            {
                DTable.Columns.Add(i.ToString());
            }
            for (int i = 1; i <= rows; i++)
            {
                DTable.Rows.Add();
            }
            console.Text = console.Text + "Utworzono tabele";
        }

        private void fillTable(int columns)
        {
            Random rnd = new Random();
            int seqLength = rnd.Next(1, columns + 1);
            int start = rnd.Next(1, columns - seqLength + 2);
        }
             
        /////////////////////////////////////////////

        private void buttonGenerateInstance_Click(object sender, EventArgs e)
        {
            clearTable();
            generateEmptyTable( int.Parse(comboBoxSamples.Text), int.Parse(comboBoxPlaces.Text));
            fillTable(int.Parse(comboBoxPlaces.Text));

        }

        private void buttonGenerateErrors_Click(object sender, EventArgs e)
        {
            clearTable();
            //console.Text = DTable.Columns.Count.ToString();
            //DTable.Columns.Remove("1");
        }
    }
}
