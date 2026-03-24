using MiPrimeraAPI.DAL.Entidades.External;
using MiPrimeraAPI.DAL.Personas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimeraAPI.BLL.Persona
{
    public class PersonaServicio: IPersonaServicio
    {
        private IPersonaRepositorio repo;


        public PersonaServicio(IPersonaRepositorio repo)
        {
            this.repo = repo;
        }

        public IEnumerable<DAL.Entidades.Persona.Persona> GetPersonas()
        {
            return repo.GetPersonas();
        }

        public void AddPersona(DAL.Entidades.Persona.Persona persona)
        {
            repo.AddPersona(persona);
        }

        public void DeletePersona(int id)
        {
            repo.DeletePersona(id);
        }

        public DAL.Entidades.Persona.Persona GetPersona(int id)
        {
            return repo.GetPersona(id);
        }

        public void UpdatePersona(int id, DAL.Entidades.Persona.Persona persona)
        {
            repo.UpdatePersona(id, persona);
        }

        public IEnumerable<ProductResponse> GetProductos()
        {
            repo.GetProductos();
             return repo.GetProductos();
        }

        public RandomUserResponse GetUser()
        {
            var consulta = repo.GetUser();

            if (consulta.Results[0].Email == "evie.thompson@example.com") // Consideracion o validacion de datos, se puede hacer con cualquier dato que se quiera validar
            {
                return consulta;
                //VAlidacion
            }

            if (consulta.Results[0].Name.First == "Carlos") // Consideracion o validacion de datos, se puede hacer con cualquier dato que se quiera validar
            {
                return consulta;
                //VAlidacion
            }
            return consulta;
                //VAlidacion
        }
    }

}
