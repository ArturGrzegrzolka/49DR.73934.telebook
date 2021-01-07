using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KsiazkaTeleadresowa
{
    public partial class ShowPerson : Form
    {
        private Point wspolrzedneKursoraMyszki;
        private bool wcisnietyPrzyciskMyszki = false;
        AdressBook ksiazkaadresowa;
        private static ShowPerson theInstance;

        private ShowPerson()
        {
            InitializeComponent();
            inicjalizacjaKomponentow();
            ksiazkaadresowa = AdressBook.Instance;
        }

        public static ShowPerson Instance
        {
            get
            {
                if (theInstance == null)
                    theInstance = new ShowPerson();
                return theInstance;
            }

        }

        private void ShowPerson_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                wspolrzedneKursoraMyszki = new Point(e.X, e.Y);
                wcisnietyPrzyciskMyszki = true;
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (wcisnietyPrzyciskMyszki)
            {
                Point wspolrzedneMyszy = Control.MousePosition;
                wspolrzedneMyszy.Offset(-wspolrzedneKursoraMyszki.X, -wspolrzedneKursoraMyszki.Y);
                this.Location = wspolrzedneMyszy;
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                wcisnietyPrzyciskMyszki = false;
            }
        }

        private void inicjalizacjaKomponentow()
        {
            this.MouseDown += new MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new MouseEventHandler(this.Form1_MouseUp);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainBook main = MainBook.Instance;
            main.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Czy na pewno chcesz usunąć tą osobę?", "Komunikat", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (dialogResult == DialogResult.Yes)
            {
                if (ksiazkaadresowa.ErasePerson(int.Parse(label23.Text)))
                {
                    MessageBox.Show("Pomyślnie usunięto osobę z książki.", "Information", MessageBoxButtons.OK,
              MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    this.Hide();
                    MainBook main = MainBook.Instance;
                    main.Show();
                }
                else
                {
                    MessageBox.Show("Nie udało się usunąć osoby.", "Error", MessageBoxButtons.OK,
               MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {

            label2.Visible = false;
            label3.Visible = false;
            label14.Visible = false;
            label15.Visible = false;
            label16.Visible = false;
            label17.Visible = false;
            label18.Visible = false;
            label19.Visible = false;
            label20.Visible = false;
            label21.Visible = false;
            label23.Visible = false;
            button1.Visible = false;
            button3.Visible = true;
            textBox1.Visible = true;
            textBox1.Text = label2.Text;
            textBox2.Visible = true;
            textBox2.Text = label3.Text;
            textBox3.Visible = true;
            textBox3.Text = label14.Text;
            textBox4.Visible = true;
            textBox4.Text = label15.Text;
            textBox5.Visible = true;
            textBox5.Text = label16.Text;
            textBox6.Visible = true;
            textBox6.Text = label17.Text;
            textBox7.Visible = true;
            textBox7.Text = label18.Text;
            textBox8.Visible = true;
            textBox8.Text = label19.Text;
            textBox9.Visible = true;
            textBox9.Text = label20.Text;
            textBox10.Visible = true;
            textBox10.Text = label21.Text;

        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (validationFields())
            {
                textBox1.Visible = false;

                textBox2.Visible = false;

                textBox3.Visible = false;

                textBox4.Visible = false;

                textBox5.Visible = false;

                textBox6.Visible = false;

                textBox7.Visible = false;

                textBox8.Visible = false;

                textBox9.Visible = false;
                textBox10.Visible = false;

                label2.Text = textBox1.Text;
                label3.Text = textBox2.Text;
                label14.Text = textBox3.Text;
                label15.Text = textBox4.Text;
                label16.Text = textBox5.Text;
                label17.Text = textBox6.Text;
                label18.Text = textBox7.Text;
                label19.Text = textBox8.Text;
                label20.Text = textBox9.Text;
                label21.Text = textBox10.Text;

                label2.Visible = true;
                label3.Visible = true;
                label14.Visible = true;
                label15.Visible = true;
                label16.Visible = true;
                label17.Visible = true;
                label18.Visible = true;
                label19.Visible = true;
                label20.Visible = true;
                label21.Visible = true;
                ksiazkaadresowa.EditPerson(int.Parse(label23.Text), textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text,
                   textBox5.Text, textBox6.Text, textBox7.Text, textBox8.Text, textBox9.Text, textBox10.Text);
                button3.Visible = false;
                button1.Visible = true;
            }
        }


        private bool validationFields()
        {
            bool value = true;


            if (textBox1.Text.Length > 75 ||
              (!System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, @"^[a-zA-Z]+$"))
          || textBox1.Text.Length == 0)
            {
                textBox1.BackColor = System.Drawing.Color.Red;
                //label16.Visible = true;
                value = false;
            }
            else
            {
                textBox1.BackColor = System.Drawing.Color.White;
                //label16.Visible = false;
            }

            if (textBox2.Text.Length > 5 ||
               (!System.Text.RegularExpressions.Regex.IsMatch(textBox2.Text, @"^\d{1,5}|(\d{1,4}\[a-zA-Z]{1})+$"))
           || textBox2.Text.Length == 0)
            {
                textBox2.BackColor = System.Drawing.Color.Red;
                //label17.Visible = true;
                value = false;
            }
            else
            {
                textBox2.BackColor = System.Drawing.Color.White;
                //label17.Visible = false;
            }

            if (textBox3.Text == "" || textBox3.Text == "brak")
            {
                textBox3.Text = "brak";
            }
            else
            {
                if (textBox3.Text.Length > 3 ||
                 (!System.Text.RegularExpressions.Regex.IsMatch(textBox3.Text, @"^\d{1,3}$")))
                {
                    textBox3.BackColor = System.Drawing.Color.Red;
                    //label18.Visible = true;
                    value = false;
                }
                else
                {

                    textBox3.BackColor = System.Drawing.Color.White;
                    //label18.Visible = false;
                }
            }

            if (textBox4.Text.Length > 6 ||
             (!System.Text.RegularExpressions.Regex.IsMatch(textBox4.Text, @"^\d{2}\-\d{3}$"))
         || textBox4.Text.Length == 0)
            {
                textBox4.BackColor = System.Drawing.Color.Red;
                //label19.Visible = true;
                value = false;
            }
            else
            {
                textBox4.BackColor = System.Drawing.Color.White;
                //label19.Visible = false;
            }

            if (textBox5.Text.Length > 75 ||
                (!System.Text.RegularExpressions.Regex.IsMatch(textBox5.Text, @"^[a-zA-Z]+$"))
            || textBox5.Text.Length == 0)
            {
                textBox5.BackColor = System.Drawing.Color.Red;
                //label20.Visible = true;
                value = false;
            }
            else
            {
                textBox5.BackColor = System.Drawing.Color.White;
                //label20.Visible = false;
            }

            if (textBox6.Text.Length > 9 ||
              (!System.Text.RegularExpressions.Regex.IsMatch(textBox6.Text, @"^\d{9}$"))
          || textBox6.Text.Length == 0)
            {
                textBox6.BackColor = System.Drawing.Color.Red;
                //label21.Visible = true;
                value = false;
            }
            else
            {
                textBox6.BackColor = System.Drawing.Color.White;
                //label21.Visible = false;
            }

            if (textBox7.Text.Length == 0 || textBox7.Text == "brak")
            {
                textBox7.Text = "brak";
            }
            else
            {
                if (textBox7.Text.Length > 9 ||
                 (!System.Text.RegularExpressions.Regex.IsMatch(textBox7.Text, @"^\d{9}$")))
                {
                    textBox7.BackColor = System.Drawing.Color.Red;
                    //label22.Visible = true;
                    value = false;
                }
                else
                {
                    textBox7.BackColor = System.Drawing.Color.White;
                    //label22.Visible = false;
                }
            }

            if (textBox8.Text.Length == 0 || textBox8.Text == "brak")
            {
                textBox8.Text = "brak";
            }
            else
            {
                if (textBox8.Text.Length > 9 ||
                 (!System.Text.RegularExpressions.Regex.IsMatch(textBox8.Text, @"^\d{9}$")))
                {
                    textBox8.BackColor = System.Drawing.Color.Red;
                    //label23.Visible = true;
                    value = false;
                }
                else
                {
                    textBox8.BackColor = System.Drawing.Color.White;
                    //label23.Visible = false;
                }
            }

            if (textBox9.Text.Length > 30 ||
                (!System.Text.RegularExpressions.Regex.IsMatch(textBox9.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$")))
            {
                textBox9.BackColor = System.Drawing.Color.Red;
                //label24.Visible = true;
                value = false;
            }
            else
            {
                textBox9.BackColor = System.Drawing.Color.White;
                //label24.Visible = false;
            }
            if (textBox10.Text.Length == 0 || textBox10.Text == "brak")
            {
                textBox10.Text = "brak";
            }
            else
            {
                if (textBox10.Text.Length > 30 ||
                  (!System.Text.RegularExpressions.Regex.IsMatch(textBox10.Text, @"^www.([\w\-]+)((\.(\w){2,3})+)$")))
                {
                    textBox10.BackColor = System.Drawing.Color.Red;
                    //label25.Visible = true;
                    value = false;
                }
                else
                {
                    textBox10.BackColor = System.Drawing.Color.White;
                    //label25.Visible = false;
                }
            }
            return value;
        }

        private void shapeContainer1_Load(object sender, EventArgs e)
        {

        }
    }
}
