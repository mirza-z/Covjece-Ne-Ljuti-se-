using Data;

namespace CovjeceNeLjutiSe
{
    public partial class Form1 : Form
    {
        Igra igra = new Igra();
        Igrac igrac1 = new Igrac(0);
        Igrac igrac2 = new Igrac(1);
        Igrac igrac3 = new Igrac(2);
        Igrac igrac4 = new Igrac(3);

        Pijun pijun1 = new Pijun() { Ime = "pbPlavi1", DefaultnaLokacija = new Lokacija(62, 396), Id = 0, LegalanPotez = false, TrenutnaLokacija = -1 };
        Pijun pijun2 = new Pijun() { Ime = "pbPlavi2", DefaultnaLokacija = new Lokacija(140, 396), Id = 1, LegalanPotez = false, TrenutnaLokacija = -1 };
        Pijun pijun3 = new Pijun() { Ime = "pbPlavi3", DefaultnaLokacija = new Lokacija(62, 473), Id = 2, LegalanPotez = false, TrenutnaLokacija = -1 };
        Pijun pijun4 = new Pijun() { Ime = "pbPlavi4", DefaultnaLokacija = new Lokacija(140, 473), Id = 3, LegalanPotez = false, TrenutnaLokacija = -1 };
        Pijun pijun5 = new Pijun() { Ime = "pbCrveni1", DefaultnaLokacija = new Lokacija(62, 55), Id = 0, LegalanPotez = false, TrenutnaLokacija = -1 };
        Pijun pijun6 = new Pijun() { Ime = "pbCrveni2", DefaultnaLokacija = new Lokacija(140, 55), Id = 1, LegalanPotez = false, TrenutnaLokacija = -1 };
        Pijun pijun7 = new Pijun() { Ime = "pbCrveni3", DefaultnaLokacija = new Lokacija(62, 132), Id = 2, LegalanPotez = false, TrenutnaLokacija = -1 };
        Pijun pijun8 = new Pijun() { Ime = "pbCrveni4", DefaultnaLokacija = new Lokacija(140, 132), Id = 3, LegalanPotez = false, TrenutnaLokacija = -1 };
        Pijun pijun9 = new Pijun() { Ime = "pbZeleni1", DefaultnaLokacija = new Lokacija(418, 55), Id = 0, LegalanPotez = false, TrenutnaLokacija = -1 };
        Pijun pijun10 = new Pijun() { Ime = "pbZeleni2", DefaultnaLokacija = new Lokacija(496, 55), Id = 1, LegalanPotez = false, TrenutnaLokacija = -1 };
        Pijun pijun11 = new Pijun() { Ime = "pbZeleni3", DefaultnaLokacija = new Lokacija(418, 132), Id = 2, LegalanPotez = false, TrenutnaLokacija = -1 };
        Pijun pijun12 = new Pijun() { Ime = "pbZeleni4", DefaultnaLokacija = new Lokacija(496, 132), Id = 3, LegalanPotez = false, TrenutnaLokacija = -1 };
        Pijun pijun13 = new Pijun() { Ime = "pbZeleni1", DefaultnaLokacija = new Lokacija(418, 396), Id = 0, LegalanPotez = false, TrenutnaLokacija = -1 };
        Pijun pijun14 = new Pijun() { Ime = "pbZeleni2", DefaultnaLokacija = new Lokacija(496, 396), Id = 1, LegalanPotez = false, TrenutnaLokacija = -1 };
        Pijun pijun15 = new Pijun() { Ime = "pbZeleni3", DefaultnaLokacija = new Lokacija(418, 473), Id = 2, LegalanPotez = false, TrenutnaLokacija = -1 };
        Pijun pijun16 = new Pijun() { Ime = "pbZeleni4", DefaultnaLokacija = new Lokacija(496, 473), Id = 3, LegalanPotez = false, TrenutnaLokacija = -1 };

