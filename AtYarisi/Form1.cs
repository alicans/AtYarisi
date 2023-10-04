namespace AtYarisi
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        int sayac = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;

            // Atlar�n ilerletilmesi.
            at1.Left += rnd.Next(1, 6);
            at2.Left += rnd.Next(1, 6);
            at3.Left += rnd.Next(1, 6);

            // EN �NDEK� ATIN BEL�RLENMES�
            PictureBox ondeki = at1;
            if (at2.Left > ondeki.Left) ondeki = at2;
            if (at3.Left > ondeki.Left) ondeki = at3;
            if (sayac > 10)
                lblDurum.Text = ondeki.Tag + " no'lu at yar��� �nde s�rd�r�yor..";

            // Yar���n bitirilmesi.
            if (ondeki.Right > bitis.Left)
            {
                timer1.Stop();
                lblDurum.Text = "Yar�� bitti. " + ondeki.Tag + " no'lu at yar��� kazand�.";
                label1.Text = "KAZANAN\n" + ondeki.Tag + " numara!";
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnBaslat_Click(object sender, EventArgs e)
        {
            if (btnBaslat.Text == "BA�LAT")
            {
                timer1.Start();
                lblDurum.Text = "ve yar�� ba�lad�..";
                btnBaslat.Text = "YEN� YARI�";
                label1.Text = "";
            }
            else
            {
                timer1.Stop();
                at1.Left = at2.Left = at3.Left = 0;
                btnBaslat.Text = "BA�LAT";
                lblDurum.Text = "Atlar yar��a haz�r.";
                sayac = 0;
                label1.Text = "";

            }

        }
    }
}