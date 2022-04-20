using Client.Web.Models.PhotoStocks;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Client.Web.Services.Interfaces
{
    public interface IPhotoStockService
    {
        Task<PhotoStockViewModel> UploadPhoto(IFormFile formFile);
        Task<bool> DeletePhoto(string photoUrl);
    }
}
