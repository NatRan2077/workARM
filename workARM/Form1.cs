namespace workARM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var PresenterRegistration = new PresenterRegistration();

            string Login = this.textBox1.Text;
            PresenterRegistration.Login = this.textBox1.Text;
            string Password = this.textBox2.Text;

            PresenterRegistration.Password = this.textBox2.Text;
            string filePath = "Users2.json";

            var MainLogicRegistration = new MainLogicRegistration();
            MainLogicRegistration.CheckCredentials(filePath, Login, Password);

            //this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration registration = new Registration();
            registration.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}