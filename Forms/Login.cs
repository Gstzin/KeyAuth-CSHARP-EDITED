using Keyauth.Others;
using Loader;
using System;
using System.Diagnostics;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyAuth
{
    public partial class Login : Form
    {
        public static api KeyAuthApp = new api(
           name: "",
           ownerid: "",
           secret: "",
           version: ""
       );
        private void ShowResponse(string type)
        {
            //responseTimeLbl.Text = $"It took {api.responseTime} ms to {type}"; // you need to create a label called responseTimeLbl to display to a label.
            MessageBox.Show($"It took {api.responseTime} msg to {type}");
        }

        public Login()
        {
            InitializeComponent();
        }

        private void siticoneControlBox1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        
        public static bool SubExist(string name)
        {
            if(KeyAuthApp.user_data.subscriptions.Exists(x => x.subscription == name))
                return true;
            return false;
        }
        
        private void Login_Load(object sender, EventArgs e)
        {
            KeyAuthApp.init();

            if (KeyAuthApp.response.message == "invalidver")
            {
                if (!string.IsNullOrEmpty(KeyAuthApp.app_data.downloadLink))
                {
                    DialogResult dialogResult = MessageBox.Show("Yes to open file in browser\nNo to download file automatically", "Auto update", MessageBoxButtons.YesNo);
                    switch (dialogResult)
                    {
                        case DialogResult.Yes:
                            Process.Start(KeyAuthApp.app_data.downloadLink);
                            Environment.Exit(0);
                            break;
                        case DialogResult.No:
                            WebClient webClient = new WebClient();
                            string destFile = Application.ExecutablePath;

                            string rand = random_string();

                            destFile = destFile.Replace(".exe", $"-{rand}.exe");
                            webClient.DownloadFile(KeyAuthApp.app_data.downloadLink, destFile);

                            Process.Start(destFile);
                            Process.Start(new ProcessStartInfo()
                            {
                                Arguments = "/C choice /C Y /N /D Y /T 3 & Del \"" + Application.ExecutablePath + "\"",
                                WindowStyle = ProcessWindowStyle.Hidden,
                                CreateNoWindow = true,
                                FileName = "cmd.exe"
                            });
                            Environment.Exit(0);

                            break;
                        default:
                            MessageBox.Show("Invalid option");
                            Environment.Exit(0);
                            break;
                    }
                }
                MessageBox.Show("Version of this program does not match the one online. Furthermore, the download link online isn't set. You will need to manually obtain the download link from the developer");
                Environment.Exit(0);
            }
            
            if (!KeyAuthApp.response.success)
            {
                MessageBox.Show(KeyAuthApp.response.message);
                Environment.Exit(0);
            }
        }

        static string random_string()
        {
            string str = null;

            Random random = new Random();
            for (int i = 0; i < 5; i++)
            {
                str += Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65))).ToString();
            }
            return str;

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

        private async void siticoneButton1_Click(object sender, EventArgs e)
        {
            label3.Visible = false;
            pictureBox1.Visible = false;
            siticonePictureBox2.Visible = false;
            pass.Visible = false;
            user.Visible = false;
            siticoneButton1.Visible = false;
            siticoneCircleButton2.Visible = false;
            siticoneCircleButton1.Visible = false;
            pictureBox2.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            await Task.Run(() =>
            {
                Thread.Sleep(2000);
                KeyAuthApp.login(user.Text, pass.Text);
            });
            if (KeyAuthApp.response.success)
            {
                MessageBox.Show("Successfully Logged!");
                {
                    {
                        {
                        }
                    }
                };
                Main main = new Main();
                main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(KeyAuthApp.response.message);
                label3.Visible = true;
                pictureBox1.Visible = true;
                siticonePictureBox2.Visible = true;
                pass.Visible = true;
                user.Visible = true;
                siticoneButton1.Visible = true;
                siticoneCircleButton2.Visible = true;
                siticoneCircleButton1.Visible = true;
                pictureBox2.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
            }
        }

        private void siticoneCircleButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void siticoneCircleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
            Application.ExitThread();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();
        }
    }
}

