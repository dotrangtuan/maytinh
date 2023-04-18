namespace WinFormsApp1
{
    public partial class FrmBai1 : Form
    {
        public FrmBai1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnHieu_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnTong_Click(object sender, EventArgs e)
        {

            Console.WriteLine(txtA.Text);
            Console.WriteLine(txtB.Text);
            int tong = int.Parse(txtA.Text) + int.Parse(txtB.Text);
            lblKetQua.Text = tong + "";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {

        }
    }
}