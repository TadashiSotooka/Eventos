﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Eventos.DataAcessLayer.Models
{
    public class Evento
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdEvento { get; set; }
        [Required]
        //[StringLength(50)]
        public String Nome { get; set; }
        [Required]
        //[StringLength(100)]
        public String Local { get; set; }
        [DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Data { get; set; }
        //[DisplayFormat(DataFormatString = "{0:hh\\:mm}", ApplyFormatInEditMode = true)]
        public TimeSpan HoraIncio { get; set; }
        //[DisplayFormat(DataFormatString = "{0:hh\\:mm}", ApplyFormatInEditMode = true)]
        public TimeSpan HoraFim { get; set; }
        [Required]
        public Boolean OpenBar { get; set; }
        public int QuantidadeDeAmbientes { get; set; }
        [Required]
        public String FaixaEtaria { get; set; }

        public int MaximoIngressos { get; set; }
        public int IngressosVendidos { get; set; }

        public ICollection<Participante> Participantes { get; set; }
    }
}
