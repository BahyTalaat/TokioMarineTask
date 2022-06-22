using AutoMapper;
using Core.Common;
using Data.DataContext;
using DTO.Category;
using Repositories.TokioMarineRepositories.Category;
using Repositories.UOW;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.TokioMarine.Category
{
    public class CategoryService: ICategoryService
    {
        private readonly IUnitOfWork<ApplicationDbContext> _unitOfWork;
        private readonly IMapper _mapper;
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(IUnitOfWork<ApplicationDbContext> unitOfWork,
            IMapper mapper, ICategoryRepository categoryRepository)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _categoryRepository = categoryRepository;
        }

        public async Task<AjaxResult> Add(AddCategoryDto addCategoryDto)
        {
            try
            {
                var res = new AjaxResult();
                var cat = _categoryRepository.GetFirst(x => x.Name == addCategoryDto.Name);
                if (cat != null)
                    return "Category Already Exist";

                Data.Models.Category category=new Data.Models.Category()
                {
                    Name = addCategoryDto.Name,
                    LMD=DateTime.UtcNow,
                    
                };
                _categoryRepository.Add(category);
                await _unitOfWork.SaveAsync();
                res.AddParameter("Message", "Category has been added successfully");

                return res;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<AjaxResult> Delete(long Id)
        {
            try
            {
                var res = new AjaxResult();

                var category = await _categoryRepository.GetFirstAsync(x => x.Id == Id);
                if (category == null)
                    return "Category not exist";

                _categoryRepository.Remove(category);
                await _unitOfWork.SaveAsync();
                res.AddParameter("Message", "Category has been deleted successfully");

                return res;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<AjaxResult> GetAll()
        {
            try
            {
                var res = new AjaxResult();

                var categorylist = await _categoryRepository.GetAllAsync();

                var categorylistDto = _mapper.Map <List<GetCategoryDto>>(categorylist);


                res.AddParameter("CategoryList", categorylistDto);

                return res;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<AjaxResult> GetById(long Id)
        {
            try
            {
                var res = new AjaxResult();

                var category =  _categoryRepository.GetAll(x => x.Id == Id).FirstOrDefault();
                if (category == null)
                    return "Category not exist";

                var categoryDto = _mapper.Map<GetCategoryDto>(category);


                res.AddParameter("Category", category);

                return res;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<AjaxResult> Update(UpdateCategoryDto updateCategoryDto)
        {
            try
            {
                var res = new AjaxResult();
                var category = await _categoryRepository.GetFirstAsync(x => x.Id == updateCategoryDto.Id);
                if (category == null)
                    return "Category not exist";

                var cat = _mapper.Map<Data.Models.Category>(updateCategoryDto);

                cat.LMD = DateTime.UtcNow;

                _categoryRepository.Update(cat);
                await _unitOfWork.SaveAsync();
                res.AddParameter("Message", "Category has been Updated successfully");

                return res;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
