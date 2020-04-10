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
using System.IO.Compression;
//  buildovati program u Debug zato sto imamo puno tajmera

namespace Billiard
{
    public partial class Form1 : Form
    {
        // ucitavanje forme, ovo radi umrli visual studio i iritantno je 
        public Form1()
        {
            InitializeComponent();

        }

        // tajmer1, zaustavljanje i cuvanje
        public void button6_Click(object sender, EventArgs e)
        {


            timer1.Stop();
            
            cij1 = cij1 + cijena1;
            vrh1 = vrh1 + timer1.Elapsed.Hours;
            vrm1 = vrm1 + timer1.Elapsed.Minutes;
            vrs1 = vrs1 + timer1.Elapsed.Seconds;
            timertog1 = false;

            timer1.Reset();

        }
        // Objekat za zakljucavanje i sakrivanje foldera za izvjestaje
        DirectoryInfo fldr;
        // Stoperice koje se koriste za vrijeme
        public Stopwatch timer1 = new Stopwatch();
        public Stopwatch timer2 = new Stopwatch();
        public Stopwatch timer3 = new Stopwatch();
        public Stopwatch timer4 = new Stopwatch();
        public Stopwatch timer5 = new Stopwatch();
        public Stopwatch timer6 = new Stopwatch();
        public Stopwatch timer7 = new Stopwatch();
        // float,int,bool,...
        //---------------------------------------------
        // cijene 
        public float cij1;
        public float cij2;
        public float cij3;
        public float cij4;
        public float cij5;
        public float cij6;
        public float cij7;
        // vremena (sekunde,minute,sati)
        public int vrm1;
        public int vrm2;
        public int vrm3;
        public int vrm4;
        public int vrm5;
        public int vrm6;
        public int vrm7;
        public int vrs1;
        public int vrs2;
        public int vrs3;
        public int vrs4;
        public int vrs5;
        public int vrs6;
        public int vrs7;
        public int vrh1;
        public int vrh2;
        public int vrh3;
        public int vrh4;
        public int vrh5;
        public int vrh6;
        public int vrh7;
        // ukupna cijena
        public float ciju;
        // boolovi za vrijeme (1/0)
         bool timertog1;
         bool timertog2;
         bool timertog3;
         bool timertog4;
         bool tt5; // iz nekog razloga "timertog5" ne radi, tacnije ne moze se koristiti..?
         bool timertog6;
         bool timertog7;

        // sekunde, minute, sati za tajmere sa realnim pracenjem vremena 
        // eksperimenti sa public,public static itd...
        // todo: memoryleak sa decimalnim brojevima
        public static int s, m, h;
        public int s1, m1, h1;
        int s2, m2, h2;
        public int s3, m3, h3;
        public int s4, m4, h4;
        public int s5, m5, h5;
        public int s6, m6, h6;
        // ukupne cijene za realtime tajmere, float?
        public float cijena7;
        public float cijena1;
        public float cijena2;
        public float cijena3;
        public float cijena4;
        public float cijena5;
        public float cijena6;


        


        // tajmer1, dugme za pokretanje i zaustavljanje

        public void button1_Click(object sender, EventArgs e)
        {

            
            if (label1.Text == "Slobodan")
            {
                button1.Text = "Stop";
                pictureBox1.BackColor = Color.FromArgb(100, 255, 255, 153);
                label1.Text = "Zauzet - igra u toku";
                label1.ForeColor = Color.Red;
                pictureBox1.Image = Billiard.Properties.Resources.playingp;
                // ovde timertog1 stavljamo na 1 ili true, da bi realni tajmer znao kad da krene otkucavati vrijeme
                // isto je u svakom dugmetu, ako je false onda se tajmer freezuje i ceka na reset.
                timertog1 = true;
                timer1.Start();

            }


            else if (label1.Text == "Zauzet - igra u toku")
            {
                button1.Text = "Start";
                pictureBox1.BackColor = Color.FromArgb(255, 0, 64, 64);
                label1.ForeColor = Color.Green;
                label1.Text = "Slobodan";
                
                pictureBox1.Image = Billiard.Properties.Resources.notplayingp;




            }


        }
        // useless
        private void label6_Click(object sender, EventArgs e)
        {

        }
        //-----------------------------------------------------------

