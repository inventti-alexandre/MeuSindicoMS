﻿using System;

namespace MeuSindicoMS.Domain.Arguments.Usuario
{
    public class AutenticarUsuarioResponse
    {
        public Guid Id { get; set; }
        public string PrimeiroNome { get; set; }

        public static explicit operator AutenticarUsuarioResponse(Entities.Playlist.UsuarioPlaylist entidade)
        {
            return new AutenticarUsuarioResponse() {
                Id = entidade.Id,
                PrimeiroNome = entidade.Nome.PrimeiroNome
            };
        }
    }
}
