namespace DenarConversion
{
    partial class AddNewCurrency
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewCurrency));
            tbName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            tbValue = new TextBox();
            btnOk = new Button();
            btnCancel = new Button();
            errorProvider1 = new ErrorProvider(components);
            errorProvider2 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).BeginInit();
            SuspendLayout();
            // 
            // tbName
            // 
            tbName.Location = new Point(48, 56);
            tbName.Name = "tbName";
            tbName.Size = new Size(280, 27);
            tbName.TabIndex = 0;
            tbName.Validating += tbName_Validating;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 33);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 1;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 98);
            label2.Name = "label2";
            label2.Size = new Size(48, 20);
            label2.TabIndex = 3;
            label2.Text = "Value:";
            // 
            // tbValue
            // 
            tbValue.Location = new Point(48, 121);
            tbValue.Name = "tbValue";
            tbValue.Size = new Size(280, 27);
            tbValue.TabIndex = 2;
            tbValue.Validating += tbValue_Validating;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(48, 178);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(134, 42);
            btnOk.TabIndex = 4;
            btnOk.Text = "OK";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(194, 178);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(134, 42);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            errorProvider2.ContainerControl = this;
            // 
            // AddNewCurrency
            // 
            AcceptButton = btnOk;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(382, 253);
            Controls.Add(btnCancel);
            Controls.Add(btnOk);
            Controls.Add(label2);
            Controls.Add(tbValue);
            Controls.Add(label1);
            Controls.Add(tbName);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddNewCurrency";
            Text = "Add New Currency";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbName;
        private Label label1;
        private Label label2;
        private TextBox tbValue;
        private Button btnOk;
        private Button btnCancel;
        private ErrorProvider errorProvider1;
        private ErrorProvider errorProvider2;
    }
}