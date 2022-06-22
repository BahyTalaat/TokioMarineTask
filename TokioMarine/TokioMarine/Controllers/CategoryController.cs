using DTO.Category;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.TokioMarine.Category;
using System.Threading.Tasks;

namespace TokioMarine.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        // GET: CategoryController
        public ActionResult Index()
        {
            var CategoryList=_categoryService.GetAll();
            return View(CategoryList.Result.ServerParams["CategoryList"]);
        }

        // GET: CategoryController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CategoryController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CategoryController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(AddCategoryDto addCategoryDto)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(addCategoryDto);
                }
                else
                {
                    
                    var res = await _categoryService.Add(addCategoryDto);
                    if(!res.IsError)
                         return RedirectToAction(nameof(Index));
                    else
                    {
                        ModelState.AddModelError("", res.ErrorMessage);
                        return View(addCategoryDto);
                        //return BadRequest(ModelState);
                    }
                }
            }
            catch
            {
                return View();
            }
        }

        // GET: CategoryController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CategoryController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CategoryController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CategoryController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
