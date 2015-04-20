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
    /// Assembler for <see cref="messages"/> and <see cref="messagesDTO"/>.
    /// </summary>
    public static partial class messagesCONVERTIDOR
    {
        /// <summary>
        /// Invoked when <see cref="ToDTO"/> operation is about to return.
        /// </summary>
        /// <param name="dto"><see cref="messagesDTO"/> converted from <see cref="messages"/>.</param>
        static partial void OnDTO(this messages entity, messagesDTO dto);

        /// <summary>
        /// Invoked when <see cref="ToEntity"/> operation is about to return.
        /// </summary>
        /// <param name="entity"><see cref="messages"/> converted from <see cref="messagesDTO"/>.</param>
        static partial void OnEntity(this messagesDTO dto, messages entity);

        /// <summary>
        /// Converts this instance of <see cref="messagesDTO"/> to an instance of <see cref="messages"/>.
        /// </summary>
        /// <param name="dto"><see cref="messagesDTO"/> to convert.</param>
        public static messages ToEntity(this messagesDTO dto)
        {
            if (dto == null) return null;

            var entity = new messages();

            entity.id_message = dto.id_message;
            entity.from_user_id = dto.from_user_id;
            entity.to_user_id = dto.to_user_id;
            entity.subject = dto.subject;
            entity.contentx = dto.contentx;
            entity.create_date = dto.create_date;
            entity.unread = dto.unread;
            entity.status = dto.status;
            entity.id_workgroup = dto.id_workgroup;
            entity.id_act = dto.id_act;

            dto.OnEntity(entity);

            return entity;
        }

        /// <summary>
        /// Converts this instance of <see cref="messages"/> to an instance of <see cref="messagesDTO"/>.
        /// </summary>
        /// <param name="entity"><see cref="messages"/> to convert.</param>
        public static messagesDTO ToDTO(this messages entity)
        {
            if (entity == null) return null;

            var dto = new messagesDTO();

            dto.id_message = entity.id_message;
            dto.from_user_id = entity.from_user_id;
            dto.to_user_id = entity.to_user_id;
            dto.subject = entity.subject;
            dto.contentx = entity.contentx;
            dto.create_date = entity.create_date;
            dto.unread = entity.unread;
            dto.status = entity.status;
            dto.id_workgroup = entity.id_workgroup;
            dto.id_act = entity.id_act;

            entity.OnDTO(dto);

            return dto;
        }

        /// <summary>
        /// Converts each instance of <see cref="messagesDTO"/> to an instance of <see cref="messages"/>.
        /// </summary>
        /// <param name="dtos"></param>
        /// <returns></returns>
        public static List<messages> ToEntities(this IEnumerable<messagesDTO> dtos)
        {
            if (dtos == null) return null;

            return dtos.Select(e => e.ToEntity()).ToList();
        }

        /// <summary>
        /// Converts each instance of <see cref="messages"/> to an instance of <see cref="messagesDTO"/>.
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public static List<messagesDTO> ToDTOs(this IEnumerable<messages> entities)
        {
            if (entities == null) return null;

            return entities.Select(e => e.ToDTO()).ToList();
        }
        public static void Actualizar(Dominio.Dtos.messagesDTO dto, PersistenciaDatos.messages entity)
        {
            entity.id_message = dto.id_message;
            entity.from_user_id = dto.from_user_id;
            entity.to_user_id = dto.to_user_id;
            entity.subject = dto.subject;
            entity.contentx = dto.contentx;
            entity.create_date = dto.create_date;
            entity.unread = dto.unread;
            entity.status = dto.status;
            entity.id_workgroup = dto.id_workgroup;
            entity.id_act = dto.id_act;

        }

    }
}
