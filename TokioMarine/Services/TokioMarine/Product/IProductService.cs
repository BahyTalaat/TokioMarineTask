using Core.Common;
using DTO.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.TokioMarine.Product
{
    public interface IProductService
    {
        Task<AjaxResult> Add(AddProductDto addProductDto);
        Task<AjaxResult> Update(UpdateProductDto updateProductDto);
        Task<AjaxResult> Delete(long Id);
        Task<AjaxResult> GetAll();
        Task<AjaxResult> GetById(long Id);
        Task<AjaxResult> GetByCategoryId(long CategoryId);

    }
}
