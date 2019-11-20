namespace CryptoAPIApp
{
    partial class UserControlRSAS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlRSAS));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnVerify = new System.Windows.Forms.Button();
            this.textboxsigned = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textboxplaintext = new System.Windows.Forms.TextBox();
            this.btnSign = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label8 = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.btnVerify);
            this.panel1.Controls.Add(this.textboxsigned);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.textboxplaintext);
            this.panel1.Controls.Add(this.btnSign);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(604, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(415, 498);
            this.panel1.TabIndex = 27;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Crimson;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(415, 3);
            this.panel5.TabIndex = 33;
            // 
            // btnVerify
            // 
            this.btnVerify.BackColor = System.Drawing.Color.IndianRed;
            this.btnVerify.FlatAppearance.BorderSize = 0;
            this.btnVerify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerify.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerify.ForeColor = System.Drawing.Color.White;
            this.btnVerify.Location = new System.Drawing.Point(21, 430);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(377, 49);
            this.btnVerify.TabIndex = 13;
            this.btnVerify.Text = "Verify";
            this.btnVerify.UseVisualStyleBackColor = false;
            this.btnVerify.Click += new System.EventHandler(this.BtnDecrypt_Click);
            // 
            // textboxsigned
            // 
            this.textboxsigned.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxsigned.Location = new System.Drawing.Point(21, 219);
            this.textboxsigned.Multiline = true;
            this.textboxsigned.Name = "textboxsigned";
            this.textboxsigned.Size = new System.Drawing.Size(377, 205);
            this.textboxsigned.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Corbel", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.label6.Location = new System.Drawing.Point(17, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 21);
            this.label6.TabIndex = 9;
            this.label6.Text = "Signed string:";
            // 
            // textboxplaintext
            // 
            this.textboxplaintext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxplaintext.Location = new System.Drawing.Point(21, 53);
            this.textboxplaintext.Multiline = true;
            this.textboxplaintext.Name = "textboxplaintext";
            this.textboxplaintext.Size = new System.Drawing.Size(377, 63);
            this.textboxplaintext.TabIndex = 8;
            // 
            // btnSign
            // 
            this.btnSign.BackColor = System.Drawing.Color.IndianRed;
            this.btnSign.FlatAppearance.BorderSize = 0;
            this.btnSign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSign.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSign.ForeColor = System.Drawing.Color.White;
            this.btnSign.Location = new System.Drawing.Point(21, 127);
            this.btnSign.Name = "btnSign";
            this.btnSign.Size = new System.Drawing.Size(377, 49);
            this.btnSign.TabIndex = 1;
            this.btnSign.Text = "Sign";
            this.btnSign.UseVisualStyleBackColor = false;
            this.btnSign.Click += new System.EventHandler(this.BtnEncrypt_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Corbel", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.label5.Location = new System.Drawing.Point(17, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "Enter the string to sign:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(210, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 26);
            this.label2.TabIndex = 24;
            this.label2.Text = "RSA Signature";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.label3.Location = new System.Drawing.Point(60, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(514, 147);
            this.label3.TabIndex = 23;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Corbel", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.label8.Location = new System.Drawing.Point(600, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(198, 21);
            this.label8.TabIndex = 22;
            this.label8.Text = "Test the algorithm below:";
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
            this.backButton.TabIndex = 35;
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(40, 290);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(534, 260);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // UserControlRSAS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Name = "UserControlRSAS";
            this.Size = new System.Drawing.Size(1045, 595);

            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnVerify;
        private System.Windows.Forms.TextBox textboxsigned;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textboxplaintext;
        private System.Windows.Forms.Button btnSign;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
