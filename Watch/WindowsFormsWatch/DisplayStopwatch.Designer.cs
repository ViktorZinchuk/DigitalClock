namespace WindowsFormsWatch
{
    partial class DisplayStopwatch
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
            this.label2 = new System.Windows.Forms.Label();
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label2.Location = new System.Drawing.Point(91, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 46);
            this.label2.TabIndex = 1;
            this.label2.Text = ":";
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
            // DisplayStopwatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.PositionSec);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PositionM);
            this.Name = "DisplayStopwatch";
            this.Size = new System.Drawing.Size(210, 65);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PositionM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label PositionSec;
    }
}
