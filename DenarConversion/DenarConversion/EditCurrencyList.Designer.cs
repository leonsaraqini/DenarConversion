namespace DenarConversion
{
    partial class EditCurrencyList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditCurrencyList));
            lbCurrencies = new ListBox();
            tbNewValue = new TextBox();
            label1 = new Label();
            btnEnterNewCurrency = new Button();
            btnRemoveCurrency = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lbCurrencies
            // 
            lbCurrencies.FormattingEnabled = true;
            lbCurrencies.Location = new Point(43, 40);
            lbCurrencies.Name = "lbCurrencies";
            lbCurrencies.Size = new Size(178, 264);
            lbCurrencies.TabIndex = 0;
            // 
            // tbNewValue
            // 
            tbNewValue.Location = new Point(227, 63);
            tbNewValue.Name = "tbNewValue";
            tbNewValue.Size = new Size(217, 27);
            tbNewValue.TabIndex = 1;
            tbNewValue.Validating += tbNewValue_Validating;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(227, 40);
            label1.Name = "label1";
            label1.Size = new Size(217, 20);
            label1.TabIndex = 2;
            label1.Text = "Enter value of existing currency:";
            // 
            // btnEnterNewCurrency
            // 
            btnEnterNewCurrency.Location = new Point(227, 105);
            btnEnterNewCurrency.Name = "btnEnterNewCurrency";
            btnEnterNewCurrency.Size = new Size(217, 44);
            btnEnterNewCurrency.TabIndex = 3;
            btnEnterNewCurrency.Text = "Enter";
            btnEnterNewCurrency.UseVisualStyleBackColor = true;
            btnEnterNewCurrency.Click += btnEnterNewCurrency_Click;
            // 
            // btnRemoveCurrency
            // 
            btnRemoveCurrency.Location = new Point(227, 260);
            btnRemoveCurrency.Name = "btnRemoveCurrency";
            btnRemoveCurrency.Size = new Size(217, 44);
            btnRemoveCurrency.TabIndex = 4;
            btnRemoveCurrency.Text = "Remove";
            btnRemoveCurrency.UseVisualStyleBackColor = true;
            btnRemoveCurrency.Click += btnRemoveCurrency_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // EditCurrencyList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 353);
            Controls.Add(btnRemoveCurrency);
            Controls.Add(btnEnterNewCurrency);
            Controls.Add(label1);
            Controls.Add(tbNewValue);
            Controls.Add(lbCurrencies);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "EditCurrencyList";
            Text = "Edit Existing Currency";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbCurrencies;
        private TextBox tbNewValue;
        private Label label1;
        private Button btnEnterNewCurrency;
        private Button btnRemoveCurrency;
        private ErrorProvider errorProvider1;
    }
}