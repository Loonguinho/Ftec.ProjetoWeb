using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ftec.ProjetoWeb.Aplicacao1.Mvc.Filtros
{
    public class CustomActionFilter : Attribute, IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {
            context.Result = new ContentResult()
            {
                Content = "Falha na execução, tente novamente mais tarde"
            };
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            context.Result = new ContentResult()
            {
                Content = "Recurso indisponivel, tente novamente mais tarde"
            };
        }
    }
}
