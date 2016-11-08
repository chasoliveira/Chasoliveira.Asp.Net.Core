using AutoMapper;
using Chasoliveira.Core.Dto;
using Chasoliveira.Core.Domain.Entities;

namespace Chasoliveira.Core.Application
{
    public class MapperModelDTO
    {
        internal class ChasoMapperProfile : Profile
        {
            protected override void Configure()
            {
                CreateMap<Person, PersonDTO>()
                    .ForMember(p => p.FullName, o => o.Ignore())
                    .ForMember(p => p.DisplayName, o => o.Ignore())
                    .ForMember(p => p.Age, o => o.Ignore())
                    .ReverseMap();
                CreateMap<History, HistoryDTO>()
                    .ForMember(h => h.IsCurrently, o => o.Ignore())
                    .ForMember(h => h.FinishedString, o => o.Ignore())
                    .ReverseMap();
                CreateMap<Contact, ContactDTO>().ReverseMap();
                CreateMap<Skill, SkillDTO>().ReverseMap();
                CreateMap<Social, SocialDTO>().ReverseMap();
                CreateMap<User, UserDTO>().ReverseMap();
                CreateMap<Token, TokenDTO>().ForMember(t => t.IsValid, o => o.Ignore()).ReverseMap();
            }
        }

        private static IMapper _mapper;

        public static void Initialize()
        {
            var config = new MapperConfiguration((cfg) =>
            {
                cfg.AddProfile<ChasoMapperProfile>();
            });
            config.AssertConfigurationIsValid();
            _mapper = config.CreateMapper();
        }

        public static TDestination Map<TDestination>(object source)
        {
            return _mapper.Map<TDestination>(source);
        }

        public static TDestination Map<TSource, TDestination>(TSource source)
        {
            return _mapper.Map<TSource, TDestination>(source);
        }

        public static TDestination Map<TSource, TDestination>(TSource source, TDestination destination)
        {
            return _mapper.Map(source, destination);
        }
    }
}
