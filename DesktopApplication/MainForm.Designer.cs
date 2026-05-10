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
            SuspendLayout();
            // 
            // btnOpenSorting
            // 
            btnOpenSorting.Location = new Point(279, 77);
            btnOpenSorting.Name = "btnOpenSorting";
            btnOpenSorting.Size = new Size(214, 58);
            btnOpenSorting.TabIndex = 0;
            btnOpenSorting.Text = "Sorting Visualizer";
            btnOpenSorting.UseVisualStyleBackColor = true;
            btnOpenSorting.Click += btnOpenSorting_Click;
            // 
            // btnOpenPathfinding
            // 
            btnOpenPathfinding.Location = new Point(279, 258);
            btnOpenPathfinding.Name = "btnOpenPathfinding";
            btnOpenPathfinding.Size = new Size(214, 58);
            btnOpenPathfinding.TabIndex = 1;
            btnOpenPathfinding.Text = "Pathfinding Visualizer";
            btnOpenPathfinding.UseVisualStyleBackColor = true;
            btnOpenPathfinding.Click += this.btnOpenPathfinding_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnOpenPathfinding);
            Controls.Add(btnOpenSorting);
            Name = "MainForm";
            Text = "MainForm";
            ResumeLayout(false);
        }

        #endregion

        private Button btnOpenSorting;
        private Button btnOpenPathfinding;
    }
}
