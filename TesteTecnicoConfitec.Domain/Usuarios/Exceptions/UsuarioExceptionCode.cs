using System;
using System.Collections.Generic;
using System.Text;

namespace TesteTecnicoConfitec.Domain.Usuarios.Exceptions
{
    public static class UsuarioExceptionCode
    {
        // Value Object
        public static string OEmailInformadoNaoEValido = "O email informado não é válido";
        public static string ADataDeNascimentoDeveSerSuperiorADataAtual = "A data de nascimento deve ser superior à data atual";

        // Command Handler
        public static string UsuarioInformadoNaoEncontrado = "Usuário informado não encontrado";
    }
}
