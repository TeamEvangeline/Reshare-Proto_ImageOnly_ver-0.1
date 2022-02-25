using Reshare_Proto_ImageOnly_ver_0._1.Models.Dtos.ImageDto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Reshare_Proto_ImageOnly_ver_0._1.Services.Interfaces
{
    public interface IImageService
    {
        Task<bool> AddImage(ImageWriteDto imageWriteDto);

        Task<IEnumerable<ImageReadDto>> GetAll();

        Task<ImageReadDto> Get(int imageId);
    }
}
