using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tarea1.Models;


namespace Tarea1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TareasController : Controller
    {
        private readonly ILogger<TareasController> _logger;

        private IList<Tarea> _tareasList;

        public TareasController(ILogger<TareasController> logger)
        {
            this._logger = logger;

            this._tareasList = new List<Tarea>();

            this._tareasList.Add(new Tarea(1, "TestTarea1", "Picar1", 23, "Debugear", DateTime.Now));
            this._tareasList.Add(new Tarea(2, "TestTarea2", "Picar2", 24, "Debugear2", DateTime.Parse("2024-08-15 10:30:00")));
           


        }
                
        [HttpGet]
        public ActionResult<IList<Tarea>> GetAll()
        {
            _logger.LogInformation("Retorno lista de tareas");
            return Ok(_tareasList.ToList());
        }


        [HttpGet]
        [Route("{id}")]
        public ActionResult<Tarea> GetById(int id)
        {
            _logger.LogInformation($"Retorno tarea con id: {id}");
            return Ok(_tareasList[id]);
        }

        [HttpPost]
        public ActionResult CrearTarea([FromBody] Tarea tarea)
        {
            _logger.LogInformation($"Nueva tarea con id: {tarea.Id}");
            this._tareasList.Add(tarea);
            return Ok();
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteById(int id)
        {
            _logger.LogInformation($"Borrar tarea con id: {id}");
            this._tareasList.RemoveAt(id);
            return Ok();
        }
    }
}
