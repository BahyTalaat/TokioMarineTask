using Core.Common;
using DTO.Category;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.TokioMarine.Category
{
    public interface ICategoryService
    {
        Task<AjaxResult> Add(AddCategoryDto addCategoryDto);
        Task<AjaxResult> Update(UpdateCategoryDto updateCategoryDto);
        Task<AjaxResult> Delete(long Id);
        Task<AjaxResult> GetAll();
        Task<AjaxResult> GetById(long Id);
    }
}
