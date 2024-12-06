using Grpc.Core;
using Server;

namespace Server.Services
{
    public class GreeterService : Greeter.GreeterBase
    {
        private readonly ILogger<GreeterService> _logger;
        public GreeterService(ILogger<GreeterService> logger)
        {
            _logger = logger;
        }

        public override Task<HelloReply> SayHello(HelloRequest request, ServerCallContext context)
        {
            return Task.FromResult(new HelloReply
            {
                Text = "Hello World"
            });
        }

        public override Task<TimeReply> GetTime(TimeRequest request, ServerCallContext context)
        {
            var hour = DateTime.Now.Hour;
            var minute = DateTime.Now.Minute;
            var second = DateTime.Now.Second;

            TimeReply output = new TimeReply();

            output.Hour = hour;
            output.Minute = minute;
            output.Second = second;

            return Task.FromResult(output);
        }
    }
}
