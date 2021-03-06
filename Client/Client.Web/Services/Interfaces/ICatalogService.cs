using Client.Web.Models.Catalogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Client.Web.Services.Interfaces
{
    public interface ICatalogService
    { 
        Task<List<CourseViewModel>> GetAllCourseAsync();

        Task<List<CourseViewModel>> GetAllCourseByUserIdAsync(string userId);

        Task<CourseViewModel> GetByCourseId(string courseId);
        Task<List<CategoryViewModel>> GetAllCategoryAsync();

        Task<bool> CreateCourseAsync(CourseCreateInput courseCreateInput);

        Task<bool> UpdateCourseAsync(CourseUpdateInput courseUpdateInput);

        Task<bool> DeleteCourseAsync(string courseId);
    }
}
