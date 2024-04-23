namespace DesignPartOnlyTest
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblCurrency = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDenar = new System.Windows.Forms.Label();
            this.tbnChangeExistingCurrency = new System.Windows.Forms.Button();
            this.btnAddNewCurrency = new System.Windows.Forms.Button();
            this.tbDenarValue = new System.Windows.Forms.TextBox();
            this.tbCurrencyValue = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbCurrencies = new System.Windows.Forms.ListBox();
            
            this.currencyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            
            ((System.ComponentModel.ISupportInitialize)(this.currencyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCurrency
            // 
            this.lblCurrency.AutoSize = true;
            this.lblCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrency.Location = new System.Drawing.Point(267, 74);
            this.lblCurrency.Name = "lblCurrency";
            this.lblCurrency.Size = new System.Drawing.Size(0, 39);
            this.lblCurrency.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(268, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 33);
            this.label2.TabIndex = 2;
            this.label2.Text = "is";
            // 
            // lblDenar
            // 
            this.lblDenar.AutoSize = true;
            this.lblDenar.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDenar.Location = new System.Drawing.Point(267, 199);
            this.lblDenar.Name = "lblDenar";
            this.lblDenar.Size = new System.Drawing.Size(139, 39);
            this.lblDenar.TabIndex = 3;
            this.lblDenar.Text = "0 Denar";
            // 
            // tbnChangeExistingCurrency
            // 
            this.tbnChangeExistingCurrency.Location = new System.Drawing.Point(53, 365);
            this.tbnChangeExistingCurrency.Name = "tbnChangeExistingCurrency";
            this.tbnChangeExistingCurrency.Size = new System.Drawing.Size(189, 36);
            this.tbnChangeExistingCurrency.TabIndex = 5;
            this.tbnChangeExistingCurrency.Text = "Edit Existing Currency";
            this.tbnChangeExistingCurrency.UseVisualStyleBackColor = true;
            this.tbnChangeExistingCurrency.Click += new System.EventHandler(this.tbnChangeExistingCurrency_Click);
            // 
            // btnAddNewCurrency
            // 
            this.btnAddNewCurrency.Location = new System.Drawing.Point(53, 323);
            this.btnAddNewCurrency.Name = "btnAddNewCurrency";
            this.btnAddNewCurrency.Size = new System.Drawing.Size(189, 36);
            this.btnAddNewCurrency.TabIndex = 6;
            this.btnAddNewCurrency.Text = "Add New Currency";
            this.btnAddNewCurrency.UseVisualStyleBackColor = true;
            this.btnAddNewCurrency.Click += new System.EventHandler(this.btnAddNewCurrency_Click);
            // 
            // tbDenarValue
            // 
            this.tbDenarValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDenarValue.Location = new System.Drawing.Point(274, 285);
            this.tbDenarValue.Name = "tbDenarValue";
            this.tbDenarValue.Size = new System.Drawing.Size(256, 32);
            this.tbDenarValue.TabIndex = 7;
            this.tbDenarValue.TextChanged += new System.EventHandler(this.tbDenarValue_TextChanged);
            this.tbDenarValue.Validating += new System.ComponentModel.CancelEventHandler(this.tbDenarValue_Validating);
            // 
            // tbCurrencyValue
            // 
            this.tbCurrencyValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCurrencyValue.Location = new System.Drawing.Point(274, 369);
            this.tbCurrencyValue.Name = "tbCurrencyValue";
            this.tbCurrencyValue.ReadOnly = true;
            this.tbCurrencyValue.Size = new System.Drawing.Size(256, 32);
            this.tbCurrencyValue.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(278, 337);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "converts to";
            // 
            // lbCurrencies
            // 
            this.lbCurrencies.FormattingEnabled = true;
            this.lbCurrencies.ItemHeight = 16;
            this.lbCurrencies.Location = new System.Drawing.Point(53, 25);
            this.lbCurrencies.Name = "lbCurrencies";
            this.lbCurrencies.Size = new System.Drawing.Size(189, 292);
            this.lbCurrencies.TabIndex = 11;
            this.lbCurrencies.SelectedIndexChanged += new System.EventHandler(this.lbCurrencies_SelectedIndexChanged);
            this.lbCurrencies.Validating += new System.ComponentModel.CancelEventHandler(this.lbCurrencies_Validating);
            // 
            // currencyDataSet
            // 
            
            // 
            // currencyBindingSource
            // 
            
            // 
            // currencyTableAdapter
            // 
            
            // 
            // tableAdapterManager
            // 
            
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 450);
            this.Controls.Add(this.lbCurrencies);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbCurrencyValue);
            this.Controls.Add(this.tbDenarValue);
            this.Controls.Add(this.btnAddNewCurrency);
            this.Controls.Add(this.tbnChangeExistingCurrency);
            this.Controls.Add(this.lblDenar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCurrency);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Denar Conversion";

            ((System.ComponentModel.ISupportInitialize)(this.currencyBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCurrency;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDenar;
        private System.Windows.Forms.Button tbnChangeExistingCurrency;
        private System.Windows.Forms.Button btnAddNewCurrency;
        private System.Windows.Forms.TextBox tbDenarValue;
        private System.Windows.Forms.TextBox tbCurrencyValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lbCurrencies;
        
        private System.Windows.Forms.BindingSource currencyBindingSource;
        
    }
}

