namespace CSharpCalc
{
    partial class Calc
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
            Result = new Label();
            SuspendLayout();
            // 
            // Result
            // 
            Result.AutoSize = true;
            Result.Font = new Font("Noto Sans JP", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Result.Location = new Point(398, 9);
            Result.Name = "Result";
            Result.Size = new Size(72, 87);
            Result.TabIndex = 0;
            Result.Text = "0";
            Result.Click += label1_Click;
            // 
            // Calc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(482, 553);
            Controls.Add(Result);
            ForeColor = Color.White;
            Name = "Calc";
            Text = "CSharpCalc";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Result;
    }
}
