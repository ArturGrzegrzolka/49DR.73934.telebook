using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;


namespace KsiazkaTeleadresowa
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool firstrun;

            try
            {
                using (Mutex mutex = new Mutex(true, "Example", out firstrun))
                {
                    if (firstrun)
                    {
                        Application.EnableVisualStyles();
                        Application.SetCompatibleTextRenderingDefault(false);
                        Application.Run(MainBook.Instance);
                    }
                    else
                    {
                        mutex.ReleaseMutex();
                    }
                }
            }
            catch (ApplicationException)
            {
                MessageBox.Show("Program jest już uruchomiony.", "Komunikat", MessageBoxButtons.OK, MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1);
            }
            finally
            {
                Application.Exit();
            }
        }
    }
}
