using ExemploCarol.Core.Entidades;
using ExemploCarol.Infra.Repositorio;
using System;
using System.Collections.Generic;

namespace ExemploCarol.Service
{
    internal class ClienteService
        //faz as validaçoes , regras de negocio
    {
        private readonly ClienteRepositorio _clienteRepositorio;
        public ClienteService()
        {
            _clienteRepositorio = new ClienteRepositorio();
        }
        public void AdicionarCliente(Cliente cliente) //regra é que o cliente tem que ter nome, sobrenome e nao precisa endereco
        {
            if (cliente == null || cliente.Nome == null || cliente.Sobrenome == null)
            {
                Console.WriteLine("Cliente invalido para cadastro");
                return;
            }else if (cliente.Nome.Length < 3)
            {
                Console.WriteLine("Nome do cliente deve ter mais de 3 caracteres");
                return;
            }
            _clienteRepositorio.AdicionarCliente(cliente);
        }

        public List<Cliente> ListarClientes()
        {
            return _clienteRepositorio.ListarClientes();
        }
    }
}
