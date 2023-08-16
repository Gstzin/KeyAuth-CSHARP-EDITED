using KeyAuth; // Make sure to include the appropriate KeyAuth namespace
using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Keyauth.Others
{
    public partial class Register : Form
    {
        public static api KeyAuthApp = new api(
           name: "Bypass",
           ownerid: "RmsL08C9Z9",
           secret: "63e36a8511683630c93baa87f5f233c8f5804ad469f9249820cdf3591ef0672c",
           version: "1.0"
       );

        public Register()
        {
            InitializeComponent();
            KeyAuthApp.init();
        }

        private async void siticoneButton1_Click(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                KeyAuthApp.register(user.Text, pass.Text, key.Text);
                if (KeyAuthApp.response.success)
                {

                    {
                        {

                            {
                            };
                        }
                    };
                    MessageBox.Show("Successfully Registred!");
                    Main main = new Main();
                    main.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show(KeyAuthApp.response.message);
                }
            });
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string url = "https://github.com/Gstzin";

            try
            {
                Process.Start(url);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void siticoneCircleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
            Application.ExitThread();
        }

        private void siticoneCircleButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
