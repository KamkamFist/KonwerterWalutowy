namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
        float liczba = 0;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int result))
            {
                liczba = result;
            }
        }





        private void button1_Click(object sender, EventArgs e)
        {

            if (USD.Checked)
            {
                liczba /= 3.81f;
                label1.Text = liczba.ToString("0.00");
                liczba *= 3.81f;
            }
            else if (EUR.Checked)
            {
                liczba /= 4.26f;
                label1.Text = liczba.ToString("0.00");
                liczba *= 4.26f;
            }
            else if (RUB.Checked)
            {
                liczba *= 24.38f;
                label1.Text = liczba.ToString("0.00");
                liczba /= 24.38f;
            }
            else if (TRY.Checked)
            {
                liczba *= 8.97f;
                label1.Text = liczba.ToString("0.00");
                liczba /= 8.97f;
            }



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
