using Microsoft.AspNetCore.Mvc;
using AjaxMvc.Models;
using AjaxMvc.Views.Movies;

namespace AjaxMvc.Controllers
{
   

    public class MoviesController : Controller
    {
        
        
            DataService dataService;
            public MoviesController(DataService dataservice)
            {
                this.dataService = dataservice;
            }
        
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("/Movies/{Id}")]
        public IActionResult Index(IndexVM vM)
        {
            Movie movie = dataService.MovieGetById(vM);
            return View();
        }


    }
}
