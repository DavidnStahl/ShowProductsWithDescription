using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MediafyAssignment.Models;
using MediafyAssignment.Interface;

namespace MediafyAssignment.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductsService _service;
        private readonly IProductsRepository _repository;
        private readonly IViewModelBuilder _viewModelBuilder;

        public HomeController(IProductsService service, IProductsRepository repository, IViewModelBuilder viewModelBuilder)
        {
            _service = service;
            _repository = repository;
            _viewModelBuilder = viewModelBuilder;
        }
        public IActionResult Index()
        {
            var model = _service.GetDataToShow(_repository, _viewModelBuilder);
            return View(model);
        }
    }
}
