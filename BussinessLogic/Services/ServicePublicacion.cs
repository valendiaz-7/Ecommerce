using System;
using System.Security.Cryptography.X509Certificates;
using BussinessLogic.DTO;
using DataAccess.IRepository;
using DataAccess.Entities;
using Mapster;
using Microsoft.EntityFrameworkCore;

namespace BussinessLogic.Services
{
    public class ServicePublicacion
    {
        //Instancio el UnitOfWork que vamos a usar
        private readonly IUnitOfWork _unitOfWork;

        //Inyecto el UnitOfWork por el constructor, esto se hace para que se cree un nuevo contexto por cada vez que se llame a la clase
        public ServicePublicacion(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IList<PublicacionDTO>> GetAllPublicaciones()
        {
            try
            {
                IList<Publicacion> publicaciones = await _unitOfWork.PublicacionRepository.GetAllPublicaciones();
                IList<PublicacionDTO> publicacionesDTO = publicaciones.Adapt<IList<PublicacionDTO>>();
                return publicacionesDTO;
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }


  

    }
}