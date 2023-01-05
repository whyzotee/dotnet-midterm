namespace TestMid
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = userInput.Text;
            string pass = passInput.Text;
  
            Main mainpage = new Main();
            
            if (user == "")
                MessageBox.Show("User is null!@#!$!");
            else if (pass == "")
                MessageBox.Show("Pass is null!@#!$!");
            else {
                if (user == "admin")
                {
                    if (pass != "12345")
                        MessageBox.Show("Your password wrong!");
                    else {
                        this.Hide();
                        mainpage.ShowDialog();
                        this.Close();
                    }
                }
                else
                    MessageBox.Show("Your username wrong!");
            }
        }
    }
}