namespace CSharpCalc
{
    public partial class Calc : Form
    {
        private string CurrentInput = "0";
        private double FirstOperand = 0;
        private char CurrentOperator;
        private bool OperatorPressed = false;
        public Calc()
        {
            InitializeComponent();
            UpdateDisplay(CurrentInput);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UpdateDisplay(string text)
        {
            this.Result.Text = text;
            this.Result.Update();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string digit = btn.Text;

            if (OperatorPressed)
            {
                CurrentInput = "0";
                OperatorPressed = false;
            }

            if (CurrentInput == "0" && digit != ".")
            {
                CurrentInput = digit;
            }
            else if (digit == "." && CurrentInput.Contains("."))
            {
                
            }
            else if (CurrentInput == "Error")
            {
                CurrentInput = digit;
            }
            else
            {
                CurrentInput += digit;
            }

            UpdateDisplay(CurrentInput);
        }

        private void EqualsButton_Click(object sender, EventArgs e)
        {
            if (CurrentInput == "Error") return;

            PerformCalculation();
            CurrentOperator = default(char);
            OperatorPressed = false;
        }

        private void PerformCalculation()
        {
            if (CurrentOperator == default(char))
            {
                FirstOperand = double.Parse(CurrentInput);
                return;
            }

            double secondOperand;
            if (!double.TryParse(CurrentInput, out secondOperand))
            {
                CurrentInput = "Error";
                UpdateDisplay(CurrentInput);
                FirstOperand = 0;
                CurrentOperator = default(char);
                return;
            }

            double result = 0;

            switch (CurrentOperator)
            {
                case '+':
                    result = FirstOperand + secondOperand;
                    break;
                case '-':
                    result = FirstOperand - secondOperand;
                    break;
                case 'x':
                    result = FirstOperand * secondOperand;
                    break;
                case '/':
                    if (secondOperand != 0)
                    {
                        result = FirstOperand / secondOperand;
                    }
                    else
                    {
                        CurrentInput = "Error";
                        UpdateDisplay(CurrentInput);
                        FirstOperand = 0;
                        CurrentOperator = default(char);
                        return;
                    }
                    break;
            }

            CurrentInput = result.ToString();
            FirstOperand = result;
            UpdateDisplay(CurrentInput);
        }

        private void OperatorButton_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            char op = btn.Text[0];

            if (CurrentInput == "Error") return;

            if (!OperatorPressed)
            {
                if (FirstOperand != 0 || CurrentInput != "0")
                {
                    if (CurrentOperator != default(char))
                    {
                        PerformCalculation();
                    }
                    else
                    {
                        FirstOperand = double.Parse(CurrentInput);
                    }
                }
            }

            CurrentOperator = op;
            OperatorPressed = true; 
            // UpdateDisplay(firstOperand.ToString());
        }

        private void Delete_Char(object sender, EventArgs e)
        {
            if (CurrentInput == "Error")
            {
                CurrentInput = "0";
            }
            else if (CurrentInput.Length > 1)
            {
                CurrentInput = CurrentInput.Remove(CurrentInput.Length - 1);
            }
            else
            {
                CurrentInput = "0";
            }
            UpdateDisplay(CurrentInput);
        }

        private void Clear_Result(object sender, EventArgs e)
        {
            CurrentInput = "0";
            FirstOperand = 0;
            CurrentOperator = default(char);
            OperatorPressed = false;
            UpdateDisplay(CurrentInput);
        }

        private void SignChangeButton_Click(object sender, EventArgs e)
        {
            if (CurrentInput == "0" || CurrentInput == "Error") return;
            if (double.TryParse(CurrentInput, out double number))
            {
                number *= -1;
                CurrentInput = number.ToString();
                UpdateDisplay(CurrentInput);
            }
        }

        private void PercentageButton_Click(object sender, EventArgs e)
        {
            if (CurrentInput == "0" || CurrentInput == "Error") return;
            if (double.TryParse(CurrentInput, out double number))
            {
                number /= 100;
                CurrentInput = number.ToString();
                UpdateDisplay(CurrentInput);
            }
        }
    }
}
