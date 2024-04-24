namespace DenarConversion
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lbCurrencies = new ListBox();
            btnAddNewCurrency = new Button();
            btnEditExistingCurrency = new Button();
            tbDenarValue = new TextBox();
            tbCurrencyValue = new TextBox();
            lblConvertsTo = new Label();
            lblCurrencyName = new Label();
            lblCurrencyValue = new Label();
            lblDenarValue = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // lbCurrencies
            // 
            lbCurrencies.FormattingEnabled = true;
            lbCurrencies.Location = new Point(42, 41);
            lbCurrencies.Name = "lbCurrencies";
            lbCurrencies.Size = new Size(200, 284);
            lbCurrencies.TabIndex = 0;
            lbCurrencies.SelectedIndexChanged += lbCurrencies_SelectedIndexChanged;
            // 
            // btnAddNewCurrency
            // 
            btnAddNewCurrency.Location = new Point(42, 331);
            btnAddNewCurrency.Name = "btnAddNewCurrency";
            btnAddNewCurrency.Size = new Size(200, 40);
            btnAddNewCurrency.TabIndex = 1;
            btnAddNewCurrency.Text = "Add New Currency";
            btnAddNewCurrency.UseVisualStyleBackColor = true;
            btnAddNewCurrency.Click += btnAddNewCurrency_Click;
            // 
            // btnEditExistingCurrency
            // 
            btnEditExistingCurrency.Location = new Point(42, 377);
            btnEditExistingCurrency.Name = "btnEditExistingCurrency";
            btnEditExistingCurrency.Size = new Size(200, 40);
            btnEditExistingCurrency.TabIndex = 2;
            btnEditExistingCurrency.Text = "Edit Existing Currency";
            btnEditExistingCurrency.UseVisualStyleBackColor = true;
            btnEditExistingCurrency.Click += btnEditExistingCurrency_Click;
            // 
            // tbDenarValue
            // 
            tbDenarValue.Font = new Font("Segoe UI", 13.9F);
            tbDenarValue.Location = new Point(272, 287);
            tbDenarValue.Name = "tbDenarValue";
            tbDenarValue.Size = new Size(274, 38);
            tbDenarValue.TabIndex = 3;
            tbDenarValue.TextChanged += tbDenarValue_TextChanged;
            // 
            // tbCurrencyValue
            // 
            tbCurrencyValue.Font = new Font("Segoe UI", 13.9F);
            tbCurrencyValue.Location = new Point(272, 379);
            tbCurrencyValue.Name = "tbCurrencyValue";
            tbCurrencyValue.ReadOnly = true;
            tbCurrencyValue.Size = new Size(274, 38);
            tbCurrencyValue.TabIndex = 4;
            // 
            // lblConvertsTo
            // 
            lblConvertsTo.AutoSize = true;
            lblConvertsTo.Location = new Point(272, 341);
            lblConvertsTo.Name = "lblConvertsTo";
            lblConvertsTo.Size = new Size(82, 20);
            lblConvertsTo.TabIndex = 5;
            lblConvertsTo.Text = "converts to";
            // 
            // lblCurrencyName
            // 
            lblCurrencyName.AutoSize = true;
            lblCurrencyName.Font = new Font("Segoe UI", 20F);
            lblCurrencyName.Location = new Point(280, 50);
            lblCurrencyName.Name = "lblCurrencyName";
            lblCurrencyName.Size = new Size(0, 46);
            lblCurrencyName.TabIndex = 6;
            // 
            // lblCurrencyValue
            // 
            lblCurrencyValue.AutoSize = true;
            lblCurrencyValue.Font = new Font("Segoe UI", 20F);
            lblCurrencyValue.Location = new Point(272, 50);
            lblCurrencyValue.Name = "lblCurrencyValue";
            lblCurrencyValue.Size = new Size(0, 46);
            lblCurrencyValue.TabIndex = 7;
            // 
            // lblDenarValue
            // 
            lblDenarValue.AutoSize = true;
            lblDenarValue.Font = new Font("Segoe UI", 20F);
            lblDenarValue.Location = new Point(272, 195);
            lblDenarValue.Name = "lblDenarValue";
            lblDenarValue.Size = new Size(151, 46);
            lblDenarValue.TabIndex = 8;
            lblDenarValue.Text = "0 Denars";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(280, 132);
            label3.Name = "label3";
            label3.Size = new Size(32, 35);
            label3.TabIndex = 9;
            label3.Text = "is";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 453);
            Controls.Add(label3);
            Controls.Add(lblDenarValue);
            Controls.Add(lblCurrencyValue);
            Controls.Add(lblCurrencyName);
            Controls.Add(lblConvertsTo);
            Controls.Add(tbCurrencyValue);
            Controls.Add(tbDenarValue);
            Controls.Add(btnEditExistingCurrency);
            Controls.Add(btnAddNewCurrency);
            Controls.Add(lbCurrencies);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Denar Conversion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbCurrencies;
        private Button btnAddNewCurrency;
        private Button btnEditExistingCurrency;
        private TextBox tbDenarValue;
        private TextBox tbCurrencyValue;
        private Label lblConvertsTo;
        private Label lblCurrencyName;
        private Label lblCurrencyValue;
        private Label lblDenarValue;
        private Label label3;
    }
}
