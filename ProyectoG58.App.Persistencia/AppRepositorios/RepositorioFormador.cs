using System.Collections.Generic;
using System.Linq;
using ProyectoG58.App.Dominio.Entidades;
using ProyectoG58.App.Persistencia.AppRepositorios;

namespace ProyectoG58.App.Persistencia.AppRepositorios
{
    public class RepositorioFormador : IRepositorioFormador
    {
         private readonly AppContext _appContext;

        public RepositorioFormador(AppContext appContext)
         {
            _appContext = appContext;
         }

        //AQUÍ CADA UNO DE LOS MÉTODOS DEL CRUD, REFERENCIADOS EN LA INTERFACE
         //SIGUIENTE DIAPOSITIVA

        Formador IRepositorioFormador.AddFormador(Formador formador)
        {
            var FormadorAdicionado = _appContext.Formadores.Add(formador);
            _appContext.SaveChanges();
            return FormadorAdicionado.Entity;
        }

        IEnumerable<Formador> IRepositorioFormador.GetAllFormadores()
        {
            return _appContext.Formadores;
        }

        Formador IRepositorioFormador.GetFormador(int idFormador)
        {
            return _appContext.Formadores.FirstOrDefault(p => p.id == idFormador);
        }

        Formador IRepositorioFormador.UpdateFormador(Formador formador)
        {
            var FormadorEncontrado = _appContext.Formadores.FirstOrDefault(p => p.id == formador.id);
            if (FormadorEncontrado != null)
            {
                FormadorEncontrado.identificacion = formador.identificacion;
                FormadorEncontrado.nombre          = formador.nombre;
                _appContext.SaveChanges();
            }
            return FormadorEncontrado;
        }

        void IRepositorioFormador.DeleteFormador(int idFormador)
        {
            var FormadorEncontrado = _appContext.Formadores.FirstOrDefault(p => p.id == idFormador);
            if (FormadorEncontrado == null)
                return;
            _appContext.Formadores.Remove(FormadorEncontrado);
            _appContext.SaveChanges();
        }
       
    }
}