        Polje polje = new Polje();
        public Form1()
        {

            igrac1.pijuni.Add(pijun1);
            igrac1.pijuni.Add(pijun2);
            igrac1.pijuni.Add(pijun3);
            igrac1.pijuni.Add(pijun4);

            igrac2.pijuni.Add(pijun5);
            igrac2.pijuni.Add(pijun6);
            igrac2.pijuni.Add(pijun7);
            igrac2.pijuni.Add(pijun8);

            igrac3.pijuni.Add(pijun9);
            igrac3.pijuni.Add(pijun10);
            igrac3.pijuni.Add(pijun11);
            igrac3.pijuni.Add(pijun12);

            igrac4.pijuni.Add(pijun13);
            igrac4.pijuni.Add(pijun14);
            igrac4.pijuni.Add(pijun15);
            igrac4.pijuni.Add(pijun16);

            igra.igraci.Add(igrac1);
            igra.igraci.Add(igrac2);
            igra.igraci.Add(igrac3);
            igra.igraci.Add(igrac4);

            InitializeComponent();


            ZapocniIgru(igra);
        }

        int kocka = 0;
        private void ZapocniIgru(Igra igra)
        {
            IgraPlavi();
        }

        private void IgraPlavi()
        {
            PostaviIliUgasiKontrole(0);
            btnKocka.Enabled =true;
            btnNaPotezu.Text = "Igra: Plavi";
        }

        private void IgraCrveni()
        {
            PostaviIliUgasiKontrole(1);
            btnKocka.Enabled = true;
            btnNaPotezu.Text = "Igra: Crveni";
        }

        private void IgraZeleni()
        {
            PostaviIliUgasiKontrole(2);
            btnKocka.Enabled = true;
            btnNaPotezu.Text = "Igra: Zeleni";
        }

        private void IgraZuti()
        {
            PostaviIliUgasiKontrole(3);
            btnKocka.Enabled = true;
            btnNaPotezu.Text = "Igra: Zuti";
        }

        private void btnKocka_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            kocka = rnd.Next(1, 7);
            btnBroj.Text = kocka.ToString();
            // btnKocka.Enabled = false;
        }
        private void PostaviIliUgasiKontrole(int x)
        {
            bool uslov = false;
            if (x == 0)
            {
                uslov = true;
            }
            pbPlavi1.Enabled = uslov;
            pbPlavi2.Enabled = uslov;
            pbPlavi3.Enabled = uslov;
            pbPlavi4.Enabled = uslov;
            uslov = false;
            if (x == 1)
            {
                uslov = true;
                
            }
            pbCrveni1.Enabled = uslov;
            pbCrveni2.Enabled = uslov;
            pbCrveni3.Enabled = uslov;
            pbCrveni4.Enabled = uslov;
            uslov = false;
            if (x == 2)
            {
                uslov = true;
            }
            pbZeleni1.Enabled = uslov;
            pbZeleni2.Enabled = uslov;
            pbZeleni3.Enabled = uslov;
            pbZeleni4.Enabled = uslov;
            if (x == 3)
            {
                uslov = true;
            }
            pbZuti1.Enabled = uslov;
            pbZuti2.Enabled = uslov;
            pbZuti3.Enabled = uslov;
            pbZuti4.Enabled = uslov;
        }

