using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Reshare_Proto_ImageOnly_ver_0._1.Models.Dtos.ImageDto;
using Reshare_Proto_ImageOnly_ver_0._1.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Reshare_Proto_ImageOnly_ver_0._1.Controllers
{
    [Route("api/images")]
    [ApiController]
    public class ImagesController : ControllerBase
    {
        private readonly IImageService _service;
        
        public ImagesController(IImageService service)
        {
            _service = service;
        }

        [HttpGet("image/id")]
        public async Task<ImageReadDto> Get(int imageId)
        {
            return await _service.Get(imageId);
        }

        [HttpPost("addImage")]
        public async Task<bool> Post(ImageWriteDto imageWriteDto)
        {
            return await _service.AddImage(imageWriteDto);
        }

        [HttpGet("allimages")]
        public async Task<IEnumerable<ImageReadDto>> GetAll()
        {
            return await _service.GetAll();
        }
    }
}
