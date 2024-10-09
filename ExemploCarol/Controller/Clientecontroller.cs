using System;
using System.Collections.Generic;
using System.Text;
using ExemploCarol.Core.Entidades;
using ExemploCarol.Service;


namespace ExemploCarol.Controller
{
    internal class Clientecontroller
    {
        private readonly ClienteService _clienteService;
        public void AdicionarCliente(string nome, string sobrenome)
        {
            Cliente cliente = new Cliente()
            {
                Nome = nome,
                Sobrenome = sobrenome
            };
            _clienteService.AdicionarCliente(cliente);

            //return OK();

        }

    }
}
