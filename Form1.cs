using DersNotKayit.SqlConnectionClass;

namespace DersNotKayit
{
    public partial class Form1 : Form
    {
        private SqlConnectionDataBase sqlConnectionData;
        public Form1()
        {

            InitializeComponent();
            this.sqlConnectionData = new SqlConnectionDataBase();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            
            ogretmen og = this.sqlConnectionData.ogretmenPasswordControl(TcNoTextBox.Text.ToString());
            
            if (og != null)
            {
                if (PasswordTextBox.Text==og.password)
                {
                    dataGridView1.DataSource = this.sqlConnectionData.OgrenciKayitSelect1();
                    label3.Text = "giris yapildi";
                }
                else
                {
                    label3.Text = "sifre yanlis";
                }

            }
            else
            {
                label3.Text = "giris yapilamadi";
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}