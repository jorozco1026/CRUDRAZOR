using System;
using System.Collections.Generic;
using System.Linq;
using ProyectoG58.App.Dominio.Entidades;

namespace ProyectoG58.App.Persistencia.AppRepositorios
{
    public interface IRepositorioFormador
    {
        IEnumerable<Formador> GetAllFormadores();
        Formador AddFormador(Formador formador);
        Formador UpdateFormador(Formador formador);
        void DeleteFormador(int idFormador);    
        Formador GetFormador(int idFormador);
    }
     
}
