
using MiPrimeraAPI.DAL.Entidades.External;
using MiPrimeraAPI.DAL.Entidades.Persona;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimeraAPI.DAL.Personas
{
    public interface IPersonaRepositorio
    {
            IEnumerable<Persona> GetPersonas();
            Persona GetPersona(int id);
            void AddPersona(Persona persona);
            void UpdatePersona(int id, Persona persona);
            void DeletePersona(int id);


            RandomUserResponse GetUser();

        IEnumerable<ProductResponse> GetProductos(); //Mala practica por que no son elemento del mismo tipo, pero es solo un ejemplo para mostrar como consumir una API externa desde nuestro repositorio    
    }
}
