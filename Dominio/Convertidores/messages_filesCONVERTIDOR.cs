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
    /// Assembler for <see cref="messages_files"/> and <see cref="messages_filesDTO"/>.
    /// </summary>
    public static partial class messages_filesCONVERTIDOR
    {
        /// <summary>
        /// Invoked when <see cref="ToDTO"/> operation is about to return.
        /// </summary>
        /// <param name="dto"><see cref="messages_filesDTO"/> converted from <see cref="messages_files"/>.</param>
        static partial void OnDTO(this messages_files entity, messages_filesDTO dto);

        /// <summary>
        /// Invoked when <see cref="ToEntity"/> operation is about to return.
        /// </summary>
        /// <param name="entity"><see cref="messages_files"/> converted from <see cref="messages_filesDTO"/>.</param>
        static partial void OnEntity(this messages_filesDTO dto, messages_files entity);

        /// <summary>
        /// Converts this instance of <see cref="messages_filesDTO"/> to an instance of <see cref="messages_files"/>.
        /// </summary>
        /// <param name="dto"><see cref="messages_filesDTO"/> to convert.</param>
        public static messages_files ToEntity(this messages_filesDTO dto)
        {
            if (dto == null) return null;

            var entity = new messages_files();

            entity.id_messages_files = dto.id_messages_files;
            entity.id_message = dto.id_message;
            entity.id_file = dto.id_file;

            dto.OnEntity(entity);

            return entity;
        }

        /// <summary>
        /// Converts this instance of <see cref="messages_files"/> to an instance of <see cref="messages_filesDTO"/>.
        /// </summary>
        /// <param name="entity"><see cref="messages_files"/> to convert.</param>
        public static messages_filesDTO ToDTO(this messages_files entity)
        {
            if (entity == null) return null;

            var dto = new messages_filesDTO();

            dto.id_messages_files = entity.id_messages_files;
            dto.id_message = entity.id_message;
            dto.id_file = entity.id_file;

            entity.OnDTO(dto);

            return dto;
        }

        /// <summary>
        /// Converts each instance of <see cref="messages_filesDTO"/> to an instance of <see cref="messages_files"/>.
        /// </summary>
        /// <param name="dtos"></param>
        /// <returns></returns>
        public static List<messages_files> ToEntities(this IEnumerable<messages_filesDTO> dtos)
        {
            if (dtos == null) return null;

            return dtos.Select(e => e.ToEntity()).ToList();
        }

        /// <summary>
        /// Converts each instance of <see cref="messages_files"/> to an instance of <see cref="messages_filesDTO"/>.
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public static List<messages_filesDTO> ToDTOs(this IEnumerable<messages_files> entities)
        {
            if (entities == null) return null;

            return entities.Select(e => e.ToDTO()).ToList();
        }

        public static void Actualizar(Dominio.Dtos.messages_filesDTO dto, PersistenciaDatos.messages_files entity)
        {
            entity.id_messages_files = dto.id_messages_files;
            entity.id_message = dto.id_message;
            entity.id_file = dto.id_file;

        }

    }
}
