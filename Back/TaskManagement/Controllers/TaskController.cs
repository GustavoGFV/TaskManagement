using Microsoft.AspNetCore.Mvc;

namespace TaskManagement.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TaskController : ControllerBase
    {
        private readonly ILogger<TaskController> _logger;

        public TaskController(ILogger<TaskController> logger)
        {
            _logger = logger;
        }

        [HttpPost("CreateTask")]
        public Task CreateTask()
        {
            return null;
        }
        [HttpGet("DeleteTask/{id}")]
        public Task DeleteTask(int id)
        {
            return null;
        }
        [HttpGet("UpdateTask/{id}")]
        public IList<Task> UpdateTask(int id)
        {
            return null;
        }
    }
}
