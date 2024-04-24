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
    public partial class AddNewCurrency : Form
    {
        public Currency newCurrency { get; set; }
        public AddNewCurrency()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            tbName.Text = char.ToUpper(tbName.Text[0]) + tbName.Text.Substring(1).ToLower();
            newCurrency = new Currency(tbName.Text, double.Parse(tbValue.Text));
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void tbName_Validating(object sender, CancelEventArgs e)
        {
            bool isAllLetters = tbName.Text.All(c => char.IsLetter(c));

            if (String.IsNullOrEmpty(tbName.Text) || !isAllLetters)
            {
                errorProvider1.SetError(tbName, "Enter a valid Name!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(tbName, null);
                e.Cancel = false;
            }
        }

        private void tbValue_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(tbValue.Text) || !double.TryParse(tbValue.Text, out double error))
            {
                errorProvider2.SetError(tbValue, "Enter a valid Value!");
                e.Cancel = true;
            }
            else
            {
                errorProvider2.SetError(tbValue, null);
                e.Cancel = false;
            }
        }
    }
}
