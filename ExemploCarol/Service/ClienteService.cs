using System;
using System.Collections.Generic;
using System.Net.WebSockets;
using System.Text;
using ExemploCarol.Core.Entidades;
using ExemploCarol.Infra.Repositorio;

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
        public void AdicionarCliente(Cliente cliente)
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
    }
}
