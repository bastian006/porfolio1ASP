using Microsoft.AspNetCore.Mvc;//usando las carpetas de mvc, voy a buscar carpetas dentro de la instalacion de c#
namespace portfolio.Controllers;

public class ProyectController : Controller{

    [HttpGet]
    [Route("")]
    public string Index(){
      return "This is my index";       
    }

    [HttpGet]
    [Route("Projects")]
    public string project(){
        return "these are my projects";
    }

    [HttpGet]
    [Route("Contact")]
    public String contact(){
        return "This is my Contact";
    }
}
