namespace DenarConversion
{
    public partial class Form1 : Form
    {
        List<Currency> currencies = new List<Currency>();

        public Form1()
        {
            currencies.Add(new Currency("Dollar", 57.99));
            currencies.Add(new Currency("Euro", 61.65));
            currencies.Add(new Currency("Peso", 1.5));

            InitializeComponent();

            btnEditExistingCurrency.TabStop = false;
            btnAddNewCurrency.TabStop = false;

            setCurrencyList();
        }

        private void setCurrencyList()
        {
            lbCurrencies.Items.Clear();
            currencies.ForEach(c => lbCurrencies.Items.Add(c));
        }

        private double getCurrencyValue(String currency)
        {
            return currencies.Find(c => c.Name == currency).Value;
        }
        private bool doesCurrencyExists(String currency)
        {
            return currencies.Any(c => c.Name == currency);
        }

        private void setCurrencyValue()
        {
            if (String.IsNullOrEmpty(tbDenarValue.Text))
            {
                tbCurrencyValue.Clear();
                return;
            }

            string currencyText = lbCurrencies.Items[lbCurrencies.SelectedIndex].ToString();
            double currencyValue = getCurrencyValue(currencyText);

            if (!double.TryParse(tbDenarValue.Text, out double error))
            {
                tbCurrencyValue.Text = "Enter the right value";
                return;
            };

            if (!String.IsNullOrEmpty(tbDenarValue.Text))
                tbCurrencyValue.Text = (currencyValue * double.Parse(tbDenarValue.Text)).ToString();

        }

        private void lbCurrencies_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbCurrencies.SelectedIndex != -1)
            {

                string currencyText = lbCurrencies.Items[lbCurrencies.SelectedIndex].ToString();
                lblCurrencyValue.Text = "1 " + currencyText;
                lblDenarValue.Text = getCurrencyValue(currencyText) + " Denars";

                setCurrencyValue();

            }
            else
            {
                tbDenarValue.Clear();
                tbCurrencyValue.Clear();

                lblCurrencyValue.Text = "";
                lblDenarValue.Text = "0 Denar";
            }
        }

        private void tbDenarValue_TextChanged(object sender, EventArgs e)
        {
            if (lbCurrencies.SelectedIndex == -1) lbCurrencies.SelectedIndex = 0;

            setCurrencyValue();
        }

        private void btnAddNewCurrency_Click(object sender, EventArgs e)
        {
            AddNewCurrency addNewCurrency = new AddNewCurrency();

            if (addNewCurrency.ShowDialog() == DialogResult.OK)
            {
                if (doesCurrencyExists(addNewCurrency.newCurrency.Name)) return;

                currencies.Add(addNewCurrency.newCurrency);
                lbCurrencies.Items.Add(addNewCurrency.newCurrency);

                lbCurrencies.ClearSelected();
            }
        }

        private void btnEditExistingCurrency_Click(object sender, EventArgs e)
        {
            EditCurrencyList editCurrencyList = new EditCurrencyList(currencies);

            if (editCurrencyList.ShowDialog() == DialogResult.OK)
            {
                setCurrencyList();
            }
        }
    }
}
