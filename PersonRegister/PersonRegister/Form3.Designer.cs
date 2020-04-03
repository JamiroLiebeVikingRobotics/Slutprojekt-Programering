namespace PersonRegister
{
    partial class listForm
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
            System.Windows.Forms.Label firstNameLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nameTxt2 = new System.Windows.Forms.TextBox();
            this.ageTxt = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.secondNameTextBox = new System.Windows.Forms.TextBox();
            this.saveBttn = new System.Windows.Forms.Button();
            this.listPerson = new System.Windows.Forms.ListBox();
            this.ageListBox = new System.Windows.Forms.ListBox();
            firstNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            firstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            firstNameLabel.Location = new System.Drawing.Point(61, 67);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(105, 26);
            firstNameLabel.TabIndex = 10;
            firstNameLabel.Text = "Förnamn:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(463, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 3;
            // 
            // nameTxt2
            // 
            this.nameTxt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.nameTxt2.Location = new System.Drawing.Point(53, 131);
            this.nameTxt2.Name = "nameTxt2";
            this.nameTxt2.ReadOnly = true;
            this.nameTxt2.Size = new System.Drawing.Size(113, 32);
            this.nameTxt2.TabIndex = 11;
            this.nameTxt2.Text = "Efternamn:";
            // 
            // ageTxt
            // 
            this.ageTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.ageTxt.Location = new System.Drawing.Point(53, 202);
            this.ageTxt.Name = "ageTxt";
            this.ageTxt.ReadOnly = true;
            this.ageTxt.Size = new System.Drawing.Size(113, 32);
            this.ageTxt.TabIndex = 12;
            this.ageTxt.Text = "Ålder:";
            this.ageTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.firstNameTextBox.Location = new System.Drawing.Point(172, 64);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(215, 32);
            this.firstNameTextBox.TabIndex = 13;
            this.firstNameTextBox.TextChanged += new System.EventHandler(this.firstNameTextBox_TextChanged);
            // 
            // secondNameTextBox
            // 
            this.secondNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.secondNameTextBox.Location = new System.Drawing.Point(172, 131);
            this.secondNameTextBox.Name = "secondNameTextBox";
            this.secondNameTextBox.Size = new System.Drawing.Size(215, 32);
            this.secondNameTextBox.TabIndex = 14;
            this.secondNameTextBox.TextChanged += new System.EventHandler(this.secondNameTextBox_TextChanged);
            // 
            // saveBttn
            // 
            this.saveBttn.BackColor = System.Drawing.Color.GreenYellow;
            this.saveBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.saveBttn.ForeColor = System.Drawing.Color.Black;
            this.saveBttn.Location = new System.Drawing.Point(172, 360);
            this.saveBttn.Name = "saveBttn";
            this.saveBttn.Size = new System.Drawing.Size(113, 52);
            this.saveBttn.TabIndex = 15;
            this.saveBttn.Text = "Spara";
            this.saveBttn.UseVisualStyleBackColor = false;
            this.saveBttn.Click += new System.EventHandler(this.saveBttn_Click);
            // 
            // listPerson
            // 
            this.listPerson.FormattingEnabled = true;
            this.listPerson.Location = new System.Drawing.Point(520, 48);
            this.listPerson.Name = "listPerson";
            this.listPerson.Size = new System.Drawing.Size(348, 186);
            this.listPerson.TabIndex = 16;
            // 
            // ageListBox
            // 
            this.ageListBox.FormattingEnabled = true;
            this.ageListBox.Location = new System.Drawing.Point(182, 202);
            this.ageListBox.Name = "ageListBox";
            this.ageListBox.Size = new System.Drawing.Size(120, 95);
            this.ageListBox.TabIndex = 17;
            this.ageListBox.SelectedIndexChanged += new System.EventHandler(this.ageListBox_SelectedIndexChanged);
            // 
            // listForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 495);
            this.Controls.Add(this.ageListBox);
            this.Controls.Add(this.listPerson);
            this.Controls.Add(this.saveBttn);
            this.Controls.Add(this.secondNameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.ageTxt);
            this.Controls.Add(this.nameTxt2);
            this.Controls.Add(firstNameLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "listForm";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.listForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nameTxt2;
        private System.Windows.Forms.TextBox ageTxt;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox secondNameTextBox;
        private System.Windows.Forms.Button saveBttn;
        private System.Windows.Forms.ListBox listPerson;
        private System.Windows.Forms.ListBox ageListBox;
    }
}