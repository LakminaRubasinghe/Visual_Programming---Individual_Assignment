namespace DesktopApplication
{
    partial class PathfindingVisualizerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnOpenSettings = new Button();
            pnlGrid = new Panel();
            btnStartSearch = new Button();
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            numCols = new NumericUpDown();
            numRows = new NumericUpDown();
            btnResetSearch = new Button();
            btnClearGrid = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numCols).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numRows).BeginInit();
            SuspendLayout();
            // 
            // btnOpenSettings
            // 
            btnOpenSettings.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnOpenSettings.Location = new Point(664, 93);
            btnOpenSettings.Name = "btnOpenSettings";
            btnOpenSettings.Size = new Size(113, 38);
            btnOpenSettings.TabIndex = 2;
            btnOpenSettings.Text = "Settings";
            btnOpenSettings.UseVisualStyleBackColor = true;
            btnOpenSettings.Click += btnOpenSettings_Click_1;
            // 
            // pnlGrid
            // 
            pnlGrid.Dock = DockStyle.Fill;
            pnlGrid.Location = new Point(0, 0);
            pnlGrid.Name = "pnlGrid";
            pnlGrid.Size = new Size(800, 450);
            pnlGrid.TabIndex = 3;
            pnlGrid.Paint += pnlGrid_Paint;
            pnlGrid.MouseDown += pnlGrid_MouseDown;
            // 
            // btnStartSearch
            // 
            btnStartSearch.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStartSearch.Location = new Point(34, 89);
            btnStartSearch.Name = "btnStartSearch";
            btnStartSearch.Size = new Size(140, 42);
            btnStartSearch.TabIndex = 3;
            btnStartSearch.Text = "Start Search";
            btnStartSearch.UseVisualStyleBackColor = true;
            btnStartSearch.Click += btnStartSearch_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(numCols);
            panel1.Controls.Add(numRows);
            panel1.Controls.Add(btnResetSearch);
            panel1.Controls.Add(btnClearGrid);
            panel1.Controls.Add(btnOpenSettings);
            panel1.Controls.Add(btnStartSearch);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 150);
            panel1.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(395, 27);
            label2.Name = "label2";
            label2.Size = new Size(93, 28);
            label2.TabIndex = 9;
            label2.Text = "Columns";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(58, 27);
            label1.Name = "label1";
            label1.Size = new Size(62, 28);
            label1.TabIndex = 8;
            label1.Text = "Rows";
            // 
            // numCols
            // 
            numCols.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            numCols.Location = new Point(508, 25);
            numCols.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            numCols.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            numCols.Name = "numCols";
            numCols.Size = new Size(150, 34);
            numCols.TabIndex = 7;
            numCols.Value = new decimal(new int[] { 10, 0, 0, 0 });
            numCols.ValueChanged += numCols_ValueChanged;
            // 
            // numRows
            // 
            numRows.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            numRows.Location = new Point(143, 25);
            numRows.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            numRows.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            numRows.Name = "numRows";
            numRows.Size = new Size(150, 34);
            numRows.TabIndex = 6;
            numRows.Value = new decimal(new int[] { 10, 0, 0, 0 });
            numRows.ValueChanged += numRows_ValueChanged;
            // 
            // btnResetSearch
            // 
            btnResetSearch.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnResetSearch.Location = new Point(299, 94);
            btnResetSearch.Name = "btnResetSearch";
            btnResetSearch.Size = new Size(94, 36);
            btnResetSearch.TabIndex = 5;
            btnResetSearch.Text = "Reset Path";
            btnResetSearch.UseVisualStyleBackColor = true;
            btnResetSearch.Click += btnResetSearch_Click;
            // 
            // btnClearGrid
            // 
            btnClearGrid.BackColor = SystemColors.ButtonHighlight;
            btnClearGrid.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnClearGrid.Location = new Point(189, 92);
            btnClearGrid.Name = "btnClearGrid";
            btnClearGrid.Size = new Size(94, 38);
            btnClearGrid.TabIndex = 4;
            btnClearGrid.Text = "Clear All";
            btnClearGrid.UseVisualStyleBackColor = false;
            btnClearGrid.Click += button1_Click;
            // 
            // PathfindingVisualizerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(pnlGrid);
            Name = "PathfindingVisualizerForm";
            Text = "PathFindingVisualizerForm";
            Load += PathfindingVisualizerForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numCols).EndInit();
            ((System.ComponentModel.ISupportInitialize)numRows).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnOpenSettings;
        private Panel pnlGrid;
        private Button btnStartSearch;
        private Panel panel1;
        private Button btnResetSearch;
        private Button btnClearGrid;
        private Label label2;
        private Label label1;
        private NumericUpDown numCols;
        private NumericUpDown numRows;
    }
}