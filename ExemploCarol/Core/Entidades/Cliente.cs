using System;
using System.Collections.Generic;
using System.Text;

namespace ExemploCarol.Core.Entidades
{
    internal class Cliente : EntidadeBase
    {
       // public int Id { get; set; } -> a entidade base ja tem
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public Endereco Endereco { get; set; }//relação de endereço com cliente 
    }
}
