using System;
using Datos;
using Entidad;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Logica
{
    public class RestauranteService
    {
        private readonly PersonaContext _context;
        public RestauranteService(PersonaContext context){
            _context=context;
        }

         public GuardarRestauranteResponse Guardar(Restaurante restaurante)
        {
            try
            {
                var restauranteBuscada = _context.Restaurantes.Find(restaurante.NIT);
                if(restauranteBuscada != null){
                    return new GuardarRestauranteResponse("Error, ya registrarada");
                }
                _context.Restaurantes.Add(restaurante);
                _context.SaveChanges();
                return new GuardarRestauranteResponse(restaurante);
            }
            catch (Exception e)
            {
                return new GuardarRestauranteResponse($"Error de la Aplicacion: {e.Message}");
            }
            finally { }
        }
        public List<Restaurante> ConsultarTodos()
        {
            List<Restaurante> restaurantes = _context.Restaurantes.ToList();

            return restaurantes;
        }
         
        public GuardarRestauranteResponse Buscar(string nombre){
            Restaurante restaurante = _context.Restaurantes.Find(nombre);
            if(restaurante == null){
                return new GuardarRestauranteResponse("No existe");
            }
            return new GuardarRestauranteResponse(restaurante);
        }

        public class GuardarRestauranteResponse 
    {
        public GuardarRestauranteResponse(Restaurante restaurante)
        {
            Error = false;
            Restaurante = restaurante;
        }
        public GuardarRestauranteResponse(string mensaje)
        {
            Error = true;
            Mensaje = mensaje;
        }
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public Restaurante Restaurante { get; set; }

    }
    }
}