        // tajmer2, ista dugmad
        public void button2_Click(object sender, EventArgs e)
        {
            if (label2.Text == "Slobodan")
            {
                button2.Text = "Stop";
                pictureBox2.BackColor = Color.FromArgb(100, 255, 255, 153);
                label2.Text = "Zauzet - igra u toku";
                label2.ForeColor = Color.Red;
                pictureBox1.Image = Billiard.Properties.Resources.playingp;

                timertog2 = true;
                timer2.Start();

            }


            else if (label2.Text == "Zauzet - igra u toku")
            {
                button2.Text = "Start";
                pictureBox2.BackColor = Color.FromArgb(255, 0, 64, 64);
                label2.ForeColor = Color.Green;
                label2.Text = "Slobodan";
                
                pictureBox2.Image = Billiard.Properties.Resources.notplayingp;




            }
        }
        // dugme za zaustavljanje tajmera 2, cuvanje vremena i cijene za ispis u izvjestaju na kraju
        public void button7_Click(object sender, EventArgs e)
        {
            timer2.Stop();
            
            cij2 = cij2 + cijena2;
            vrh2 = vrh2 + timer2.Elapsed.Hours;
            vrm2 = vrm2 + timer2.Elapsed.Minutes;
            vrs2 = vrs2 + timer2.Elapsed.Seconds;
            timertog2 = false;

            timer2.Reset();

        }
        // tajmer3, ista dugmad
        public void button3_Click(object sender, EventArgs e)
        {
            if (label3.Text == "Slobodan")
            {
                button3.Text = "Stop";
                pictureBox3.BackColor = Color.FromArgb(100, 255, 255, 153);
                label3.Text = "Zauzet - igra u toku";
                label3.ForeColor = Color.Red;
                pictureBox3.Image = Billiard.Properties.Resources.playingp;
                timertog3 = true;

                timer3.Start();

            }


            else if (label3.Text == "Zauzet - igra u toku")
            {
                button3.Text = "Start";
                pictureBox3.BackColor = Color.FromArgb(255, 0, 64, 64);
                label3.ForeColor = Color.Green;
                label3.Text = "Slobodan";
                
                pictureBox3.Image = Billiard.Properties.Resources.notplayingp;




            }
        }
        // tajmer3, zaustavljanje i cuvanje, bla bla
        private void button8_Click(object sender, EventArgs e)
        {
            timer3.Stop();
           
            cij3 = cij3 + cijena3;
            vrh3 = vrh3 + timer3.Elapsed.Hours;
            vrm3 = vrm3 + timer3.Elapsed.Minutes;
            vrs3 = vrs3 + timer3.Elapsed.Seconds;
            timertog3 = false;
            timer3.Reset();
        }
        // tajmer4, ista dugmad
        public void button4_Click(object sender, EventArgs e)
        {
            if (label4.Text == "Slobodan")
            {
                button4.Text = "Stop";
                pictureBox4.BackColor = Color.FromArgb(100, 255, 255, 153);
                label4.Text = "Zauzet - igra u toku";
                label4.ForeColor = Color.Red;
                pictureBox4.Image = Billiard.Properties.Resources.playingp;

                timertog4 = true;
                timer4.Start();

            }


            else if (label4.Text == "Zauzet - igra u toku")
            {
                button4.Text = "Start";
                pictureBox4.BackColor = Color.FromArgb(255, 0, 64, 64);
                label4.ForeColor = Color.Green;
                label4.Text = "Slobodan";
               
                pictureBox4.Image = Billiard.Properties.Resources.notplayingp;




            }
        }
        // tajmer4, zaustavljanje i cuvanje
        private void button9_Click(object sender, EventArgs e)
        {
            timer4.Stop();
          
            cij4 = cij4 + cijena4;
            vrh4 = vrh4 + timer4.Elapsed.Hours;
            vrm4 = vrm4 + timer4.Elapsed.Minutes;
            vrs4 = vrs4 + timer4.Elapsed.Seconds;
            timertog4 = false;
            timer4.Reset();
        }
        // tajmer5, ista dugmad
        public void button5_Click(object sender, EventArgs e)
        {
            if (label5.Text == "Slobodan")
            {
                button5.Text = "Stop";
                pictureBox5.BackColor = Color.FromArgb(100, 255, 255, 153);
                label5.Text = "Zauzet - igra u toku";
                label5.ForeColor = Color.Red;
                pictureBox5.Image = Billiard.Properties.Resources.playingp;
                tt5 = true;
                timer5.Start();

            }


            else if (label5.Text == "Zauzet - igra u toku")
            {
                button5.Text = "Start";
                pictureBox5.BackColor = Color.FromArgb(255, 0, 64, 64);
                label5.ForeColor = Color.Green;
                label5.Text = "Slobodan";
                
                pictureBox5.Image = Billiard.Properties.Resources.notplayingp;




            }
        }
        // tajmer5, zaustavljanje i cuvanje
        private void button10_Click(object sender, EventArgs e)
        {
            timer5.Stop();
          
            cij5 = cij5 + cijena5;
            vrh5 = vrh5 + timer5.Elapsed.Hours;
            vrm5 = vrm5 + timer5.Elapsed.Minutes;
            vrs5 = vrs5 + timer5.Elapsed.Seconds;
            tt5 = false;
            timer5.Reset();
        }
        // realni tajmer3, interval 1000 (1s) zbog jebenog RAM usage
        private void timer10_Tick(object sender, EventArgs e)
        {
            if (timertog3)
            {
                s2++;
                if (s2 >= 60)
                {
                    m2++;
                    cijena3 = cijena3 + 0.1f;
                    s2 = 0;
                }
                if (m2 >= 60)
                {
                    h2++;
                    m2 = 0;
                }
                drawtime3(h2, m2, s2, cijena3);
            }
            if (!timertog3)
                reset3();
        }
        // tajmer6, ista dugmad
        public void button11_Click(object sender, EventArgs e)
        {
            if (label11.Text == "Slobodan")
            {
                button11.Text = "Stop";
                pictureBox6.BackColor = Color.FromArgb(100, 255, 255, 153);
                label11.Text = "Zauzet - igra u toku";
                label11.ForeColor = Color.Red;
                pictureBox6.Image = Billiard.Properties.Resources.playingp;

               timertog6 = true;
                timer6.Start();

            }


            else if (label11.Text == "Zauzet - igra u toku")
            {
                button11.Text = "Start";
                pictureBox6.BackColor = Color.FromArgb(255, 0, 64, 64);
                label11.ForeColor = Color.Green;
                label11.Text = "Slobodan";
                
                pictureBox6.Image = Billiard.Properties.Resources.notplayingp;




            }
        }

