using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Cliente
{
   public class ValidaDados
    {

        public void Valida(Cliente cliente)
        {
            var ctx = new ValidationContext(cliente);
            var resultados = new List<ValidationResult>();
            if (!Validator.TryValidateObject(cliente, ctx, resultados, true))
            {
                foreach (var erros in resultados)
                {
                    Console.WriteLine($"Erro de validação : {erros}");
                }
            }

           
        }

    }
}
