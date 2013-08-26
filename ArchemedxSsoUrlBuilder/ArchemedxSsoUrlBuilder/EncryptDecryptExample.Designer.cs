namespace ArchemedxSsoUrlBuilder
{
    partial class EncryptDecryptExample
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
            this.txtStringToEncrypt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEncryptedString = new System.Windows.Forms.Label();
            this.txtEncryptedString = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDecryptedString = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSecretKey = new System.Windows.Forms.TextBox();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.pnlEncrypted = new System.Windows.Forms.Panel();
            this.pnlDecrypted = new System.Windows.Forms.Panel();
            this.pnlEncrypted.SuspendLayout();
            this.pnlDecrypted.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtStringToEncrypt
            // 
            this.txtStringToEncrypt.Location = new System.Drawing.Point(149, 61);
            this.txtStringToEncrypt.Name = "txtStringToEncrypt";
            this.txtStringToEncrypt.Size = new System.Drawing.Size(171, 20);
            this.txtStringToEncrypt.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "String to Encrypt:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEncryptedString
            // 
            this.lblEncryptedString.AutoSize = true;
            this.lblEncryptedString.Location = new System.Drawing.Point(10, 7);
            this.lblEncryptedString.Name = "lblEncryptedString";
            this.lblEncryptedString.Size = new System.Drawing.Size(88, 13);
            this.lblEncryptedString.TabIndex = 3;
            this.lblEncryptedString.Text = "Encrypted String:";
            this.lblEncryptedString.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtEncryptedString
            // 
            this.txtEncryptedString.Location = new System.Drawing.Point(107, 3);
            this.txtEncryptedString.Name = "txtEncryptedString";
            this.txtEncryptedString.ReadOnly = true;
            this.txtEncryptedString.Size = new System.Drawing.Size(171, 20);
            this.txtEncryptedString.TabIndex = 0;
            this.txtEncryptedString.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Decrypted String:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDecryptedString
            // 
            this.txtDecryptedString.Location = new System.Drawing.Point(105, 6);
            this.txtDecryptedString.Name = "txtDecryptedString";
            this.txtDecryptedString.ReadOnly = true;
            this.txtDecryptedString.Size = new System.Drawing.Size(171, 20);
            this.txtDecryptedString.TabIndex = 0;
            this.txtDecryptedString.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Secret Key:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSecretKey
            // 
            this.txtSecretKey.Location = new System.Drawing.Point(149, 25);
            this.txtSecretKey.Name = "txtSecretKey";
            this.txtSecretKey.Size = new System.Drawing.Size(171, 20);
            this.txtSecretKey.TabIndex = 10;
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(344, 60);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(75, 23);
            this.btnEncrypt.TabIndex = 30;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(302, 2);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(75, 23);
            this.btnDecrypt.TabIndex = 40;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // pnlEncrypted
            // 
            this.pnlEncrypted.Controls.Add(this.txtEncryptedString);
            this.pnlEncrypted.Controls.Add(this.btnDecrypt);
            this.pnlEncrypted.Controls.Add(this.lblEncryptedString);
            this.pnlEncrypted.Location = new System.Drawing.Point(42, 95);
            this.pnlEncrypted.Name = "pnlEncrypted";
            this.pnlEncrypted.Size = new System.Drawing.Size(390, 32);
            this.pnlEncrypted.TabIndex = 10;
            // 
            // pnlDecrypted
            // 
            this.pnlDecrypted.Controls.Add(this.label2);
            this.pnlDecrypted.Controls.Add(this.txtDecryptedString);
            this.pnlDecrypted.Location = new System.Drawing.Point(42, 133);
            this.pnlDecrypted.Name = "pnlDecrypted";
            this.pnlDecrypted.Size = new System.Drawing.Size(390, 32);
            this.pnlDecrypted.TabIndex = 11;
            // 
            // EncryptDecryptExample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 401);
            this.Controls.Add(this.pnlDecrypted);
            this.Controls.Add(this.pnlEncrypted);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSecretKey);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtStringToEncrypt);
            this.Name = "EncryptDecryptExample";
            this.Text = "Encrypt/Decrypt Example";
            this.Load += new System.EventHandler(this.EncryptionTester_Load);
            this.pnlEncrypted.ResumeLayout(false);
            this.pnlEncrypted.PerformLayout();
            this.pnlDecrypted.ResumeLayout(false);
            this.pnlDecrypted.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtStringToEncrypt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEncryptedString;
        private System.Windows.Forms.TextBox txtEncryptedString;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDecryptedString;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSecretKey;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Panel pnlEncrypted;
        private System.Windows.Forms.Panel pnlDecrypted;
    }
}