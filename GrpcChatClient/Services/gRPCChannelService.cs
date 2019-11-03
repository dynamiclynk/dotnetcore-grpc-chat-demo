using Grpc.Net.Client;
using GrpcChatService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrpcChatClient.Services
{
    public class gRPCChannelService
    {
        public gRPCChannelService() : this("https://localhost:5001") { }
        public gRPCChannelService(string hostAddress)
        {
            GrpcChannel = GrpcChannel.ForAddress(hostAddress);

            ChatterClient = new Chatter.ChatterClient(GrpcChannel);
        }

        public GrpcChannel GrpcChannel { get; } = null;
        public Chatter.ChatterClient ChatterClient {get;} = null;
    }
}
