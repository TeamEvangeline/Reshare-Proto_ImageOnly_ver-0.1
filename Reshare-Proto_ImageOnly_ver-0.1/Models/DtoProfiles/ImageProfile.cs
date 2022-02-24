using AutoMapper;
using Reshare_Proto_ImageOnly_ver_0._1.Models.Dtos.ImageDto;

namespace Reshare_Proto_ImageOnly_ver_0._1.Models.DtoProfiles
{
    public class ImageProfile : Profile
    {
        public ImageProfile()
        {
            CreateMap<ImageModel, ImageReadDto>();
            CreateMap<ImageModel, ImageWriteDto>();
            CreateMap<ImageWriteDto, ImageModel>();
            CreateMap<ImageReadDto, ImageModel>();
        }
    }
}
