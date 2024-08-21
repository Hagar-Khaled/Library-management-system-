namespace ADOproj
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.txt_BookID = new System.Windows.Forms.TextBox();
            this.label_BookID = new System.Windows.Forms.Label();
            this.tbx_Title = new System.Windows.Forms.TextBox();
            this.label_Title = new System.Windows.Forms.Label();
            this.tbx_Author = new System.Windows.Forms.TextBox();
            this.label_Author = new System.Windows.Forms.Label();
            this.tbx_ISBN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbx_year = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbx_genre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_BookID
            // 
            this.txt_BookID.Location = new System.Drawing.Point(258, 92);
            this.txt_BookID.Name = "txt_BookID";
            this.txt_BookID.Size = new System.Drawing.Size(214, 23);
            this.txt_BookID.TabIndex = 0;
            this.txt_BookID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label_BookID
            // 
            this.label_BookID.AutoSize = true;
            this.label_BookID.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_BookID.Location = new System.Drawing.Point(94, 95);
            this.label_BookID.Name = "label_BookID";
            this.label_BookID.Size = new System.Drawing.Size(55, 17);
            this.label_BookID.TabIndex = 1;
            this.label_BookID.Text = "BookID";
            this.label_BookID.Click += new System.EventHandler(this.label_BookID_Click);
            // 
            // tbx_Title
            // 
            this.tbx_Title.Location = new System.Drawing.Point(258, 139);
            this.tbx_Title.Name = "tbx_Title";
            this.tbx_Title.Size = new System.Drawing.Size(214, 23);
            this.tbx_Title.TabIndex = 0;
            this.tbx_Title.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Title.Location = new System.Drawing.Point(94, 142);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(33, 17);
            this.label_Title.TabIndex = 1;
            this.label_Title.Text = "Title";
            // 
            // tbx_Author
            // 
            this.tbx_Author.Location = new System.Drawing.Point(258, 180);
            this.tbx_Author.Name = "tbx_Author";
            this.tbx_Author.Size = new System.Drawing.Size(214, 23);
            this.tbx_Author.TabIndex = 0;
            this.tbx_Author.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label_Author
            // 
            this.label_Author.AutoSize = true;
            this.label_Author.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Author.Location = new System.Drawing.Point(94, 183);
            this.label_Author.Name = "label_Author";
            this.label_Author.Size = new System.Drawing.Size(49, 17);
            this.label_Author.TabIndex = 1;
            this.label_Author.Text = "Author";
            // 
            // tbx_ISBN
            // 
            this.tbx_ISBN.Location = new System.Drawing.Point(258, 219);
            this.tbx_ISBN.Name = "tbx_ISBN";
            this.tbx_ISBN.Size = new System.Drawing.Size(214, 23);
            this.tbx_ISBN.TabIndex = 0;
            this.tbx_ISBN.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(94, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "ISBN";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // tbx_year
            // 
            this.tbx_year.Location = new System.Drawing.Point(258, 264);
            this.tbx_year.Name = "tbx_year";
            this.tbx_year.Size = new System.Drawing.Size(214, 23);
            this.tbx_year.TabIndex = 0;
            this.tbx_year.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(94, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "PublishedYear";
            // 
            // tbx_genre
            // 
            this.tbx_genre.Location = new System.Drawing.Point(258, 305);
            this.tbx_genre.Name = "tbx_genre";
            this.tbx_genre.Size = new System.Drawing.Size(214, 23);
            this.tbx_genre.TabIndex = 0;
            this.tbx_genre.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(94, 308);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Genre";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(258, 352);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(214, 23);
            this.textBox6.TabIndex = 0;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(94, 355);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "AvailableCopies";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(525, 373);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 49);
            this.button1.TabIndex = 2;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.RoyalBlue;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(662, 373);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 49);
            this.button2.TabIndex = 3;
            this.button2.Text = "BACK";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(798, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_Author);
            this.Controls.Add(this.label_Title);
            this.Controls.Add(this.label_BookID);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.tbx_genre);
            this.Controls.Add(this.tbx_year);
            this.Controls.Add(this.tbx_ISBN);
            this.Controls.Add(this.tbx_Author);
            this.Controls.Add(this.tbx_Title);
            this.Controls.Add(this.txt_BookID);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Add New Books";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txt_BookID;
        private Label label_BookID;
        private TextBox tbx_Title;
        private Label label_Title;
        private TextBox tbx_Author;
        private Label label_Author;
        private TextBox tbx_ISBN;
        private Label label3;
        private TextBox tbx_year;
        private Label label4;
        private TextBox tbx_genre;
        private Label label5;
        private TextBox textBox6;
        private Label label6;
        private Button button1;
        private Button button2;
    }
}