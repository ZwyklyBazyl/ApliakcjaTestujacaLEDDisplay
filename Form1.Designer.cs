namespace ApliakcjaTestujacaLEDDisplay
{
    partial class Form1
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
            this.display1 = new LEDDisplay.Display();
            this.SuspendLayout();
            // 
            // display1
            // 
            this.display1.BorderColor = System.Drawing.Color.MediumSpringGreen;
            this.display1.DisplayText = "ABL";
            this.display1.LettersSize = 10;
            this.display1.LettersSpacing = 20;
            this.display1.Location = new System.Drawing.Point(12, 12);
            this.display1.MoveRight = true;
            this.display1.Name = "display1";
            this.display1.PanelHeight = 200;
            this.display1.PanelWidth = 770;
            this.display1.Size = new System.Drawing.Size(776, 245);
            this.display1.TabIndex = 0;
            this.display1.TextColor = System.Drawing.Color.Orange;
            this.display1.TickRate = 50;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.display1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private LEDDisplay.Display display1;
    }
}