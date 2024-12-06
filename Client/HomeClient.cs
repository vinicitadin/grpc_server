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
            string name = tbName.Text;
            var input = new HelloRequest { Name = name };

            var channel = GrpcChannel.ForAddress("https://localhost:7044/");
            var client = new Greeter.GreeterClient(channel);

            var reply = await client.SayHelloAsync(input);

            Console.WriteLine(reply);
        }

        private async void btnTime_Click(object sender, EventArgs e)
        {
            string name = tbName.Text;
            var input = new TimeRequest { Name = name };

            var channel = GrpcChannel.ForAddress("https://localhost:7044/");
            var client = new Time.TimeClient(channel);

            var reply = await client.GetTimeAsync(input);

            Console.WriteLine(reply);
        }
    }
}
