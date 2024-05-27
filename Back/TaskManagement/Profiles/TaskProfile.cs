using AutoMapper;
using TaskManagement.Dbo.Dto.Task;
using TaskManagement.Dbo.Model;

namespace TaskManagement.Profiles
{
    public class TaskProfile : Profile
    {
        public TaskProfile()
        {
            CreateMap<CreateTaskDto, TaskModel>();
            CreateMap<TaskModel, UpdateTaskDto>();
            CreateMap<UpdateTaskDto, TaskModel>();
            CreateMap<TaskModel, ReadTaskDto>();
        }
    }
}
