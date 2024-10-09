using System;
using System.Collections.Generic;
using System.Text;

namespace ExemploCarol.Core.Entidades
{
    internal class Endereco : EntidadeBase
    {
       // public int Id { get; set; }//do endereço
        public string Rua { get; set; }
        public int Numero { get; set; }
        public int ClienteID { get; set; }//chave estrangeira com a tabela cliente

    }
}
