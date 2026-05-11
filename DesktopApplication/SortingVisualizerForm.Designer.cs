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
            components = new System.ComponentModel.Container();
            btnOpenSettings = new Button();
            pnlCanvas = new Panel();
            pnlControls = new Panel();
            lblComparisons = new Label();
            cmbAlgorithms = new ComboBox();
            btnReset = new Button();
            btnStart = new Button();
            btnGenerate = new Button();
            tmrSort = new System.Windows.Forms.Timer(components);
            pnlControls.SuspendLayout();
            SuspendLayout();
            // 
            // btnOpenSettings
            // 
            btnOpenSettings.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnOpenSettings.Location = new Point(650, 78);
            btnOpenSettings.Name = "btnOpenSettings";
            btnOpenSettings.Size = new Size(128, 50);
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
            pnlControls.Size = new Size(800, 148);
            pnlControls.TabIndex = 3;
            pnlControls.Paint += pnlControls_Paint;
            // 
            // lblComparisons
            // 
            lblComparisons.AutoSize = true;
            lblComparisons.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblComparisons.Location = new Point(432, 87);
            lblComparisons.Name = "lblComparisons";
            lblComparisons.Size = new Size(162, 28);
            lblComparisons.TabIndex = 4;
            lblComparisons.Text = "Comparisons : 0";
            lblComparisons.Click += label1_Click;
            // 
            // cmbAlgorithms
            // 
            cmbAlgorithms.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            cmbAlgorithms.FormattingEnabled = true;
            cmbAlgorithms.Items.AddRange(new object[] { "Quick Sort", "Insertion Sort" });
            cmbAlgorithms.Location = new Point(432, 30);
            cmbAlgorithms.Name = "cmbAlgorithms";
            cmbAlgorithms.Size = new Size(162, 31);
            cmbAlgorithms.TabIndex = 3;
            cmbAlgorithms.Text = "Algorithm Type";
            // 
            // btnReset
            // 
            btnReset.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnReset.Location = new Point(309, 12);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(97, 64);
            btnReset.TabIndex = 2;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnStart
            // 
            btnStart.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnStart.Location = new Point(168, 12);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(121, 64);
            btnStart.TabIndex = 1;
            btnStart.Text = "Start Sort";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnGenerate
            // 
            btnGenerate.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnGenerate.Location = new Point(21, 12);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(129, 64);
            btnGenerate.TabIndex = 0;
            btnGenerate.Text = "Generate New Array";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += button1_Click;
            // 
            // tmrSort
            // 
            tmrSort.Interval = 50;
            tmrSort.Tick += timer1_Tick;
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
        private System.Windows.Forms.Timer tmrSort;
    }
}