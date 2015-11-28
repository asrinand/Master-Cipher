namespace TripleCipher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonEncrypt = new System.Windows.Forms.Button();
            this.buttonDecrypt = new System.Windows.Forms.Button();
            this.txtClearText = new System.Windows.Forms.TextBox();
            this.txtCipherText = new System.Windows.Forms.TextBox();
            this.labelTemp1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButtonEncrypt = new System.Windows.Forms.RadioButton();
            this.radioButtonDecrypt = new System.Windows.Forms.RadioButton();
            this.buttonClear = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonEncrypt
            // 
            this.buttonEncrypt.BackColor = System.Drawing.Color.Black;
            this.buttonEncrypt.Font = new System.Drawing.Font("Courier New", 14.25F);
            this.buttonEncrypt.ForeColor = System.Drawing.Color.White;
            this.buttonEncrypt.Location = new System.Drawing.Point(26, 230);
            this.buttonEncrypt.Name = "buttonEncrypt";
            this.buttonEncrypt.Size = new System.Drawing.Size(96, 35);
            this.buttonEncrypt.TabIndex = 13;
            this.buttonEncrypt.Text = "Encrypt";
            this.buttonEncrypt.UseVisualStyleBackColor = false;
            this.buttonEncrypt.Click += new System.EventHandler(this.buttonEncrypt_Click);
            // 
            // buttonDecrypt
            // 
            this.buttonDecrypt.BackColor = System.Drawing.Color.Black;
            this.buttonDecrypt.Font = new System.Drawing.Font("Courier New", 14.25F);
            this.buttonDecrypt.ForeColor = System.Drawing.Color.White;
            this.buttonDecrypt.Location = new System.Drawing.Point(26, 230);
            this.buttonDecrypt.Name = "buttonDecrypt";
            this.buttonDecrypt.Size = new System.Drawing.Size(96, 35);
            this.buttonDecrypt.TabIndex = 12;
            this.buttonDecrypt.Text = "Decrypt";
            this.buttonDecrypt.UseVisualStyleBackColor = false;
            this.buttonDecrypt.Click += new System.EventHandler(this.buttonDecrypt_Click);
            // 
            // txtClearText
            // 
            this.txtClearText.BackColor = System.Drawing.Color.Black;
            this.txtClearText.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClearText.ForeColor = System.Drawing.Color.White;
            this.txtClearText.Location = new System.Drawing.Point(26, 178);
            this.txtClearText.Name = "txtClearText";
            this.txtClearText.Size = new System.Drawing.Size(765, 22);
            this.txtClearText.TabIndex = 1;
            this.txtClearText.DoubleClick += new System.EventHandler(this.txtClearText_DoubleClick);
            // 
            // txtCipherText
            // 
            this.txtCipherText.BackColor = System.Drawing.Color.Black;
            this.txtCipherText.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtCipherText.ForeColor = System.Drawing.Color.White;
            this.txtCipherText.Location = new System.Drawing.Point(26, 317);
            this.txtCipherText.Name = "txtCipherText";
            this.txtCipherText.Size = new System.Drawing.Size(765, 22);
            this.txtCipherText.TabIndex = 3;
            this.txtCipherText.DoubleClick += new System.EventHandler(this.txtCipherText_DoubleClick);
            // 
            // labelTemp1
            // 
            this.labelTemp1.AutoSize = true;
            this.labelTemp1.Enabled = false;
            this.labelTemp1.Location = new System.Drawing.Point(23, 357);
            this.labelTemp1.Name = "labelTemp1";
            this.labelTemp1.Size = new System.Drawing.Size(0, 13);
            this.labelTemp1.TabIndex = 6;
            this.labelTemp1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 14.25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(22, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Enter Plain Text -";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(22, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Encrypted Text -";
            // 
            // radioButtonEncrypt
            // 
            this.radioButtonEncrypt.AutoSize = true;
            this.radioButtonEncrypt.Font = new System.Drawing.Font("Courier New", 14.25F);
            this.radioButtonEncrypt.ForeColor = System.Drawing.Color.White;
            this.radioButtonEncrypt.Location = new System.Drawing.Point(26, 100);
            this.radioButtonEncrypt.Name = "radioButtonEncrypt";
            this.radioButtonEncrypt.Size = new System.Drawing.Size(138, 25);
            this.radioButtonEncrypt.TabIndex = 9;
            this.radioButtonEncrypt.TabStop = true;
            this.radioButtonEncrypt.Text = "Encryption";
            this.radioButtonEncrypt.UseVisualStyleBackColor = true;
            this.radioButtonEncrypt.CheckedChanged += new System.EventHandler(this.radioButtonEncrypt_CheckedChanged);
            // 
            // radioButtonDecrypt
            // 
            this.radioButtonDecrypt.AutoSize = true;
            this.radioButtonDecrypt.Font = new System.Drawing.Font("Courier New", 14.25F);
            this.radioButtonDecrypt.ForeColor = System.Drawing.Color.White;
            this.radioButtonDecrypt.Location = new System.Drawing.Point(258, 100);
            this.radioButtonDecrypt.Name = "radioButtonDecrypt";
            this.radioButtonDecrypt.Size = new System.Drawing.Size(138, 25);
            this.radioButtonDecrypt.TabIndex = 10;
            this.radioButtonDecrypt.TabStop = true;
            this.radioButtonDecrypt.Text = "Decryption";
            this.radioButtonDecrypt.UseVisualStyleBackColor = true;
            this.radioButtonDecrypt.CheckedChanged += new System.EventHandler(this.radioButtonDecrypt_CheckedChanged);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.Black;
            this.buttonClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonClear.Font = new System.Drawing.Font("Courier New", 14.25F);
            this.buttonClear.ForeColor = System.Drawing.Color.White;
            this.buttonClear.Location = new System.Drawing.Point(197, 230);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 35);
            this.buttonClear.TabIndex = 11;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(26, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(780, 50);
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(818, 401);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.radioButtonDecrypt);
            this.Controls.Add(this.radioButtonEncrypt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelTemp1);
            this.Controls.Add(this.txtCipherText);
            this.Controls.Add(this.txtClearText);
            this.Controls.Add(this.buttonDecrypt);
            this.Controls.Add(this.buttonEncrypt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Master Cipher";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEncrypt;
        private System.Windows.Forms.Button buttonDecrypt;
        private System.Windows.Forms.TextBox txtClearText;
        private System.Windows.Forms.TextBox txtCipherText;
        private System.Windows.Forms.Label labelTemp1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButtonEncrypt;
        private System.Windows.Forms.RadioButton radioButtonDecrypt;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

