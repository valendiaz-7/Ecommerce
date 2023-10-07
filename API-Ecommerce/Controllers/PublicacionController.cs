using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BussinessLogic.DTO;
using BussinessLogic.Services;
using Microsoft.AspNetCore.Mvc;
using AutoWrapper.Wrappers;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API_Ecommerce.Controllers
{
    [Route("api/[controller]")]
    public class PublicacionController : Controller
    {

        //Instancio el service que vamos a usar
        private ServicePublicacion _service;

        //Inyecto el service por el constructor
        public PublicacionController(ServicePublicacion service)
        {
            _service = service;
        }
        // GET: api/values

        //Metodo para traer todas las categorias
        [HttpGet]
        [Route("/publicaciones")]
        public async Task<ApiResponse> GetPublicaciones()
        {
            try
            {
                IList<PublicacionDTO> publicaciones = await _service.GetAllPublicaciones();
                ApiResponse response = new ApiResponse(new { data = publicaciones, cantidadPublicaciones = publicaciones.Count() });
                return response;
            }
            catch (Exception ex)
            {
                while (ex.InnerException != null)
                {
                    ex = ex.InnerException;
                }
                throw new ApiException(ex);
            }


        }



    }
}

