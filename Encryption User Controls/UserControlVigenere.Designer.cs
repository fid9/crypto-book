namespace CryptoAPIApp
{
    partial class UserControlVigenere
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlVigenere));
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textboxkey = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textboxdecrypted = new System.Windows.Forms.TextBox();
            this.textboxencrypted = new System.Windows.Forms.TextBox();
            this.textboxplaintext = new System.Windows.Forms.TextBox();
            this.textboxmessage = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnHash = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.label3.Location = new System.Drawing.Point(78, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(499, 273);
            this.label3.TabIndex = 38;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.textboxkey);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textboxdecrypted);
            this.panel1.Controls.Add(this.textboxencrypted);
            this.panel1.Controls.Add(this.textboxplaintext);
            this.panel1.Controls.Add(this.textboxmessage);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnHash);
            this.panel1.Location = new System.Drawing.Point(604, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(415, 498);
            this.panel1.TabIndex = 40;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Crimson;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(415, 3);
            this.panel2.TabIndex = 35;
            // 
            // textboxkey
            // 
            this.textboxkey.AutoSize = true;
            this.textboxkey.Font = new System.Drawing.Font("Corbel", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxkey.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.textboxkey.Location = new System.Drawing.Point(19, 118);
            this.textboxkey.Name = "textboxkey";
            this.textboxkey.Size = new System.Drawing.Size(44, 21);
            this.textboxkey.TabIndex = 20;
            this.textboxkey.Text = "Key:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(23, 143);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(377, 20);
            this.textBox1.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.label1.Location = new System.Drawing.Point(19, 375);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 21);
            this.label1.TabIndex = 16;
            this.label1.Text = "Decrypted data:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.IndianRed;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(23, 325);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(377, 46);
            this.button1.TabIndex = 13;
            this.button1.Text = "Decrypt";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // textboxdecrypted
            // 
            this.textboxdecrypted.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxdecrypted.Location = new System.Drawing.Point(23, 400);
            this.textboxdecrypted.Multiline = true;
            this.textboxdecrypted.Name = "textboxdecrypted";
            this.textboxdecrypted.Size = new System.Drawing.Size(377, 79);
            this.textboxdecrypted.TabIndex = 15;
            // 
            // textboxencrypted
            // 
            this.textboxencrypted.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxencrypted.Location = new System.Drawing.Point(23, 242);
            this.textboxencrypted.Multiline = true;
            this.textboxencrypted.Name = "textboxencrypted";
            this.textboxencrypted.Size = new System.Drawing.Size(377, 79);
            this.textboxencrypted.TabIndex = 14;
            // 
            // textboxplaintext
            // 
            this.textboxplaintext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxplaintext.Location = new System.Drawing.Point(23, 35);
            this.textboxplaintext.Multiline = true;
            this.textboxplaintext.Name = "textboxplaintext";
            this.textboxplaintext.Size = new System.Drawing.Size(377, 79);
            this.textboxplaintext.TabIndex = 12;
            // 
            // textboxmessage
            // 
            this.textboxmessage.AutoSize = true;
            this.textboxmessage.Font = new System.Drawing.Font("Corbel", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxmessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.textboxmessage.Location = new System.Drawing.Point(19, 10);
            this.textboxmessage.Name = "textboxmessage";
            this.textboxmessage.Size = new System.Drawing.Size(152, 21);
            this.textboxmessage.TabIndex = 11;
            this.textboxmessage.Text = "Enter the message:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Corbel", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.label6.Location = new System.Drawing.Point(19, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 21);
            this.label6.TabIndex = 9;
            this.label6.Text = "Encrypted data:";
            // 
            // btnHash
            // 
            this.btnHash.BackColor = System.Drawing.Color.IndianRed;
            this.btnHash.FlatAppearance.BorderSize = 0;
            this.btnHash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHash.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHash.ForeColor = System.Drawing.Color.White;
            this.btnHash.Location = new System.Drawing.Point(23, 167);
            this.btnHash.Name = "btnHash";
            this.btnHash.Size = new System.Drawing.Size(377, 46);
            this.btnHash.TabIndex = 1;
            this.btnHash.Text = "Encrypt";
            this.btnHash.UseVisualStyleBackColor = false;
            this.btnHash.Click += new System.EventHandler(this.BtnHash_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(219, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 26);
            this.label2.TabIndex = 39;
            this.label2.Text = "Vigenere Cipher";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.label9.Location = new System.Drawing.Point(600, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(208, 19);
            this.label9.TabIndex = 45;
            this.label9.Text = "Test the algorithm below:";
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
            this.backButton.TabIndex = 46;
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(139, 366);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(344, 222);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            // 
            // UserControlVigenere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Name = "UserControlVigenere";
            this.Size = new System.Drawing.Size(1045, 595);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textboxdecrypted;
        private System.Windows.Forms.TextBox textboxencrypted;
        private System.Windows.Forms.TextBox textboxplaintext;
        private System.Windows.Forms.Label textboxmessage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnHash;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label textboxkey;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
