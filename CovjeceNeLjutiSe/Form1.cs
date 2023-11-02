using Data;
using Microsoft.VisualBasic;

namespace CovjeceNeLjutiSe
{
    public partial class Form1 : Form
    {
        Igra igra = new Igra();
        Igrac igrac1 = new Igrac(0);
        Igrac igrac2 = new Igrac(1);
        Igrac igrac3 = new Igrac(2);
        Igrac igrac4 = new Igrac(3);

        List<PictureBox> pictureBoxes = new List<PictureBox>();




        Pijun pijun1 = new Pijun() { DefaultnaLokacija = new Lokacija(62, 396), Id = 0, UKucici = false, TrenutnaLokacija = -1 };
        Pijun pijun2 = new Pijun() { DefaultnaLokacija = new Lokacija(140, 396), Id = 1, UKucici = false, TrenutnaLokacija = -1 };
        Pijun pijun3 = new Pijun() { DefaultnaLokacija = new Lokacija(62, 473), Id = 2, UKucici = false, TrenutnaLokacija = -1 };
        Pijun pijun4 = new Pijun() { DefaultnaLokacija = new Lokacija(140, 473), Id = 3, UKucici = false, TrenutnaLokacija = -1 };
        Pijun pijun5 = new Pijun() { DefaultnaLokacija = new Lokacija(62, 55), Id = 0, UKucici = false, TrenutnaLokacija = -1 };
        Pijun pijun6 = new Pijun() { DefaultnaLokacija = new Lokacija(140, 55), Id = 1, UKucici = false, TrenutnaLokacija = -1 };
        Pijun pijun7 = new Pijun() { DefaultnaLokacija = new Lokacija(62, 132), Id = 2, UKucici = false, TrenutnaLokacija = -1 };
        Pijun pijun8 = new Pijun() { DefaultnaLokacija = new Lokacija(140, 132), Id = 3, UKucici = false, TrenutnaLokacija = -1 };
        Pijun pijun9 = new Pijun() { DefaultnaLokacija = new Lokacija(418, 55), Id = 0, UKucici = false, TrenutnaLokacija = -1 };
        Pijun pijun10 = new Pijun() { DefaultnaLokacija = new Lokacija(496, 55), Id = 1, UKucici = false, TrenutnaLokacija = -1 };
        Pijun pijun11 = new Pijun() { DefaultnaLokacija = new Lokacija(418, 132), Id = 2, UKucici = false, TrenutnaLokacija = -1 };
        Pijun pijun12 = new Pijun() { DefaultnaLokacija = new Lokacija(496, 132), Id = 3, UKucici = false, TrenutnaLokacija = -1 };
        Pijun pijun13 = new Pijun() { DefaultnaLokacija = new Lokacija(418, 396), Id = 0, UKucici = false, TrenutnaLokacija = -1 };
        Pijun pijun14 = new Pijun() { DefaultnaLokacija = new Lokacija(496, 396), Id = 1, UKucici = false, TrenutnaLokacija = -1 };
        Pijun pijun15 = new Pijun() { DefaultnaLokacija = new Lokacija(418, 473), Id = 2, UKucici = false, TrenutnaLokacija = -1 };
        Pijun pijun16 = new Pijun() { DefaultnaLokacija = new Lokacija(496, 473), Id = 3, UKucici = false, TrenutnaLokacija = -1 };

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

            pictureBoxes.Add(pbPlavi1);
            pictureBoxes.Add(pbPlavi2);
            pictureBoxes.Add(pbPlavi3);
            pictureBoxes.Add(pbPlavi4);
            pictureBoxes.Add(pbCrveni1);
            pictureBoxes.Add(pbCrveni2);
            pictureBoxes.Add(pbCrveni3);
            pictureBoxes.Add(pbCrveni4);
            pictureBoxes.Add(pbZeleni1);
            pictureBoxes.Add(pbZeleni2);
            pictureBoxes.Add(pbZeleni3);
            pictureBoxes.Add(pbZeleni4);
            pictureBoxes.Add(pbZuti1);
            pictureBoxes.Add(pbZuti2);
            pictureBoxes.Add(pbZuti3);
            pictureBoxes.Add(pbZuti4);

