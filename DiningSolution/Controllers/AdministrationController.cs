using DiningSolution.Application.Personnels.Commands.CreatePersonel;
using DiningSolution.Domain.Shared;
using DiningSolution.WEB.API.Abstractions;
using DiningSolution.WEB.API.Contracts.Personnel;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DiningSolution.WEB.API.Controllers
{
    [Route("api/personnel")]
    [ApiController]
    // [Authorize]
    // [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "Administration")]
    //Login Controller atsikrai nuo Administration ir Waiter
    public class AdministrationController(ISender sender) : ApiController(sender)
    {
        [HttpPost]
        [Route("create")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ActionResult<int>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> CreatePersonnelAsync([FromBody] CreatePersonnelRequest request, CancellationToken cancellationToken)
        {
            var command = new CreatePersonnelCommand(request.PersonnelName, request.PersonnelPosition);
            Result<int> result = await Sender.Send(command, cancellationToken);

            if (result.IsFailure)
            {
                return BadRequest(result.Error);
            }
            return Ok(result.Value);
        }
    }
}
