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
    public partial class LocalSearch : Form
    {
        DataTable DTableBase;
        DataTable DTableActual = new DataTable();
        DataTable DTableOutput = new DataTable();
        BindingSource SBind = new BindingSource();
        Form1 form = new Form1();
        int rows, columns;
        Random r = new Random();
        bool flag = false;



        public LocalSearch(DataTable table)
        {
            InitializeComponent();
            DTableBase = table;
            rows = DTableBase.Rows.Count;
            columns = DTableBase.Columns.Count;
            SBind.DataSource = DTableBase;
            dataGridViewLocalSearch.DataSource = SBind;
            fillComponents();
        }

        private void fillComponents()
        {
            textBoxStartScore.Text = Convert.ToString(countScore(DTableBase));

            for (int i = 1; i <= 100; i++)
            {
                this.comboBoxTurns.Items.Add(i);
                this.comboBoxRestarts.Items.Add(i);
            }
            comboBoxTurns.SelectedIndex = 2;
            comboBoxRestarts.SelectedIndex = 0;

            for (int i = 0; i < columns; i++)
            {
                DTableActual.Columns.Add(i.ToString());
                DTableOutput.Columns.Add(i.ToString());
            }
            for (int i = 0; i < rows; i++)
            {
                DTableActual.Rows.Add();
                DTableOutput.Rows.Add();
            }

            foreach (DataGridViewColumn column in dataGridViewLocalSearch.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private int countScore(DataTable DTable)
        {
            int score = 0;
            int start, end;
            List<int> row = new List<int>();
            List<int> subset = new List<int>();
            int[] startSet = new int[2];

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
                scoreLeft = countLeftScore(helpSubset, 0, maxScore);
            }

            if (startSet[1] != subset.Count - 1)
            {
                helpSubset = subset.GetRange(startSet[1] + 1, subset.Count - startSet[1] - 1);
                maxScore = counter(helpSubset);
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
                helpSubset = subset.GetRange(oneSetFinish, subset.Count - oneSetFinish); 
                int helpFirstOne = helpSubset.FindIndex(item => item == 1);            
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
            return longestSubset;
        }


        private int localSearch(DataTable DTable, int turns)
        {
            int bestScore = countScore(DTableBase);
            Debug.WriteLine(" start local search with score : " + Convert.ToString(bestScore));
            int oldIndex, newIndex, column, moves;
            int newScore = 99999999;

            for (int i = 0; i < turns; i++)
            {
                moves = 0;
                while (newScore >= bestScore)
                {
                    if (bestScore == 0 || moves > 1000)
                    {
                        break;
                    }
                    else
                    {
                        moves++;
                        column = r.Next(0, DTable.Columns.Count);
                        newIndex = r.Next(0, DTable.Columns.Count);
                        oldIndex = DTable.Columns[Convert.ToString(column)].Ordinal;
                        DTable.Columns[Convert.ToString(column)].SetOrdinal(newIndex);
                      //  form.moveColumn(column, newIndex, DTable);
                        newScore = countScore(DTable);

                        if (newScore >= bestScore)
                        {
                            DTable.Columns[Convert.ToString(column)].SetOrdinal(oldIndex);
                        }
                        else
                        {
                            bestScore = newScore;
                            break;
                        }

                    }
                }
            }
            return bestScore;
        }

        private int MultiStartLocalSearch(int restarts, int turns)
        {
            int bestScore = 999999999;
            int score;

            for (int i = 0; i < restarts; i++)
            {            
                for (int c = 0; c < rows; c++)
                {
                    for (int cc = 0; cc < columns; cc++)
                        DTableActual.Rows[c][cc] = DTableBase.Rows[c][cc];
                }
                score = localSearch(DTableActual, turns);

                if (score < bestScore)
                {
                    bestScore = score;
                    for (int c = 0; c < rows; c++)
                    {
                        for (int cc = 0; cc < columns; cc++)
                           DTableOutput.Rows[c][cc] = DTableActual.Rows[c][cc];
                    }
                }
            }
            return bestScore;
        }


        //////////////////////Obsługa elementów///////////////////////////////////////////

        private void buttonGenerateInstance_Click(object sender, EventArgs e)
        {
            Stopwatch watch = Stopwatch.StartNew();
            int score = MultiStartLocalSearch(int.Parse(comboBoxRestarts.Text), int.Parse(comboBoxTurns.Text));
            watch.Stop();
            var time = watch.ElapsedMilliseconds;
            czas.Text = Convert.ToString(time/1000.00);

            textBoxLocalSearchScore.Text = Convert.ToString(score);
            SBind.DataSource = DTableOutput; 
            dataGridViewLocalSearch.DataSource = SBind;
            flag = true;
        }

        private void buttonTabuSearch_Click(object sender, EventArgs e)
        {
            if (flag)
            {
              TabuSearch ts = new TabuSearch(DTableOutput);
              ts.Show();
            }
            else
            {
               TabuSearch ts = new TabuSearch(DTableBase);
               ts.Show();
            }
            this.Visible = false;
        }
    }

}
