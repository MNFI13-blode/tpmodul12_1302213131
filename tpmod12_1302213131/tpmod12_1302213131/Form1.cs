namespace tpmod12_1302213131
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string CariTandaBilangan(int a)
        {
            if (a == 0)
            {
                return "Nol";
            }
            else if (a < 0)
            {
                return "Negatif";
            }
            else if (a > 0)
            {
                return "Positif";
            }
            return " ";
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int parameterValue;
            if (!int.TryParse(textBox1.Text, out parameterValue))
            {
                MessageBox.Show("inputannya angka ya masbro, jangan teks :v");
                return;
            }

            string result = CariTandaBilangan(parameterValue);

            label1.Text = result;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}