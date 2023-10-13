﻿using System;
using System.Security.Cryptography.X509Certificates;
using BussinessLogic.DTO;
using DataAccess.IRepository;
using DataAccess.Entities;
using Mapster;
using Microsoft.EntityFrameworkCore;
using BussinessLogic.DTO.Search;

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

        public async Task<PublicacionDTO> GetPublicacionById(int id){
            Publicacion publicacion = await _unitOfWork.PublicacionRepository.GetPublicacionById(id);
            return publicacion.Adapt<PublicacionDTO>();

        }

        public async Task<List<PublicacionDTO>> GetPublicacionesCarrito(List<SearchPublicacionCarritoDTO> publicacionCarrito){
            List<int> ids = publicacionCarrito.Select(p => p.Id).ToList();
            List<Publicacion> publicaciones = await _unitOfWork.PublicacionRepository.GetPublicacionesCarrito(ids);
            return publicaciones.Adapt<List<PublicacionDTO>>();
        }
  

    }
}