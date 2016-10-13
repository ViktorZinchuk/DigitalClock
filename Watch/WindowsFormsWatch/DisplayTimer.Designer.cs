namespace WindowsFormsWatch
{
    partial class DisplayTimer
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
            this.PositionM = new System.Windows.Forms.Label();
            this.PositionSeparator = new System.Windows.Forms.Label();
            this.PositionSec = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PositionM
            // 
            this.PositionM.AutoSize = true;
            this.PositionM.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PositionM.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.PositionM.Location = new System.Drawing.Point(16, 0);
            this.PositionM.Name = "PositionM";
            this.PositionM.Size = new System.Drawing.Size(87, 63);
            this.PositionM.TabIndex = 0;
            this.PositionM.Text = "00";
            // 
            // PositionSeparator
            // 
            this.PositionSeparator.AutoSize = true;
            this.PositionSeparator.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PositionSeparator.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.PositionSeparator.Location = new System.Drawing.Point(91, 12);
            this.PositionSeparator.Name = "PositionSeparator";
            this.PositionSeparator.Size = new System.Drawing.Size(31, 46);
            this.PositionSeparator.TabIndex = 1;
            this.PositionSeparator.Text = ".";
            // 
            // PositionSec
            // 
            this.PositionSec.AutoSize = true;
            this.PositionSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PositionSec.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.PositionSec.Location = new System.Drawing.Point(109, 0);
            this.PositionSec.Name = "PositionSec";
            this.PositionSec.Size = new System.Drawing.Size(87, 63);
            this.PositionSec.TabIndex = 2;
            this.PositionSec.Text = "00";
            // 
            // DisplayTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.PositionSec);
            this.Controls.Add(this.PositionSeparator);
            this.Controls.Add(this.PositionM);
            this.Name = "DisplayTimer";
            this.Size = new System.Drawing.Size(210, 65);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PositionM;
        private System.Windows.Forms.Label PositionSeparator;
        private System.Windows.Forms.Label PositionSec;
    }
}
