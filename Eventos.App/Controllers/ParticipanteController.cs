using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Eventos.BussinessLogicLayer;
using Eventos.DataAcessLayer.ModelView;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Eventos.App.Controllers
{
    //[Produces("application/json")]
    [Route("api/Participante")]
    public class ParticipanteController : Controller
    {
        [HttpPost]
        public IActionResult Post([FromBody] ParticipanteModelView participanteModelView)
        {
            try
            {
                var participanteBll = new ParticipanteBll();
                participanteBll.Insert(participanteModelView);
                return NoContent();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return StatusCode(500);
            }
        }

        //api/Serie/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] ParticipanteModelView participanteModelView)
        {
            try
            {
                var participanteBll = new ParticipanteBll();
                participanteBll.Atualizar(id, participanteModelView);
                return NoContent();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return StatusCode(500);
            }
        }

        //api/Serie/5
        [HttpGet("{id}")]
        public IActionResult GetComId(int id)
        {
            try
            {
                var participanteBll = new ParticipanteBll();
                var participante = participanteBll.ObterPorId(id);
                return Json(participante);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return StatusCode(500);
            }
        }

        //api/Serie/5
        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                var participanteBll = new ParticipanteBll();
                var listaDeParticipantes = participanteBll.ObterTodos();
                return Json(listaDeParticipantes);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return StatusCode(500);
            }
        }


    }
}