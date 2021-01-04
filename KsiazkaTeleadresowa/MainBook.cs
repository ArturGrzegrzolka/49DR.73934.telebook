using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace KsiazkaTeleadresowa
{
    public partial class MainBook : Form
    {
        #region declaration
        private Point wspolrzedneKursoraMyszki;
        private bool wcisnietyPrzyciskMyszki = false;
        PersonSearching oknoWyszukaj; 
        AdressBook ksiazkateleadresowa;
        #endregion 

        #region SingleInstance
        private static MainBook theInstance = null;


        public static MainBook Instance
        {
            get
            {
                if (theInstance == null)
                    theInstance = new MainBook();
                return theInstance;
            }
        }
        #endregion

        private MainBook()
        {
            ksiazkateleadresowa = AdressBook.Instance;
            ksiazkateleadresowa.CreateBook("data.xml");

            InitializeComponent();
            inicjalizacjaKomponentow();

        }
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ksiazkateleadresowa.SaveBook())
                {
                    MessageBox.Show("Podczas serializacji nastąpił błąd. Jeśli problem będzie się powtarzał skontaktuj się z adminem." +
                "Aplikacja zostanie teraz zamknięta. ",
                        "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    this.Close();
                }
                else
                {
                    this.Close();
                }
            }
            catch (SystemException ex)
            {
                MessageBox.Show("Podczas serializacji nastąpił błąd. Jeśli problem będzie się powtarzał skontaktuj się z adminem." +
                "Aplikacja zostanie teraz zamknięta. " + ex.Message,
                        "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                this.Close();
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            oknoWyszukaj = PersonSearching.Instance;
            oknoWyszukaj.refreshData();
            oknoWyszukaj.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            SaveFileDialog okienko = new SaveFileDialog();
            okienko.Filter = "Plik z rozszerzeniem (csv)|*.csv";
            okienko.FilterIndex = 2;
            okienko.RestoreDirectory = true;
            DialogResult result = okienko.ShowDialog();
            if (result == DialogResult.OK)
            {
                ksiazkateleadresowa.SaveBookToXLSX(okienko.FileName);
                MessageBox.Show("Eksport przeprowadzony pomyślnie. ",
                    "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PersonAdding addpersonform = PersonAdding.Instance;
            addpersonform.textBox1.Text = "";
            addpersonform.textBox2.Text = "";
            addpersonform.textBox3.Text = "";
            addpersonform.textBox4.Text = "";
            addpersonform.textBox5.Text = "";
            addpersonform.textBox6.Text = "";
            addpersonform.textBox7.Text = "";
            addpersonform.textBox8.Text = "";
            addpersonform.textBox9.Text = "";
            addpersonform.textBox10.Text = "";
            addpersonform.textBox11.Text = "";
            addpersonform.textBox12.Text = "";
            addpersonform.label14.Visible = false;
            addpersonform.label15.Visible = false;
            addpersonform.label16.Visible = false;
            addpersonform.label17.Visible = false;
            addpersonform.label18.Visible = false;
            addpersonform.label19.Visible = false;
            addpersonform.label20.Visible = false;
            addpersonform.label21.Visible = false;
            addpersonform.label22.Visible = false;
            addpersonform.label23.Visible = false;
            addpersonform.label24.Visible = false;
            addpersonform.label25.Visible = false;
            this.Hide();
            addpersonform.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            ksiazkateleadresowa.Listofpersons.Clear();
            MessageBox.Show("Książka została wyczyszczona pomyślnie! ",
                    "Komunikat", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }
    }

}
