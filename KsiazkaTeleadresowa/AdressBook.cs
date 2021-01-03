using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Imaging;
using System.Media;
using System.Xml.Serialization;


namespace KsiazkaTeleadresowa
{
    public class AdressBook
    {
        private StreamWriter fwrite;
        private StreamReader freader;
        private string pathToFile;
        private List<Person> listofpersons;

        private static AdressBook theInstance = null;

        private AdressBook()
        {
            listofpersons = new List<Person>();
        }

        public static AdressBook Instance
        {
            get
            {
                if (theInstance == null)
                {
                    theInstance = new AdressBook();
                }
                return theInstance;
            }
        }

        public bool CreateBook(string sciezka)
        {
            try
            {
                this.pathToFile = sciezka;
                WriteDataFileToBook();

            }
            catch (IOException)
            {
                return false;
            }

            return true;

        }

        public string PathToFile
        {
            get { return pathToFile; }
            set { pathToFile = value; }
        }

        public List<Person> Listofpersons
        {
            get { return listofpersons; }
        }

        public bool SaveBook()
        {

            try
            {
                fwrite = new StreamWriter(pathToFile);
            }
            catch (SystemException)
            {
                return false;
            }

            try
            {

                System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(typeof(List<Person>));

                serializer.Serialize(fwrite, listofpersons);



                fwrite.Flush();
                fwrite.Close();
            }
            catch (SystemException ex)
            {
                MessageBox.Show("Nastąpił błąd podczas serializacji lub zapisu pliku z danymi. " + ex.Message,
                       "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }

            return true;
        }

        public bool EditPerson(int id, string ulica, string numerDomu, string numerMieszkania,
            string kodPocztowy, string miejscowosc, string komorka, string stacjonarny, string fax, string adresEmial,
            string www)
        {
            try
            {
                listofpersons[GetIndexPersonByID(id)].ulica = ulica;
                listofpersons[GetIndexPersonByID(id)].numerDomu = numerDomu;
                listofpersons[GetIndexPersonByID(id)].numerMieszkania = numerMieszkania;
                listofpersons[GetIndexPersonByID(id)].kodPocztowy = kodPocztowy;
                listofpersons[GetIndexPersonByID(id)].miejscowosc = miejscowosc;
                listofpersons[GetIndexPersonByID(id)].komorka = komorka;
                listofpersons[GetIndexPersonByID(id)].stacjonarny = stacjonarny;
                listofpersons[GetIndexPersonByID(id)].fax = fax;
                listofpersons[GetIndexPersonByID(id)].adresEmail = adresEmial;
                listofpersons[GetIndexPersonByID(id)].www = www;
            }

            catch (IndexOutOfRangeException)
            {
                return false;
            }

            catch (IOException)
            {
                return false;
            }
            return true;
        }

        public List<Person> SearchPersons(string fraza)
        {
            List<Person> osobyspelniajacefraze = new List<Person>();
            foreach (Person osobafromlist in listofpersons)
            {
                if (osobafromlist.ToString().ToLower().Contains(fraza))
                {
                    osobyspelniajacefraze.Add(osobafromlist);
                }
            }
            return osobyspelniajacefraze;
        }

        public bool WriteDataFileToBook()
        {
            try
            {
                freader = new StreamReader(pathToFile);
                XmlSerializer serializer = new XmlSerializer(typeof(List<Person>));

                listofpersons = (List<Person>)serializer.Deserialize(freader);

                freader.Close();
            }
            catch (FileNotFoundException)
            {
                return true;
            }
            catch (SystemException ex)
            {
                MessageBox.Show("Nastąpił błąd podczas odczytu danych. " + ex.Message,
                       "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);

                return false;
            }

            freader = new StreamReader("dane.txt");


            /* for(int i=0;i<1000;i++)
             {
                 string line = freader.ReadLine();
                 string [] words = line.Split(',');

                 Person person = new Person();
                 person.id = int.Parse(words[0]);
                 person.imie = words[1];
                 person.nazwisko = words[2];

                 string[] words2 = words[3].Split(' ');
                 if (words2.Length == 3)
                 {
                     person.ulica = words2[1];
                     person.numerDomu = words2[2];
                 }
                 if (words2.Length == 4)
                 {
                     person.ulica = words2[1] + " " + words2[2];
                     person.numerDomu = words2[3];
                 }
                 if (words2.Length == 5)
                 {
                     person.ulica = words2[1] + " " + words2[2] + " " + words2[3];
                     person.numerDomu = words2[4];
                 }
                 person.numerMieszkania = "brak";
                 person.kodPocztowy = words[6];
                 person.miejscowosc = words[4];

                 person.komorka = words[7];
                 person.stacjonarny = words[7];
                 person.fax = "brak";
                 person.adresEmail = words[8];
                 person.www = "brak";
                 listofpersons.Add(person);
             }*/
            return true;
        }

        public bool ErasePerson(int id)
        {
            try
            {
                listofpersons.RemoveAt(GetIndexPersonByID(id));

            }
            catch (IndexOutOfRangeException)
            {
                return false;
            }

            return true;
        }

        public int GetIndexPersonByID(int id)
        {
            int i = 0;
            foreach (Person osobafromlist in listofpersons)
            {
                if (osobafromlist.id == id)
                {
                    return i;
                }
                i++;
            }
            return -1;
        }

        public void SaveBookToXLSX(string path)
        {
            try
            {

                FileStream file = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);
                StreamWriter write = new StreamWriter(file, Encoding.UTF8);

                foreach (Person p in listofpersons)
                {
                    write.WriteLine(p.id + "," + p.imie + "," + p.nazwisko + "," + p.ulica + "," + p.numerDomu
                        + "," + p.numerMieszkania + "," + p.kodPocztowy + "," + p.miejscowosc + "," + p.komorka + ","
                        + p.stacjonarny + "," + p.fax + "," + p.adresEmail + "," + p.www);
                }


                write.Close();
                file.Close();
            }
            catch (SystemException ex)
            {
                MessageBox.Show("Nastąpił błąd podczas zapisu pliku z danymi. " + ex.Message,
                      "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }



        }

        public Person GetPersonByID(int id)
        {
            foreach (Person person in listofpersons)
            {
                if (person.id == id)
                {
                    return person;
                }
            }

            return null;
        }
    }
}
