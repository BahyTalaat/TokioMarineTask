using AutoMapper;
using Core.Common;
using Data.DataContext;
using DTO.Product;
using Repositories.UOW;
using Repositories.TokioMarineRepositories.Category;
using Repositories.TokioMarineRepositories.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.TokioMarine.Product
{
    public class ProductService: IProductService
    {
        private readonly IUnitOfWork<ApplicationDbContext> _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IProductRepository _productRepository;
        private readonly ICategoryRepository _categoryRepository;

        public ProductService(IUnitOfWork<ApplicationDbContext> unitOfWork,
            IMapper mapper, IProductRepository productRepository,
            ICategoryRepository categoryRepository)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
        }

        public async Task<AjaxResult> Add(AddProductDto addProductDto)
        {
            try
            {
                var res = new AjaxResult();

                var cat = await _categoryRepository.GetFirstAsync(x => x.Id == addProductDto.CategoryId);

                if (cat == null)
                    return "Please select category";

                var pro =await _productRepository.GetFirstAsync(x => x.Name == addProductDto.Name);

                if (pro != null)
                    return "Product Already exist";


                Data.Models.Product product = _mapper.Map<Data.Models.Product>(addProductDto);

                product.LMD = DateTime.UtcNow;

                _productRepository.Add(product);
                await _unitOfWork.SaveAsync();
                res.AddParameter("Message", "Product has been added successfully");

                return res;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public Task<AjaxResult> Delete(long Id)
        {
            throw new NotImplementedException();
        }

        public async Task<AjaxResult> GetAll()
        {
            try
            {
                var res = new AjaxResult();

                var products = await _productRepository.GetAllAsync();

                var productsDto = _mapper.Map<List<GetProductDto>>(products);

                
                res.AddParameter("ProductList", productsDto);

                return res;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public Task<AjaxResult> GetByCategoryId(long CategoryId)
        {
            throw new NotImplementedException();
        }

        public async Task<AjaxResult> GetById(long Id)
        {
            try
            {
                var res = new AjaxResult();
                var product = await _productRepository.GetFirstAsync(x => x.Id == Id);

                if (product == null)
                    return "Product not exist";

                var productDto = _mapper.Map<GetProductDto>(product);


                res.AddParameter("Product", productDto);

                return res;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public Task<AjaxResult> Update(UpdateProductDto updateProductDto)
        {
            throw new NotImplementedException();
        }
    }
}
