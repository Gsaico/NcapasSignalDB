//-------------------------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by EntitiesToDTOs.v3.2 (entitiestodtos.codeplex.com).
//     Timestamp: 2015/04/19 - 13:28:00
//
//     Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
//-------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using System.Linq;
using Dominio.Dtos;
using PersistenciaDatos;

namespace Dominio.Convertidores
{

    /// <summary>
    /// Assembler for <see cref="files"/> and <see cref="filesDTO"/>.
    /// </summary>
    public static partial class filesCONVERTIDOR
    {
        /// <summary>
        /// Invoked when <see cref="ToDTO"/> operation is about to return.
        /// </summary>
        /// <param name="dto"><see cref="filesDTO"/> converted from <see cref="files"/>.</param>
        static partial void OnDTO(this files entity, filesDTO dto);

        /// <summary>
        /// Invoked when <see cref="ToEntity"/> operation is about to return.
        /// </summary>
        /// <param name="entity"><see cref="files"/> converted from <see cref="filesDTO"/>.</param>
        static partial void OnEntity(this filesDTO dto, files entity);

        /// <summary>
        /// Converts this instance of <see cref="filesDTO"/> to an instance of <see cref="files"/>.
        /// </summary>
        /// <param name="dto"><see cref="filesDTO"/> to convert.</param>
        public static files ToEntity(this filesDTO dto)
        {
            if (dto == null) return null;

            var entity = new files();

            entity.id_file = dto.id_file;
            entity.name_file = dto.name_file;
            entity.adjunt_date = dto.adjunt_date;
            entity.status = dto.status;
            entity.type = dto.type;
            entity.modify_date = dto.modify_date;
            entity.address = dto.address;

            dto.OnEntity(entity);

            return entity;
        }

        /// <summary>
        /// Converts this instance of <see cref="files"/> to an instance of <see cref="filesDTO"/>.
        /// </summary>
        /// <param name="entity"><see cref="files"/> to convert.</param>
        public static filesDTO ToDTO(this files entity)
        {
            if (entity == null) return null;

            var dto = new filesDTO();

            dto.id_file = entity.id_file;
            dto.name_file = entity.name_file;
            dto.adjunt_date = entity.adjunt_date;
            dto.status = entity.status;
            dto.type = entity.type;
            dto.modify_date = entity.modify_date;
            dto.address = entity.address;

            entity.OnDTO(dto);

            return dto;
        }

        /// <summary>
        /// Converts each instance of <see cref="filesDTO"/> to an instance of <see cref="files"/>.
        /// </summary>
        /// <param name="dtos"></param>
        /// <returns></returns>
        public static List<files> ToEntities(this IEnumerable<filesDTO> dtos)
        {
            if (dtos == null) return null;

            return dtos.Select(e => e.ToEntity()).ToList();
        }

        /// <summary>
        /// Converts each instance of <see cref="files"/> to an instance of <see cref="filesDTO"/>.
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public static List<filesDTO> ToDTOs(this IEnumerable<files> entities)
        {
            if (entities == null) return null;

            return entities.Select(e => e.ToDTO()).ToList();
        }

        public static void Actualizar(Dominio.Dtos.filesDTO dto, PersistenciaDatos.files entity)
        {
            entity.id_file = dto.id_file;
            entity.name_file = dto.name_file;
            entity.adjunt_date = dto.adjunt_date;
            entity.status = dto.status;
            entity.type = dto.type;
            entity.modify_date = dto.modify_date;
            entity.address = dto.address;

        }

    }
}
