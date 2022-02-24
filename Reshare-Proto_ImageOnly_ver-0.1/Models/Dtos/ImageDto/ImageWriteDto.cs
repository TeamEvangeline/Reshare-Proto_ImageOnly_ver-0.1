using System.ComponentModel.DataAnnotations;

namespace Reshare_Proto_ImageOnly_ver_0._1.Models.Dtos.ImageDto
{
    public class ImageWriteDto
    {
        [Required]
        public string ImageUrl { get; set; }

        public string ImageName { get; set; }
    }
}
