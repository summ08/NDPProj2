/****************************************************************************
**					SAKARYA ÜNÝVERSÝTESÝ
**		 BÝLGÝSAYAR VE BÝLÝÞÝM BÝLÝMLERÝ FAKÜLTESÝ
**				BÝLGÝSAYAR MÜHENDÝSLÝÐÝ BÖLÜMÜ
**			 NESNEYE DAYALI PROGRAMLAMA DERSÝ
**				2021-2022 BAHAR DÖNEMÝ
**	
**				ÖDEV NUMARASI..........: Homework 2 
**				ÖÐRENCÝ ADI............: Sümeyye Üstün
**				ÖÐRENCÝ NUMARASI.......: B211210065
**              DERSÝN ALINDIÐI GRUP...: 1B
****************************************************************************/









namespace ndpOdev2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Label yazý = new Label();
        TextBox inp = new TextBox();

        Label outp = new Label();
        string donustur(int sayi)
        {
            
            int xbinler, binler, yuzler, onlar, birler;
            bool binVar = false;
            string xbin = "";
            string bin = "";
            string on = "";
            string yuz = "";
            string bir = "";

            birler = sayi % 10;

            onlar = (sayi % 100) - birler;

            yuzler = (sayi % 1000) - (onlar + birler);

            binler = (sayi %10000)/ 1000;

            xbinler = sayi / 10000;



                switch (xbinler)
                {


                    case 9: xbin = "doksan "; binVar = true; break;
                    case 8: xbin = "seksen "; binVar = true; break;
                    case 7: xbin = "yetmiþ "; binVar = true; break;
                    case 6: xbin = "altmýþ "; binVar = true; break;
                    case 5: xbin = "elli "; binVar = true; break;
                    case 4: xbin = "kýrk "; binVar = true; break;
                    case 3: xbin = "otuz "; binVar = true; break;
                    case 2: xbin = "yirmi "; binVar = true; break;
                    case 1: xbin = "on "; binVar = true; break;

                }






            switch (binler)
            {

                case 9: bin = "dokuz "; binVar = true; break;
                case 8: bin = "sekiz "; binVar = true; break;
                case 7: bin = "yedi "; binVar = true; break;
                case 6: bin = "altý "; binVar = true; break;
                case 5: bin = "beþ "; binVar = true; break;
                case 4: bin = "dört "; binVar = true; break;
                case 3: bin = "üç "; binVar = true; break;
                case 2: bin = "iki "; binVar = true; break;
                case 1: bin = "bin"; break;

            }




            switch (yuzler)
            {

                case 900: yuz = "dokuz yüz"; break;
                case 800: yuz = "sekiz yüz"; break;
                case 700: yuz = "yedi yüz"; break;
                case 600: yuz = "altý yüz"; break;
                case 500: yuz = "beþ yüz"; break;
                case 400: yuz = "dört yüz"; break;
                case 300: yuz = "üç yüz"; break;
                case 200: yuz = "ikiyüz"; break;
                case 100: yuz = "yüz"; break;

            }



            switch (onlar)
            {

                case 90: on = "doksan"; break;
                case 80: on = "seksen"; break;
                case 70: on = "yetmiþ"; break;
                case 60: on = "altmýþ"; break;
                case 50: on = "elli"; break;
                case 40: on = "kýrk"; break;
                case 30: on = "otuz"; break;
                case 20: on = "yirmi"; break;
                case 10: on = "on"; break;

            }

            switch (birler)

            {

                case 9: bir = "dokuz"; break;
                case 8: bir = "sekiz"; break;
                case 7: bir = "yedi"; break;
                case 6: bir = "altý"; break;
                case 5: bir = "beþ"; break;
                case 4: bir = "dört"; break;
                case 3: bir = "üç"; break;
                case 2: bir = "iki"; break;
                case 1: bir = "bir"; break;



            }
            string ybin = "";
            if (binVar)
            {
                ybin = " bin";

            }
            string yazi = xbin + " " + bin + " " + ybin + " " + yuz + " " + on + " " + bir;
            return yazi;
            
        }




        private void Form1_Load(object sender, EventArgs e)
        {

            Size = new Size(1600, 500);



            yazý.Text = "Fatura Tutarý:";
            yazý.AutoSize = true;
            yazý.ForeColor = Color.Black;
            yazý.Font = new Font("Arial", 15, FontStyle.Bold);
            yazý.Location = new Point(100, 70);
            this.Controls.Add(yazý);



            Label yazý1 = new Label();
            yazý1.Text = "Fatura Tutarý (Yazýyla):";
            yazý1.AutoSize = true;
            yazý1.ForeColor = Color.Black;
            yazý1.Font = new Font("Arial", 15, FontStyle.Bold);
            yazý1.Location = new Point(100, 200);
            this.Controls.Add(yazý1);


            outp.Text = " ";
            outp.AutoSize = true;
            outp.Name = "outYazý";
            outp.ForeColor = Color.Black;
            outp.Font = new Font("Arial", 15, FontStyle.Bold);
            outp.Location = new Point(400, 200);
            this.Controls.Add(outp);

            Button buton1 = new Button();
            buton1.Name = "btn";
            buton1.ForeColor = Color.Black;
            buton1.AutoSize = true;
            buton1.Location = new Point(300, 135);
            buton1.Text = "OKU";
            buton1.Font = new Font("Arial", 15);
            buton1.Click += new EventHandler(Ftrhsb_Click);
            this.Controls.Add(buton1);




            inp.AutoSize = true;
            inp.Name = "inpSayý";
            inp.ForeColor = Color.Black;
            inp.Font = new Font("Arial", 10, FontStyle.Bold);
            inp.Location = new Point(300, 70);
            this.Controls.Add(inp);



        }
        private void Ftrhsb_Click(object sender, EventArgs e)
        {
            bool nokta=false;
            string sonuc;
        foreach (char b in inp.Text)
            {
                if (b == '.') 
                    nokta = true;
            }

            if (nokta)
            {

                string lira = inp.Text.Substring(0, inp.Text.IndexOf('.'));
                string kurus = inp.Text.Substring(inp.Text.IndexOf('.') + 1, 2);

                sonuc = donustur(Convert.ToInt32(lira)) + "  Lira"+ donustur(Convert.ToInt32(kurus)) + "  Kuruþ";
            }
            else
            {
                sonuc = donustur(Convert.ToInt32(inp.Text)) + "  Lira";
            }


   

           
            outp.Text = sonuc;


        }
    }
}