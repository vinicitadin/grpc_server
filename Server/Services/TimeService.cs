using Grpc.Core;

namespace Server.Services
{
    public class TimeService : Timer.TimerBase
    {

        private readonly ILogger<TimeService> _logger;

        public TimeService(ILogger<TimeService> logger) 
        {
            _logger = logger;
        }

        public override Task<TimeResponse> GetTime(TimeRequest request, ServerCallContext context)
        {
            TimeResponse output = new TimeResponse();

            output.Hour = 9;
            output.Minute = 35;
            output.Second = 10;

            return Task.FromResult(output);
        }
    }
}
