﻿using System;
using System.Collections.Generic;
using System.Text;
using ExemploCarol.Core.Entidades;

namespace ExemploCarol.Infra.Repositorio
{
    internal class ClienteRepositorio
    {
        //essa classe vai manipular crud de cliente, vai fazer a comunicação com o banco
        private static List<Cliente> clientes = new List<Cliente>();
        public void AdicionarCliente(Cliente cliente)
        {
            //contexto<cliente>().Add() -> esta se comunicando com o banco de dados. como nao temos, vai criar uma lista pra simular o banco
            //context.SaveChanges()
            clientes.Add(cliente);
        }
    }
}