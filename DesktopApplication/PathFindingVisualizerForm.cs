using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DesktopApplication
{
    public partial class PathfindingVisualizerForm : Form
    {

        private Node[,] grid;
        private int rows = 20;
        private int cols = 40;
        private int cellSize = 25;

        private int animationSpeed = 50;

        private Node startNode;
        private Node endNode;

        private bool isRunning = false;

        public PathfindingVisualizerForm()
        {
            InitializeComponent();
            this.DoubleBuffered = true;

            numRows.Value = rows;
            numCols.Value = cols;

            InitializeGrid();
        }

        private void PathfindingVisualizerForm_Load(object sender, EventArgs e)
        {

        }

        private void InitializeGrid()
        {
            grid = new Node[rows, cols];
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    grid[r, c] = new Node(r, c);
                }
            }
        }

        private void btnOpenSettings_Click_1(object sender, EventArgs e)
        {
            using (SettingsForm settings = new SettingsForm())
            {
                if (settings.ShowDialog() == DialogResult.OK)
                {
                    this.animationSpeed = settings.TimerInterval;
                }
            }
        }

        private void pnlGrid_Paint(object sender, PaintEventArgs e)
        {
            if (grid == null) return;
            Graphics g = e.Graphics;

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    Brush brush = Brushes.White;


                    if (grid[r, c].IsWall) brush = Brushes.Black;
                    else if (grid[r, c].IsStart) brush = Brushes.Green;
                    else if (grid[r, c].IsEnd) brush = Brushes.Red;
                    else if (grid[r, c].IsPath) brush = Brushes.Yellow;
                    else if (grid[r, c].IsVisited) brush = Brushes.LightBlue;

                    g.FillRectangle(brush, c * cellSize, r * cellSize, cellSize, cellSize);
                    g.DrawRectangle(Pens.LightGray, c * cellSize, r * cellSize, cellSize, cellSize);
                }
            }
        }

        private void pnlGrid_MouseDown(object sender, MouseEventArgs e)
        {
            int c = e.X / cellSize;
            int r = e.Y / cellSize;

            if (r >= 0 && r < rows && c >= 0 && c < cols)
            {
                if (e.Button == MouseButtons.Left)
                {
                    if (startNode == null)
                    {
                        grid[r, c].IsStart = true;
                        grid[r, c].IsWall = false;
                        startNode = grid[r, c];
                    }
                    else if (endNode == null && !grid[r, c].IsStart)
                    {
                        grid[r, c].IsEnd = true;
                        grid[r, c].IsWall = false;
                        endNode = grid[r, c];
                    }
                    else if (!grid[r, c].IsStart && !grid[r, c].IsEnd)
                    {
                        grid[r, c].IsWall = !grid[r, c].IsWall;
                    }
                }
                else if (e.Button == MouseButtons.Right)
                {
                    if (grid[r, c] == startNode) startNode = null;
                    if (grid[r, c] == endNode) endNode = null;

                    grid[r, c].IsWall = false;
                    grid[r, c].IsStart = false;
                    grid[r, c].IsEnd = false;
                }

                pnlGrid.Invalidate();
            }
        }

        private async void StartDijkstra()
        {
            if (startNode == null || endNode == null) return;

            isRunning = true;
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(startNode);
            startNode.IsVisited = true;

            while (queue.Count > 0)
            {
                if (!isRunning) return;

                Node current = queue.Dequeue();

                if (current == endNode)
                {
                    DrawPath();
                    isRunning = false;
                    return;
                }

                foreach (Node neighbor in GetNeighbors(current))
                {
                    if (!neighbor.IsVisited && !neighbor.IsWall)
                    {
                        neighbor.IsVisited = true;
                        neighbor.Parent = current;
                        queue.Enqueue(neighbor);
                    }
                }

                pnlGrid.Invalidate();
                await Task.Delay(animationSpeed);
            }

            isRunning = false;
        }

        private List<Node> GetNeighbors(Node node)
        {
            List<Node> neighbors = new List<Node>();
            int[] dr = { -1, 1, 0, 0 };
            int[] dc = { 0, 0, -1, 1 };

            for (int i = 0; i < 4; i++)
            {
                int newR = node.X + dr[i];
                int newC = node.Y + dc[i];

                if (newR >= 0 && newR < rows && newC >= 0 && newC < cols)
                {
                    neighbors.Add(grid[newR, newC]);
                }
            }
            return neighbors;
        }

        private void DrawPath()
        {
            Node temp = endNode.Parent;
            while (temp != null && temp != startNode)
            {
                temp.IsPath = true;
                temp = temp.Parent;
            }
            pnlGrid.Invalidate();
            MessageBox.Show("Path Found!");
        }

        private void btnStartSearch_Click(object sender, EventArgs e)
        {
            StartDijkstra();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearFullGrid();
        }

        private void ClearFullGrid()
        {
            isRunning = false;

            if (grid == null) return;

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    grid[r, c].IsWall = false;
                    grid[r, c].IsStart = false;
                    grid[r, c].IsEnd = false;
                    grid[r, c].IsVisited = false;
                    grid[r, c].IsPath = false;
                    grid[r, c].Parent = null;
                }
            }

            startNode = null;
            endNode = null;

            pnlGrid.Invalidate();
        }

        private void ResetSearchOnly()
        {
            if (grid == null) return;

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    grid[r, c].IsVisited = false;
                    grid[r, c].IsPath = false;
                    grid[r, c].Parent = null;
                }
            }

            pnlGrid.Invalidate();
        }

        private void btnResetSearch_Click(object sender, EventArgs e)
        {
            ResetSearchOnly();
        }


        private void ApplyNewGridSize()
        {
            rows = (int)numRows.Value;
            cols = (int)numCols.Value;

            startNode = null;
            endNode = null;

            InitializeGrid();

            pnlGrid.Invalidate();
        }

        private void numRows_ValueChanged(object sender, EventArgs e)
        {
            ApplyNewGridSize();
        }

        private void numCols_ValueChanged(object sender, EventArgs e)
        {
            ApplyNewGridSize();
        }
    }
}
