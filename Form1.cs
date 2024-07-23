using InstagramApiSharp.API;
using InstagramApiSharp.API.Builder;
using InstagramApiSharp.Classes;
using InstagramApiSharp.Logger;

namespace Instagram_Common_followers
{
    public partial class Form1 : Form
    {
        private static UserSessionData user;
        private static IInstaApi api;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {

            user = new UserSessionData();
            user.UserName = Username.Text;
            user.Password = Password.Text;
            api = InstaApiBuilder.CreateBuilder()
                .SetUser(user).UseLogger(new DebugLogger(LogLevel.All))
                .SetRequestDelay(RequestDelay.FromSeconds(0, 1))
                .Build();


            var login = await api.LoginAsync();
            if (!login.Succeeded)
                

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
