using System.Threading.Tasks;
using Application.Profiles;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class ProfilesController : BaseController
    {
        [HttpGet("{userName}")]
        public async Task<ActionResult<Profile>> GetTask(string userName)
        {
            return await Mediator.Send(new Details.Query { UserName = userName });
        }
    }
}