        // tajmer6, zaustavljanje i cuvanje
        private void button12_Click(object sender, EventArgs e)
        {
            timer6.Stop();
            
           
            
            cij6 = cij6 + cijena6;
            vrh6 = vrh6 + timer6.Elapsed.Hours;
            vrm6 = vrm6 + timer6.Elapsed.Minutes;
            vrs6 = vrs6 + timer6.Elapsed.Seconds;
           timertog6 = false;
            timer6.Reset();
        }


        // tajmer7, ista dugmad
        public void button13_Click(object sender, EventArgs e)
        {
            if (label13.Text == "Slobodan")
            {
                button13.Text = "Stop";
                pictureBox7.BackColor = Color.FromArgb(100, 255, 255, 153);
                label13.Text = "Zauzet - igra u toku";
                label13.ForeColor = Color.Red;
                pictureBox7.Image = Billiard.Properties.Resources.playingp;

                timertog7 = true;
                timer7.Start();

            }


            else if (label13.Text == "Zauzet - igra u toku")
            {
                button13.Text = "Start";
                pictureBox7.BackColor = Color.FromArgb(255, 0, 64, 64);
                label13.ForeColor = Color.Green;
                label13.Text = "Slobodan";
                
                pictureBox7.Image = Billiard.Properties.Resources.notplayingp;




            }
        }

