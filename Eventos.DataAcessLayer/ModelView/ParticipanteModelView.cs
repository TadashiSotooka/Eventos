using Eventos.DataAcessLayer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Eventos.DataAcessLayer.ModelView
{
    public class ParticipanteModelView
    {
        [Required]
        public String NomeParticipante { get; set; }
        [Required]
        public String Email { get; set; }

        public Evento Evento;
    }
}
