using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aspnet_WebCourse
{
    public class Relatorio : IRelatorio
    {
        private readonly ICatalogo catalogo;

        public Relatorio(ICatalogo catalogo)
        {
            this.catalogo = catalogo;
        }

        public async Task Imprimir(HttpContext context)
        {
            foreach (var livro in catalogo.GetLivros())
            {
                await context.Response.WriteAsync($"{livro.Codigo,-10} {livro.Nome,-40} {livro.Preco.ToString("C"),10} \r\n");
            }
        }
    }
}
