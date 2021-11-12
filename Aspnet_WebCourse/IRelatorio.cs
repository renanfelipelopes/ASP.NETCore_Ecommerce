using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace Aspnet_WebCourse
{
    public interface IRelatorio
    {
        Task Imprimir(HttpContext context);
    }
}