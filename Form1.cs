namespace stajornek2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnkayit_Click(object sender, EventArgs e)
        {
            

            if (txtad.Text == "" || txtsoyad.Text == "" || txttelefon.Text == "" || txteposta.Text == "")
            {
                MessageBox.Show("Boþ alan býrakmayýnýz!");

            }

            else {
                lbladsoyad.Text = txtad.Text + " " + txtsoyad.Text;
                lbltelefon.Text = txttelefon.Text;
                lbleposta.Text = txteposta.Text;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtad.Clear();
            txtsoyad.Clear();
            txttelefon.Clear();
            txteposta.Clear();
            
            lbladsoyad.Text=txtad.Text;
            lbleposta.Text = txteposta.Text;
            lbltelefon.Text=txttelefon.Text;

        }
    }
}