using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;

namespace KsiazkaTeleadresowa
{
    public partial class PersonSearching : Form
    {
        private Point wspolrzedneKursoraMyszki;
        private bool wcisnietyPrzyciskMyszki = false;
        AdressBook ksiazkaadresowa;

        private static PersonSearching theInstance = null;
        private PersonSearching()
        {
            InitializeComponent();
            inicjalizacjaKomponentow();
            ksiazkaadresowa = AdressBook.Instance;
        }

        public static PersonSearching Instance
        {
            get
            {
                if (theInstance == null)
                    theInstance = new PersonSearching();
                return theInstance;
            }
        }

        public void refreshData()
        {
            foreach (ListViewItem item in listView1.Items)
            {
                item.Remove();
            }

            listView1.View = View.Details;

            foreach (Person osoba in ksiazkaadresowa.Listofpersons)
            {
                string[] row = { osoba.id.ToString(), osoba.imie, osoba.nazwisko,osoba.ulica,
                               osoba.numerDomu,osoba.numerMieszkania,osoba.kodPocztowy,
                               osoba.miejscowosc,osoba.komorka,osoba.stacjonarny,osoba.fax,osoba.adresEmail,
                               osoba.www};
                var listViewItem = new ListViewItem(row);
                listView1.Items.Add(listViewItem);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            MainBook menuGlowne = MainBook.Instance;
            menuGlowne.Show();

        }

        private void textBox1_Focused(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void textBox1_LostFocus(object sender, EventArgs e)
        {
            //textBox1.Text = "Wprowadź szukaną frazę...";
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.Focused)
            {
                ShowPerson sh = ShowPerson.Instance;
                sh.Show();
                foreach (ListViewItem item in listView1.Items)
                {
                    if (item.Selected == true)
                    {
                        sh.label1.Text = item.SubItems[1].Text + " " + item.SubItems[2].Text;
                        sh.label2.Text = item.SubItems[3].Text;
                        sh.label3.Text = item.SubItems[4].Text;
                        sh.label14.Text = item.SubItems[5].Text;
                        sh.label15.Text = item.SubItems[6].Text;
                        sh.label16.Text = item.SubItems[7].Text;
                        sh.label17.Text = item.SubItems[8].Text;
                        sh.label18.Text = item.SubItems[9].Text;
                        sh.label19.Text = item.SubItems[10].Text;
                        sh.label20.Text = item.SubItems[11].Text;
                        sh.label21.Text = item.SubItems[12].Text;
                        sh.label23.Text = item.SubItems[0].Text;
                    }

                    item.Selected = false;
                }

                this.Hide();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.Items)
            {
                item.Remove();
            }


            listView1.View = View.Details;

            foreach (Person osoba in ksiazkaadresowa.SearchPersons(textBox1.Text))
            {
                string[] row = { osoba.id.ToString(), osoba.imie, osoba.nazwisko,osoba.ulica,
                               osoba.numerDomu,osoba.numerMieszkania,osoba.kodPocztowy,
                               osoba.miejscowosc,osoba.komorka,osoba.stacjonarny,osoba.fax,osoba.adresEmail,
                               osoba.www};
                var listViewItem = new ListViewItem(row);
                listView1.Items.Add(listViewItem);
            }

        }

        private void PersonSearching_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void shapeContainer1_Load(object sender, EventArgs e)
        {

        }

        private void rectangleShape1_Click(object sender, EventArgs e)
        {

        }
    }
}
