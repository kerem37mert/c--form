namespace OtoparkOtomasyonu
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

       

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = "admin";
            string password = "123456";

            if(textBoxUserName.Text != "" && textBoxPassword.Text != "")
            {
                if(textBoxUserName.Text == username && textBoxPassword.Text == password)
                {
                    Home home = new Home();
                    home.Show();
                    Hide();
                }
                else
                {
                    labelLoginResult.Text = "L�tfen bilgilerinizi kontrol ediniz";;
                }
            }
            else
            {
                labelLoginResult.Text = "L�tfen bo� alan b�rakmay�n�z.";
            }

            labelLoginResult.Visible = true;
        }

    }
}