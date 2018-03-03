using Eventos.DataAcessLayer.DAO;
using Eventos.DataAcessLayer.Models;
using Eventos.DataAcessLayer.ModelView;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Eventos.BussinessLogicLayer
{
    public class EventoBll
    {
        public void Insert(EventoModelView eventoModelView)
        {
            var evento = new Evento();
            evento = PrepararEvento(eventoModelView, evento);

            var eventoDAO = new EventoDAO();
            eventoDAO.Inserir(evento);
        }

        public void Atualizar(int id, EventoModelView eventoModelView)
        {
            var eventoDAO = new EventoDAO();
            var evento = eventoDAO.ObterPorId(id);

            evento = PrepararEvento(eventoModelView, evento);

            eventoDAO.Atualizar(evento);
        }

        public List<Evento> ObterTodos()
        {
            var eventoDAO = new EventoDAO();
            return eventoDAO.ObterTodos();
        }
        public Evento ObterPorId(int id)
        {
            var eventoDAO = new EventoDAO();
            return eventoDAO.ObterPorId(id);
        }

        public void Delete(int id)
        {
            var eventoDAO = new EventoDAO();
            eventoDAO.Deletar(id);
        }

        public Evento PrepararEvento(EventoModelView eventoModelView, Evento evento)
        {
            evento.Nome = eventoModelView.Nome;
            evento.Data = eventoModelView.Data;
            evento.HoraIncio = eventoModelView.HoraIncio;
            evento.HoraFim = eventoModelView.HoraFim;
            evento.OpenBar = eventoModelView.OpenBar;
            evento.QuantidadeDeAmbientes = eventoModelView.QuantidadeDeAmbientes;
            //evento.FaixaEtaria = eventoModelView.FaixaEtaria;

            evento.MaximoIngressos = eventoModelView.MaximoIngressos;
            evento.IngressosVendidos = eventoModelView.IngressosVendidos;

            if(evento.IngressosVendidos > evento.MaximoIngressos)
            {
                var message = string.Format("Não foi possivel, esgotou os ingressos");
                Console.WriteLine(message);
            }

            /*  
            if (evento.HoraIncio > 10:00 && evento.HoraFim < 20:00  && evento.QuantidadeDeAmbientes > 2)
            {
                evento.FaixaEtaria = "Para menores de 16";
            }
            else if (evento.HoraInicio > 20:30 && evento.HoraFim < 02:00 && evento.OpenBar == false)
            {
                evento.FaixaEtaria = "Para maiores de 16";
            }
            else
            {
                evento.FaixaEtaria =  "Para Maiores de 18";
            }*/

            return evento;

        }
    }
}