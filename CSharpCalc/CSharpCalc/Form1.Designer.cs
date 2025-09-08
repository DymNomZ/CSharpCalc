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
            DelButton = new Button();
            CButton = new Button();
            SignButton = new Button();
            DivideButton = new Button();
            NineButton = new Button();
            EightButton = new Button();
            SevenButton = new Button();
            SixButton = new Button();
            FiveButton = new Button();
            FourButton = new Button();
            ThreeButton = new Button();
            TwoButton = new Button();
            OneButton = new Button();
            DecimalButton = new Button();
            ZeroButton = new Button();
            ModuloButton = new Button();
            MultiplyButton = new Button();
            SubtractButton = new Button();
            AddButton = new Button();
            EqualButton = new Button();
            SuspendLayout();
            // 
            // Result
            // 
            Result.AutoSize = true;
            Result.Font = new Font("Noto Sans JP", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Result.Location = new Point(12, 57);
            Result.Name = "Result";
            Result.RightToLeft = RightToLeft.No;
            Result.Size = new Size(72, 87);
            Result.TabIndex = 0;
            Result.Text = "0";
            Result.TextAlign = ContentAlignment.MiddleCenter;
            Result.Click += label1_Click;
            // 
            // DelButton
            // 
            DelButton.BackColor = Color.Gray;
            DelButton.Font = new Font("Noto Sans JP", 18F, FontStyle.Bold);
            DelButton.ForeColor = Color.White;
            DelButton.Location = new Point(12, 167);
            DelButton.Name = "DelButton";
            DelButton.Size = new Size(90, 90);
            DelButton.TabIndex = 1;
            DelButton.Text = "Del";
            DelButton.UseVisualStyleBackColor = false;
            DelButton.Click += Delete_Char;
            // 
            // CButton
            // 
            CButton.BackColor = Color.Gray;
            CButton.Font = new Font("Noto Sans JP", 18F, FontStyle.Bold);
            CButton.ForeColor = Color.WhiteSmoke;
            CButton.Location = new Point(108, 167);
            CButton.Name = "CButton";
            CButton.Size = new Size(90, 90);
            CButton.TabIndex = 2;
            CButton.Text = "C";
            CButton.UseVisualStyleBackColor = false;
            CButton.Click += Clear_Result;
            // 
            // SignButton
            // 
            SignButton.BackColor = Color.Gray;
            SignButton.Font = new Font("Noto Sans JP", 18F, FontStyle.Bold);
            SignButton.ForeColor = Color.White;
            SignButton.Location = new Point(204, 167);
            SignButton.Name = "SignButton";
            SignButton.Size = new Size(90, 90);
            SignButton.TabIndex = 3;
            SignButton.Text = "+/-";
            SignButton.UseVisualStyleBackColor = false;
            SignButton.Click += SignChangeButton_Click;
            // 
            // DivideButton
            // 
            DivideButton.BackColor = Color.Orange;
            DivideButton.Font = new Font("Noto Sans JP", 18F, FontStyle.Bold);
            DivideButton.ForeColor = Color.White;
            DivideButton.Location = new Point(300, 167);
            DivideButton.Name = "DivideButton";
            DivideButton.Size = new Size(90, 90);
            DivideButton.TabIndex = 4;
            DivideButton.Text = "/";
            DivideButton.UseVisualStyleBackColor = false;
            DivideButton.Click += OperatorButton_Click;
            // 
            // NineButton
            // 
            NineButton.BackColor = Color.FromArgb(64, 64, 64);
            NineButton.Font = new Font("Noto Sans JP", 18F, FontStyle.Bold);
            NineButton.ForeColor = Color.White;
            NineButton.Location = new Point(204, 263);
            NineButton.Name = "NineButton";
            NineButton.Size = new Size(90, 90);
            NineButton.TabIndex = 7;
            NineButton.Text = "9";
            NineButton.UseVisualStyleBackColor = false;
            NineButton.Click += Button_Click;
            // 
            // EightButton
            // 
            EightButton.BackColor = Color.FromArgb(64, 64, 64);
            EightButton.Font = new Font("Noto Sans JP", 18F, FontStyle.Bold);
            EightButton.ForeColor = Color.White;
            EightButton.Location = new Point(108, 263);
            EightButton.Name = "EightButton";
            EightButton.Size = new Size(90, 90);
            EightButton.TabIndex = 6;
            EightButton.Text = "8";
            EightButton.UseVisualStyleBackColor = false;
            EightButton.Click += Button_Click;
            // 
            // SevenButton
            // 
            SevenButton.BackColor = Color.FromArgb(64, 64, 64);
            SevenButton.Font = new Font("Noto Sans JP", 18F, FontStyle.Bold);
            SevenButton.ForeColor = Color.White;
            SevenButton.Location = new Point(12, 263);
            SevenButton.Name = "SevenButton";
            SevenButton.Size = new Size(90, 90);
            SevenButton.TabIndex = 5;
            SevenButton.Text = "7";
            SevenButton.UseVisualStyleBackColor = false;
            SevenButton.Click += Button_Click;
            // 
            // SixButton
            // 
            SixButton.BackColor = Color.FromArgb(64, 64, 64);
            SixButton.Font = new Font("Noto Sans JP", 18F, FontStyle.Bold);
            SixButton.ForeColor = Color.White;
            SixButton.Location = new Point(204, 359);
            SixButton.Name = "SixButton";
            SixButton.Size = new Size(90, 90);
            SixButton.TabIndex = 11;
            SixButton.Text = "6";
            SixButton.UseVisualStyleBackColor = false;
            SixButton.Click += Button_Click;
            // 
            // FiveButton
            // 
            FiveButton.BackColor = Color.FromArgb(64, 64, 64);
            FiveButton.Font = new Font("Noto Sans JP", 18F, FontStyle.Bold);
            FiveButton.ForeColor = Color.White;
            FiveButton.Location = new Point(108, 359);
            FiveButton.Name = "FiveButton";
            FiveButton.Size = new Size(90, 90);
            FiveButton.TabIndex = 10;
            FiveButton.Text = "5";
            FiveButton.UseVisualStyleBackColor = false;
            FiveButton.Click += Button_Click;
            // 
            // FourButton
            // 
            FourButton.BackColor = Color.FromArgb(64, 64, 64);
            FourButton.Font = new Font("Noto Sans JP", 18F, FontStyle.Bold);
            FourButton.ForeColor = Color.White;
            FourButton.Location = new Point(12, 359);
            FourButton.Name = "FourButton";
            FourButton.Size = new Size(90, 90);
            FourButton.TabIndex = 9;
            FourButton.Text = "4";
            FourButton.UseVisualStyleBackColor = false;
            FourButton.Click += Button_Click;
            // 
            // ThreeButton
            // 
            ThreeButton.BackColor = Color.FromArgb(64, 64, 64);
            ThreeButton.Font = new Font("Noto Sans JP", 18F, FontStyle.Bold);
            ThreeButton.ForeColor = Color.White;
            ThreeButton.Location = new Point(204, 455);
            ThreeButton.Name = "ThreeButton";
            ThreeButton.Size = new Size(90, 90);
            ThreeButton.TabIndex = 15;
            ThreeButton.Text = "3";
            ThreeButton.UseVisualStyleBackColor = false;
            ThreeButton.Click += Button_Click;
            // 
            // TwoButton
            // 
            TwoButton.BackColor = Color.FromArgb(64, 64, 64);
            TwoButton.Font = new Font("Noto Sans JP", 18F, FontStyle.Bold);
            TwoButton.ForeColor = Color.White;
            TwoButton.Location = new Point(108, 455);
            TwoButton.Name = "TwoButton";
            TwoButton.Size = new Size(90, 90);
            TwoButton.TabIndex = 14;
            TwoButton.Text = "2";
            TwoButton.UseVisualStyleBackColor = false;
            TwoButton.Click += Button_Click;
            // 
            // OneButton
            // 
            OneButton.BackColor = Color.FromArgb(64, 64, 64);
            OneButton.Font = new Font("Noto Sans JP", 18F, FontStyle.Bold);
            OneButton.ForeColor = Color.White;
            OneButton.Location = new Point(12, 455);
            OneButton.Name = "OneButton";
            OneButton.Size = new Size(90, 90);
            OneButton.TabIndex = 13;
            OneButton.Text = "1";
            OneButton.UseVisualStyleBackColor = false;
            OneButton.Click += Button_Click;
            // 
            // DecimalButton
            // 
            DecimalButton.BackColor = Color.FromArgb(64, 64, 64);
            DecimalButton.Font = new Font("Noto Sans JP", 18F, FontStyle.Bold);
            DecimalButton.ForeColor = Color.White;
            DecimalButton.Location = new Point(204, 551);
            DecimalButton.Name = "DecimalButton";
            DecimalButton.Size = new Size(90, 90);
            DecimalButton.TabIndex = 19;
            DecimalButton.Text = ".";
            DecimalButton.UseVisualStyleBackColor = false;
            DecimalButton.Click += Button_Click;
            // 
            // ZeroButton
            // 
            ZeroButton.BackColor = Color.FromArgb(64, 64, 64);
            ZeroButton.Font = new Font("Noto Sans JP", 18F, FontStyle.Bold);
            ZeroButton.ForeColor = Color.White;
            ZeroButton.Location = new Point(108, 551);
            ZeroButton.Name = "ZeroButton";
            ZeroButton.Size = new Size(90, 90);
            ZeroButton.TabIndex = 18;
            ZeroButton.Text = "0";
            ZeroButton.UseVisualStyleBackColor = false;
            ZeroButton.Click += Button_Click;
            // 
            // ModuloButton
            // 
            ModuloButton.BackColor = Color.FromArgb(64, 64, 64);
            ModuloButton.Font = new Font("Noto Sans JP", 18F, FontStyle.Bold);
            ModuloButton.ForeColor = Color.White;
            ModuloButton.Location = new Point(12, 551);
            ModuloButton.Name = "ModuloButton";
            ModuloButton.Size = new Size(90, 90);
            ModuloButton.TabIndex = 17;
            ModuloButton.Text = "%";
            ModuloButton.UseVisualStyleBackColor = false;
            ModuloButton.Click += PercentageButton_Click;
            // 
            // MultiplyButton
            // 
            MultiplyButton.BackColor = Color.Orange;
            MultiplyButton.Font = new Font("Noto Sans JP", 18F, FontStyle.Bold);
            MultiplyButton.ForeColor = Color.White;
            MultiplyButton.Location = new Point(300, 263);
            MultiplyButton.Name = "MultiplyButton";
            MultiplyButton.Size = new Size(90, 90);
            MultiplyButton.TabIndex = 20;
            MultiplyButton.Text = "X";
            MultiplyButton.UseVisualStyleBackColor = false;
            MultiplyButton.Click += OperatorButton_Click;
            // 
            // SubtractButton
            // 
            SubtractButton.BackColor = Color.Orange;
            SubtractButton.Font = new Font("Noto Sans JP", 18F, FontStyle.Bold);
            SubtractButton.ForeColor = Color.White;
            SubtractButton.Location = new Point(300, 359);
            SubtractButton.Name = "SubtractButton";
            SubtractButton.Size = new Size(90, 90);
            SubtractButton.TabIndex = 21;
            SubtractButton.Text = "-";
            SubtractButton.UseVisualStyleBackColor = false;
            SubtractButton.Click += OperatorButton_Click;
            // 
            // AddButton
            // 
            AddButton.BackColor = Color.Orange;
            AddButton.Font = new Font("Noto Sans JP", 18F, FontStyle.Bold);
            AddButton.ForeColor = Color.White;
            AddButton.Location = new Point(300, 455);
            AddButton.Name = "AddButton";
            AddButton.RightToLeft = RightToLeft.No;
            AddButton.Size = new Size(90, 90);
            AddButton.TabIndex = 22;
            AddButton.Text = "+";
            AddButton.UseVisualStyleBackColor = false;
            AddButton.Click += OperatorButton_Click;
            // 
            // EqualButton
            // 
            EqualButton.BackColor = Color.Orange;
            EqualButton.Font = new Font("Noto Sans JP", 18F, FontStyle.Bold);
            EqualButton.ForeColor = Color.White;
            EqualButton.Location = new Point(300, 551);
            EqualButton.Name = "EqualButton";
            EqualButton.Size = new Size(90, 90);
            EqualButton.TabIndex = 23;
            EqualButton.Text = "=";
            EqualButton.UseVisualStyleBackColor = false;
            EqualButton.Click += EqualsButton_Click;
            // 
            // Calc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(402, 653);
            Controls.Add(EqualButton);
            Controls.Add(AddButton);
            Controls.Add(SubtractButton);
            Controls.Add(MultiplyButton);
            Controls.Add(DecimalButton);
            Controls.Add(ZeroButton);
            Controls.Add(ModuloButton);
            Controls.Add(ThreeButton);
            Controls.Add(TwoButton);
            Controls.Add(OneButton);
            Controls.Add(SixButton);
            Controls.Add(FiveButton);
            Controls.Add(FourButton);
            Controls.Add(NineButton);
            Controls.Add(EightButton);
            Controls.Add(SevenButton);
            Controls.Add(DivideButton);
            Controls.Add(SignButton);
            Controls.Add(CButton);
            Controls.Add(DelButton);
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
        private Button DelButton;
        private Button CButton;
        private Button SignButton;
        private Button DivideButton;
        private Button NineButton;
        private Button EightButton;
        private Button SevenButton;
        private Button SixButton;
        private Button FiveButton;
        private Button FourButton;
        private Button ThreeButton;
        private Button TwoButton;
        private Button OneButton;
        private Button DecimalButton;
        private Button ZeroButton;
        private Button ModuloButton;
        private Button MultiplyButton;
        private Button SubtractButton;
        private Button AddButton;
        private Button EqualButton;
    }
}
