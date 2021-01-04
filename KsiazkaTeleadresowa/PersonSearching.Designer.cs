namespace KsiazkaTeleadresowa
{
    partial class PersonSearching
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Imię = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nazwisko = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ulica = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NumerDomu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NumerMieszkania = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Miejscowosc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Stacjonarny = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FAX = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.www = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Indigo;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Light", 12.75F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(975, 433);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 44);
            this.button1.TabIndex = 1;
            this.button1.Text = "Powrót";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(16, 140);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "Wyniki wyszukiwania : ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(162)))), ((int)(((byte)(225)))));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Segoe UI Light", 12.75F);
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(975, 78);
            this.button6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(208, 39);
            this.button6.TabIndex = 9;
            this.button6.Text = "Wyszukaj";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(23, 78);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(943, 38);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = "Wprowadź szukaną frazę...";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.GotFocus += new System.EventHandler(this.textBox1_Focused);
            this.textBox1.LostFocus += new System.EventHandler(this.textBox1_LostFocus);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(78)))), ((int)(((byte)(84)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(16, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(601, 37);
            this.label2.TabIndex = 11;
            this.label2.Text = "Wprowadź frazę na temat osoby aby ją wyszukać.";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Imię,
            this.Nazwisko,
            this.Ulica,
            this.NumerDomu,
            this.NumerMieszkania,
            this.columnHeader1,
            this.Miejscowosc,
            this.Tel,
            this.Stacjonarny,
            this.FAX,
            this.Email,
            this.www});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(16, 170);
            this.listView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1165, 255);
            this.listView1.TabIndex = 12;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 30;
            // 
            // Imię
            // 
            this.Imię.Text = "Imię";
            this.Imię.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Imię.Width = 100;
            // 
            // Nazwisko
            // 
            this.Nazwisko.Text = "Nazwisko";
            this.Nazwisko.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Nazwisko.Width = 100;
            // 
            // Ulica
            // 
            this.Ulica.Text = "Ulica";
            this.Ulica.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Ulica.Width = 100;
            // 
            // NumerDomu
            // 
            this.NumerDomu.Text = "Numer domu";
            this.NumerDomu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NumerDomu.Width = 100;
            // 
            // NumerMieszkania
            // 
            this.NumerMieszkania.Text = "Numer mieszkania";
            this.NumerMieszkania.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NumerMieszkania.Width = 100;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Kod pocztowy";
            this.columnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Miejscowosc
            // 
            this.Miejscowosc.Text = "Miejscowość";
            this.Miejscowosc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Miejscowosc.Width = 150;
            // 
            // Tel
            // 
            this.Tel.Text = "Tel ( Komórka)";
            this.Tel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Tel.Width = 100;
            // 
            // Stacjonarny
            // 
            this.Stacjonarny.Text = "Stacjonarny";
            this.Stacjonarny.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Stacjonarny.Width = 100;
            // 
            // FAX
            // 
            this.FAX.Text = "FAX";
            this.FAX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FAX.Width = 100;
            // 
            // Email
            // 
            this.Email.Text = "E-mail";
            this.Email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Email.Width = 100;
            // 
            // www
            // 
            this.www.Text = "WWW";
            this.www.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.www.Width = 100;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(1199, 492);
            this.shapeContainer1.TabIndex = 13;
            this.shapeContainer1.TabStop = false;
            this.shapeContainer1.Load += new System.EventHandler(this.shapeContainer1_Load);
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(78)))), ((int)(((byte)(84)))));
            this.rectangleShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.rectangleShape1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(78)))), ((int)(((byte)(84)))));
            this.rectangleShape1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.rectangleShape1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(78)))), ((int)(((byte)(84)))));
            this.rectangleShape1.FillGradientColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(78)))), ((int)(((byte)(84)))));
            this.rectangleShape1.Location = new System.Drawing.Point(1, 12);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(897, 102);
            this.rectangleShape1.Click += new System.EventHandler(this.rectangleShape1_Click);
            // 
            // PersonSearching
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(203)))), ((int)(((byte)(211)))));
            this.ClientSize = new System.Drawing.Size(1199, 492);
            this.ControlBox = false;
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.shapeContainer1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PersonSearching";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowIcon = false;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.PersonSearching_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Imię;
        private System.Windows.Forms.ColumnHeader Nazwisko;
        private System.Windows.Forms.ColumnHeader Ulica;
        private System.Windows.Forms.ColumnHeader NumerDomu;
        private System.Windows.Forms.ColumnHeader NumerMieszkania;
        private System.Windows.Forms.ColumnHeader Miejscowosc;
        private System.Windows.Forms.ColumnHeader Tel;
        private System.Windows.Forms.ColumnHeader Stacjonarny;
        private System.Windows.Forms.ColumnHeader FAX;
        private System.Windows.Forms.ColumnHeader Email;
        private System.Windows.Forms.ColumnHeader www;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}