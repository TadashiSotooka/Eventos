using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Eventos.DataAcessLayer.ModelView
{
    public class EventoModelView
    {

        public String Nome { get; set; }
        public String Local { get; set; }
        public DateTime Data { get; set; }
        public TimeSpan HoraIncio { get; set; }
        public TimeSpan HoraFim { get; set; }
        public Boolean OpenBar { get; set; }
        public int QuantidadeDeAmbientes { get; set; }
        public String FaixaEtaria { get; set; }

        public int MaximoIngressos { get; set; }
        public int IngressosVendidos { get; set; }
    }
}