        // tajmer7, cuvanje i zaustavljanje
        private void button14_Click(object sender, EventArgs e)
        {
            timer7.Stop();
            
            cij7 = cij7 + cijena7;
            vrh7 = vrh7 + timer7.Elapsed.Hours;
            vrm7 = vrm7 + timer7.Elapsed.Minutes;
            vrs7 = vrs7 + timer7.Elapsed.Seconds;
            timertog7 = false;
            timer7.Reset();
        }
        // string za ime izvjestaja, datetime za dobijanje datuma sistema (valjda je dobar datum podesen?)
        string datum = @"C:\Private\" + DateTime.Now.ToString("dd.MM.yyyy") + ".txt";


        //ispisivanje ukupne cijene u donjem lijevom uglu, pocinje StreamWriter za kreiranje fajla,
        //provjerava se da li fajl postoji i ako postoji overwriteuje ga.
        // "if" uslovi su stavljeni kao clamp za sekunde,minute i sate (za 100% sigurno ispisivanje vremena)
        // form2 je prozor za pregled izvjestaja koji se otvara
        private void button15_Click(object sender, EventArgs e)
        {
            ciju = cij1 + cij2 + cij3 + cij4 + cij5 + cij6 + cij7;
            label16.Text = "Ukupna cijena: " + ciju + "KM";
            if (vrs1 >= 60)
            {
                vrm1 = vrs1 / 60 + vrm1;
                vrs1 = vrs1 % 60;
            };
            if (vrs2 >= 60)
            {
                vrm2 = vrs2 / 60 + vrm2;
                vrs2 = vrs2 % 60;
            };
            if (vrs3 >= 60)
            {
                vrm3 = vrs3 / 60 + vrm3;
                vrs3 = vrs3 % 60;
            };
            if (vrs4 >= 60)
            {
                vrm4 = vrs4 / 60 + vrm4;
                vrs4 = vrs4 % 60;
            };
            if (vrs5 >= 60)
            {
                vrm5 = vrs5 / 60 + vrm5;
                vrs5 = vrs5 % 60;
            };
            if (vrs6 >= 60)
            {
                vrm6 = vrs6 / 60 + vrm6;
                vrs6 = vrs6 % 60;
            };
            if (vrs7 >= 60)
            {
                vrm7 = vrs7 / 60 + vrm7;
                vrs7 = vrs7 % 60;
            };
            if (vrm1 >= 60)
            {
                vrh1 = vrm1 / 60 + vrh1;
                vrm1 = vrm1 % 60;
            };
            if (vrm2 >= 60)
            {
                vrh2 = vrm2 / 60 + vrh2;
                vrm2 = vrm2 % 60;
            };
            if (vrs3 >= 60)
            {
                vrh3 = vrm3 / 60 + vrh3;
                vrm3 = vrm3 % 60;
            };
            if (vrm4 >= 60)
            {
                vrh4 = vrm4 / 60 + vrh4;
                vrm4 = vrm4 % 60;
            };
            if (vrh5 >= 60)
            {
                vrh5 = vrm5 / 60 + vrh5;
                vrm5 = vrm5 % 60;
            };
            if (vrh6 >= 60)
            {
                vrh6 = vrm6 / 60 + vrh6;
                vrm6 = vrm6 % 60;
            };
            if (vrh7 >= 60)
            {
                vrh7 = vrm7 / 60 + vrh7;
                vrm7 = vrm7 % 60;
            };
            try { // ako postoji datum, iskace MessageBox, brise izvjestaj i ostavlja prostor za novi 
                if (File.Exists(datum))
                {
                    MessageBox.Show("Izvjestaj za ovu sesiju je vec napravljen!");
                    if (File.Exists(datum))
                    {
                        File.Delete(datum);
                    }
                }
                // ispis pomocu StreamWritera, sw je objekat u StreamWriteru
                // najlaksi za koriscenje, jednostavne sintakse (create,createtext,findline,write,writeline,readline...)
                using (StreamWriter sw = File.CreateText(datum))
                {
                    sw.WriteLine("Vrijeme S1: " + vrh1 + "h " + vrm1 + "m " + vrs1 + "s" + "-- Ukupna naplata: " + cij1 + "KM");
                    sw.WriteLine("Vrijeme S2: " + vrh2 + "h " + vrm2 + "m " + vrs2 + "s" + "-- Ukupna naplata: " + cij2 + "KM");
                    sw.WriteLine("Vrijeme S3: " + vrh3 + "h " + vrm3 + "m " + vrs3 + "s" + "-- Ukupna naplata: " + cij3 + "KM");
                    sw.WriteLine("Vrijeme S4: " + vrh4 + "h " + vrm4 + "m " + vrs4 + "s" + "-- Ukupna naplata: " + cij4 + "KM");
                    sw.WriteLine("Vrijeme S5: " + vrh5 + "h " + vrm5 + "m " + vrs5 + "s" + "-- Ukupna naplata: " + cij5 + "KM");
                    sw.WriteLine("Vrijeme S6: " + vrh6 + "h " + vrm6 + "m " + vrs6 + "s" + "-- Ukupna naplata: " + cij6 + "KM");
                    sw.WriteLine("Vrijeme S7: " + vrh7 + "h " + vrm7 + "m " + vrs7 + "s" + "-- Ukupna naplata: " + cij7 + "KM");
                    sw.WriteLine("Ukupna cijena za sve stolove:" + ciju + "KM");
                    sw.WriteLine("Proporcija >> 1KM/10mins");
                }
                // iscitava izvjestaj u pozadini i poredi ga sa sacuvanim izvjestajem zbog greski
                using (StreamReader sr = File.OpenText(datum))
                {
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                }
            }
            // u slucaju greske, ispisi u konzoli
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.ToString());
            }
            try    // sakricemo folder i otkriti ga kad nam je potreban 
            {

                fldr = new DirectoryInfo("C:\\Private");

                fldr.Attributes = FileAttributes.Hidden;



            }
            catch { }
            // prikazujemo prozor (formu) za izvjestaj
            Form2 f2 = new Form2();
            f2.Show();
        }
        // kraj radnog vremena, da glupa konobarica ne pravi izvjestaj 1337 puta
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            button15.Enabled = checkBox1.Checked;
        }
        // login za izvjestaje, treca forma
        private void button16_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
        }

     
        // realni tajmer1
        private void timer8_Tick(object sender, EventArgs e)
        {
            //1
            if (timertog1)
            {

                s++;
                if (s >= 60)
                {
                    m++;
                    cijena1 = cijena1 + 0.1f;
                    s = 0;
                }
                if (m >= 60)
                {
                    h++;
                    m = 0;
                }
                drawtime1(h, m, s, cijena1);
            }
            if (!timertog1)
                reset1();
        }
        // realni tajmer2
        private void timer9_Tick(object sender, EventArgs e)
        {
            //2
            if (timertog2)
            {
                s1++;
                if (s1 >= 60)
                {
                    m1++;
                    cijena2 = cijena2 + 0.1f;
                    s1 = 0;
                }
                if (m1 >= 60)
                {
                    h1++;
                    m1 = 0;
                }
                drawtime2(h1, m1, s1, cijena2);
            }


            if (!timertog2)
                reset2();
        }
        // realni tajmer5
        private void timer11_Tick(object sender, EventArgs e)
        {
            if (tt5)
            {
                s4++;
                if (s4 >= 60)
                {
                    m4++;
                    cijena5 = cijena5 + 0.1f;
                    s4 = 0;
                }
                if (m4 >= 60)
                {
                    h4++;
                    m4 = 0;
                }
                drawtime5(h4, m4, s4, cijena5);
            }
            if (!tt5)
                reset5();
        }
        // realni tajmer4
        private void timer12_Tick(object sender, EventArgs e)
        {
            if (timertog4)
            {
                s3++;
                if (s3 >= 60)
                {
                    m3++;
                    cijena4 = cijena4 + 0.1f;
                    s3 = 0;
                }
                if (m3 >= 60)
                {
                    h3++;
                    m3 = 0;
                }
                drawtime4(h3, m3, s3, cijena4);
            }
            if (!timertog4)
                reset4();
        }
        // realni tajmer6
        private void timer13_Tick(object sender, EventArgs e)
        {
            if (timertog6)
            {
                s5++;
                if (s5 >= 60)
                {
                    m5++;
                    cijena6 = cijena6 + 0.1f;
                    s5 = 0;
                }
                if (m5 >= 60)
                {
                    h5++;
                    m5 = 0;
                }
                drawtime6(h5, m5, s5, cijena6);
            }
            if (!timertog6)
                reset6();
        }
        // realni tajmer7
        private void timer14_Tick(object sender, EventArgs e)
        {
            if (timertog7)
            {
                s6++;
                if (s6 >= 60)
                {
                    m6++;
                    cijena7 = cijena7 + 0.1f;
                    s6 = 0;
                }
                if (m6 >= 60)
                {
                    h6++;
                    m6 = 0;
                }
                drawtime7(h6, m6, s6, cijena7);
            }
            if (!timertog7)
                reset7();
        }

     

        // funkcije za ispis vremena tajmera i cijene
        // odradjene kao private i public zbog memoryleakovanja 
        // lakse je pozvati jednu funkciju nego svaki milisekund pozivati 4 linije koda 
        private void drawtime1(int a, int b, int c, float d)
        {

            // mislim na ove 4 linije koda

            label24.Text = "" + a + "h";
            label31.Text = "" + b + "m";
            label38.Text = "" + c + "s";
            label45.Text = "" + d + "KM";
        }
        public void drawtime2(int a, int b, int c, float d)
        {
            label25.Text = "" + a + "h";
            label32.Text = "" + b + "m";
            label39.Text = "" + c + "s";
            label46.Text = "" + d + "KM";
        }
        public void drawtime3(int a, int b, int c, float d)
        {
            label26.Text = "" + a + "h";
            label33.Text = "" + b + "m";
            label40.Text = "" + c + "s";
            label47.Text = "" + d + "KM";
        }
        public void drawtime4(int a, int b, int c, float d)
        {
            label27.Text = "" + a + "h";
            label34.Text = "" + b + "m";
            label41.Text = "" + c + "s";
            label48.Text = "" + d + "KM";
        }
        public void drawtime5(int a, int b, int c, float d)
        {
            label28.Text = "" + a + "h";
            label35.Text = "" + b + "m";
            label42.Text = "" + c + "s";
            label49.Text = "" + d + "KM";
        }
        public void drawtime6(int a, int b, int c, float d)
        {
            label29.Text = "" + a + "h";
            label36.Text = "" + b + "m";
            label43.Text = "" + c + "s";
            label50.Text = "" + d + "KM";
        }
        public void drawtime7(int a, int b, int c, float d)
        {
            label30.Text = "" + a + "h";
            label37.Text = "" + b + "m";
            label44.Text = "" + c + "s";
            label51.Text = "" + d + "KM";
        }

        // reset za realtime tajmere, memoryleak, isti razlog, pozivamo jednu funkciju na klik a ne 4 linije koda
        public void reset1()
        {
            h = 0;
            m = 0;
            s = 0;
            cijena1 = 0;
        }
        public void reset2()
        {
            h1 = 0;
            m1 = 0;
            s1 = 0;
            cijena2 = 0;
        }
        public void reset3()
        {
            h2 = 0;
            m2 = 0;
            s2 = 0;
            cijena3 = 0;
        }
        public void reset4()
        {
            h3 = 0;
            m3 = 0;
            s3 = 0;
            cijena4 = 0;
        }
        public void reset5()
        {
            h4 = 0;
            m4 = 0;
            s4 = 0;
            cijena5 = 0;
        }
        public void reset6()
        {
            h5 = 0;
            m5 = 0;
            s5 = 0;
            cijena6 = 0;
        }
        public void reset7()
        {
            h6 = 0;
            m6 = 0;
            s6 = 0;
            cijena7 = 0;
        }
    }
}

