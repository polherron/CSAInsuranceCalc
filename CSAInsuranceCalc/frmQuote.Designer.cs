namespace CSAInsuranceCalc
{
    partial class frmQuote
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
            this.btnGetQuote = new System.Windows.Forms.Button();
            this.cbStates = new System.Windows.Forms.ComboBox();
            this.dtPicker = new System.Windows.Forms.DateTimePicker();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.blbQuote = new System.Windows.Forms.Label();
            this.lnlDiscount = new System.Windows.Forms.Label();
            this.txtPremium = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnGetQuote
            // 
            this.btnGetQuote.Location = new System.Drawing.Point(476, 65);
            this.btnGetQuote.Name = "btnGetQuote";
            this.btnGetQuote.Size = new System.Drawing.Size(143, 50);
            this.btnGetQuote.TabIndex = 1;
            this.btnGetQuote.Text = "Get Quote";
            this.btnGetQuote.UseVisualStyleBackColor = true;
            this.btnGetQuote.Click += new System.EventHandler(this.btnQuote_Click);
            // 
            // cbStates
            // 
            this.cbStates.FormattingEnabled = true;
            this.cbStates.Location = new System.Drawing.Point(191, 246);
            this.cbStates.Name = "cbStates";
            this.cbStates.Size = new System.Drawing.Size(213, 24);
            this.cbStates.TabIndex = 3;
            // 
            // dtPicker
            // 
            this.dtPicker.Location = new System.Drawing.Point(191, 297);
            this.dtPicker.Name = "dtPicker";
            this.dtPicker.Size = new System.Drawing.Size(213, 22);
            this.dtPicker.TabIndex = 4;
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(191, 60);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(100, 22);
            this.txtCustomerID.TabIndex = 5;
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(191, 108);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(171, 22);
            this.txtFName.TabIndex = 6;
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(191, 154);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(171, 22);
            this.txtLName.TabIndex = 7;
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(94, 65);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(85, 17);
            this.lblNumber.TabIndex = 8;
            this.lblNumber.Text = "Customer ID";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(94, 113);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(76, 17);
            this.lblFirstName.TabIndex = 9;
            this.lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(94, 157);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(76, 17);
            this.lblLastName.TabIndex = 10;
            this.lblLastName.Text = "Last Name";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(94, 249);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(41, 17);
            this.lblState.TabIndex = 11;
            this.lblState.Text = "State";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Location = new System.Drawing.Point(94, 302);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(38, 17);
            this.lblDOB.TabIndex = 12;
            this.lblDOB.Text = "DOB";
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(396, 385);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(100, 22);
            this.txtDiscount.TabIndex = 13;
            // 
            // blbQuote
            // 
            this.blbQuote.AutoSize = true;
            this.blbQuote.Location = new System.Drawing.Point(188, 365);
            this.blbQuote.Name = "blbQuote";
            this.blbQuote.Size = new System.Drawing.Size(63, 17);
            this.blbQuote.TabIndex = 14;
            this.blbQuote.Text = "Premium";
            // 
            // lnlDiscount
            // 
            this.lnlDiscount.AutoSize = true;
            this.lnlDiscount.Location = new System.Drawing.Point(393, 365);
            this.lnlDiscount.Name = "lnlDiscount";
            this.lnlDiscount.Size = new System.Drawing.Size(79, 17);
            this.lnlDiscount.TabIndex = 16;
            this.lnlDiscount.Text = "Discount %";
            // 
            // txtPremium
            // 
            this.txtPremium.Location = new System.Drawing.Point(191, 385);
            this.txtPremium.Name = "txtPremium";
            this.txtPremium.Size = new System.Drawing.Size(100, 22);
            this.txtPremium.TabIndex = 15;
            // 
            // frmQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 496);
            this.Controls.Add(this.lnlDiscount);
            this.Controls.Add(this.txtPremium);
            this.Controls.Add(this.blbQuote);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.lblDOB);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.txtLName);
            this.Controls.Add(this.txtFName);
            this.Controls.Add(this.txtCustomerID);
            this.Controls.Add(this.dtPicker);
            this.Controls.Add(this.cbStates);
            this.Controls.Add(this.btnGetQuote);
            this.Name = "frmQuote";
            this.Text = "Insurance Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnGetQuote;
        private System.Windows.Forms.ComboBox cbStates;
        private System.Windows.Forms.DateTimePicker dtPicker;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label blbQuote;
        private System.Windows.Forms.Label lnlDiscount;
        private System.Windows.Forms.TextBox txtPremium;
    }
}

