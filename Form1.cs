namespace week8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        class calculator
        {
            public double A;
            public double B;
            public calculator(double a, double b)
            {
                A = a;
                B = b;
            }
            public double add()
            {
                return A + B;
            }
            public double sub()
            { return A - B; }
            public double mul()
            { return A * B; }
            public double div()
            { return A / B; }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);
            calculator s = new calculator(a, b);
            label1.Text = s.sub().ToString();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);
            calculator s = new calculator(a, b);
            label1.Text = s.add().ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);
            calculator s = new calculator(a, b);
            label1.Text = s.mul().ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);
            calculator s = new calculator(a, b);
            label1.Text = s.div().ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
