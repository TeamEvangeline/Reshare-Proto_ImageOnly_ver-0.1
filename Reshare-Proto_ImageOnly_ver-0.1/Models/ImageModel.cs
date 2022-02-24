using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Reshare_Proto_ImageOnly_ver_0._1.Models
{
    [Table("tblImage")]
    public class ImageModel
    {
        [Key]
        [Required]
        [Column("ImgId")]
        public int ImageId { get; set; }

        [Required]
        [Column("ImgUrl")]
        public string ImageUrl { get; set; }

        [Column("ImgNm")]
        public string ImageName { get; set; }

        [Column("Views")]
        public int ImageViews { get; set; }
    }
}