            IgraSljedeci(naPotezu);

        }

        int kocka = 0;
        int naPotezu = 0;
        int brojBacanja = 0;


        private void IgraSljedeci(int naPotezu)
        {
            
            btnBroj.Text = "X";
            if (naPotezu == 4)
                naPotezu = 0;
            ProvjeriPobijedu(naPotezu);
            brojBacanja = 0;
            kocka = 0;
            switch (naPotezu)
            {
                case 0: IgraPlavi(); break;
                case 1: IgraCrveni(); break;
                case 2: IgraZeleni(); break;
                case 3: IgraZuti(); break;
            }
        }

        private void ProvjeriPobijedu(int igracID)
        {
            int uslov = 0;
            for(int i=0; i<4; i++)
            {
                if (igra.igraci[igracID].pijuni[i].UKucici)
                    uslov++;
            }
            if(uslov == 4)
            {
                if(uslov == 0)
                    MessageBox.Show("Plavi je pobijedio.");
                if (uslov == 1)
                    MessageBox.Show("Crveni je pobijedio.");
                if (uslov == 2)
                    MessageBox.Show("Zeleni je pobijedio.");
                if (uslov == 3)
                    MessageBox.Show("Zuti je pobijedio.");
                Restartuj();
            }
        }

        private void UgasiKontrole()
        {

            pbPlavi1.Enabled = false;
            pbPlavi2.Enabled = false;
            pbPlavi3.Enabled = false;
            pbPlavi4.Enabled = false;

            pbCrveni1.Enabled = false;
            pbCrveni2.Enabled = false;
            pbCrveni3.Enabled = false;
            pbCrveni4.Enabled = false;

            pbZeleni1.Enabled = false;
            pbZeleni2.Enabled = false;
            pbZeleni3.Enabled = false;
            pbZeleni4.Enabled = false;

            pbZuti1.Enabled = false;
            pbZuti2.Enabled = false;
            pbZuti3.Enabled = false;
            pbZuti4.Enabled = false;
        }
        private void IgraPlavi()
        {
            UgasiKontrole();
            if (!igra.igraci[0].pijuni[0].UKucici)
                pbPlavi1.Enabled = true;
            if (!igra.igraci[0].pijuni[1].UKucici)
                pbPlavi2.Enabled = true;
            if (!igra.igraci[0].pijuni[2].UKucici)
                pbPlavi3.Enabled = true;
            if (!igra.igraci[0].pijuni[3].UKucici)
                pbPlavi4.Enabled = true;

            btnKocka.Enabled = true;
            btnNaPotezu.Text = "Igra: Plavi";
        }
        private void IgraCrveni()
        {
            UgasiKontrole();

            if (!igra.igraci[1].pijuni[0].UKucici)
                pbCrveni1.Enabled = true;
            if (!igra.igraci[1].pijuni[1].UKucici)
                pbCrveni2.Enabled = true;
            if (!igra.igraci[1].pijuni[2].UKucici)
                pbCrveni3.Enabled = true;
            if (!igra.igraci[1].pijuni[3].UKucici)
                pbCrveni4.Enabled = true;

            btnKocka.Enabled = true;
            btnNaPotezu.Text = "Igra: Crveni";
        }
        private void IgraZeleni()
        {
            UgasiKontrole();

            if (!igra.igraci[2].pijuni[0].UKucici)
                pbZeleni1.Enabled = true;
            if (!igra.igraci[2].pijuni[1].UKucici)
                pbZeleni2.Enabled = true;
            if (!igra.igraci[2].pijuni[2].UKucici)
                pbZeleni3.Enabled = true;
            if (!igra.igraci[2].pijuni[3].UKucici)
                pbZeleni4.Enabled = true;

            btnKocka.Enabled = true;
            btnNaPotezu.Text = "Igra: Zeleni";
        }
        private void IgraZuti()
        {
            UgasiKontrole();

            if (!igra.igraci[3].pijuni[0].UKucici)
                pbZuti1.Enabled = true;
            if (!igra.igraci[3].pijuni[1].UKucici)
                pbZuti2.Enabled = true;
            if (!igra.igraci[3].pijuni[2].UKucici)
                pbZuti3.Enabled = true;
            if (!igra.igraci[3].pijuni[3].UKucici)
                pbZuti4.Enabled = true;

            btnKocka.Enabled = true;
            btnNaPotezu.Text = "Igra: Zuti";
        }

