using System;

namespace Cliente
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente();
            cliente.Email = "erbson.santos#Developer.com";
            cliente.nome = "Jó";
            cliente.idade = 17;
            ValidaDados valida = new ValidaDados();
            valida.Valida(cliente);


        }
    }
}
