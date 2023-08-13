namespace Büfe_Sinema_Projesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        int kasatutar = 0; // Burada bunu yazmamızın  aşağı yazdııgmız zaman dongu oluyor her hesaplaya bastıgımız zaman 0 değerını atıyor ama burada yazdıgımız zaman kasa tutarını bir kere 0 yapıyor bıdaha alt tarafda karısmmıyor o yuzden  buraya yazdık 
        private void button1_Click(object sender, EventArgs e)
        {
            int misir, cay, su, bilet, toplam;
            misir = Convert.ToInt32(textBox1.Text);
            cay = Convert.ToInt32(textBox2.Text);
            su = Convert.ToInt32(textBox3.Text);
            bilet = Convert.ToInt32(textBox4.Text);

            toplam = misir * 4 + su * 1 + cay * 2 + bilet * 8;

            lbltoplam.Text = toplam.ToString() + " TL";
            kasatutar = kasatutar + toplam;
            lblkasa.Text = kasatutar.ToString() + " TL";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            lbltoplam.Text = 0.ToString() + " TL ";
            textBox1.Focus();


        }
    }
}