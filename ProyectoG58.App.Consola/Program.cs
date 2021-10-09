using System;
using System.Collections.Generic;

using ProyectoG58.App.Dominio;
using ProyectoG58.App.Persistencia;

namespace ProyectoG58.App.Consola
{
    class Program
    {
        private static IRepositorioFormador _repoFormador = new RepositorioFormador (new Persistencia.AppContext());

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            AddFormador();
        }

        private static void AddFormador(){
            var formador = new Formador
            {               
                identificacion = "102030",
                nombre = "probando adicionar"
            };
            _repoFormador.AddFormador(formador);
        }
    }
}
