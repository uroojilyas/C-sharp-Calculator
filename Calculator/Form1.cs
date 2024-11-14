namespace Calculator
{
    public partial class Form1 : Form
    {
        double result = 0;                  // Stores the result of calculations
        string operation = "";               // Stores the current operation
        bool isOperationPerformed = false;   // Flag to track if an operation button was pressed
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }
        private void button19_Click(object sender, EventArgs e)
        {

            if ((txtDisplay.Text == "0") || isOperationPerformed)
                txtDisplay.Clear();    // Clear display if starting a new number

            isOperationPerformed = false;
            Button button = (Button)sender;
            txtDisplay.Text += button.Text;  // Append the number to the display
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if ((txtDisplay.Text == "1") || isOperationPerformed)
                txtDisplay.Clear();    // Clear display if starting a new number

            isOperationPerformed = false;
            Button button = (Button)sender;
            txtDisplay.Text += button.Text;  // Append the number to the display
        }

        private void button7_Click(object sender, EventArgs e)
        {

            if ((txtDisplay.Text == "2") || isOperationPerformed)
                txtDisplay.Clear();    // Clear display if starting a new number

            isOperationPerformed = false;
            Button button = (Button)sender;
            txtDisplay.Text += button.Text;  // Append the number to the display
        }

        private void button18_Click(object sender, EventArgs e)
        {

            if ((txtDisplay.Text == "0") || isOperationPerformed)
                txtDisplay.Clear();    // Clear display if starting a new number

            isOperationPerformed = false;
            Button button = (Button)sender;
            txtDisplay.Text += button.Text;  // Append the number to the display
        }

        private void button12_Click(object sender, EventArgs e)
        {

            if ((txtDisplay.Text == "0") || isOperationPerformed)
                txtDisplay.Clear();    // Clear display if starting a new number

            isOperationPerformed = false;
            Button button = (Button)sender;
            txtDisplay.Text += button.Text;  // Append the number to the display
        }

        private void button9_Click(object sender, EventArgs e)
        {

            if ((txtDisplay.Text == "0") || isOperationPerformed)
                txtDisplay.Clear();    // Clear display if starting a new number

            isOperationPerformed = false;
            Button button = (Button)sender;
            txtDisplay.Text += button.Text;  // Append the number to the display
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if ((txtDisplay.Text == "0") || isOperationPerformed)
                txtDisplay.Clear();    // Clear display if starting a new number

            isOperationPerformed = false;
            Button button = (Button)sender;
            txtDisplay.Text += button.Text;  // Append the number to the display
        }

        private void button15_Click(object sender, EventArgs e)
        {

            if ((txtDisplay.Text == "0") || isOperationPerformed)
                txtDisplay.Clear();    // Clear display if starting a new number

            isOperationPerformed = false;
            Button button = (Button)sender;
            txtDisplay.Text += button.Text;  // Append the number to the display
        }

        private void button13_Click(object sender, EventArgs e)
        {

            if ((txtDisplay.Text == "0") || isOperationPerformed)
                txtDisplay.Clear();    // Clear display if starting a new number

            isOperationPerformed = false;
            Button button = (Button)sender;
            txtDisplay.Text += button.Text;  // Append the number to the display
        }

        private void button5_Click(object sender, EventArgs e)
        {

            if ((txtDisplay.Text == "0") || isOperationPerformed)
                txtDisplay.Clear();    // Clear display if starting a new number

            isOperationPerformed = false;
            Button button = (Button)sender;
            txtDisplay.Text += button.Text;  // Append the number to the display
        }

        private void button23_Click(object sender, EventArgs e)
        {
            result = double.Parse(txtDisplay.Text); // Store the current value as result
            operation = "+";                        // Set the operation to addition
            isOperationPerformed = true;            // Mark that an operation was performed
        }

        private void button17_Click_1(object sender, EventArgs e)
        {
            result = double.Parse(txtDisplay.Text);
            operation = "-";
            isOperationPerformed = true;
        }

        private void button16_Click(object sender, EventArgs e)
        {

            result = double.Parse(txtDisplay.Text);
            operation = "*";
            isOperationPerformed = true;

        }

        private void button24_Click(object sender, EventArgs e)
        {
            result = double.Parse(txtDisplay.Text);
            operation = "/";
            isOperationPerformed = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            result = double.Parse(txtDisplay.Text);
            operation = "%";
            isOperationPerformed = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            double number = double.Parse(txtDisplay.Text);
            txtDisplay.Text = (number * number).ToString(); // Calculate and display the square
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double number = double.Parse(txtDisplay.Text);
            txtDisplay.Text = Math.Sqrt(number).ToString(); // Calculate and display the square root
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = Math.PI.ToString(); // Display the value of Pi
        }

        private void button14_Click_1(object sender, EventArgs e)
        {
            int number = int.Parse(txtDisplay.Text);
            txtDisplay.Text = Factorial(number).ToString(); // Calculate and display factorial
        }

        private int Factorial(int number)
        {
            if (number <= 1)
                return 1;
            else
                return number * Factorial(number - 1); // Recursive factorial calculation
        }

        private void button10_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":
                    txtDisplay.Text = (result + double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "-":
                    txtDisplay.Text = (result - double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "*":
                    txtDisplay.Text = (result * double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "/":
                    txtDisplay.Text = (result / double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "%":
                    txtDisplay.Text = (result % double.Parse(txtDisplay.Text)).ToString();
                    break;
            }
            result = double.Parse(txtDisplay.Text); // Store the result in case of further calculations
            operation = "";
        }

        private void button26_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            result = 0;
            operation = "";
        }

        private void button25_Click(object sender, EventArgs e)
        {
            // Check if there's anything in the display
            if (txtDisplay.Text.Length > 0)
            {
                // Remove the last character
                txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - 1);

                // If display becomes empty, reset it to "0"
                if (txtDisplay.Text == "")
                {
                    txtDisplay.Text = "0";
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt"); // Display current time in HH:MM:SS AM/PM format
        }

        private void button20_Click(object sender, EventArgs e)
        {
            // Check if the display already contains a decimal point
            if (!txtDisplay.Text.Contains("."))
            {
                // If not, add a decimal point to the display
                txtDisplay.Text += ".";
            }
        }
    }
}
