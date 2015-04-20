//-------------------------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by EntitiesToDTOs.v3.2 (entitiestodtos.codeplex.com).
//     Timestamp: 2015/04/19 - 13:27:59
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
    /// Assembler for <see cref="acts"/> and <see cref="actsDTO"/>.
    /// </summary>
    public static partial class actsCONVERTIDOR
    {
        /// <summary>
        /// Invoked when <see cref="ToDTO"/> operation is about to return.
        /// </summary>
        /// <param name="dto"><see cref="actsDTO"/> converted from <see cref="acts"/>.</param>
        static partial void OnDTO(this acts entity, actsDTO dto);

        /// <summary>
        /// Invoked when <see cref="ToEntity"/> operation is about to return.
        /// </summary>
        /// <param name="entity"><see cref="acts"/> converted from <see cref="actsDTO"/>.</param>
        static partial void OnEntity(this actsDTO dto, acts entity);

        /// <summary>
        /// Converts this instance of <see cref="actsDTO"/> to an instance of <see cref="acts"/>.
        /// </summary>
        /// <param name="dto"><see cref="actsDTO"/> to convert.</param>
        public static acts ToEntity(this actsDTO dto)
        {
            if (dto == null) return null;

            var entity = new acts();

            entity.id_act = dto.id_act;
            entity.name_act = dto.name_act;
            entity.create_date = dto.create_date;
            entity.status = dto.status;
            entity.description_small = dto.description_small;
            entity.description_large = dto.description_large;
            entity.id_user_create = dto.id_user_create;

            dto.OnEntity(entity);

            return entity;
        }

        /// <summary>
        /// Converts this instance of <see cref="acts"/> to an instance of <see cref="actsDTO"/>.
        /// </summary>
        /// <param name="entity"><see cref="acts"/> to convert.</param>
        public static actsDTO ToDTO(this acts entity)
        {
            if (entity == null) return null;

            var dto = new actsDTO();

            dto.id_act = entity.id_act;
            dto.name_act = entity.name_act;
            dto.create_date = entity.create_date;
            dto.status = entity.status;
            dto.description_small = entity.description_small;
            dto.description_large = entity.description_large;
            dto.id_user_create = entity.id_user_create;

            entity.OnDTO(dto);

            return dto;
        }

        /// <summary>
        /// Converts each instance of <see cref="actsDTO"/> to an instance of <see cref="acts"/>.
        /// </summary>
        /// <param name="dtos"></param>
        /// <returns></returns>
        public static List<acts> ToEntities(this IEnumerable<actsDTO> dtos)
        {
            if (dtos == null) return null;

            return dtos.Select(e => e.ToEntity()).ToList();
        }

        /// <summary>
        /// Converts each instance of <see cref="acts"/> to an instance of <see cref="actsDTO"/>.
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public static List<actsDTO> ToDTOs(this IEnumerable<acts> entities)
        {
            if (entities == null) return null;

            return entities.Select(e => e.ToDTO()).ToList();
        }

    }
}
