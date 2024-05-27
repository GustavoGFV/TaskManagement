using Microsoft.AspNetCore.Mvc;

namespace TaskManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentController : ControllerBase
    {
        [HttpGet("GetCommentsFromTask/{id}")]
        public IList<string> CommentsFromTask([FromRoute] int id)
        {
            return null;
        }

        [HttpPost("CommentOnTask/{id}")]
        public void Post([FromRoute] int id, [FromBody] string username)
        {
        }

        [HttpPut("{id}")]
        public void Put([FromRoute] int id, [FromBody] string value)
        {
        }

        [HttpDelete("{id}")]
        public void Delete([FromRoute] int id)
        {
        }
    }
}
