using System;
using Convertion;
using Newtonsoft.Json.Linq;
using System.IO;
using System.Net;
using System.Windows.Forms;


namespace LiveCurrencyConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            getCurrency();
        }

        public void getCurrency()
        {
            API Request = new API("https://free.currconv.com/api/v7/currencies?apiKey=83bc82312153c2b7933c");
            CurrencyList currencyList = CurrencyList.Deserialize(Request.SendAndGetResponse());

            CurrencyData[] datas = currencyList.ToArray();
            foreach (CurrencyData currency in datas)
            {
                fromComboBox.Items.Add(currency.id + " - " + currency.currencyName);
                toComboBox.Items.Add(currency.id + " - " + currency.currencyName);
            }
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox.Text))
            {
                MessageBox.Show("Please fill in the amount.");
            }

            else if (string.IsNullOrEmpty((string)toComboBox.SelectedItem) || string.IsNullOrEmpty((string)fromComboBox.SelectedItem))
            {
                MessageBox.Show("Please choose the currency first.");
            }

            else
            {
                Double i = Convert.ToDouble(textBox.Text);
                Double rate = getRate(fromComboBox.Text.Substring(0, 3), toComboBox.Text.Substring(0, 3), dateTimePicker.Value.Date.ToString("yyyy-MM-dd"));
                i = i * rate;


                labelConverted.Text = toComboBox.Text.Substring(0, 3) + " " + string.Format("{0:F2}", i);
            }
        }

        public static double getRate(string from, string to, string date)
        {
            string url;
            url = "https://free.currencyconverterapi.com/api/v6/" + "convert?q=" + from + "_" + to + "&compact=y&date=" + date + "&apiKey=83bc82312153c2b7933c";
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.AutomaticDecompression = DecompressionMethods.GZip;

            string jsonString;
            using (var response = (HttpWebResponse)request.GetResponse())
            using (var stream = response.GetResponseStream())
            using (var reader = new StreamReader(stream))
            {
                jsonString = reader.ReadToEnd();
            }

            return JObject.Parse(jsonString).First.First["val"].First.ToObject<double>();
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                textBox.Text = textBox.Text.Remove(textBox.Text.Length - 1);
            }
        }
    }
}
