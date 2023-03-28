using AutoMapper;
using WebApi.Models.Dtos;
using WebApi.Models.Entities;

public class ModelsProfile : Profile
{
    public ModelsProfile() {
        CreateMap<ClientDto, Client>()
            .ForPath(dest => dest.Id, opt => opt.MapFrom(src => src.client_id))
            .ForPath(dest => dest.Name, opt => opt.MapFrom(src => src.name_client))
            .ForPath(dest => dest.UserId, opt => opt.MapFrom(src => src.user_id))
            .ForPath(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.created_at))
            .ReverseMap();
        
        CreateMap<ClientUpdateDto, Client>()
            .ForPath(dest => dest.Name, opt => opt.MapFrom(src => src.name_client))
            .ForPath(dest => dest.UserId, opt => opt.MapFrom(src => src.name_client))
            .ForPath(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.updated_at))
            .ReverseMap();

        CreateMap<UserDto, User>()
            .ForPath(dest => dest.UserId, opt => opt.MapFrom(src => src.user_id))
            .ForPath(dest => dest.Name, opt => opt.MapFrom(src => src.name_user))
            .ForPath(dest => dest.Email, opt => opt.MapFrom(src => src.email))
            .ForPath(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.created_at))
            .ReverseMap();

        CreateMap<UserUpdateDto, User>()
            .ForPath(dest => dest.Name, opt => opt.MapFrom(src => src.name_user))
            .ForPath(dest => dest.Email, opt => opt.MapFrom(src => src.email))
            .ForPath(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.updated_at))
            .ReverseMap();
    }
}
