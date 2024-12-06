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
                Message = "Hello " + request.Name
            });
        }

        public override Task<TimeReply> GetTime(TimeRequest request, ServerCallContext context)
        {
            TimeReply output = new TimeReply();

            output.Hour = 9;
            output.Minute = 35;
            output.Second = 10;

            return Task.FromResult(output);
        }
    }
}
