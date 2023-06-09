﻿using AjaxMvc.Controllers;
using AjaxMvc.Views.Movies;
using AjaxMvc.Views.Shared;

namespace AjaxMvc.Models
{
    public class DataService
    {
        List<Movie> movies = new List<Movie>()
        {
            new Movie(){Id = 1, Title ="Harry potter" , Description = "A young wizard goes on adventures"},
            new Movie(){Id = 2, Title ="Batman" , Description = "Action movie"},
            new Movie(){Id = 3, Title ="Titanic" , Description = "Incorporating both historical and fictionalized aspects, it is based on accounts of the sinking of the RMS Titanic and stars Kate Winslet and Leonardo DiCaprio as members of different social classes who fall in love aboard the ship during its ill-fated maiden voyage."},
        };

        public _MovieVM MovieGetById(int id)
        {
            Movie m = movies.SingleOrDefault(a => a.Id == id);
            return new _MovieVM()
            {
                Titel = m.Title,Description = m.Description,
            };
        }
    }
}
