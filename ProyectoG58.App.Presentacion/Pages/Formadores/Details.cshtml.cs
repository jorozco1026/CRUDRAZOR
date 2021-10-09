using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using ProyectoG58.App.Dominio;
using ProyectoG58.App.Persistencia;

namespace ProyectoG58.App.Presentacion.Pages
{
    public class DetailsModel : PageModel
    {
        private readonly IRepositorioFormador repositorioFormadores;
        public Formador Formador { get; set; }

        public DetailsModel()
        {
            this.repositorioFormadores=new RepositorioFormador(new ProyectoG58.App.Persistencia.AppContext());
        }

        public IActionResult OnGet(int FormadorId)
        {
            Formador = repositorioFormadores.GetFormador(FormadorId);
            if(Formador==null)
            {
                return RedirectToPage("./NotFound");
            }
            else
            return Page();
        }
    }
}