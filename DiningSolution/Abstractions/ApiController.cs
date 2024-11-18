using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DiningSolution.WEB.API.Abstractions
{
    [ApiController]
    public class ApiController(ISender sender) : ControllerBase
    {
        protected readonly ISender Sender = sender;

    }
}
