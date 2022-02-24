using Microsoft.EntityFrameworkCore;
using Reshare_Proto_ImageOnly_ver_0._1.Models;
using Reshare_Proto_ImageOnly_ver_0._1.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Reshare_Proto_ImageOnly_ver_0._1.Repository
{
    public class ImageRepo : IImageRepo
    {
        private readonly ImageContext _context;

        public ImageRepo(ImageContext context)
        {
            _context = context;
        }

        public void AddImage(ImageModel image)
        {
            if(image == null)
            {
                throw new ArgumentNullException();
            }
            _context.Images.Add(image);
        }

        public async Task<ImageModel> Get(int id)
        {
            ImageModel image = await _context.Images.FirstOrDefaultAsync(b => b.ImageId == id);
            return image;
        }

        public async Task<IEnumerable<ImageModel>> GetAll()
        {
            List<ImageModel> images = await _context.Images.ToListAsync();
            return images;
        }

        public async Task<bool> SaveChanges()
        {
            int rowsAffected = await _context.SaveChangesAsync();
            return (rowsAffected >= 0);
        }
    }
}
