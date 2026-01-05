using System.Diagnostics.Metrics;

namespace week2
{
    public partial class Form1 : Form
    {int Ctr = 0;
        
        public Form1()
        {            

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add("item" + Ctr);
            Ctr+=1;

        }
    }
}
