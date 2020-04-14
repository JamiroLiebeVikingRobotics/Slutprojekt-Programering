namespace PersonRegister
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
            this.addPersonBox = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.searchPersonBox = new System.Windows.Forms.Button();
            this.toListBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // addPersonBox
            // 
            this.addPersonBox.BackColor = System.Drawing.Color.DarkSlateGray;
            this.addPersonBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.addPersonBox.ForeColor = System.Drawing.Color.Black;
            this.addPersonBox.Location = new System.Drawing.Point(784, 378);
            this.addPersonBox.Name = "addPersonBox";
            this.addPersonBox.Size = new System.Drawing.Size(116, 67);
            this.addPersonBox.TabIndex = 0;
            this.addPersonBox.Text = "Lägg till person";
            this.addPersonBox.UseVisualStyleBackColor = false;
            this.addPersonBox.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(404, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(302, 149);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.textBox2.Location = new System.Drawing.Point(404, 167);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(302, 44);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "Jamiros sökregister";
            // 
            // searchPersonBox
            // 
            this.searchPersonBox.BackColor = System.Drawing.Color.DarkSlateGray;
            this.searchPersonBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.searchPersonBox.ForeColor = System.Drawing.Color.Black;
            this.searchPersonBox.Location = new System.Drawing.Point(499, 378);
            this.searchPersonBox.Name = "searchPersonBox";
            this.searchPersonBox.Size = new System.Drawing.Size(116, 67);
            this.searchPersonBox.TabIndex = 4;
            this.searchPersonBox.Text = "Sök Person";
            this.searchPersonBox.UseVisualStyleBackColor = false;
            this.searchPersonBox.Click += new System.EventHandler(this.searchPersonBox_Click);
            // 
            // toListBtn
            // 
            this.toListBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.toListBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.toListBtn.ForeColor = System.Drawing.Color.Black;
            this.toListBtn.Location = new System.Drawing.Point(184, 378);
            this.toListBtn.Name = "toListBtn";
            this.toListBtn.Size = new System.Drawing.Size(116, 67);
            this.toListBtn.TabIndex = 5;
            this.toListBtn.Text = "Listvy";
            this.toListBtn.UseVisualStyleBackColor = false;
            this.toListBtn.Click += new System.EventHandler(this.toListBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 541);
            this.Controls.Add(this.toListBtn);
            this.Controls.Add(this.searchPersonBox);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.addPersonBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addPersonBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button searchPersonBox;
        private System.Windows.Forms.Button toListBtn;
    }
}

