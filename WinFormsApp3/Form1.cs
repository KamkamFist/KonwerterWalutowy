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

        void funkcja()
        {
            if (PLN.Checked)
            {
                label1.Text = liczba.ToString("0.00") + "PLN";
            }
            else if (USD.Checked)
            {
                liczba *= 0.26f;
                label1.Text = liczba.ToString("0.00") + "USD";
                liczba /= 0.26f;
            }
            else if (EUR.Checked)
            {
                liczba *= 0.23f;
                label1.Text = liczba.ToString("0.00") + "EUR";
                liczba /= 0.23f;
            }
            else if (RUB.Checked)
            {
                liczba *= 24.38f;
                label1.Text = liczba.ToString("0.00") + "RUB";
                liczba /= 24.38f;
            }
            else if (TRY.Checked)
            {
                liczba *= 8.97f;
                label1.Text = liczba.ToString("0.00") + "TRY";
                liczba /= 8.97f;
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (PLN1.Checked)
            {
                funkcja();
            }
            if (USD1.Checked)
            {
                liczba *= 3.81f;

                funkcja();

                liczba /= 3.81f;
            }
            if (EUR1.Checked)
            {
                liczba *= 4.26f;

                funkcja();

                liczba /= 4.26f;
            }
            if (RUB1.Checked)
            {
                liczba /= 24.38f;

                funkcja();

                liczba *= 24.38f;
            }
            if (TRY1.Checked)
            {
                liczba /= 8.97f;

                funkcja();

                liczba *= 8.97f;
            }




        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
