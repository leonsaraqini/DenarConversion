namespace DesignPartOnlyTest
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditCurrencyList));
            this.lbCurrencies = new System.Windows.Forms.ListBox();
            this.btnEnterNewCurrency = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNewValue = new System.Windows.Forms.TextBox();
            this.btnRemoveCurrency = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbCurrencies
            // 
            this.lbCurrencies.FormattingEnabled = true;
            this.lbCurrencies.ItemHeight = 16;
            this.lbCurrencies.Location = new System.Drawing.Point(56, 42);
            this.lbCurrencies.Name = "lbCurrencies";
            this.lbCurrencies.Size = new System.Drawing.Size(160, 228);
            this.lbCurrencies.TabIndex = 0;
            // 
            // btnEnterNewCurrency
            // 
            this.btnEnterNewCurrency.Location = new System.Drawing.Point(241, 89);
            this.btnEnterNewCurrency.Name = "btnEnterNewCurrency";
            this.btnEnterNewCurrency.Size = new System.Drawing.Size(192, 37);
            this.btnEnterNewCurrency.TabIndex = 1;
            this.btnEnterNewCurrency.Text = "Enter";
            this.btnEnterNewCurrency.UseVisualStyleBackColor = true;
            this.btnEnterNewCurrency.Click += new System.EventHandler(this.btnEnterNewCurrency_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(240, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter value of existing currency:";
            // 
            // tbNewValue
            // 
            this.tbNewValue.Location = new System.Drawing.Point(241, 61);
            this.tbNewValue.Name = "tbNewValue";
            this.tbNewValue.Size = new System.Drawing.Size(192, 22);
            this.tbNewValue.TabIndex = 4;
            this.tbNewValue.Validating += new System.ComponentModel.CancelEventHandler(this.tbNewValue_Validating);
            // 
            // btnRemoveCurrency
            // 
            this.btnRemoveCurrency.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnRemoveCurrency.Location = new System.Drawing.Point(243, 231);
            this.btnRemoveCurrency.Name = "btnRemoveCurrency";
            this.btnRemoveCurrency.Size = new System.Drawing.Size(190, 39);
            this.btnRemoveCurrency.TabIndex = 6;
            this.btnRemoveCurrency.Text = "Remove currency";
            this.btnRemoveCurrency.UseVisualStyleBackColor = true;
            this.btnRemoveCurrency.Click += new System.EventHandler(this.btnRemoveCurrency_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // EditCurrencyList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 324);
            this.Controls.Add(this.btnRemoveCurrency);
            this.Controls.Add(this.tbNewValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEnterNewCurrency);
            this.Controls.Add(this.lbCurrencies);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditCurrencyList";
            this.Text = "Edit Currency List";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbCurrencies;
        private System.Windows.Forms.Button btnEnterNewCurrency;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNewValue;
        private System.Windows.Forms.Button btnRemoveCurrency;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}