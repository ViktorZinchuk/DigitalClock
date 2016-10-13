namespace WindowsFormsWatch
{
    partial class DigitalWatch
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
            this.ModeButton = new System.Windows.Forms.Button();
            this.BacklightButton = new System.Windows.Forms.Button();
            this.SettingButton = new System.Windows.Forms.Button();
            this.Functional_Button = new System.Windows.Forms.Button();
            this.displayTimer1 = new WindowsFormsWatch.DisplayTimer();
            this.displayStopwatch1 = new WindowsFormsWatch.DisplayStopwatch();
            this.displayProClock1 = new WindowsFormsWatch.DisplayProClock();
            this.displaySimpleClock1 = new WindowsFormsWatch.DisplaySimpleClock();
            this.SuspendLayout();
            // 
            // ModeButton
            // 
            this.ModeButton.Location = new System.Drawing.Point(12, 12);
            this.ModeButton.Name = "ModeButton";
            this.ModeButton.Size = new System.Drawing.Size(25, 25);
            this.ModeButton.TabIndex = 0;
            this.ModeButton.Text = "M";
            this.ModeButton.UseVisualStyleBackColor = true;
            this.ModeButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ModeButton_MouseDown);
            this.ModeButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ModeButton_MouseUp);
            // 
            // BacklightButton
            // 
            this.BacklightButton.Location = new System.Drawing.Point(12, 52);
            this.BacklightButton.Name = "BacklightButton";
            this.BacklightButton.Size = new System.Drawing.Size(25, 25);
            this.BacklightButton.TabIndex = 1;
            this.BacklightButton.Text = "B";
            this.BacklightButton.UseVisualStyleBackColor = true;
            this.BacklightButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BacklightButton_MouseDown);
            this.BacklightButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BacklightButton_MouseUp);
            // 
            // SettingButton
            // 
            this.SettingButton.Location = new System.Drawing.Point(259, 12);
            this.SettingButton.Name = "SettingButton";
            this.SettingButton.Size = new System.Drawing.Size(25, 25);
            this.SettingButton.TabIndex = 2;
            this.SettingButton.Text = "S";
            this.SettingButton.UseVisualStyleBackColor = true;
            this.SettingButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SettingButton_MouseDown);
            this.SettingButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.SettingButton_MouseUp);
            // 
            // Functional_Button
            // 
            this.Functional_Button.Location = new System.Drawing.Point(259, 52);
            this.Functional_Button.Name = "Functional_Button";
            this.Functional_Button.Size = new System.Drawing.Size(25, 25);
            this.Functional_Button.TabIndex = 3;
            this.Functional_Button.Text = "F";
            this.Functional_Button.UseVisualStyleBackColor = true;
            this.Functional_Button.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Functional_Button_MouseDown);
            this.Functional_Button.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Functional_Button_MouseUp);
            // 
            // displayTimer1
            // 
            this.displayTimer1.BackColor = System.Drawing.Color.Black;
            this.displayTimer1.Location = new System.Drawing.Point(43, 12);
            this.displayTimer1.Name = "displayTimer1";
            this.displayTimer1.Size = new System.Drawing.Size(210, 65);
            this.displayTimer1.TabIndex = 7;
            // 
            // displayStopwatch1
            // 
            this.displayStopwatch1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.displayStopwatch1.Location = new System.Drawing.Point(43, 12);
            this.displayStopwatch1.Name = "displayStopwatch1";
            this.displayStopwatch1.Size = new System.Drawing.Size(210, 65);
            this.displayStopwatch1.TabIndex = 6;
            // 
            // displayProClock1
            // 
            this.displayProClock1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.displayProClock1.Location = new System.Drawing.Point(43, 12);
            this.displayProClock1.Name = "displayProClock1";
            this.displayProClock1.Size = new System.Drawing.Size(210, 65);
            this.displayProClock1.TabIndex = 5;
            // 
            // displaySimpleClock1
            // 
            this.displaySimpleClock1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.displaySimpleClock1.Location = new System.Drawing.Point(43, 12);
            this.displaySimpleClock1.Name = "displaySimpleClock1";
            this.displaySimpleClock1.Size = new System.Drawing.Size(210, 65);
            this.displaySimpleClock1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(299, 92);
            this.Controls.Add(this.displayTimer1);
            this.Controls.Add(this.displayStopwatch1);
            this.Controls.Add(this.displayProClock1);
            this.Controls.Add(this.displaySimpleClock1);
            this.Controls.Add(this.Functional_Button);
            this.Controls.Add(this.SettingButton);
            this.Controls.Add(this.BacklightButton);
            this.Controls.Add(this.ModeButton);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Watch";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ModeButton;
        private System.Windows.Forms.Button BacklightButton;
        private System.Windows.Forms.Button SettingButton;
        private System.Windows.Forms.Button Functional_Button;
        private DisplaySimpleClock displaySimpleClock1;
        private DisplayProClock displayProClock1;
        private DisplayStopwatch displayStopwatch1;
        private DisplayTimer displayTimer1;
    }
}

