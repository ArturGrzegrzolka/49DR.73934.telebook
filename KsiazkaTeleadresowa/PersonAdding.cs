using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace KsiazkaTeleadresowa
{
    public partial class PersonAdding : Form
    {
        private Point wspolrzedneKursoraMyszki;
        private bool wcisnietyPrzyciskMyszki = false;
        AdressBook ksiazkaadresowa;
        MainBook main = MainBook.Instance;
        private static PersonAdding theInstance = null;

        private PersonAdding()
        {
            InitializeComponent();
            inicjalizacjaKomponentow();
            ksiazkaadresowa = AdressBook.Instance;
        }

        public static PersonAdding Instance
        {
            get
            {
                if (theInstance == null)
                    theInstance = new PersonAdding();
                return theInstance;
            }
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

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = System.Drawing.Color.White;
            label14.Visible = false;
            textBox2.BackColor = System.Drawing.Color.White;
            label15.Visible = false;
            textBox3.BackColor = System.Drawing.Color.White;
            label16.Visible = false;
            textBox4.BackColor = System.Drawing.Color.White;
            label17.Visible = false;
            textBox5.BackColor = System.Drawing.Color.White;
            label18.Visible = false;
            textBox6.BackColor = System.Drawing.Color.White;
            label19.Visible = false;
            textBox7.BackColor = System.Drawing.Color.White;
            label20.Visible = false;
            textBox8.BackColor = System.Drawing.Color.White;
            label21.Visible = false;
            textBox9.BackColor = System.Drawing.Color.White;
            label22.Visible = false;
            textBox10.BackColor = System.Drawing.Color.White;
            label23.Visible = false;
            textBox11.BackColor = System.Drawing.Color.White;
            label24.Visible = false;
            textBox12.BackColor = System.Drawing.Color.White;
            label25.Visible = false;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
            textBox12.Text = "";
            //pictureBox1.Image = new Bitmap(Properties.Resources.tloStandard1);
            this.Hide();
            main.Show();

        }

        private void AddPersonForm_Load(object sender, EventArgs e)
        {

            label14.Visible = false;
            label15.Visible = false;
            label16.Visible = false;
            label17.Visible = false;
            label18.Visible = false;
            label19.Visible = false;
            label20.Visible = false;
            label21.Visible = false;
            label22.Visible = false;
            label23.Visible = false;
            label24.Visible = false;
            label25.Visible = false;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
            textBox12.Text = "";


        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (validationFields())
            {
                try
                {

                    Person osoba = new Person();
                    osoba.imie = textBox1.Text;
                    osoba.nazwisko = textBox2.Text;
                    osoba.ulica = textBox3.Text;
                    osoba.numerDomu = textBox4.Text;
                    osoba.numerMieszkania = textBox5.Text;
                    osoba.kodPocztowy = textBox6.Text;
                    osoba.miejscowosc = textBox7.Text;
                    osoba.komorka = System.Text.RegularExpressions.Regex.Replace(textBox8.Text, "[^0-9]", string.Empty);
                    osoba.stacjonarny = System.Text.RegularExpressions.Regex.Replace(textBox9.Text, "[^0-9]", string.Empty);
                    osoba.fax = System.Text.RegularExpressions.Regex.Replace(textBox10.Text, "[^0-9]", string.Empty);
                    osoba.adresEmail = textBox11.Text;
                    osoba.www = textBox12.Text;
                    osoba.photo = null;

                    ksiazkaadresowa.Listofpersons.Add(osoba);
                    MessageBox.Show("Pomyślnie dodano osobę do książki teleadresowej.",
                       "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    this.Hide();
                    main.Show();

                }
                catch (SystemException ex)
                {
                    MessageBox.Show("Nastąpił błąd w dodaniu osoby do książki teleadresowej. " + ex.Message,
                        "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }

        }
        private bool validationFields()
        {
            bool value = true;
            if (textBox1.Text.Length > 50 ||
                (!System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, @"^[a-żA-Ż]+$"))
            || textBox1.Text.Length == 0)
            {
                textBox1.BackColor = System.Drawing.Color.Red;
                label14.Visible = true;
                value = false;
            }
            else
            {
                textBox1.BackColor = System.Drawing.Color.White;
                label14.Visible = false;
            }


            if (textBox2.Text.Length > 50 ||
               (!System.Text.RegularExpressions.Regex.IsMatch(textBox2.Text, @"^[a-żA-Ż]+$"))
           || textBox2.Text.Length == 0)
            {
                textBox2.BackColor = System.Drawing.Color.Red;
                label15.Visible = true;
                value = false;
            }
            else
            {
                textBox2.BackColor = System.Drawing.Color.White;
                label15.Visible = false;
            }

            if (textBox3.Text.Length > 75 ||
              (!System.Text.RegularExpressions.Regex.IsMatch(textBox3.Text, @"^[A-Ża-ż\s]{1,}$"))
          || textBox3.Text.Length == 0)
            {
                textBox3.BackColor = System.Drawing.Color.Red;
                label16.Visible = true;
                value = false;
            }
            else
            {
                textBox3.BackColor = System.Drawing.Color.White;
                label16.Visible = false;
            }

            if (textBox4.Text.Length > 5 ||
               (!System.Text.RegularExpressions.Regex.IsMatch(textBox4.Text, @"^\d{1,5}|(\d{1,4}\[a-żA-Ż]{1})+$"))
           || textBox4.Text.Length == 0)
            {
                textBox4.BackColor = System.Drawing.Color.Red;
                label17.Visible = true;
                value = false;
            }
            else
            {
                textBox4.BackColor = System.Drawing.Color.White;
                label17.Visible = false;
            }

            if (textBox5.Text == "" || textBox5.Text == "brak")
            {
                textBox5.Text = "brak";
            }
            else
            {
                if (textBox5.Text.Length > 3 ||
                 (!System.Text.RegularExpressions.Regex.IsMatch(textBox5.Text, @"^\d{1,3}$")))
                {
                    textBox5.BackColor = System.Drawing.Color.Red;
                    label18.Visible = true;
                    value = false;
                }
                else
                {

                    textBox5.BackColor = System.Drawing.Color.White;
                    label18.Visible = false;
                }
            }

            if (textBox6.Text.Length > 6 ||
             (!System.Text.RegularExpressions.Regex.IsMatch(textBox6.Text, @"^\d{2}\-\d{3}$"))
         || textBox6.Text.Length == 0)
            {
                textBox6.BackColor = System.Drawing.Color.Red;
                label19.Visible = true;
                value = false;
            }
            else
            {
                textBox6.BackColor = System.Drawing.Color.White;
                label19.Visible = false;
            }

            if (textBox7.Text.Length > 75 ||
                (!System.Text.RegularExpressions.Regex.IsMatch(textBox7.Text, @"^[A-Ża-ż\s]{1,}$"))
            || textBox7.Text.Length == 0)
            {
                textBox7.BackColor = System.Drawing.Color.Red;
                label20.Visible = true;
                value = false;
            }
            else
            {
                textBox7.BackColor = System.Drawing.Color.White;
                label20.Visible = false;
            }
            textBox8.Text = System.Text.RegularExpressions.Regex.Replace(textBox8.Text, "[^0-9]", string.Empty);
            if (textBox8.Text.Length > 9 ||
              (!System.Text.RegularExpressions.Regex.IsMatch(textBox8.Text, @"^\d{9}$"))
          || textBox8.Text.Length == 0)
            {
                textBox8.BackColor = System.Drawing.Color.Red;
                label21.Visible = true;
                value = false;
            }
            else
            {
                textBox8.BackColor = System.Drawing.Color.White;
                label21.Visible = false;
            }

            if (textBox9.Text.Length == 0 || textBox9.Text == "brak")
            {
                textBox9.Text = "brak";
            }
            else
            {
                textBox9.Text = System.Text.RegularExpressions.Regex.Replace(textBox9.Text, "[^0-9]", string.Empty);
                if (textBox9.Text.Length > 9 ||
                 (!System.Text.RegularExpressions.Regex.IsMatch(textBox9.Text, @"^\d{9}$")))
                {
                    textBox9.BackColor = System.Drawing.Color.Red;
                    label22.Visible = true;
                    value = false;
                }
                else
                {
                    textBox9.BackColor = System.Drawing.Color.White;
                    label22.Visible = false;
                }
            }

            if (textBox10.Text.Length == 0 || textBox10.Text == "brak")
            {
                textBox10.Text = "brak";
            }
            else
            {
                textBox10.Text = System.Text.RegularExpressions.Regex.Replace(textBox10.Text, "[^0-9]", string.Empty);
                if (textBox10.Text.Length > 9 ||
                 (!System.Text.RegularExpressions.Regex.IsMatch(textBox10.Text, @"^\d{9}$")))
                {
                    textBox10.BackColor = System.Drawing.Color.Red;
                    label23.Visible = true;
                    value = false;
                }
                else
                {
                    textBox10.BackColor = System.Drawing.Color.White;
                    label23.Visible = false;
                }
            }

            if (textBox11.Text.Length > 30 ||
                (!System.Text.RegularExpressions.Regex.IsMatch(textBox11.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$")))
            {
                textBox11.BackColor = System.Drawing.Color.Red;
                label24.Visible = true;
                value = false;
            }
            else
            {
                textBox11.BackColor = System.Drawing.Color.White;
                label24.Visible = false;
            }
            if (textBox12.Text.Length == 0 || textBox12.Text == "brak")
            {
                textBox12.Text = "brak";
            }
            else
            {
                if (textBox12.Text.Length > 30 ||
                  (!System.Text.RegularExpressions.Regex.IsMatch(textBox12.Text, @"^www.([\w\-]+)((\.(\w){2,3})+)$")))
                {
                    textBox12.BackColor = System.Drawing.Color.Red;
                    label25.Visible = true;
                    value = false;
                }
                else
                {
                    textBox12.BackColor = System.Drawing.Color.White;
                    label25.Visible = false;
                }
            }
            return value;
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void shapeContainer1_Load(object sender, EventArgs e)
        {

        }

        private void PersonAdding_Load(object sender, EventArgs e)
        {

        }

    }
}
