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
    /// Assembler for <see cref="users"/> and <see cref="usersDTO"/>.
    /// </summary>
    public static partial class usersCONVERTIDOR
    {
        /// <summary>
        /// Invoked when <see cref="ToDTO"/> operation is about to return.
        /// </summary>
        /// <param name="dto"><see cref="usersDTO"/> converted from <see cref="users"/>.</param>
        static partial void OnDTO(this users entity, usersDTO dto);

        /// <summary>
        /// Invoked when <see cref="ToEntity"/> operation is about to return.
        /// </summary>
        /// <param name="entity"><see cref="users"/> converted from <see cref="usersDTO"/>.</param>
        static partial void OnEntity(this usersDTO dto, users entity);

        /// <summary>
        /// Converts this instance of <see cref="usersDTO"/> to an instance of <see cref="users"/>.
        /// </summary>
        /// <param name="dto"><see cref="usersDTO"/> to convert.</param>
        public static users ToEntity(this usersDTO dto)
        {
            if (dto == null) return null;

            var entity = new users();

            entity.id_user = dto.id_user;
            entity.username = dto.username;
            entity.fullname = dto.fullname;
            entity.password = dto.password;
            entity.create_date = dto.create_date;
            entity.last_acces_datex = dto.last_acces_datex;
            entity.status = dto.status;
            entity.mail = dto.mail;
            entity.date_of_birth = dto.date_of_birth;
            entity.profession = dto.profession;
            entity.id_department = dto.id_department;
            entity.role = dto.role;

            dto.OnEntity(entity);

            return entity;
        }

        /// <summary>
        /// Converts this instance of <see cref="users"/> to an instance of <see cref="usersDTO"/>.
        /// </summary>
        /// <param name="entity"><see cref="users"/> to convert.</param>
        public static usersDTO ToDTO(this users entity)
        {
            if (entity == null) return null;

            var dto = new usersDTO();

            dto.id_user = entity.id_user;
            dto.username = entity.username;
            dto.fullname = entity.fullname;
            dto.password = entity.password;
            dto.create_date = entity.create_date;
            dto.last_acces_datex = entity.last_acces_datex;
            dto.status = entity.status;
            dto.mail = entity.mail;
            dto.date_of_birth = entity.date_of_birth;
            dto.profession = entity.profession;
            dto.id_department = entity.id_department;
            dto.role = entity.role;

            entity.OnDTO(dto);

            return dto;
        }

        /// <summary>
        /// Converts each instance of <see cref="usersDTO"/> to an instance of <see cref="users"/>.
        /// </summary>
        /// <param name="dtos"></param>
        /// <returns></returns>
        public static List<users> ToEntities(this IEnumerable<usersDTO> dtos)
        {
            if (dtos == null) return null;

            return dtos.Select(e => e.ToEntity()).ToList();
        }

        /// <summary>
        /// Converts each instance of <see cref="users"/> to an instance of <see cref="usersDTO"/>.
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public static List<usersDTO> ToDTOs(this IEnumerable<users> entities)
        {
            if (entities == null) return null;

            return entities.Select(e => e.ToDTO()).ToList();
        }

    }
}
