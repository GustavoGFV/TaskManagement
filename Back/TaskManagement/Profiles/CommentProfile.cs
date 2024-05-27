using AutoMapper;
using TaskManagement.Dbo.Dto.Comment;
using TaskManagement.Dbo.Model;

namespace TaskManagement.Profiles
{
    public class CommentProfile : Profile
    {
        public CommentProfile()
        {
            CreateMap<CreateCommentDto, CommentModel>();
            CreateMap<CommentModel, UpdateCommentDto>();
            CreateMap<UpdateCommentDto, CommentModel>();
            CreateMap<CommentModel, ReadCommentDto>();
        }
    }
}
