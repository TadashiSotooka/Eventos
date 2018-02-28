using System;
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
        public String Nome { get; set; }
        public String Local { get; set; }
        public DateTime Data { get; set; }
        public DateTime HoraIncio { get; set; }
        public DateTime HoraFim{ get; set; }
        public String OpenBar { get; set; }
        public int QuantidadeDeAmbientes { get; set; }
        public int FaixaEtaria { get; set; }
    }
}
