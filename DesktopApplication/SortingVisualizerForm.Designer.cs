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
            SuspendLayout();
            // 
            // btnOpenSettings
            // 
            btnOpenSettings.Location = new Point(285, 165);
            btnOpenSettings.Name = "btnOpenSettings";
            btnOpenSettings.Size = new Size(214, 58);
            btnOpenSettings.TabIndex = 1;
            btnOpenSettings.Text = "Settings";
            btnOpenSettings.UseVisualStyleBackColor = true;
            btnOpenSettings.Click += btnOpenSettings_Click;
            // 
            // SortingVisualizerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnOpenSettings);
            Name = "SortingVisualizerForm";
            Text = "SortingVisualizerForm";
            ResumeLayout(false);
        }

        #endregion

        private Button btnOpenSettings;
    }
}