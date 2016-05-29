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
            for (int i = 0; i < columns; i++)
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

        // //////////////////// Maszyneria do liczenia score /////////////


        private int countScore(DataTable DTable)
        {
            int score = 0;
            int start, end;
            List<int> row = new List<int>();
            List<int> subset = new List<int>();
            int[] startSet = new int[2];
            int rows = DTable.Rows.Count;
            int columns = DTable.Columns.Count;

            for (int i = 0; i < rows; i++)
            {
                for (int ii = 0; ii < columns; ii++)
                {
                    row.Add(Convert.ToInt32(DTable.Rows[i][ii]));
                }

                if (row.FindIndex(item => item == 0) == -1 || row.FindIndex(item => item == 1) == -1)
                {
                    score = score + 0;
                }
                else
                {
                    start = row.FindIndex(item => item == 1);
                    end = row.FindLastIndex(item => item == 1);
                    subset = row.GetRange(start, end - start + 1);
                    if (subset.FindIndex(item => item == 0) != -1)
                    {
                        startSet = findLongestOneSet(subset);
                        score = score + countScoreHelper(startSet, subset); // liczenie score
                    }
                }
                row.Clear();
                subset.Clear();
            }
            return score;
        }

        private int countScoreHelper(int[] startSet, List<int> subset)
        {
            int scoreLeft = 0;
            int scoreRight = 0;
            int maxScore = 0;
            List<int> helpSubset = new List<int>();

            if (startSet[0] != 0)
            {
                helpSubset = subset.GetRange(0, startSet[0]);
                maxScore = counter(helpSubset);
                // Debug.WriteLine("wynik lewej: " + Convert.ToString(countLeftScore(helpSubset, 0, maxScore) + "/////////////////////////////"));
                scoreLeft = countLeftScore(helpSubset, 0, maxScore);
            }

            if (startSet[1] != subset.Count - 1)
            {
                helpSubset = subset.GetRange(startSet[1] + 1, subset.Count - startSet[1] - 1);
                maxScore = counter(helpSubset);
                // Debug.WriteLine("wynik prawej: " + Convert.ToString(countRightScore(helpSubset, 0, maxScore) + "/////////////////////////////"));
                scoreRight = countRightScore(helpSubset, 0, maxScore);
            }
            return scoreLeft + scoreRight;

        }

        private int countRightScore(List<int> subset, int score, int bigMaxScore)
        {
            int subscore = score;
            int maxScore = counter(subset);
            List<int> helpSubset = new List<int>();

            int firstOne = subset.FindIndex(item => item == 1);
            int lenZeroSet = subset.Count - (subset.Count - firstOne);
            if (lenZeroSet >= maxScore)
            {
                return bigMaxScore;
            }
            else
            {
                subscore = subscore + lenZeroSet;
                helpSubset = subset.GetRange(firstOne, subset.Count - firstOne);
                int firstZero = helpSubset.FindIndex(item => item == 0);
                helpSubset = helpSubset.GetRange(firstZero, helpSubset.Count - firstZero);

                if (helpSubset.FindIndex(item => item == 0) == -1)
                {
                    return subscore;
                }
                else
                {
                    return countRightScore(helpSubset, subscore, bigMaxScore);
                }
            }
        }

        private int countLeftScore(List<int> subset, int score, int bigMaxScore)
        {

            int subscore = score;
            int maxScore = counter(subset);
            List<int> helpSubset = new List<int>();
            int lastOne = subset.FindLastIndex(item => item == 1);
            int lenZeroSet = subset.Count - lastOne - 1;

            if (lenZeroSet >= maxScore)
            {
                return bigMaxScore;
            }
            else
            {
                subscore = subscore + lenZeroSet;
                helpSubset = subset.GetRange(0, lastOne + 1);
                helpSubset = helpSubset.GetRange(0, helpSubset.FindLastIndex(item => item == 0) + 1);

                if (helpSubset.FindIndex(item => item == 0) == -1)
                {
                    return subscore;
                }
                else
                {
                    return countLeftScore(helpSubset, subscore, bigMaxScore);
                }
            }
        }

        private int counter(List<int> subset)
        {
            int countZero = 0;
            int countOne = 0;

            for (int i = 0; i < subset.Count; i++)
            {
                if (subset[i] == 0)
                    countZero++;
                else
                    countOne++;
            }
            return Math.Min(countOne, countZero);
        }

        private int[] findLongestOneSet(List<int> subset)
        {
            int i = 0;
            List<int> smallSubset = new List<int>();
            List<int> helpSubset = new List<int>();
            List<Tuple<int, int>> subsetList = new List<Tuple<int, int>>();
            int[] longestSubset = new int[2];
            bool last = false;

            while (!last)
            {
                smallSubset = subset.GetRange(i, subset.Count - i);

                int oneSetStart = i;
                int oneSetFinish = smallSubset.FindIndex(item => item == 0) + i;
                subsetList.Add(new Tuple<int, int>(oneSetStart, oneSetFinish - 1));

                int sizeOneSet = oneSetFinish - i;
                ////////////////// tu jest coś nie tak
                helpSubset = subset.GetRange(oneSetFinish, subset.Count - oneSetFinish); // help z zerami na poczatku
                int helpFirstOne = helpSubset.FindIndex(item => item == 1);              // index pierwszej 1
                int sizeZeroSet = helpSubset.Count - (helpSubset.Count - helpFirstOne);
                i = i + sizeOneSet + sizeZeroSet;

                helpSubset = helpSubset.GetRange(helpFirstOne, helpSubset.Count - helpFirstOne);
                int helpLastOne = helpSubset.FindLastIndex(item => item == 1);
                last = true;
                for (int j = 0; j <= helpLastOne; j++)
                {
                    if (helpSubset[j] == 0)
                    {
                        last = false;
                    }
                }
                if (last)
                {
                    subsetList.Add(new Tuple<int, int>(i, i + helpLastOne));
                }
            }

            int len = 0;
            foreach (var ii in subsetList)
            {
                if (ii.Item2 - ii.Item1 + 1 > len)
                {
                    len = ii.Item2 - ii.Item1 + 1;
                    longestSubset[0] = ii.Item1;
                    longestSubset[1] = ii.Item2;
                }
            }
            //Debug.WriteLine("najdluzszy ciag: " + Convert.ToString(len) + "wspolrzedne: " + Convert.ToString(longestSubset[0]) + " " + Convert.ToString(longestSubset[1]));
            return longestSubset;
        }

        /// ///////////////////////////

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

        public void startTabu(int userLimit)
        {
            Debug.WriteLine("Wynik na start: " + Convert.ToString(countScore(DTable)));


            DataTable DTableBest = new DataTable();
            int columns = DTable.Columns.Count;
            int rows = DTable.Rows.Count;
            int limit = userLimit;
            int bestScore = 99999999;
            int score;
            int littleRestart = 20;

            for (int i = 0; i < columns; i++)
            {
                DTableBest.Columns.Add(i.ToString());
            }
            for (int i = 0; i < rows; i++)
            {
                DTableBest.Rows.Add();
            }

            while ( limit > 0 || bestScore == 0)
            {
                if (littleRestart == 0)
                {
                    Random rand = new Random();
                    for (int i = 0; i < 3; i++)
                    {
                        DTable.Columns[rand.Next(0, columns)].SetOrdinal(rand.Next(0, columns));
                    }
                    littleRestart = 20;
                }

                makeMove();
                score = countScore(DTable);

                if (score < bestScore)
                {
                    bestScore = score;
                    for (int c = 0; c < rows; c++)
                    {
                        for (int cc = 0; cc < columns; cc++)
                        {
                            DTableBest.Rows[c][cc] = DTable.Rows[c][cc];
                        }
                    }
                }else
                {
                    littleRestart--;
                }


                limit--;
            }



            Debug.WriteLine("Wynik1 : " + Convert.ToString(countScore(DTableBest)));

            Debug.WriteLine("Wynik: " + Convert.ToString(bestScore));

            for (int c = 0; c < rows; c++)
            {
                for (int cc = 0; cc < columns; cc++)
                {
                    Debug.WriteLine(DTable.Rows[c][cc] + " " + DTableBest.Rows[c][cc]);
                }
            }

            SBind.DataSource = null; // 1st lvl connection

            SBind.DataSource = DTableBest; // 1st lvl connection
            dataGridViewInput.DataSource = SBind; // final connection


        }

        //public void makeMove(int tabuListSize, int limit)
        public void makeMove()
        {
            Dictionary<int, int> scores = new Dictionary<int, int>();
            List<Move> sortedScores = new List<Move>();
            Queue<Move> tabuList = new Queue<Move>();
            bool onTabu = false;
            bool flag = true;
            int tabuListSize = 5;

            sortedScores = countProbability();

            while (flag)
            {
                for (int i = 0; i < sortedScores.Count; i++)
                {
                    Debug.WriteLine("analizuje " + Convert.ToString(sortedScores[i].getColumn()) + Convert.ToString(sortedScores[i].getIndex()));

                    foreach (Move value in tabuList)
                    {
                        if (value.getColumn() == sortedScores[i].getColumn() && value.getIndex() == sortedScores[i].getIndex())
                        {
                            onTabu = true;
                            Debug.WriteLine("jestem na liście tabu: " + Convert.ToString(value.getColumn()) + Convert.ToString(value.getIndex()));

                        }

                        // Debug.WriteLine("z listy tabu: " + Convert.ToString(value.getColumn()) + Convert.ToString(value.getIndex()));
                    }
                    if (!onTabu)
                    {
                        Debug.WriteLine("nie bylo mnie na tabu, wykonuej ruch: " + Convert.ToString(sortedScores[i].getColumn()) + Convert.ToString(sortedScores[i].getIndex()));

                        DTable.Columns[sortedScores[i].getColumn()].SetOrdinal(sortedScores[i].getIndex());
                        addToQueue(tabuList, tabuListSize, sortedScores[i]);
                        flag = false;

                    }
                }
            }

            foreach (Move pair in tabuList)
            {
              Debug.WriteLine("tabu list: " + Convert.ToString(pair.getColumn()) + " : " + Convert.ToString(pair.getIndex()));
            }

        }

        public void addToQueue(Queue<Move> tabuList, int limit, Move move)
        {
            if (tabuList.Count < limit)
            {
                tabuList.Enqueue(move);
            }
            else
            {
                tabuList.Enqueue(move);
                tabuList.Dequeue();
            }
        }

        public List<Move> countProbability()
        {
            Debug.WriteLine("im in count probability");

            Dictionary<int, int> scores = new Dictionary<int, int>();
            Dictionary<int, int> orderedScores = new Dictionary<int, int>();
            List<Move> sortedScores = new List<Move>();

            int score = 0;
            int columns = DTable.Columns.Count;
            int rows = DTable.Rows.Count;

            for (int i = 0; i < rows; i++)
            {
                if (Convert.ToInt32(DTable.Rows[i][0]) == 1 && Convert.ToInt32(DTable.Rows[i][1]) == 0)
                    score++;
            }
            scores.Add(0, score);

            for (int i = 1; i < columns - 1; i++)
            {
                score = 0;
                for (int ii = 0; ii < rows; ii++)
                {
                    if (Convert.ToInt32(DTable.Rows[ii][i - 1]) == 1 && Convert.ToInt32(DTable.Rows[ii][i]) == 0 && Convert.ToInt32(DTable.Rows[ii][i + 1]) == 1)
                        score++;
                    if (Convert.ToInt32(DTable.Rows[ii][i - 1]) == 0 && Convert.ToInt32(DTable.Rows[ii][i]) == 1 && Convert.ToInt32(DTable.Rows[ii][i + 1]) == 0)
                        score++;
                }
                scores.Add(i, score);
            }

            score = 0;
            for (int i = 0; i < rows; i++)
            {
                if (Convert.ToInt32(DTable.Rows[i][columns - 2]) == 0 && Convert.ToInt32(DTable.Rows[i][columns - 1]) == 1)
                    score++;
            }
            scores.Add(columns - 1, score);

            var helper = from pair in scores
                         orderby pair.Value descending
                         select pair;

            foreach (KeyValuePair<int, int> pair in helper)
            {
                orderedScores.Add(pair.Key, pair.Value);
                sortedScores.Add(new Move(pair.Key, pair.Value));
                Debug.WriteLine("cala lista: " + Convert.ToString(pair.Key) + " : " + Convert.ToString(pair.Value));

            }

            return sortedScores;
        }
        //////////////////////////////////////////////////////////////////////////////////
        //obsługa elementów
        /// /////////////////////////////////////////////////////////////////////////////


        private void buttonGenerateInstance_Click(object sender, EventArgs e)
        {
            clearTable();
            generateEmptyTable(int.Parse(comboBoxPlaces.Text), int.Parse(comboBoxSamples.Text));
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
            // shuffle();
            // makeMove();
            startTabu(10);
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
        public class Move{

            int column;
            int index;

            public Move(int _column, int _index)
            {
                this.column = _column;
                this.index = _index;
            }

            public int getColumn()
            {
                return column;
            }
            public int getIndex()
            {
                return index;
            }

        }
    }

}
