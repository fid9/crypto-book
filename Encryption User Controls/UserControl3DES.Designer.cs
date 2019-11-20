namespace CryptoAPIApp
{
    partial class UserControl3DES
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl3DES));
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxkey2 = new System.Windows.Forms.TextBox();
            this.textboxkey = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.textboxdecrypted = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textboxencrypted = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textboxplaintext = new System.Windows.Forms.TextBox();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.textBoxkey2);
            this.panel1.Controls.Add(this.textboxkey);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.btnDecrypt);
            this.panel1.Controls.Add(this.textboxdecrypted);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.textboxencrypted);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.textboxplaintext);
            this.panel1.Controls.Add(this.btnEncrypt);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(602, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(415, 520);
            this.panel1.TabIndex = 31;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Crimson;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(415, 5);
            this.panel2.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Corbel", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.label9.Location = new System.Drawing.Point(17, 315);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 21);
            this.label9.TabIndex = 17;
            this.label9.Text = "Enter the key:";
            // 
            // textBoxkey2
            // 
            this.textBoxkey2.Location = new System.Drawing.Point(21, 339);
            this.textBoxkey2.Name = "textBoxkey2";
            this.textBoxkey2.Size = new System.Drawing.Size(377, 20);
            this.textBoxkey2.TabIndex = 16;
            // 
            // textboxkey
            // 
            this.textboxkey.Location = new System.Drawing.Point(21, 46);
            this.textboxkey.Name = "textboxkey";
            this.textboxkey.Size = new System.Drawing.Size(377, 20);
            this.textboxkey.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Corbel", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.label8.Location = new System.Drawing.Point(17, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 21);
            this.label8.TabIndex = 14;
            this.label8.Text = "Enter the key:";
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.BackColor = System.Drawing.Color.IndianRed;
            this.btnDecrypt.FlatAppearance.BorderSize = 0;
            this.btnDecrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDecrypt.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecrypt.ForeColor = System.Drawing.Color.White;
            this.btnDecrypt.Location = new System.Drawing.Point(21, 362);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(377, 41);
            this.btnDecrypt.TabIndex = 13;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = false;
            this.btnDecrypt.Click += new System.EventHandler(this.BtnDecrypt_Click);
            // 
            // textboxdecrypted
            // 
            this.textboxdecrypted.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxdecrypted.Location = new System.Drawing.Point(21, 440);
            this.textboxdecrypted.Multiline = true;
            this.textboxdecrypted.Name = "textboxdecrypted";
            this.textboxdecrypted.Size = new System.Drawing.Size(377, 59);
            this.textboxdecrypted.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Corbel", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.label7.Location = new System.Drawing.Point(17, 416);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 21);
            this.label7.TabIndex = 11;
            this.label7.Text = "Decrypted value:";
            // 
            // textboxencrypted
            // 
            this.textboxencrypted.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxencrypted.Location = new System.Drawing.Point(21, 247);
            this.textboxencrypted.Multiline = true;
            this.textboxencrypted.Name = "textboxencrypted";
            this.textboxencrypted.Size = new System.Drawing.Size(377, 59);
            this.textboxencrypted.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Corbel", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.label6.Location = new System.Drawing.Point(17, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 21);
            this.label6.TabIndex = 9;
            this.label6.Text = "Encrypted value:";
            // 
            // textboxplaintext
            // 
            this.textboxplaintext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxplaintext.Location = new System.Drawing.Point(21, 100);
            this.textboxplaintext.Multiline = true;
            this.textboxplaintext.Name = "textboxplaintext";
            this.textboxplaintext.Size = new System.Drawing.Size(377, 59);
            this.textboxplaintext.TabIndex = 8;
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.BackColor = System.Drawing.Color.IndianRed;
            this.btnEncrypt.FlatAppearance.BorderSize = 0;
            this.btnEncrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEncrypt.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncrypt.ForeColor = System.Drawing.Color.White;
            this.btnEncrypt.Location = new System.Drawing.Point(21, 164);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(377, 41);
            this.btnEncrypt.TabIndex = 1;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = false;
            this.btnEncrypt.Click += new System.EventHandler(this.BtnEncrypt_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Corbel", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.label5.Location = new System.Drawing.Point(17, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "Enter the string value:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(146, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(347, 26);
            this.label2.TabIndex = 28;
            this.label2.Text = "Triple Data Encryption Standard (3DES)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.label3.Location = new System.Drawing.Point(72, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(465, 378);
            this.label3.TabIndex = 27;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.label10.Location = new System.Drawing.Point(599, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(208, 19);
            this.label10.TabIndex = 32;
            this.label10.Text = "Test the algorithm below:";
            // 
            // backButton
            // 
            this.backButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backButton.FlatAppearance.BorderSize = 0;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Image = ((System.Drawing.Image)(resources.GetObject("backButton.Image")));
            this.backButton.Location = new System.Drawing.Point(0, 0);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(61, 56);
            this.backButton.TabIndex = 33;
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // UserControl3DES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Name = "UserControl3DES";
            this.Size = new System.Drawing.Size(1045, 595);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.TextBox textboxdecrypted;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textboxencrypted;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textboxplaintext;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textboxkey;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxkey2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button backButton;
    }
}
