using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GrpcChatClient.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace GrpcChatClient.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly gRPCChannelService _grpcChannelService = null;
        public IndexModel(ILogger<IndexModel> logger, gRPCChannelService gRPCChannelService )
        {
            _logger = logger;
            _grpcChannelService = gRPCChannelService;
        }

        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPostAsync(string name)
        {
            var reply = await _grpcChannelService.ChatterClient.SayHelloAsync(new GrpcChatService.HelloRequest { Name = name });

            ViewData["reply"] = reply.Message;
            return Page();
        }
    }
}
