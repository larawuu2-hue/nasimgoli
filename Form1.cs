namespace week9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int[,] table = new int[10, 10];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    table[i, j] = (i + 1) * (j + 1);
                }
            }
            for (int col = 0; col < 10; col++)
            {
                dataGridView2.Columns.Add("col" + col, (col + 1).ToString());
            }
            for (int row = 0; row < 10; row++)
            {
                object[] rowdata = new object[10];
                for (int col = 0; col < 10; col++)
                {
                    rowdata[col] = table[row, col];
                }
                dataGridView2.Rows.Add(rowdata);
            }
            
        }
    }
}
