using AutoMapper;
using ManagingANewspaper;
using Solid.Core.DTOs;
using Solid.Core.Entities;

namespace Solid.Core
{
    public class CoreMappingProfile:Profile
    {
        public CoreMappingProfile()
        {
            CreateMap<DesignerDto, Designer>().ReverseMap();
            CreateMap<WriterDto,Writer>().ReverseMap();
            CreateMap<EditorDto,Editor>().ReverseMap();
            CreateMap<ArticleDto, Article>().ReverseMap();

        }
    }
}
