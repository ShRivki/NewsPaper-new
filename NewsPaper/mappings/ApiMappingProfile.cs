using AutoMapper;
using ManagingANewspaper.models;
using Solid.Core.Entities;

namespace ManagingANewspaper.mappings
{
    public class ApiMappingProfile:Profile
    {
        public ApiMappingProfile()
        {
            CreateMap<DesignerPostModel,Designer>().ReverseMap();
            CreateMap<WriterPostModel, Writer>().ReverseMap();
            CreateMap<EditorPostModel, Editor>().ReverseMap();
            CreateMap<ArticlePostModel, Article>().ReverseMap();


        }
    }
}
