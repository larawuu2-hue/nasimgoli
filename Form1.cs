using System.Reflection.PortableExecutable;

namespace week6
{
    public partial class Form1 : Form
    {
        mashin m1 = new mashin();

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtsum_Click(object sender, EventArgs e)
        {
            label1.Text = m1.sum(int.Parse(textBox1.Text), int.Parse(textBox2.Text));

        }

        private void menha_Click(object sender, EventArgs e)
        {
            label1.Text = m1.menha(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
        }

        private void zarb_Click(object sender, EventArgs e)
        {
            label1.Text = m1.zarb(int.Parse(textBox1.Text), int.Parse(textBox2.Text));

        }

        private void taghsim_Click(object sender, EventArgs e)
        {
            label1.Text = m1.taghsim(int.Parse(textBox1.Text), int.Parse(textBox2.Text));

        }
        class mashin
        {

            public int n1;
            public int n2;
            public int result;
            public string r = "";



            public string sum(int n1, int n2)
            {
                result = n1 + n2;
                r = result.ToString();
                return r;
            }
            public string menha(int n1, int n2)
            {
                result = n1 - n2;
                r = result.ToString();
                return r;


            }
            public string zarb(int n1, int n2)
            {
                result = n1 * n2;
                r = result.ToString();
                return r;


            }
            public string taghsim(int n1, int n2)
            {
                result = n1 / n2;
                r = result.ToString();
                return r;


            }
        }
    }
}
