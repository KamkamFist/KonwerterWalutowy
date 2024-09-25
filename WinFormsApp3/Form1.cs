using System.Net.Http;
using System.Net.Http.Json;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {    
        
        private HttpClient sharedClient = new()
        {
            BaseAddress = new Uri("https://api.nbp.pl/"),
        };

        List<Rate> xd = new();    

        public Form1()
        {
            InitializeComponent();

            xd.Add(new Rate { currency = "Z³oty", code = "PLN", mid = 1 });
            var waluty = sharedClient.GetFromJsonAsync<List<RatesTable>>("/api/exchangerates/tables/A?format=json").Result[0];

            for (int i = 0; i < waluty.rates.Count; i++)
            {
               xd.Add(waluty.rates[i]);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

      

        void funkcja(double stara)
        {
            if (PLN.Checked)
            {
                var waluta = xd.Find(x => x.code == "PLN");
                label1.Text = (stara / waluta.mid).ToString("0.00") + waluta.code;
            }
            else if (USD.Checked)
            {
                var waluta = xd.Find(x => x.code == "USD");
                label1.Text = (stara / waluta.mid).ToString("0.00") + waluta.code;
            }
            else if (EUR.Checked)
            {
                var waluta = xd.Find(x => x.code == "EUR");
                label1.Text = (stara / waluta.mid).ToString("0.00") + waluta.code;
            }
            else if (RUB.Checked)
            {
                var waluta = xd.Find(x => x.code == "JPY");
                label1.Text = (stara / waluta.mid).ToString("0.00") + waluta.code;
            }
            else if (TRY.Checked)
            {
                var waluta = xd.Find(x => x.code == "TRY");
                label1.Text = (stara / waluta.mid).ToString("0.00") + waluta.code;
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            double.TryParse(textBox1.Text, out double liczba);
            if (PLN1.Checked)
            {
                funkcja(liczba);
            }
            if (USD1.Checked)
            {
                var waluta = xd.Find(x => x.code == "USD");
                funkcja(liczba * waluta.mid);
            }
            if (EUR1.Checked)
            {
                var waluta = xd.Find(x => x.code == "EUR");
                funkcja(liczba * waluta.mid);
            }
            if (RUB1.Checked)
            {
                var waluta = xd.Find(x => x.code == "JPY");
                funkcja(liczba * waluta.mid);
            }
            if (TRY1.Checked)
            {
                var waluta = xd.Find(x => x.code == "TRY");
                funkcja(liczba * waluta.mid);
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

