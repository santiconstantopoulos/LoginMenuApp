namespace W7FormAppTest
{
    public partial class LoginScreen : Form
    {

        private String testUser = "admin";
        private String testPass = "admin";


        public LoginScreen()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UserInputField.Focus();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            var username = UserInputField.Text;
            var password = PasswordInputField.Text;

            if (testUser == username && testPass == password)
            {
                MessageBox.Show("Inisión sesiada correctamente");
                AppMenuScreen AppMenuScreen = new();
                AppMenuScreen.Show();
                this.Hide();
                
            } else {            
                MessageBox.Show("Usuario y/o contraseña incorrectos", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                UserInputField.Clear();
                PasswordInputField.Clear();
                UserInputField.Focus();
            }
        }

        private void UserInputField_TextChanged(object sender, EventArgs e)
        {

        }

        private void SubmitButton_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SubmitButton.PerformClick();
            }
        }
    }
}