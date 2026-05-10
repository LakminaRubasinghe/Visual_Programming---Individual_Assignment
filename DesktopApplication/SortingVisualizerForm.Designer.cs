namespace DesktopApplication
{
    partial class SortingVisualizerForm
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
            pnlCanvas = new Panel();
            pnlControls = new Panel();
            btnGenerate = new Button();
            btnStart = new Button();
            btnReset = new Button();
            cmbAlgorithms = new ComboBox();
            lblComparisons = new Label();
            pnlControls.SuspendLayout();
            SuspendLayout();
            // 
            // btnOpenSettings
            // 
            btnOpenSettings.Location = new Point(564, 158);
            btnOpenSettings.Name = "btnOpenSettings";
            btnOpenSettings.Size = new Size(214, 58);
            btnOpenSettings.TabIndex = 1;
            btnOpenSettings.Text = "Settings";
            btnOpenSettings.UseVisualStyleBackColor = true;
            btnOpenSettings.Click += btnOpenSettings_Click;
            // 
            // pnlCanvas
            // 
            pnlCanvas.Dock = DockStyle.Fill;
            pnlCanvas.Location = new Point(0, 0);
            pnlCanvas.Name = "pnlCanvas";
            pnlCanvas.Size = new Size(800, 450);
            pnlCanvas.TabIndex = 2;
            pnlCanvas.Paint += pnlCanvas_Paint;
            // 
            // pnlControls
            // 
            pnlControls.Controls.Add(btnOpenSettings);
            pnlControls.Controls.Add(lblComparisons);
            pnlControls.Controls.Add(cmbAlgorithms);
            pnlControls.Controls.Add(btnReset);
            pnlControls.Controls.Add(btnStart);
            pnlControls.Controls.Add(btnGenerate);
            pnlControls.Dock = DockStyle.Top;
            pnlControls.Location = new Point(0, 0);
            pnlControls.Name = "pnlControls";
            pnlControls.Size = new Size(800, 231);
            pnlControls.TabIndex = 3;
            // 
            // btnGenerate
            // 
            btnGenerate.Location = new Point(21, 12);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(146, 64);
            btnGenerate.TabIndex = 0;
            btnGenerate.Text = "Generate New Array";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += button1_Click;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(182, 12);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(139, 64);
            btnStart.TabIndex = 1;
            btnStart.Text = "Start Sort";
            btnStart.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(337, 12);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(134, 64);
            btnReset.TabIndex = 2;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            // 
            // cmbAlgorithms
            // 
            cmbAlgorithms.FormattingEnabled = true;
            cmbAlgorithms.Items.AddRange(new object[] { "Quick Sort", "Merge Sort" });
            cmbAlgorithms.Location = new Point(487, 15);
            cmbAlgorithms.Name = "cmbAlgorithms";
            cmbAlgorithms.Size = new Size(151, 28);
            cmbAlgorithms.TabIndex = 3;
            cmbAlgorithms.Text = "cmbAlgorithms";
            // 
            // lblComparisons
            // 
            lblComparisons.AutoSize = true;
            lblComparisons.Location = new Point(664, 23);
            lblComparisons.Name = "lblComparisons";
            lblComparisons.Size = new Size(114, 20);
            lblComparisons.TabIndex = 4;
            lblComparisons.Text = "Comparisons : 0";
            lblComparisons.Click += label1_Click;
            // 
            // SortingVisualizerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlControls);
            Controls.Add(pnlCanvas);
            Name = "SortingVisualizerForm";
            Text = "SortingVisualizerForm";
            pnlControls.ResumeLayout(false);
            pnlControls.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnOpenSettings;
        private Panel pnlCanvas;
        private Panel pnlControls;
        private Button btnReset;
        private Button btnStart;
        private Button btnGenerate;
        private Label lblComparisons;
        private ComboBox cmbAlgorithms;
    }
}