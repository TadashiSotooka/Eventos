using Eventos.DataAcessLayer.DAO;
using Eventos.DataAcessLayer.Models;
using Eventos.DataAcessLayer.ModelView;
using System;
using System.Collections.Generic;
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
            return evento;

        }
    }
}