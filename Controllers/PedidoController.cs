using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using prova.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prova.Controllers
{
    [ApiController]
    [Route("Controller")]
    public class PedidoController : ControllerBase
    {
        [HttpGet]
        Public IACTIONRESULT GetPedidos()
            {
            return List < PedidoDeVendaViewModel > pedidos = FileService.XmlReader();
        }

        [HttpPost]
        public IActionResult Post(JObject payload)
             {          
            FileService.GravarJson(payload);

    }
    }
}
