using Reshare_Proto_ImageOnly_ver_0._1.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Reshare_Proto_ImageOnly_ver_0._1.Repository.Interfaces
{
    public interface IImageRepo
    {
        Task<bool> SaveChanges();

        Task<IEnumerable<ImageModel>> GetAll();

        Task<ImageModel> Get(int id);

        void AddImage(ImageModel image);
    }
}