        private void pbPlavi1_Click(object sender, EventArgs e)
        {
            if (kocka == 6 && igra.igraci[0].pijuni[0].TrenutnaLokacija == -1)
            {
                int x = igra.igraci[0].pijuni[0].TrenutnaLokacija = 0;
                pbPlavi1.Location = new Point(polje.Tabla[x].Left, polje.Tabla[x].Top);
                kocka = 0;
            }
            else if (igra.igraci[0].pijuni[0].TrenutnaLokacija != -1 && kocka != 0)
            {
                int x = igra.igraci[0].pijuni[0].TrenutnaLokacija += kocka;
                if (x > 51)
                {
                    x -= 52;
                    igra.igraci[0].pijuni[0].TrenutnaLokacija = x;
                }
                pbPlavi1.Location = new Point(polje.Tabla[x].Left, polje.Tabla[x].Top);
                kocka = 0;
                IgraCrveni();
            }
         
        }
        private void pbPlavi2_Click(object sender, EventArgs e)
        {
            if (kocka == 6 && igra.igraci[0].pijuni[1].TrenutnaLokacija == -1)
            {
                int x = igra.igraci[0].pijuni[1].TrenutnaLokacija = 0;
                pbPlavi2.Location = new Point(polje.Tabla[x].Left, polje.Tabla[x].Top);
                kocka = 0;
            }
            else if (igra.igraci[0].pijuni[1].TrenutnaLokacija != -1 && kocka != 0)
            {
                int x = igra.igraci[0].pijuni[1].TrenutnaLokacija += kocka;
                if (x > 51)
                {
                    x -= 52;
                    igra.igraci[0].pijuni[1].TrenutnaLokacija = x;
                }
                pbPlavi2.Location = new Point(polje.Tabla[x].Left, polje.Tabla[x].Top);
                kocka = 0;
                IgraCrveni();
            }
        }
        private void pbPlavi3_Click(object sender, EventArgs e)
        {
            if (kocka == 6 && igra.igraci[0].pijuni[2].TrenutnaLokacija == -1)
            {
                int x = igra.igraci[0].pijuni[2].TrenutnaLokacija = 0;
                pbPlavi3.Location = new Point(polje.Tabla[x].Left, polje.Tabla[x].Top);
                kocka = 0;
            }
            else if (igra.igraci[0].pijuni[2].TrenutnaLokacija != -1 && kocka != 0)
            {
                int x = igra.igraci[0].pijuni[2].TrenutnaLokacija += kocka;
                if (x > 51)
                {
                    x -= 52;
                    igra.igraci[0].pijuni[2].TrenutnaLokacija = x;
                }
                pbPlavi3.Location = new Point(polje.Tabla[x].Left, polje.Tabla[x].Top);
                kocka = 0;
                IgraCrveni();
            }
            
        }
        private void pbPlavi4_Click(object sender, EventArgs e)
        {
            if (kocka == 6 && igra.igraci[0].pijuni[3].TrenutnaLokacija == -1)
            {
                int x = igra.igraci[0].pijuni[3].TrenutnaLokacija = 0;
                pbPlavi4.Location = new Point(polje.Tabla[x].Left, polje.Tabla[x].Top);
                kocka = 0;
            }
            else if (igra.igraci[0].pijuni[3].TrenutnaLokacija != -1 && kocka != 0)
            {
                int x = igra.igraci[0].pijuni[3].TrenutnaLokacija += kocka;
                if (x > 51)
                {
                    x -= 52;
                    igra.igraci[0].pijuni[3].TrenutnaLokacija = x;
                }
                pbPlavi4.Location = new Point(polje.Tabla[x].Left, polje.Tabla[x].Top);
                kocka = 0;
                IgraCrveni();
            }
            
        }
        private void pbCrveni1_Click(object sender, EventArgs e)
        {
            if (kocka == 6 && igra.igraci[1].pijuni[0].TrenutnaLokacija == -1)
            {
                int x = igra.igraci[1].pijuni[0].TrenutnaLokacija = 13;
                pbCrveni1.Location = new Point(polje.Tabla[x].Left, polje.Tabla[x].Top);
                kocka = 0;
            }
            else if (igra.igraci[1].pijuni[0].TrenutnaLokacija != -1 && kocka != 0)
            {
                int x = igra.igraci[1].pijuni[0].TrenutnaLokacija += kocka;
                if (x > 51)
                {
                    x -= 52;
                    igra.igraci[1].pijuni[0].TrenutnaLokacija = x;
                }
                pbCrveni1.Location = new Point(polje.Tabla[x].Left, polje.Tabla[x].Top);
                kocka = 0;
                IgraZeleni();
            }
            
        }
        private void pbCrveni2_Click(object sender, EventArgs e)
        {
            if (kocka == 6 && igra.igraci[1].pijuni[1].TrenutnaLokacija == -1)
            {
                int x = igra.igraci[1].pijuni[1].TrenutnaLokacija = 13;
                pbCrveni2.Location = new Point(polje.Tabla[x].Left, polje.Tabla[x].Top);
                kocka = 0;
                
            }
            else if (igra.igraci[1].pijuni[1].TrenutnaLokacija != -1 && kocka != 0)
            {
                int x = igra.igraci[1].pijuni[0].TrenutnaLokacija += kocka;
                if (x > 51)
                {
                    x -= 52;
                    igra.igraci[1].pijuni[1].TrenutnaLokacija = x;
                }
                pbCrveni2.Location = new Point(polje.Tabla[x].Left, polje.Tabla[x].Top);
                kocka = 0;
                IgraZeleni();
            }
            
        }
        private void pbCrveni3_Click(object sender, EventArgs e)
        {
            if (kocka == 6 && igra.igraci[1].pijuni[2].TrenutnaLokacija == -1)
            {
                int x = igra.igraci[1].pijuni[2].TrenutnaLokacija = 13;
                pbCrveni3.Location = new Point(polje.Tabla[x].Left, polje.Tabla[x].Top);
                kocka = 0;
            }
            else if (igra.igraci[1].pijuni[2].TrenutnaLokacija != -1 && kocka != 0)
            {
                int x = igra.igraci[1].pijuni[2].TrenutnaLokacija += kocka;
                if (x > 51)
                {
                    x -= 52;
                    igra.igraci[1].pijuni[2].TrenutnaLokacija = x;
                }
                pbCrveni3.Location = new Point(polje.Tabla[x].Left, polje.Tabla[x].Top);
                kocka = 0;
                IgraZeleni();
            }
            
        }
        private void pbCrveni4_Click(object sender, EventArgs e)
        {
            if (kocka == 6 && igra.igraci[1].pijuni[3].TrenutnaLokacija == -1)
            {
                int x = igra.igraci[1].pijuni[3].TrenutnaLokacija = 13;
                pbCrveni4.Location = new Point(polje.Tabla[x].Left, polje.Tabla[x].Top);
                kocka = 0;
            }
            else if (igra.igraci[1].pijuni[3].TrenutnaLokacija != -1 && kocka != 0)
            {
                int x = igra.igraci[1].pijuni[3].TrenutnaLokacija += kocka;
                if (x > 51)
                {
                    x -= 52;
                    igra.igraci[1].pijuni[3].TrenutnaLokacija = x;
                }
                pbCrveni4.Location = new Point(polje.Tabla[x].Left, polje.Tabla[x].Top);
                kocka = 0;
                IgraZeleni();
            }
        }
        private void pbZeleni1_Click(object sender, EventArgs e)
        {
            if (kocka == 6 && igra.igraci[2].pijuni[0].TrenutnaLokacija == -1)
            {
                int x = igra.igraci[2].pijuni[0].TrenutnaLokacija = 26;
                pbZeleni1.Location = new Point(polje.Tabla[x].Left, polje.Tabla[x].Top);
                kocka = 0;
            }
            else if (igra.igraci[2].pijuni[0].TrenutnaLokacija != -1 && kocka != 0)
            {
                int x = igra.igraci[2].pijuni[0].TrenutnaLokacija += kocka;
                if (x > 51)
                {
                    x -= 52;
                    igra.igraci[2].pijuni[0].TrenutnaLokacija = x;
                }

                pbZeleni1.Location = new Point(polje.Tabla[x].Left, polje.Tabla[x].Top);
                kocka = 0;
                IgraZuti();
            }
        }
        private void pbZeleni2_Click(object sender, EventArgs e)
        {
            if (kocka == 6 && igra.igraci[2].pijuni[1].TrenutnaLokacija == -1)
            {
                int x = igra.igraci[2].pijuni[1].TrenutnaLokacija = 26;
                pbZeleni2.Location = new Point(polje.Tabla[x].Left, polje.Tabla[x].Top);
                kocka = 0;
            }
            else if (igra.igraci[2].pijuni[1].TrenutnaLokacija != -1 && kocka != 0 && kocka != 0)
            {
                int x = igra.igraci[2].pijuni[1].TrenutnaLokacija += kocka;
                if (x > 51)
                {
                    x -= 52;
                    igra.igraci[2].pijuni[1].TrenutnaLokacija = x;
                }
                pbZeleni2.Location = new Point(polje.Tabla[x].Left, polje.Tabla[x].Top);
                kocka = 0;
                IgraZuti();
            }         
        }
        private void pbZeleni3_Click(object sender, EventArgs e)
        {
            if (kocka == 6 && igra.igraci[2].pijuni[2].TrenutnaLokacija == -1)
            {
                int x = igra.igraci[2].pijuni[2].TrenutnaLokacija = 26;
                pbZeleni3.Location = new Point(polje.Tabla[x].Left, polje.Tabla[x].Top);
                kocka = 0;
            }
            else if (igra.igraci[2].pijuni[2].TrenutnaLokacija != -1 && kocka != 0)
            {
                int x = igra.igraci[2].pijuni[2].TrenutnaLokacija += kocka;
                if (x > 51)
                {
                    x -= 52;
                    igra.igraci[2].pijuni[2].TrenutnaLokacija = x;
                }
                pbZeleni3.Location = new Point(polje.Tabla[x].Left, polje.Tabla[x].Top);
                kocka = 0;
                IgraZuti();
            }
        }
        private void pbZeleni4_Click(object sender, EventArgs e)
        {
            if (kocka == 6 && igra.igraci[2].pijuni[3].TrenutnaLokacija == -1)
            {
                int x = igra.igraci[2].pijuni[3].TrenutnaLokacija = 26;
                pbZeleni4.Location = new Point(polje.Tabla[x].Left, polje.Tabla[x].Top);
                kocka = 0;
            }
            else if (igra.igraci[2].pijuni[3].TrenutnaLokacija != -1 && kocka != 0)
            {
                int x = igra.igraci[2].pijuni[3].TrenutnaLokacija += kocka;
                if (x > 51)
                {
                    x -= 52;
                    igra.igraci[2].pijuni[3].TrenutnaLokacija = x;
                }
                pbZeleni4.Location = new Point(polje.Tabla[x].Left, polje.Tabla[x].Top);
                kocka = 0;
                IgraZuti();
            }
        }
        private void pbZuti1_Click(object sender, EventArgs e)
        {
            if (kocka == 6 && igra.igraci[3].pijuni[0].TrenutnaLokacija == -1)
            {
                int x = igra.igraci[3].pijuni[0].TrenutnaLokacija = 39;
                pbZuti1.Location = new Point(polje.Tabla[x].Left, polje.Tabla[x].Top);
                kocka = 0;
            }
            else if (igra.igraci[3].pijuni[0].TrenutnaLokacija != -1 && kocka != 0)
            {
                int x = igra.igraci[3].pijuni[0].TrenutnaLokacija += kocka;
                if (x > 51)
                {
                    x -= 52;
                    igra.igraci[3].pijuni[0].TrenutnaLokacija = x;
                }
                pbZuti1.Location = new Point(polje.Tabla[x].Left, polje.Tabla[x].Top);
                kocka = 0;
                IgraPlavi();
            }           
        }
        private void pbZuti2_Click(object sender, EventArgs e)
        {
            if (kocka == 6 && igra.igraci[3].pijuni[1].TrenutnaLokacija == -1)
            {
                int x = igra.igraci[3].pijuni[1].TrenutnaLokacija = 39;
                pbZuti2.Location = new Point(polje.Tabla[x].Left, polje.Tabla[x].Top);
                kocka = 0;
            }
            else if (igra.igraci[3].pijuni[1].TrenutnaLokacija != -1 && kocka != 0)
            {
                int x = igra.igraci[3].pijuni[1].TrenutnaLokacija += kocka;
                if (x > 51)
                {
                    x -= 52;
                    igra.igraci[3].pijuni[1].TrenutnaLokacija = x;
                }
                pbZuti2.Location = new Point(polje.Tabla[x].Left, polje.Tabla[x].Top);
                kocka = 0;
                IgraPlavi();
            }
        }

