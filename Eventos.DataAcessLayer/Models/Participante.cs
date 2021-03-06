﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Eventos.DataAcessLayer.Models
{
    public class Participante
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdParticipante { get; set; }
        [Required]
        public String NomeParticipante { get; set; }
        [Required]
        //[EmailAddress]
        public String Email { get; set; }

        public Evento Evento { get; set; }
    }
}
