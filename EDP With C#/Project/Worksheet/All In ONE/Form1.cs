namespace All_In_ONE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void additionResultButton_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(additionFirstNumTextBox.Text);
            double num2 = double.Parse(additionSecondNumTextBox.Text);
            double result = num1 + num2;
            additionResultTextBox.Text = result.ToString();

        }

        private void calculatorResultButton_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void homeButton_Click(object sender, EventArgs e)
        {


        }

        private void additionButton_Click(object sender, EventArgs e)
        {
            additionPanel.Visible = true;
            calculatorPannel.Visible = false;
            homePannel.Visible = false;
            temperaturePanel.Visible = false;
            factorialPanel.Visible = false;
            taxPanel.Visible = false;



            pointerPanelOnAddition.Visible = true;
            pointerPanelOnFactorial.Visible = false;
            pointerPanelOnCalculator.Visible = false;
            pointerPanelOnSeeMore.Visible = false;
            pointerPanelOnTax.Visible = false;
            pointerPanelOnTemperature.Visible = false;
        }

        private void CalculatorButton_Click(object sender, EventArgs e)
        {
            calculatorPannel.Visible = true;
            additionPanel.Visible = false;
            homePannel.Visible = false;
            temperaturePanel.Visible = false;
            factorialPanel.Visible = false;
            taxPanel.Visible = false;



            pointerPanelOnAddition.Visible = false;
            pointerPanelOnFactorial.Visible = false;
            pointerPanelOnCalculator.Visible = true;
            pointerPanelOnSeeMore.Visible = false;
            pointerPanelOnTax.Visible = false;
            pointerPanelOnTemperature.Visible = false;
        }

        private void calculatorPannel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void homeIntroTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void homeeButton_Click(object sender, EventArgs e)
        {
            homePannel.Visible = true;
            homePannel.Visible = true;
            additionPanel.Visible = false;
            calculatorPannel.Visible = false;
            temperaturePanel.Visible = false;
            factorialPanel.Visible = false;
            taxPanel.Visible = false;



            pointerPanelOnAddition.Visible = false;
            pointerPanelOnFactorial.Visible = false;
            pointerPanelOnCalculator.Visible = false;
            pointerPanelOnSeeMore.Visible = false;
            pointerPanelOnTax.Visible = false;
            pointerPanelOnTemperature.Visible = false;
        }

        private void calculatorResultButton_Click_1(object sender, EventArgs e)
        {
            double num1 = double.Parse(calculatorFirstNumberTextBox.Text);
            double num2 = double.Parse(calculatorSecondNumberTextBox.Text);
            double result;
            if (calculatorComboBox.SelectedIndex == 0)
            {
                result = num1 + num2;
                calculatorResultTextBox.Text = result.ToString();
            }
            else if (calculatorComboBox.SelectedIndex == 1)
            {
                result = num1 - num2;
                calculatorResultTextBox.Text = result.ToString();
            }
            else if (calculatorComboBox.SelectedIndex == 2)
            {
                result = num1 * num2;
                calculatorResultTextBox.Text = result.ToString();
            }
            else if (calculatorComboBox.SelectedIndex == 3)
            {
                result = num1 / num2;
                calculatorResultTextBox.Text = result.ToString();
            }
        }

        private void additionResultButton_Click_1(object sender, EventArgs e)
        {
            double firstNum = double.Parse(additionFirstNumTextBox.Text);
            double secondNum = double.Parse(additionSecondNumTextBox.Text);
            double result = firstNum + secondNum;
            additionResultTextBox.Text = result.ToString();

        }

        private void tempConvertButton_Click(object sender, EventArgs e)
        {


            double result;
            if (tempComboBox.SelectedIndex == 0)
            {

                result = 0.56 * ((double.Parse(tempEnterNumberTextBox.Text) - 32));
                tempResultTextBox.Text = Math.Round(result, 2).ToString() + "C";
            }
            else if (tempComboBox.SelectedIndex == 1)
            {
                tempEnterNumberLabel.Text = "Enter The Number";
                result = (double.Parse(tempEnterNumberTextBox.Text) * 1.8) + 32;
                tempResultTextBox.Text = Math.Round(result, 2).ToString() + "F";
            }
        }

        private void tempEnterNumberLabel_Click(object sender, EventArgs e)
        {

        }

        private void temperatureButton_Click(object sender, EventArgs e)
        {
            temperaturePanel.Visible = true;
            homePannel.Visible = false;
            additionPanel.Visible = false;
            calculatorPannel.Visible = false;
            factorialPanel.Visible = false;
            taxPanel.Visible = false;



            pointerPanelOnTemperature.Visible = true;
            pointerPanelOnAddition.Visible = false;
            pointerPanelOnFactorial.Visible = false;
            pointerPanelOnCalculator.Visible = false;
            pointerPanelOnSeeMore.Visible = false;
            pointerPanelOnTax.Visible = false;

        }

        private void pointerPanelOnTemperature_Paint(object sender, PaintEventArgs e)
        {

        }

        private void factButton_Click(object sender, EventArgs e)
        {
            int sum = 1;
            int num = int.Parse(factEnterTextBox.Text);
            for (int i = num; i > 0; i--)
            {
                sum *= i;
            }
            factResultTextBox.Text = sum.ToString();
        }

        private void factorialButton_Click(object sender, EventArgs e)
        {
            additionPanel.Visible = false;
            calculatorPannel.Visible = false;
            homePannel.Visible = false;
            temperaturePanel.Visible = false;
            factorialPanel.Visible = true;
            taxPanel.Visible = false;



            pointerPanelOnAddition.Visible = false;
            pointerPanelOnFactorial.Visible = true;
            pointerPanelOnCalculator.Visible = false;
            pointerPanelOnSeeMore.Visible = false;
            pointerPanelOnTax.Visible = false;
            pointerPanelOnTemperature.Visible = false;
        }

        private void taxButton_Click(object sender, EventArgs e)
        {
            additionPanel.Visible = false;
            calculatorPannel.Visible = false;
            homePannel.Visible = false;
            temperaturePanel.Visible = false;
            factorialPanel.Visible = false;
            taxPanel.Visible = true;



            pointerPanelOnAddition.Visible = false;
            pointerPanelOnFactorial.Visible = false;
            pointerPanelOnCalculator.Visible = false;
            pointerPanelOnSeeMore.Visible = false;
            pointerPanelOnTax.Visible = true;
            pointerPanelOnTemperature.Visible = false;
        }



        private void taxCalculateButton_Click(object sender, EventArgs e)
        {
            if (int.Parse(taxEnterTextBox.Text) <= 150)

            {
                int result = 0;
                taxResultTextBox.Text = result.ToString() + "%";
            }

            else if (int.Parse(taxEnterTextBox.Text) > 150 && int.Parse(taxEnterTextBox.Text) <= 600)
            {
                int result = 10;
                taxResultTextBox.Text = result.ToString() + "%";
            }
            else if (int.Parse(taxEnterTextBox.Text) > 600 && int.Parse(taxEnterTextBox.Text) <= 1200)
            {
                int result = 15;
                taxResultTextBox.Text = result.ToString() + "%";
            }
            else if (int.Parse(taxEnterTextBox.Text) > 1200 && int.Parse(taxEnterTextBox.Text) <= 2400)
            {
                int result = 20;
                taxResultTextBox.Text = result.ToString() + "%";
            }
            else if (int.Parse(taxEnterTextBox.Text) > 2400 && int.Parse(taxEnterTextBox.Text) <= 3500)
            {
                int result = 25;
                taxResultTextBox.Text = result.ToString() + "%";
            }
            else if (int.Parse(taxEnterTextBox.Text) > 3500 && int.Parse(taxEnterTextBox.Text) <= 5000)
            {
                int result = 30;
                taxResultTextBox.Text = result.ToString() + "%";
            }
            else if (int.Parse(taxEnterTextBox.Text) > 5000)
            {
                int result = 35;
                taxResultTextBox.Text = result.ToString() + "%";
            }
        }

        private void seeMoreButton_Click(object sender, EventArgs e)
        {
            rightPanel.Visible = false;
            seeMore1Panel.Visible = true;
        }

        private void calc2ResultButton_Click(object sender, EventArgs e)
        {
            double result;
            double num = double.Parse(calc2EnterTextBox.Text);
            if (calc2ComboBox.SelectedIndex == 0)
            {
                result = num * num;
                calc2ResultTextBox.Text = Math.Round(result, 2).ToString();
            }
            if (calc2ComboBox.SelectedIndex == 1)
            {
                result = Math.Sqrt(num);
                calc2ResultTextBox.Text = Math.Round(result, 2).ToString();

            }
            if (calc2ComboBox.SelectedIndex == 2)
            {
                result = Math.ReciprocalEstimate(num);
                calc2ResultTextBox.Text = Math.Round(result, 2).ToString();
            }
        }

        private void home2Button_Click(object sender, EventArgs e)
        {
            homePannel.Visible = true;
            calculator2Panel.Visible = false;
            additionPanel.Visible = false;
            calculatorPannel.Visible = false;
            homePannel.Visible = false;
            temperaturePanel.Visible = false;
            factorialPanel.Visible = false;
            taxPanel.Visible = false;


            pointerPanelOnCalculator2.Visible = false;
            pointerPanelOnDayCount.Visible = false;
            pointerPanelOnSorter.Visible = false;
            pointerPanelOnLength.Visible = false;
            pointerPanelOnWeight.Visible = false;
            pointerPanelOnWeight.Visible = false;

        }

        private void calculator2Button_Click(object sender, EventArgs e)
        {
            homePannel.Visible = false;
            calculator2Panel.Visible = true;
            additionPanel.Visible = false;
            calculatorPannel.Visible = false;
            homePannel.Visible = false;
            temperaturePanel.Visible = false;
            factorialPanel.Visible = false;
            taxPanel.Visible = false;

            pointerPanelOnCalculator2.Visible = true;
            pointerPanelOnDayCount.Visible = false;
            pointerPanelOnSorter.Visible = false;
            pointerPanelOnLength.Visible = false;
            pointerPanelOnWeight.Visible = false;
            pointerPanelOnWeight.Visible = false;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            rightPanel.Visible = true;
            seeMore1Panel.Visible = false;
        }
    }
}