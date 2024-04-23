﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignPartOnlyTest
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

            tbnChangeExistingCurrency.TabStop = false;
            btnAddNewCurrency.TabStop = false;

            setCurrencyList();            
        }

        private void setCurrencyList()
        {
            lbCurrencies.SelectedIndex = -1;
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
            string currencyText = lbCurrencies.Items[lbCurrencies.SelectedIndex].ToString();
            double currencyValue = getCurrencyValue(currencyText);
            
            if (!String.IsNullOrEmpty(tbDenarValue.Text))
                tbCurrencyValue.Text = (currencyValue * double.Parse(tbDenarValue.Text)).ToString();
        }

        private void lbCurrencies_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbCurrencies.SelectedIndex != -1)
            {

                string currencyText = lbCurrencies.Items[lbCurrencies.SelectedIndex].ToString();
                lblCurrency.Text = "1 " + currencyText;
                lblDenar.Text = getCurrencyValue(currencyText) + " Denars";

                setCurrencyValue();

            }
            else
            {
                tbDenarValue.Clear();
                tbCurrencyValue.Clear();

                lblCurrency.Text = "";
                lblDenar.Text = "0 Denar";
            }
        }

        private void tbDenarValue_TextChanged(object sender, EventArgs e)
        {
            if(lbCurrencies.SelectedIndex == -1) lbCurrencies.SelectedIndex = 0;

            if (String.IsNullOrEmpty(tbDenarValue.Text))
            {
                tbCurrencyValue.Clear();
                return;
            }
            
            if (!double.TryParse(tbDenarValue.Text, out double error))
            {
                tbCurrencyValue.Text = "Enter the right value";
                return;
            };

            setCurrencyValue();
        }



        private void btnAddNewCurrency_Click(object sender, EventArgs e)
        {
            AddNewCurrency addNewCurrency = new AddNewCurrency();

            if(addNewCurrency.ShowDialog() == DialogResult.OK)
            {
                if (doesCurrencyExists(addNewCurrency.newCurrency.Name)) return;

                currencies.Add(addNewCurrency.newCurrency);
                lbCurrencies.Items.Add(addNewCurrency.newCurrency);

                lbCurrencies.ClearSelected();
            }
        }


        private void tbnChangeExistingCurrency_Click(object sender, EventArgs e)
        {
            EditCurrencyList editCurrencyList = new EditCurrencyList(currencies);            

            if(editCurrencyList.ShowDialog() == DialogResult.OK)
            {
                setCurrencyList();  
            }

          
        }

        private void tbDenarValue_Validating(object sender, CancelEventArgs e)
        {

        }

        private void lbCurrencies_Validating(object sender, CancelEventArgs e)
        {

        }

        private void currencyBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.currencyBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.currencyDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'currencyDataSet.Currency' table. You can move, or remove it, as needed.
            this.currencyTableAdapter.Fill(this.currencyDataSet.Currency);

        }
    }
}
