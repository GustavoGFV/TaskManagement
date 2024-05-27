using Microsoft.AspNetCore.Mvc;

namespace TaskManagement.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GetTaskController : ControllerBase
    {
        private readonly ILogger<GetTaskController> _logger;

        public GetTaskController(ILogger<GetTaskController> logger)
        {
            _logger = logger;
        }

        [HttpGet("GetTasks")]
        public IList<Task> GetTasks()
        {
            return null;
        }
        [HttpGet("GetTaskId/{0}")]
        public Task GetTaskId(int id)
        {
            return null;
        }
        [HttpGet("GetTaskName/{name}")]
        public IList<Task> GetTaskName(string name)
        {
            return null;
        }
        [HttpGet("GetTaskUser/{username}")]
        public IList<Task> GetTaskUser(string username)
        {
            return null;
        }
    }
}