        private void pbZuti3_Click(object sender, EventArgs e)
        {
            if (kocka == 6 && igra.igraci[3].pijuni[2].TrenutnaLokacija == -1)
            {
                int x = igra.igraci[3].pijuni[2].TrenutnaLokacija = 39;
                pbZuti3.Location = new Point(polje.Tabla[x].Left, polje.Tabla[x].Top);
                kocka = 0;
            }
            else if (igra.igraci[3].pijuni[2].TrenutnaLokacija != -1 && kocka != 0)
            {
                int x = igra.igraci[3].pijuni[2].TrenutnaLokacija += kocka;
                if (x > 51)
                {
                    x -= 52;
                    igra.igraci[3].pijuni[2].TrenutnaLokacija = x;
                }
                pbZuti3.Location = new Point(polje.Tabla[x].Left, polje.Tabla[x].Top);
                kocka = 0;
                IgraPlavi();
            }
        }

        private void pbZuti4_Click(object sender, EventArgs e)
        {
            if (kocka == 6 && igra.igraci[3].pijuni[3].TrenutnaLokacija == -1)
            {
                int x = igra.igraci[3].pijuni[3].TrenutnaLokacija = 39;
                pbZuti4.Location = new Point(polje.Tabla[x].Left, polje.Tabla[x].Top);
                kocka = 0;
            }
            else if (igra.igraci[3].pijuni[3].TrenutnaLokacija != -1 && kocka!=0)
            {
                int x = igra.igraci[3].pijuni[3].TrenutnaLokacija += kocka;
                if (x > 51)
                {
                    x -= 52;
                    igra.igraci[3].pijuni[3].TrenutnaLokacija = x;
                }
                pbZuti4.Location = new Point(polje.Tabla[x].Left, polje.Tabla[x].Top);
                kocka = 0;
                IgraPlavi();
            }
        }
    }
}