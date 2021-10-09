using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using ProyectoG58.App.Dominio;

namespace ProyectoG58.App.Presentacion.Pages
{
    public class ListModel : PageModel
    {
        public IEnumerable<Formador> formadores { get; set; }
        //Model.Formadores

        public ListModel(){
            //simular la lista a mostrar en la tabla HTML
            formadores = new List<Formador>()
            {
                new Formador{id=1, identificacion="102030", nombre="Jhon Jairo Orozco"},
                new Formador{id=2, identificacion="304050", nombre="Luz Dary Martinez"},
                new Formador{id=3, identificacion="607080", nombre="Mateo Orozco"}
            };  
        }

        public void OnGet(int formadorId)
        {
            
        }
    }
}
