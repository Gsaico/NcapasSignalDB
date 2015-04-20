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
    /// Assembler for <see cref="users_acts"/> and <see cref="users_actsDTO"/>.
    /// </summary>
    public static partial class users_actsCONVERTIDOR
    {
        /// <summary>
        /// Invoked when <see cref="ToDTO"/> operation is about to return.
        /// </summary>
        /// <param name="dto"><see cref="users_actsDTO"/> converted from <see cref="users_acts"/>.</param>
        static partial void OnDTO(this users_acts entity, users_actsDTO dto);

        /// <summary>
        /// Invoked when <see cref="ToEntity"/> operation is about to return.
        /// </summary>
        /// <param name="entity"><see cref="users_acts"/> converted from <see cref="users_actsDTO"/>.</param>
        static partial void OnEntity(this users_actsDTO dto, users_acts entity);

        /// <summary>
        /// Converts this instance of <see cref="users_actsDTO"/> to an instance of <see cref="users_acts"/>.
        /// </summary>
        /// <param name="dto"><see cref="users_actsDTO"/> to convert.</param>
        public static users_acts ToEntity(this users_actsDTO dto)
        {
            if (dto == null) return null;

            var entity = new users_acts();

            entity.id_user_act = dto.id_user_act;
            entity.id_act = dto.id_act;
            entity.id_user = dto.id_user;

            dto.OnEntity(entity);

            return entity;
        }

        /// <summary>
        /// Converts this instance of <see cref="users_acts"/> to an instance of <see cref="users_actsDTO"/>.
        /// </summary>
        /// <param name="entity"><see cref="users_acts"/> to convert.</param>
        public static users_actsDTO ToDTO(this users_acts entity)
        {
            if (entity == null) return null;

            var dto = new users_actsDTO();

            dto.id_user_act = entity.id_user_act;
            dto.id_act = entity.id_act;
            dto.id_user = entity.id_user;

            entity.OnDTO(dto);

            return dto;
        }

        /// <summary>
        /// Converts each instance of <see cref="users_actsDTO"/> to an instance of <see cref="users_acts"/>.
        /// </summary>
        /// <param name="dtos"></param>
        /// <returns></returns>
        public static List<users_acts> ToEntities(this IEnumerable<users_actsDTO> dtos)
        {
            if (dtos == null) return null;

            return dtos.Select(e => e.ToEntity()).ToList();
        }

        /// <summary>
        /// Converts each instance of <see cref="users_acts"/> to an instance of <see cref="users_actsDTO"/>.
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public static List<users_actsDTO> ToDTOs(this IEnumerable<users_acts> entities)
        {
            if (entities == null) return null;

            return entities.Select(e => e.ToDTO()).ToList();
        }

        public static void Actualizar(Dominio.Dtos.users_actsDTO dto, PersistenciaDatos.users_acts entity)
        {
            entity.id_user_act = dto.id_user_act;
            entity.id_act = dto.id_act;
            entity.id_user = dto.id_user;
        }

    }
}
