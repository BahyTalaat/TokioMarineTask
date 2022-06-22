using AspNetCore.Reporting;
using AutoMapper;
using Data.Models;
using DTO.Product;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Services.TokioMarine.Product;
using Services.TokioMarine.Report;
using System;
using System.Collections.Generic;
using System.Data;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;


namespace TokioMarine.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public ReportService reportService = new ReportService();

        public ProductController(IProductService productService,IMapper mapper,
            IWebHostEnvironment webHostEnvironment)
        {
            _productService = productService;
            _mapper = mapper;
            _webHostEnvironment = webHostEnvironment;
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

        }
        // GET: ProductController
        public ActionResult Index()
        {
            var ProductList = _productService.GetAll();
            return View(ProductList.Result.ServerParams["ProductList"]);
        }

        // GET: ProductController/Details/5
        public ActionResult Details(int id)
        {
            var Product = _productService.GetById(id);
            return View(Product);
        }

        // GET: ProductController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProductController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(AddProductDto addProductDto)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(addProductDto);
                }
                else
                {
                    var res = await _productService.Add(addProductDto);
                    if (!res.IsError)
                        return RedirectToAction(nameof(Index));
                    else
                    {
                        return View(addProductDto);
                        //return BadRequest(ModelState);
                    }
                }
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProductController/Edit/5
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

        // GET: ProductController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProductController/Delete/5
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

        [HttpGet]
        //[ValidateAntiForgeryToken]
        public async Task<ActionResult> AddToBill(long Id)
        {
            try
            {
                var productlist = new List<GetProductDto>();
                if (TempData.ContainsKey("BillList"))
                {
                    productlist = JsonConvert.DeserializeObject<List<GetProductDto>>(TempData["BillList"].ToString());
               
                }
    
                var res = await _productService.GetById(Id);
                if (!res.IsError)
                {
                    var product = (GetProductDto)res.ServerParams["Product"];
                    bool IsAdded = false;
                    foreach (var item in productlist)
                    {
                        if (product.Id == item.Id)
                        {
                            IsAdded = true;
                            break;
                        }
                            
                    }
                    if(!IsAdded)
                        productlist.Add(product);

                    TempData["BillList"] = JsonConvert.SerializeObject(productlist);
                    return RedirectToAction(nameof(BillList));
                }
                else
                {
                    TempData.Keep("BillList");
                    return RedirectToAction(nameof(BillList));
                }

            }
            catch
            {
                return View();
            }
        }

        [HttpGet]
        //[ValidateAntiForgeryToken]
        public async Task<ActionResult> BillList()
        {
            if (TempData.ContainsKey("BillList"))
            {
                  var productlist = JsonConvert.DeserializeObject<List<GetProductDto>>(TempData["BillList"].ToString());
                   TempData.Keep("BillList");
                return View(productlist);
            }
            else
            {
                return Content("Bill Is Empty");
            }
            
        }

        public IActionResult GetProductReport()
        {
            var dt = new DataTable();

            dt = reportService.GetProductReport();

            string mimeType = "";
            int extension = 1;


            //var path = $"{_webHostEnvironment.WebRootPath}\\Reports\\Report1.rdlc";
            var path = $"{_webHostEnvironment.WebRootPath}\\Reports\\Report1.rdlc";

            LocalReport localReport = new LocalReport(path);

            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("Prm1", "RDLC Report");
            parameters.Add("Prm2", DateTime.Now.ToString("dd-MMM-yyyy"));
            parameters.Add("Prm3", "Product Report");

             localReport.AddDataSource("Product report", dt);


            var result = localReport.Execute(RenderType.Pdf, extension, parameters, mimeType);

            return File(result.MainStream, "application/pdf");
        }

    }
}
