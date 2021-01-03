using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace KsiazkaTeleadresowa
{
    [Serializable]
    public class Person
    {
        public static int iloscOsob = 0;
        public int id;
        public string imie;
        public string nazwisko;
        public string ulica;
        public string numerMieszkania;
        public string numerDomu;
        public string kodPocztowy;
        public string miejscowosc;
        public string komorka;
        public string stacjonarny;
        public string fax;
        public string adresEmail;
        public string www;
        public Byte[] photo;

        public Person()
        {

            id = iloscOsob;
            iloscOsob++;
        }

        public override string ToString()
        {

            return id + " " + imie + " " + nazwisko + " " + ulica + " " + numerDomu + " " +
               numerMieszkania + " " + kodPocztowy + " " + miejscowosc + " " + komorka + " " + stacjonarny + " " + fax
            + " " + adresEmail + " " + www;
        }
    }
}
