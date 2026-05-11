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
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnOpenSettings
            // 
            btnOpenSettings.Location = new Point(488, 33);
            btnOpenSettings.Name = "btnOpenSettings";
            btnOpenSettings.Size = new Size(214, 58);
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
            btnStartSearch.Location = new Point(70, 33);
            btnStartSearch.Name = "btnStartSearch";
            btnStartSearch.Size = new Size(140, 78);
            btnStartSearch.TabIndex = 3;
            btnStartSearch.Text = "Start Search";
            btnStartSearch.UseVisualStyleBackColor = true;
            btnStartSearch.Click += btnStartSearch_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnOpenSettings);
            panel1.Controls.Add(btnStartSearch);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 150);
            panel1.TabIndex = 4;
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
            ResumeLayout(false);
        }

        #endregion

        private Button btnOpenSettings;
        private Panel pnlGrid;
        private Button btnStartSearch;
        private Panel panel1;
    }
}