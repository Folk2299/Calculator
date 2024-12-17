namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // ข้อความตัวอักษร
            string inputNum1 = num1.Text;
            string inputNum2 = num2.Text;
            // convert string to number (integer)
            double iNum1 = Double.Parse(inputNum1);
            double iNum2 = Double.Parse(inputNum2);
            // int ทำให้เราสามารถทำการ + - * / ได้
            double iResult = iNum1 + iNum2;
            // ที่ตัวแปรชื่อ result
            // มีคุณสมบัติชื่อ Text
            result.Text = iResult.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // ข้อความตัวอักษร
            string inputNum1 = num1.Text;
            string inputNum2 = num2.Text;
            // convert string to number (integer)
            double iNum1 = Double.Parse(inputNum1);
            double iNum2 = Double.Parse(inputNum2);
            // int ทำให้เราสามารถทำการ + - * / ได้
            double iResult = iNum1 - iNum2;
            // ที่ตัวแปรชื่อ result
            // มีคุณสมบัติชื่อ Text
            result.Text = iResult.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // ข้อความตัวอักษร
            string inputNum1 = num1.Text;
            string inputNum2 = num2.Text;
            // convert string to number (integer)
            double iNum1 = Double.Parse(inputNum1);
            double iNum2 = Double.Parse(inputNum2);
            // int ทำให้เราสามารถทำการ + - * / ได้
            double iResult = iNum1 * iNum2;
            // ที่ตัวแปรชื่อ result
            // มีคุณสมบัติชื่อ Text
            result.Text = iResult.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // ข้อความตัวอักษร
            string inputNum1 = num1.Text;
            string inputNum2 = num2.Text;
            // convert string to number (integer)
            double iNum1 = Double.Parse(inputNum1);
            double iNum2 = Double.Parse(inputNum2);
            // int ทำให้เราสามารถทำการ + - * / ได้
            double iResult = iNum1 / iNum2;
            // ที่ตัวแปรชื่อ result
            // มีคุณสมบัติชื่อ Text
            result.Text = iResult.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            num1.Text = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            num2.Text = textBox1.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            num1.Text = "";
            num2.Text = "";
            result.Text = "";
        }
    }
}
