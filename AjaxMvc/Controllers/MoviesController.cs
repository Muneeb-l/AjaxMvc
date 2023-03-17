using Microsoft.AspNetCore.Mvc;
using AjaxMvc.Models;
using AjaxMvc.Views.Movies;
using AjaxMvc.Views.Shared;

namespace AjaxMvc.Controllers
{
   

    public class MoviesController : Controller
    {
        
        
            DataService dataService;
            public MoviesController()
            {
                this.dataService = new DataService();
            }
        
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("/Movies/{Id}")]
        public IActionResult Index(int id)
        {
            _MovieVM movie = dataService.MovieGetById(id);
            return PartialView("_Movie", movie);
        }


    }
}
