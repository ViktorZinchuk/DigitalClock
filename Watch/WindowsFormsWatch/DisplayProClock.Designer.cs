namespace WindowsFormsWatch
{
    partial class DisplayProClock
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PositionSeparator = new System.Windows.Forms.Label();
            this.AmPm = new System.Windows.Forms.Label();
            this.PositionSeconds = new System.Windows.Forms.Label();
            this.PositionH = new System.Windows.Forms.Label();
            this.PositionM = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PositionSeparator
            // 
            this.PositionSeparator.AutoSize = true;
            this.PositionSeparator.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PositionSeparator.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.PositionSeparator.Location = new System.Drawing.Point(75, 8);
            this.PositionSeparator.Name = "PositionSeparator";
            this.PositionSeparator.Size = new System.Drawing.Size(31, 46);
            this.PositionSeparator.TabIndex = 1;
            this.PositionSeparator.Text = ":";
            // 
            // AmPm
            // 
            this.AmPm.AutoSize = true;
            this.AmPm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AmPm.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.AmPm.Location = new System.Drawing.Point(176, 8);
            this.AmPm.Name = "AmPm";
            this.AmPm.Size = new System.Drawing.Size(39, 25);
            this.AmPm.TabIndex = 3;
            this.AmPm.Text = "am";
            // 
            // PositionSeconds
            // 
            this.PositionSeconds.AutoSize = true;
            this.PositionSeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PositionSeconds.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.PositionSeconds.Location = new System.Drawing.Point(176, 33);
            this.PositionSeconds.Name = "PositionSeconds";
            this.PositionSeconds.Size = new System.Drawing.Size(34, 25);
            this.PositionSeconds.TabIndex = 4;
            this.PositionSeconds.Text = "00";
            // 
            // PositionH
            // 
            this.PositionH.AutoSize = true;
            this.PositionH.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PositionH.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.PositionH.Location = new System.Drawing.Point(0, 0);
            this.PositionH.Name = "PositionH";
            this.PositionH.Size = new System.Drawing.Size(87, 63);
            this.PositionH.TabIndex = 5;
            this.PositionH.Text = "00";
            // 
            // PositionM
            // 
            this.PositionM.AutoSize = true;
            this.PositionM.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PositionM.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.PositionM.Location = new System.Drawing.Point(93, 2);
            this.PositionM.Name = "PositionM";
            this.PositionM.Size = new System.Drawing.Size(87, 63);
            this.PositionM.TabIndex = 6;
            this.PositionM.Text = "00";
            // 
            // DisplayProClock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.PositionM);
            this.Controls.Add(this.PositionH);
            this.Controls.Add(this.PositionSeconds);
            this.Controls.Add(this.AmPm);
            this.Controls.Add(this.PositionSeparator);
            this.Name = "DisplayProClock";
            this.Size = new System.Drawing.Size(210, 65);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PositionSeparator;
        private System.Windows.Forms.Label AmPm;
        private System.Windows.Forms.Label PositionSeconds;
        private System.Windows.Forms.Label PositionH;
        private System.Windows.Forms.Label PositionM;
    }
}
