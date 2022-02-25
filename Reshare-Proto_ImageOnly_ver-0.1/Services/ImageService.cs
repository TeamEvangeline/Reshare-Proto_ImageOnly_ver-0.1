using AutoMapper;
using Reshare_Proto_ImageOnly_ver_0._1.Models;
using Reshare_Proto_ImageOnly_ver_0._1.Models.Dtos.ImageDto;
using Reshare_Proto_ImageOnly_ver_0._1.Repository.Interfaces;
using Reshare_Proto_ImageOnly_ver_0._1.Services.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reshare_Proto_ImageOnly_ver_0._1.Services
{
    public class ImageService : IImageService
    {
        private readonly IImageRepo _imageRepo;
        private readonly IMapper _mapper;

        public ImageService(IImageRepo imageRepo, IMapper mapper)
        {
            _imageRepo = imageRepo;
            _mapper = mapper;
        }

        public async Task<bool> AddImage(ImageWriteDto imageWriteDto)
        {
            ImageModel image = _mapper.Map<ImageModel>(imageWriteDto);
            _imageRepo.AddImage(image);
            return await _imageRepo.SaveChanges();
        }

        public async Task<ImageReadDto> Get(int imageId)
        {
            ImageModel image = await _imageRepo.Get(imageId);
            return _mapper.Map<ImageReadDto>(image);
        }

        public async Task<IEnumerable<ImageReadDto>> GetAll()
        {
            List<ImageModel> images = (await _imageRepo.GetAll()).ToList();
            return _mapper.Map<List<ImageReadDto>>(images);
        }
    }
}
