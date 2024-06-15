/****************************************************************************
**					SAKARYA �N�VERS�TES�
**		 B�LG�SAYAR VE B�L���M B�L�MLER� FAK�LTES�
**				B�LG�SAYAR M�HEND�SL��� B�L�M�
**			 NESNEYE DAYALI PROGRAMLAMA DERS�
**				2021-2022 BAHAR D�NEM�
**	
**				�DEV NUMARASI..........: Homework 2 
**				��RENC� ADI............: S�meyye �st�n
**				��RENC� NUMARASI.......: B211210065
**              DERS�N ALINDI�I GRUP...: 1B
****************************************************************************/









namespace ndpOdev2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Label yaz� = new Label();
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
                    case 7: xbin = "yetmi� "; binVar = true; break;
                    case 6: xbin = "altm�� "; binVar = true; break;
                    case 5: xbin = "elli "; binVar = true; break;
                    case 4: xbin = "k�rk "; binVar = true; break;
                    case 3: xbin = "otuz "; binVar = true; break;
                    case 2: xbin = "yirmi "; binVar = true; break;
                    case 1: xbin = "on "; binVar = true; break;

                }






            switch (binler)
            {

                case 9: bin = "dokuz "; binVar = true; break;
                case 8: bin = "sekiz "; binVar = true; break;
                case 7: bin = "yedi "; binVar = true; break;
                case 6: bin = "alt� "; binVar = true; break;
                case 5: bin = "be� "; binVar = true; break;
                case 4: bin = "d�rt "; binVar = true; break;
                case 3: bin = "�� "; binVar = true; break;
                case 2: bin = "iki "; binVar = true; break;
                case 1: bin = "bin"; break;

            }




            switch (yuzler)
            {

                case 900: yuz = "dokuz y�z"; break;
                case 800: yuz = "sekiz y�z"; break;
                case 700: yuz = "yedi y�z"; break;
                case 600: yuz = "alt� y�z"; break;
                case 500: yuz = "be� y�z"; break;
                case 400: yuz = "d�rt y�z"; break;
                case 300: yuz = "�� y�z"; break;
                case 200: yuz = "ikiy�z"; break;
                case 100: yuz = "y�z"; break;

            }



            switch (onlar)
            {

                case 90: on = "doksan"; break;
                case 80: on = "seksen"; break;
                case 70: on = "yetmi�"; break;
                case 60: on = "altm��"; break;
                case 50: on = "elli"; break;
                case 40: on = "k�rk"; break;
                case 30: on = "otuz"; break;
                case 20: on = "yirmi"; break;
                case 10: on = "on"; break;

            }

            switch (birler)

            {

                case 9: bir = "dokuz"; break;
                case 8: bir = "sekiz"; break;
                case 7: bir = "yedi"; break;
                case 6: bir = "alt�"; break;
                case 5: bir = "be�"; break;
                case 4: bir = "d�rt"; break;
                case 3: bir = "��"; break;
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



            yaz�.Text = "Fatura Tutar�:";
            yaz�.AutoSize = true;
            yaz�.ForeColor = Color.Black;
            yaz�.Font = new Font("Arial", 15, FontStyle.Bold);
            yaz�.Location = new Point(100, 70);
            this.Controls.Add(yaz�);



            Label yaz�1 = new Label();
            yaz�1.Text = "Fatura Tutar� (Yaz�yla):";
            yaz�1.AutoSize = true;
            yaz�1.ForeColor = Color.Black;
            yaz�1.Font = new Font("Arial", 15, FontStyle.Bold);
            yaz�1.Location = new Point(100, 200);
            this.Controls.Add(yaz�1);


            outp.Text = " ";
            outp.AutoSize = true;
            outp.Name = "outYaz�";
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
            inp.Name = "inpSay�";
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

                sonuc = donustur(Convert.ToInt32(lira)) + "  Lira"+ donustur(Convert.ToInt32(kurus)) + "  Kuru�";
            }
            else
            {
                sonuc = donustur(Convert.ToInt32(inp.Text)) + "  Lira";
            }


   

           
            outp.Text = sonuc;


        }
    }
}