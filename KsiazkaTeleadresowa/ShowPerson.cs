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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
