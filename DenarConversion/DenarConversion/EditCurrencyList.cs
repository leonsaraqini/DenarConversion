using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DenarConversion
{
    public partial class EditCurrencyList : Form
    {
        public List<Currency> currencyList { get; set; }
        public EditCurrencyList(List<Currency> currencies)
        {
            InitializeComponent();

            currencyList = currencies;

            currencyList.ForEach(c => lbCurrencies.Items.Add(c));

            lbCurrencies.SelectedIndex = 0;
        }

        private void tbNewValue_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(tbNewValue.Text) || !double.TryParse(tbNewValue.Text, out double error))
            {
                errorProvider1.SetError(tbNewValue, "Enter a valid Value!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(tbNewValue, null);
                e.Cancel = false;
            }
        }

        private void btnEnterNewCurrency_Click(object sender, EventArgs e)
        {
            Currency selectedCurrency = lbCurrencies.SelectedItem as Currency;

            selectedCurrency.Value = double.Parse(tbNewValue.Text);

            DialogResult = DialogResult.OK;
        }

        private void btnRemoveCurrency_Click(object sender, EventArgs e)
        {
            Currency removeCurrency = lbCurrencies.SelectedItem as Currency;

            currencyList.Remove(removeCurrency);

            DialogResult = DialogResult.OK;
        }
    }
}
