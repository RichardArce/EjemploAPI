using MiPrimeraAPI.DAL.Entidades.External;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimeraAPI.BLL.Persona
{
    public interface IPersonaServicio
    {
        //DEBERIAMOS UTILIZAR DTOS PARA EVITAR EXPONER NUESTRA ENTIDAD DIRECTAMENTE, PERO PARA SIMPLICIDAD EN ESTE EJEMPLO SE UTILIZARÁ LA ENTIDAD DIRECTAMENTE
        IEnumerable<DAL.Entidades.Persona.Persona> GetPersonas();
        MiPrimeraAPI.DAL.Entidades.Persona.Persona GetPersona(int id);
        void AddPersona(MiPrimeraAPI.DAL.Entidades.Persona.Persona persona);
        void UpdatePersona(int id, MiPrimeraAPI.DAL.Entidades.Persona.Persona persona);
        void DeletePersona(int id);






        //Consumo externo
        IEnumerable<DAL.Entidades.External.ProductResponse> GetProductos(); //Mala practica por que no son elemento del mismo tipo, pero es solo un ejemplo para mostrar como consumir una API externa desde nuestro servicio

        RandomUserResponse GetUser(); //Mala practica por que no son elemento del mismo tipo, pero es solo un ejemplo para mostrar como consumir una API externa desde nuestro servicio
    }
}

//CUANDO HAY DUDA SI DEBE IR EN EL MISMA CARPETA O CAPA, ES MEJOR DIVIDIRLO EN OTRA CARPETA O CAPA, PARA MANTENER UNA MEJOR ORGANIZACION Y SEPARACION DE RESPONSABILIDADES. EN ESTE CASO, EL METODO GetProductos() PODRIA IR EN UN SERVICIO SEPARADO DEDICADO A CONSUMIR LA API EXTERNA, PERO PARA SIMPLICIDAD EN ESTE EJEMPLO SE INCLUYE EN EL MISMO SERVICIO.