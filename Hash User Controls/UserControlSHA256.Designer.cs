namespace CryptoAPIApp
{
    partial class UserControlSHA256
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlSHA256));
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textboxmessage = new System.Windows.Forms.Label();
            this.textboxhashed = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textboxkey = new System.Windows.Forms.TextBox();
            this.btnHash = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.label3.Location = new System.Drawing.Point(72, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(415, 231);
            this.label3.TabIndex = 38;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.textboxmessage);
            this.panel1.Controls.Add(this.textboxhashed);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.textboxkey);
            this.panel1.Controls.Add(this.btnHash);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(603, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(415, 496);
            this.panel1.TabIndex = 40;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Crimson;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(415, 2);
            this.panel2.TabIndex = 14;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(23, 45);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(377, 150);
            this.textBox1.TabIndex = 12;
            // 
            // textboxmessage
            // 
            this.textboxmessage.AutoSize = true;
            this.textboxmessage.Font = new System.Drawing.Font("Corbel", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxmessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.textboxmessage.Location = new System.Drawing.Point(19, 21);
            this.textboxmessage.Name = "textboxmessage";
            this.textboxmessage.Size = new System.Drawing.Size(152, 21);
            this.textboxmessage.TabIndex = 11;
            this.textboxmessage.Text = "Enter the message:";
            // 
            // textboxhashed
            // 
            this.textboxhashed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxhashed.Location = new System.Drawing.Point(25, 345);
            this.textboxhashed.Multiline = true;
            this.textboxhashed.Name = "textboxhashed";
            this.textboxhashed.Size = new System.Drawing.Size(377, 130);
            this.textboxhashed.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Corbel", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.label6.Location = new System.Drawing.Point(19, 321);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 21);
            this.label6.TabIndex = 9;
            this.label6.Text = "Hashed value:";
            // 
            // textboxkey
            // 
            this.textboxkey.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxkey.Location = new System.Drawing.Point(23, 222);
            this.textboxkey.Multiline = true;
            this.textboxkey.Name = "textboxkey";
            this.textboxkey.Size = new System.Drawing.Size(377, 41);
            this.textboxkey.TabIndex = 8;
            // 
            // btnHash
            // 
            this.btnHash.BackColor = System.Drawing.Color.IndianRed;
            this.btnHash.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHash.FlatAppearance.BorderSize = 0;
            this.btnHash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHash.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHash.ForeColor = System.Drawing.Color.White;
            this.btnHash.Location = new System.Drawing.Point(23, 269);
            this.btnHash.Name = "btnHash";
            this.btnHash.Size = new System.Drawing.Size(377, 41);
            this.btnHash.TabIndex = 1;
            this.btnHash.Text = "Generate Hash";
            this.btnHash.UseVisualStyleBackColor = false;
            this.btnHash.Click += new System.EventHandler(this.BtnHash_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Corbel", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.label5.Location = new System.Drawing.Point(19, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "Enter the keyword:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(219, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 26);
            this.label2.TabIndex = 39;
            this.label2.Text = "SHA-256";
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
            this.backButton.TabIndex = 41;
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.label9.Location = new System.Drawing.Point(599, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(208, 19);
            this.label9.TabIndex = 42;
            this.label9.Text = "Test the algorithm below:";
            // 
            // UserControlSHA256
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label9);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Name = "UserControlSHA256";
            this.Size = new System.Drawing.Size(1045, 595);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label textboxmessage;
        private System.Windows.Forms.TextBox textboxhashed;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textboxkey;
        private System.Windows.Forms.Button btnHash;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label label9;
    }
}