        private void btnKocka_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            kocka = rnd.Next(1, 7);
            btnBroj.Text = kocka.ToString();
            brojBacanja++;
            bool uBazi = true;
            for (int i = 0; i < 4; i++)
            {
                //restartuj brojac
                if (naPotezu >= 4)
                    naPotezu = 0;
                // provjeri 
                if (igra.igraci[naPotezu].pijuni[i].TrenutnaLokacija != -1)
                {
                    uBazi = false;
                }
            }

            if (uBazi == false)
            {
                btnKocka.Enabled = false;
            }
            else if (uBazi == true && kocka == 6)
            {
                btnKocka.Enabled = false;
            }
            else if (brojBacanja >= 3 && kocka != 6 && uBazi == true)
            {
                brojBacanja = 0;
                naPotezu++;
                IgraSljedeci(naPotezu);
            }
        }

        private void PomjeriPlave(int lokacija, PictureBox figura, int idPijun)
        {
            if (lokacija == -1 && kocka == 6)
            {
                int x = lokacija = 0;
                figura.Location = new Point(polje.Tabla[x].Left, polje.Tabla[x].Top);
                igra.igraci[0].pijuni[idPijun].TrenutnaLokacija = lokacija;
                kocka = 0;
                btnKocka.Enabled = true;
            }

            else if (lokacija != -1)
            {
                if (lokacija + kocka <= 57)
                {
                    int x = lokacija + kocka;
                    if (lokacija < 51 && x > 50)
                    {
                        int kockaPoslije;
                        kockaPoslije = kocka - (50 - lokacija);
                        lokacija = 51 + kockaPoslije;

                    }
                    else lokacija += kocka;
                    x = lokacija;
                    figura.Location = new Point(polje.Tabla[x].Left, polje.Tabla[x].Top);
                    igra.igraci[0].pijuni[idPijun].TrenutnaLokacija = lokacija;
                    ProvjeriJedeLi(lokacija);
                    if (lokacija == 57)
                        igra.igraci[0].pijuni[idPijun].UKucici = true;
                    if (kocka != 6)
                    {
                        kocka = 0;
                        naPotezu++;
                        IgraSljedeci(naPotezu);
                    }
                    else if (kocka == 6)
                    {
                        btnKocka.Enabled = true;
                    }
                }

                else
                {
                    return;
                }
            }
        }
        private void PomjeriCrvene(int lokacija, PictureBox figura, int idPijun)
        {
            if (lokacija == -1 && kocka == 6)
            {
                int x = lokacija = 13;
                figura.Location = new Point(polje.Tabla[x].Left, polje.Tabla[x].Top);
                igra.igraci[1].pijuni[idPijun].TrenutnaLokacija = lokacija;
                kocka = 0;
                btnKocka.Enabled = true;
            }

            else if (lokacija != -1)
            {
                if (lokacija + kocka <= 63)
                {
                    int x = lokacija + kocka;
                    if (x > 51 && x < 58)
                    {
                        int kockaPoslije;
                        kockaPoslije = kocka - (51 - lokacija);
                        lokacija = 0 + kockaPoslije - 1;
                    }
                    else if (lokacija < 12 && lokacija > 5 && x > 11)
                    {
                        int kockaPoslije;
                        kockaPoslije = kocka - (11 - lokacija);
                        lokacija = 57 + kockaPoslije;

                    }
                    else lokacija += kocka;
                    x = lokacija;
                    figura.Location = new Point(polje.Tabla[x].Left, polje.Tabla[x].Top);
                    igra.igraci[1].pijuni[idPijun].TrenutnaLokacija = lokacija;
                    ProvjeriJedeLi(lokacija);
                    if (lokacija == 63)
                        igra.igraci[1].pijuni[idPijun].UKucici = true;
                    if (kocka != 6)
                    {
                        kocka = 0;
                        naPotezu++;
                        IgraSljedeci(naPotezu);
                    }
                    else if (kocka == 6)
                    {
                        btnKocka.Enabled = true;
                    }
                }
                else
                {
                    return;
                }
            }
        }
        private void PomjeriZelene(int lokacija, PictureBox figura, int idPijun)
        {
            if (lokacija == -1 && kocka == 6)
            {
                int x = lokacija = 26;
                figura.Location = new Point(polje.Tabla[x].Left, polje.Tabla[x].Top);
                igra.igraci[2].pijuni[idPijun].TrenutnaLokacija = lokacija;
                kocka = 0;
                btnKocka.Enabled = true;
            }

            else if (lokacija != -1)
            {
                if (lokacija + kocka <= 69)
                {
                    int x = lokacija + kocka;
                    if (x > 51 && x < 58)
                    {
                        int kockaPoslije;
                        kockaPoslije = kocka - (51 - lokacija);
                        lokacija = 0 + kockaPoslije - 1;
                    }
                    else if (lokacija < 25 && lokacija > 18 && x > 24)
                    {
                        int kockaPoslije;
                        kockaPoslije = kocka - (24 - lokacija);
                        lokacija = 63 + kockaPoslije;

                    }
                    else lokacija += kocka;
                    x = lokacija;
                    figura.Location = new Point(polje.Tabla[x].Left, polje.Tabla[x].Top);
                    igra.igraci[2].pijuni[idPijun].TrenutnaLokacija = lokacija;
                    ProvjeriJedeLi(lokacija);
                    if (lokacija == 69)
                        igra.igraci[2].pijuni[idPijun].UKucici = true;
                    if (kocka != 6)
                    {
                        kocka = 0;
                        naPotezu++;
                        IgraSljedeci(naPotezu);
                    }
                    else if (kocka == 6)
                    {
                        btnKocka.Enabled = true;
                    }
                }
                else
                {
                    return;
                }
            }
        }
        private void PomjeriZute(int lokacija, PictureBox figura, int idPijun)
        {
            if (lokacija == -1 && kocka == 6)
            {
                int x = lokacija = 39;
                figura.Location = new Point(polje.Tabla[x].Left, polje.Tabla[x].Top);
                igra.igraci[3].pijuni[idPijun].TrenutnaLokacija = lokacija;
                kocka = 0;
                btnKocka.Enabled = true;
            }

            else if (lokacija != -1)
            {
                if (lokacija + kocka <= 75)
                {
                    int x = lokacija + kocka;
                    if (x > 51 && x < 58)
                    {
                        int kockaPoslije;
                        kockaPoslije = kocka - (51 - lokacija);
                        lokacija = 0 + kockaPoslije - 1;
                    }
                    else if (lokacija < 38 && lokacija > 31 && x > 37)
                    {
                        int kockaPoslije;
                        kockaPoslije = kocka - (37 - lokacija);
                        lokacija = 69 + kockaPoslije;

                    }
                    else lokacija += kocka;
                    x = lokacija;
                    figura.Location = new Point(polje.Tabla[x].Left, polje.Tabla[x].Top);
                    igra.igraci[3].pijuni[idPijun].TrenutnaLokacija = lokacija;
                    ProvjeriJedeLi(lokacija);
                    if (lokacija == 75)
                        igra.igraci[3].pijuni[idPijun].UKucici = true;
                    if (kocka != 6)
                    {
                        kocka = 0;
                        naPotezu++;
                        IgraSljedeci(naPotezu);
                    }
                    else if (kocka == 6)
                    {
                        btnKocka.Enabled = true;
                    }
                }
                else
                {
                    return;
                }
            }
        }

        private void ProvjeriJedeLi(int lokacija)
        {
            for (int i = 0; i < 4; i++)
            {
                if (naPotezu != i)
                    for (int j = 0; j < 4; j++)
                    {
                        if (igra.igraci[i].pijuni[j].TrenutnaLokacija == lokacija)
                            Jede(i, j);
                    }
            }
        }
        private void Jede(int igracID, int pijunID)
        {
            igra.igraci[igracID].pijuni[pijunID].TrenutnaLokacija = -1;
            int left = igra.igraci[igracID].pijuni[pijunID].DefaultnaLokacija.Left;
            int top = igra.igraci[igracID].pijuni[pijunID].DefaultnaLokacija.Top;
            pictureBoxes[4 * igracID + pijunID].Location = new Point(left, top);
        }
        // Plavi
        private void pbPlavi1_Click(object sender, EventArgs e)
        {
            PomjeriPlave(igra.igraci[0].pijuni[0].TrenutnaLokacija, pbPlavi1, 0);
        }
        private void pbPlavi2_Click(object sender, EventArgs e)
        {
            PomjeriPlave(igra.igraci[0].pijuni[1].TrenutnaLokacija, pbPlavi2, 1);
        }
        private void pbPlavi3_Click(object sender, EventArgs e)
        {
            PomjeriPlave(igra.igraci[0].pijuni[2].TrenutnaLokacija, pbPlavi3, 2);
        }
        private void pbPlavi4_Click(object sender, EventArgs e)
        {
            PomjeriPlave(igra.igraci[0].pijuni[3].TrenutnaLokacija, pbPlavi4, 3);
        }
        // Crveni
        private void pbCrveni1_Click(object sender, EventArgs e)
        {
            PomjeriCrvene(igra.igraci[1].pijuni[0].TrenutnaLokacija, pbCrveni1, 0);
        }
        private void pbCrveni2_Click(object sender, EventArgs e)
        {
            PomjeriCrvene(igra.igraci[1].pijuni[1].TrenutnaLokacija, pbCrveni2, 1);
        }
        private void pbCrveni3_Click(object sender, EventArgs e)
        {
            PomjeriCrvene(igra.igraci[1].pijuni[2].TrenutnaLokacija, pbCrveni3, 2);
        }
        private void pbCrveni4_Click(object sender, EventArgs e)
        {
            PomjeriCrvene(igra.igraci[1].pijuni[3].TrenutnaLokacija, pbCrveni4, 3);
        }
        // Zeleni
        private void pbZeleni1_Click(object sender, EventArgs e)
        {
            PomjeriZelene(igra.igraci[2].pijuni[0].TrenutnaLokacija, pbZeleni1, 0);
        }
        private void pbZeleni2_Click(object sender, EventArgs e)
        {
            PomjeriZelene(igra.igraci[2].pijuni[1].TrenutnaLokacija, pbZeleni2, 1);
        }
        private void pbZeleni3_Click(object sender, EventArgs e)
        {
            PomjeriZelene(igra.igraci[2].pijuni[2].TrenutnaLokacija, pbZeleni3, 2);
        }
        private void pbZeleni4_Click(object sender, EventArgs e)
        {
            PomjeriZelene(igra.igraci[2].pijuni[3].TrenutnaLokacija, pbZeleni4, 3);
        }
        // Zuti
        private void pbZuti1_Click(object sender, EventArgs e)
        {
            PomjeriZute(igra.igraci[3].pijuni[0].TrenutnaLokacija, pbZuti1, 0);
        }
        private void pbZuti2_Click(object sender, EventArgs e)
        {
            PomjeriZute(igra.igraci[3].pijuni[1].TrenutnaLokacija, pbZuti2, 1);
        }
        private void pbZuti3_Click(object sender, EventArgs e)
        {
            PomjeriZute(igra.igraci[3].pijuni[2].TrenutnaLokacija, pbZuti3, 2);
        }
        private void pbZuti4_Click(object sender, EventArgs e)
        {
            PomjeriZute(igra.igraci[3].pijuni[3].TrenutnaLokacija, pbZuti4, 3);
        }

        private void btnSkip_Click(object sender, EventArgs e)
        {
            naPotezu++;
            if (naPotezu > 3) naPotezu = 0;
            IgraSljedeci(naPotezu);
        }

        private void Restartuj()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    igra.igraci[i].pijuni[j].TrenutnaLokacija = -1;
                    igra.igraci[i].pijuni[j].UKucici = false;
                    int left = igra.igraci[i].pijuni[j].DefaultnaLokacija.Left;
                    int top = igra.igraci[i].pijuni[j].DefaultnaLokacija.Top;
                    pictureBoxes[4 * i + j].Location = new Point(left, top);
                }
            }
            kocka = 0;
            naPotezu = 0;
            brojBacanja = 0;
            IgraSljedeci(naPotezu);
        }
        private void btnRestart_Click(object sender, EventArgs e)
        {
            Restartuj();
        }
    }
}