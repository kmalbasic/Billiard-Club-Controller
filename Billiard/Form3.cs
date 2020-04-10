using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace Billiard
{
    public partial class Form3 : Form
    {
        // koristimo value PasswordChar da bi sakrili password iza zvjezdica
        public Form3()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*';
        }
        // isti objekat za folder iz Form1, u ovom slucaju da ga otkrijemo kad se loginujemo
        DirectoryInfo fldr;

        // login dugme, provjerava user i pass, hardcoded vrijednosti i trebale bi se enkriptovati 
        private void button1_Click(object sender, EventArgs e)
        {
            // pozeljna enkripcija stringa, Xor?
            if (textBox1.Text == "user") 
                if(textBox2.Text == "pass")

                    // moguce funkcije isto, obe rade istu stvar kao i funkcija koja se koristi samo su drugi parametri
                    //Process.Start("explorer.exe", "/open, C:\\Private");
                    //Process.Start("explorer.exe", @"c:\private");
                    try
                    {
                        // nalazimo nas folder
                        fldr = new DirectoryInfo("C:\\Private");
                        // otkrivamo ga
                        fldr.Attributes = FileAttributes.Normal;



                    }
                    catch { }
            System.Diagnostics.Process.Start("explorer.exe", @"C:\Private");
            try
            {
                // opet nalazimo nas folder
                fldr = new DirectoryInfo("C:\\Private");
                // i sakrivamo ga dok je otvoren
                fldr.Attributes = FileAttributes.Hidden;



            }
            catch { }
        }
    }
}
