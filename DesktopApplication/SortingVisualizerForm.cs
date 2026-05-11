using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DesktopApplication
{
    public partial class SortingVisualizerForm : Form
    {

        private int currentArraySize = 50;
        private int currentTimerInterval = 50;

        private int[] array;

        private QuickSort quickSort;

        private InsertionSort insertionSort;

        private Random rand = new Random();

        private int comparisons = 0;
        public SortingVisualizerForm()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void btnOpenSettings_Click(object sender, EventArgs e)
        {
            using (SettingsForm settings = new SettingsForm())
            {
                if (settings.ShowDialog() == DialogResult.OK)
                {
                    currentArraySize = settings.ArraySize;
                    currentTimerInterval = settings.TimerInterval;

                    tmrSort.Interval = currentTimerInterval;

                    MessageBox.Show($"Settings Updated! Size: {currentArraySize}, Speed: {currentTimerInterval}ms");
                }
            }
        }


        private void pnlCanvas_Paint(object sender, PaintEventArgs e)
        {
            if (array == null) return;

            Graphics g = e.Graphics;

            float canvasWidth = pnlCanvas.Width;
            float barWidth = canvasWidth / array.Length;

            int maxCanvasHeight = pnlCanvas.Height - 20;

            for (int i = 0; i < array.Length; i++)
            {
                float x = i * barWidth;

                g.FillRectangle(Brushes.LightSkyBlue, x, pnlCanvas.Height - array[i], barWidth, array[i]);

                g.DrawRectangle(Pens.Black, x, pnlCanvas.Height - array[i], barWidth, array[i]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int arraySize = currentArraySize;
            array = new int[arraySize];

            for (int i = 0; i < arraySize; i++)
            {
                array[i] = rand.Next(20, pnlCanvas.Height - 50);
            }
            comparisons = 0;
            lblComparisons.Text = "Comparisons: 0";
            pnlCanvas.Invalidate();
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (array == null)
            {
                MessageBox.Show("Please generate an array first!");
                return;
            }


            quickSort = new QuickSort(array);


            tmrSort.Start();
        }

        private void pnlControls_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int currentStepComparisons = 0;
            bool isStillSorting = false;

            if (quickSort != null)
            {
                isStillSorting = quickSort.SortStep(out currentStepComparisons);
            }
            else if (insertionSort != null)
            {
                isStillSorting = insertionSort.SortStep(out currentStepComparisons);
            }

            comparisons += currentStepComparisons;
            lblComparisons.Text = $"Comparisons: {comparisons}";
            pnlCanvas.Invalidate();

            if (!isStillSorting)
            {
                tmrSort.Stop();
                MessageBox.Show("Sorting Complete!", "Success");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            tmrSort.Stop();
            array = null;
            comparisons = 0;
            lblComparisons.Text = "Comparisons: 0";

            quickSort = null;
            insertionSort = null;

            pnlCanvas.Invalidate();

            cmbAlgorithms.SelectedIndex = -1;
        }
    }
}
