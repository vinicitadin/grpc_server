using Grpc.Net.Client;
using Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class HomeClient : Form
    {

        public HomeClient()
        {
            InitializeComponent();



        }
        private async void btnGreet_Click(object sender, EventArgs e)
        {
            var input = new HelloRequest { Id = 1 };

            var channel = GrpcChannel.ForAddress("https://localhost:7044/");
            var client = new Greeter.GreeterClient(channel);
            var reply = await client.SayHelloAsync(input);

            MessageBox.Show(reply.Message, "Hello world!");
        }

        private async void btnTime_Click(object sender, EventArgs e)
        {
            var input = new TimeRequest { Id = 1 };

            var channel = GrpcChannel.ForAddress("https://localhost:7044/");
            var client = new Greeter.GreeterClient(channel);
            var reply = await client.GetTimeAsync(input);

            MessageBox.Show(reply.Hour + ":" + reply.Minute + ":" + reply.Second, "Horário");
        }
    }
}
