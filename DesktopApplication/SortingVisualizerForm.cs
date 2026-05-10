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
                settings.ShowDialog();
            }
        }


        private void pnlCanvas_Paint(object sender, PaintEventArgs e)
        {
            if (array == null || array.Length == 0) return;

            Graphics g = e.Graphics;


            float barWidth = (float)pnlCanvas.Width / array.Length;

            for (int i = 0; i < array.Length; i++)
            {
                float barHeight = (float)array[i];


                float x = i * barWidth;
                float y = pnlCanvas.Height - barHeight;

                g.FillRectangle(Brushes.SkyBlue, x, y, barWidth - 1, barHeight);

                g.DrawRectangle(Pens.Black, x, y, barWidth - 1, barHeight);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int arraySize = 50;
            array = new int[arraySize];

            for (int i = 0; i < arraySize; i++)
            {
                array[i] = rand.Next(10, pnlCanvas.Height - 20);
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

            // Check which sorting object is initialized
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
