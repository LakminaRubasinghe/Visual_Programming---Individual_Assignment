namespace DesktopApplication
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnOpenSorting = new Button();
            btnOpenPathfinding = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnOpenSorting
            // 
            btnOpenSorting.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            btnOpenSorting.ImageAlign = ContentAlignment.MiddleLeft;
            btnOpenSorting.Location = new Point(213, 229);
            btnOpenSorting.Name = "btnOpenSorting";
            btnOpenSorting.Size = new Size(351, 58);
            btnOpenSorting.TabIndex = 0;
            btnOpenSorting.Text = "1. Sorting Visualizer";
            btnOpenSorting.TextAlign = ContentAlignment.MiddleLeft;
            btnOpenSorting.UseVisualStyleBackColor = true;
            btnOpenSorting.Click += btnOpenSorting_Click;
            // 
            // btnOpenPathfinding
            // 
            btnOpenPathfinding.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            btnOpenPathfinding.Location = new Point(213, 334);
            btnOpenPathfinding.Name = "btnOpenPathfinding";
            btnOpenPathfinding.Size = new Size(351, 58);
            btnOpenPathfinding.TabIndex = 1;
            btnOpenPathfinding.Text = "2. Pathfinding Visualizer";
            btnOpenPathfinding.TextAlign = ContentAlignment.MiddleLeft;
            btnOpenPathfinding.UseVisualStyleBackColor = true;
            btnOpenPathfinding.Click += btnOpenPathfinding_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(96, 35);
            label1.Name = "label1";
            label1.Size = new Size(610, 46);
            label1.TabIndex = 2;
            label1.Text = "Welcome to our Desktop Application";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 144);
            label2.Name = "label2";
            label2.Size = new Size(347, 31);
            label2.TabIndex = 3;
            label2.Text = "Select one of the two methods,";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnOpenPathfinding);
            Controls.Add(btnOpenSorting);
            Name = "MainForm";
            Text = "MainForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOpenSorting;
        private Button btnOpenPathfinding;
        private Label label1;
        private Label label2;
    }
}
