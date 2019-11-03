using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Grpc.Core;
using Microsoft.Extensions.Logging;

namespace GrpcChatService
{
    public class ChatterService : Chatter.ChatterBase
    {
        private readonly ILogger<ChatterService> _logger;
        public ChatterService(ILogger<ChatterService> logger)
        {
            _logger = logger;
        }

        public override Task<HelloReply> SayHello(HelloRequest request, ServerCallContext context)
        {
            return Task.FromResult(new HelloReply
            {
                Message = $"ChatServer: Hello {request.Name}"
            });
        }
    }
}
