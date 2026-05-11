namespace DesktopApplication
{
    partial class SettingsForm
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
            tkSize = new TrackBar();
            numSpeed = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            btnSave = new Button();
            ((System.ComponentModel.ISupportInitialize)tkSize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSpeed).BeginInit();
            SuspendLayout();
            // 
            // tkSize
            // 
            tkSize.BackColor = SystemColors.ActiveCaption;
            tkSize.Location = new Point(383, 60);
            tkSize.Maximum = 100;
            tkSize.Minimum = 10;
            tkSize.Name = "tkSize";
            tkSize.Size = new Size(200, 56);
            tkSize.TabIndex = 0;
            tkSize.Value = 50;
            // 
            // numSpeed
            // 
            numSpeed.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            numSpeed.Location = new Point(383, 154);
            numSpeed.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            numSpeed.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            numSpeed.Name = "numSpeed";
            numSpeed.Size = new Size(200, 51);
            numSpeed.TabIndex = 1;
            numSpeed.Value = new decimal(new int[] { 50, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(14, 60);
            label1.Name = "label1";
            label1.Size = new Size(351, 46);
            label1.TabIndex = 2;
            label1.Text = "Array Size                 : ";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 156);
            label2.Name = "label2";
            label2.Size = new Size(353, 46);
            label2.TabIndex = 3;
            label2.Text = "Timer Interval (ms) : ";
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(574, 364);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(196, 62);
            btnSave.TabIndex = 4;
            btnSave.Text = "Apply Settings";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click_1;
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSave);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(numSpeed);
            Controls.Add(tkSize);
            Name = "SettingsForm";
            Text = "SettingsForm";
            Load += SettingsForm_Load;
            ((System.ComponentModel.ISupportInitialize)tkSize).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSpeed).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TrackBar tkSize;
        private NumericUpDown numSpeed;
        private Label label1;
        private Label label2;
        private Button btnSave;
    }
}