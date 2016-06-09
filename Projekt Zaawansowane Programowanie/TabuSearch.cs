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
using System.Xml;

namespace Projekt_Zaawansowane_Programowanie
{
    public partial class TabuSearch : Form
    {
        int columns, rows;
        DataTable DTable = new DataTable();
        DataTable DTableBest = new DataTable();
        BindingSource SBind = new BindingSource();
        Random rnd = new Random();
        Form1 form1 = new Form1();
        Queue<Move> tabuList = new Queue<Move>();

        public TabuSearch(DataTable table)
        {
            InitializeComponent();
            DTable = table;
            rows = DTable.Rows.Count;
            columns = DTable.Columns.Count;
            fillComponents();
        }

        private void fillComponents()
        {
            txtStartScore.Text = Convert.ToString(countScore(DTable));

          for (int i = 1; i <= 100; i++)
                this.comboBoxLittleReset.Items.Add(i);

            for (int i = 100; i <= 10000; i = i + 100)
                this.comboBoxTabuSteps.Items.Add(i);

            for (double i = 0.5; i < 10.5; i = i + 0.5)
                this.comboBoxTabuSize.Items.Add(columns * i);

            for (int i = 10; i < 2010; i = i + 10)
            {
                this.comboBoxBigReset.Items.Add(i);
            }
            comboBoxLittleReset.SelectedIndex = 49;
            comboBoxTabuSize.SelectedIndex = 1;
            comboBoxTabuSteps.SelectedIndex = 9;
            comboBoxBigReset.SelectedIndex = 49;
            txtStartScore.Text = Convert.ToString(countScore(DTable));


            for (int i = 0; i < columns; i++)
            {
                DTableBest.Columns.Add(i.ToString());
            }
            for (int i = 0; i < rows; i++)
            {
                DTableBest.Rows.Add();
            }

            foreach (DataGridViewColumn column in dataGridViewResult.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
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


        //Tabu//////////////////////////////////////////////////////////////////////////////

        public void startTabu(int userLimit, int tabuListSize, int littleRestart, int bigRestart)
        {
            Stopwatch watch = Stopwatch.StartNew();

            List<Move> sortedScores = new List<Move>();
            int columns = DTable.Columns.Count;
            int rows = DTable.Rows.Count;

            for (int c = 0; c < rows; c++)
            {
                for (int cc = 0; cc < columns; cc++)
                { DTableBest.Rows[c][cc] = DTable.Rows[c][cc]; }
            }

            int limit = 1;
            int bestScore = countScore(DTable);
            int startScore = countScore(DTable);
            int score = 0;
            List<int> scoresOnSteps = new List<int>();
            int previousScore = 999999999;
            int limitForBigRestart = bigRestart;
            int countLittleRestart = 0;
            int countBigRestart = 0;
            int limitForLittleRestart = littleRestart;
            int bestScoreInTurn = 0;

            while (limit < userLimit + 1 && bestScore != 0)
            {
                if (littleRestart == 0)
                {
                    countLittleRestart++;
                    for (int i = 0; i < 3; i++)
                    {
                        DTable.Columns[rnd.Next(0, columns)].SetOrdinal(rnd.Next(0, columns));
                    }
                    littleRestart = limitForLittleRestart;
                }

                if (bigRestart == 0)
                {
                    countBigRestart++;
                    for (int c = 0; c < rows; c++)
                    {
                        for (int cc = 0; cc < columns; cc++)
                        {
                            DTable.Rows[c][cc] = DTableBest.Rows[c][cc];
                        }
                    }
                    tabuList.Clear();
                    sortedScores = countProbability();
                    for (int i = 0; i < 2; i++)
                    {
                        tabuList.Enqueue(sortedScores[i]);
                    }
                    bigRestart = limitForBigRestart;
                    littleRestart = limitForLittleRestart;
                }

                makeMove(tabuListSize);
                previousScore = score;
                score = countScore(DTable);
 
                if (score < bestScore)
                {
                    bigRestart = limitForBigRestart;
                    bestScore = score;
                    bestScoreInTurn = limit;

                    for (int c = 0; c < rows; c++)
                    {
                        for (int cc = 0; cc < columns; cc++)
                        { DTableBest.Rows[c][cc] = DTable.Rows[c][cc]; }
                    }
                }
                else
                { bigRestart--; }

                if (previousScore == score || previousScore < score)
                {
                    littleRestart--;
                }
                else
                {
                    littleRestart = limitForLittleRestart;
                }
                limit++;

                if (limit % 100 == 0)
                {
                    scoresOnSteps.Add(bestScore);
                }

                textBoxActualStep.Text = Convert.ToString(limit);

                if (limit == 500)
                {
                    watch.Stop();
                    var time = watch.ElapsedMilliseconds;
                }

            }

            textBoxResult.Text = Convert.ToString(bestScore);
            textBoxPercent.Text = Convert.ToString(100-(bestScore*100/startScore));

            for (int c = 0; c < rows; c++)
            {
                for (int cc = 0; cc < columns; cc++)
                { DTable.Rows[c][cc] = DTableBest.Rows[c][cc]; }
            }
            tabuList.Clear();

        }

        private void readFile()
        {

            OpenFileDialog openFileInput = new OpenFileDialog();

            if (openFileInput.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamReader sr = new
                System.IO.StreamReader(openFileInput.FileName);
                XmlReader xmlFile = XmlReader.Create(sr, new XmlReaderSettings());
                DataSet data = new DataSet();
                data.ReadXml(xmlFile);
                xmlFile.Close();
                DTable = data.Tables[0];
                sr.Close();
            }
            txtStartScore.Text = Convert.ToString(countScore(DTable));

        }

        public void makeMove(int tabuListSize)
        {
            Dictionary<int, int> scores = new Dictionary<int, int>();
            List<Move> sortedScores = new List<Move>();
            bool onTabu = false;
            int indexToMove, indexTarget;

            sortedScores = countProbability();

            for (int i = 0; i < sortedScores.Count - 1; i++)
            {
                indexToMove = sortedScores[i].getColumn();
                indexTarget = DTable.Columns[Convert.ToString(sortedScores[i + 1].getColumn())].Ordinal;

                for (int ii = 0; ii < tabuList.Count; ii++)
                {
                    if (tabuList.ElementAt(ii).getColumn() == indexToMove && tabuList.ElementAt(ii).getIndex() == indexTarget)
                    {
                        onTabu = true;
                        ii = tabuList.Count;
                    }
                }
                if (!onTabu)
                {
                    DTable.Columns[indexToMove].SetOrdinal(indexTarget);
                    addToQueue(tabuList, tabuListSize, new Move(indexToMove, indexTarget));
                    i = sortedScores.Count;
                }
                onTabu = false;
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
            string[] columnNames = DTable.Columns.Cast<DataColumn>()
                                 .Select(x => x.ColumnName)
                                 .ToArray();

            Dictionary<int, int> scores = new Dictionary<int, int>();
            List<Move> sortedScores = new List<Move>();

            int score = 0;
            int columns = DTable.Columns.Count;
            int rows = DTable.Rows.Count;

            for (int i = 0; i < rows; i++)
            {
                if (Convert.ToInt32(DTable.Rows[i][0]) == 1 && Convert.ToInt32(DTable.Rows[i][1]) == 0)
                    score++;
            }
            scores.Add(Convert.ToInt32(columnNames[0]), score);

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
                scores.Add(Convert.ToInt32(columnNames[i]), score);
            }

            score = 0;
            for (int i = 0; i < rows; i++)
            {
                if (Convert.ToInt32(DTable.Rows[i][columns - 2]) == 0 && Convert.ToInt32(DTable.Rows[i][columns - 1]) == 1)
                    score++;
            }
            scores.Add(Convert.ToInt32(columnNames[columns - 1]), score);

            var helper = from pair in scores
                         orderby pair.Value descending
                         select pair;

            foreach (KeyValuePair<int, int> pair in helper)
            {
                sortedScores.Add(new Move(pair.Key, pair.Value));
            }
            return sortedScores;
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            form1.saveToFile(DTable);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            readFile();
        }

        private void buttonStartTS_Click(object sender, EventArgs e)
        {
            startTabu(int.Parse(comboBoxTabuSteps.Text), int.Parse(comboBoxTabuSize.Text), int.Parse(comboBoxLittleReset.Text), int.Parse(comboBoxBigReset.Text));

            SBind.DataSource = DTable;
            dataGridViewResult.DataSource = SBind;

            for (int i = 0; i < rows; i++)
            {
                for (int ii = 0; ii < columns; ii++)
                {
                    if (Convert.ToString(DTable.Rows[i][ii]) == "1")
                    {
                        dataGridViewResult.Rows[i].Cells[ii].Style.BackColor = Color.DeepSkyBlue;
                    }
                }
            }

        }
    }
}

    