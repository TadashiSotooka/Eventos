using Eventos.DataAcessLayer.DAO;
using Eventos.DataAcessLayer.Models;
using Eventos.DataAcessLayer.ModelView;
using System;
using System.Collections.Generic;
using System.Text;

namespace Eventos.BussinessLogicLayer
{
    public class ParticipanteBll
    {
        public void Insert(ParticipanteModelView participanteModelView)
        {
            var evento = new Evento();
            var participante = new Participante();
            participante = PrepararParticipante(participanteModelView, participante, evento);

            var participanteDAO = new ParticipanteDAO();
            participanteDAO.Inserir(participante);
        }

        public void Atualizar(int id, ParticipanteModelView participanteModelView)
        {
            var participanteDAO = new ParticipanteDAO();
            var participante = participanteDAO.ObterPorId(id);
            var evento = new Evento();
            participante = PrepararParticipante(participanteModelView, participante,evento);

            participanteDAO.Atualizar(participante);
        }

        public List<Participante> ObterTodos()
        {
            var participanteDAO = new ParticipanteDAO();
            return participanteDAO.ObterTodos();
        }
        public Participante ObterPorId(int id)
        {
            var participanteDAO = new ParticipanteDAO();
            return participanteDAO.ObterPorId(id);
        }

        public void Delete(int id)
        {
            var participanteDAO = new ParticipanteDAO();
            participanteDAO.Deletar(id);
        }

        public Participante PrepararParticipante(ParticipanteModelView participanteModelView, Participante participante, Evento evento)
        {
            participante.NomeParticipante = participanteModelView.NomeParticipante;
            participante.Email = participanteModelView.Email;
            evento.IdEvento = participanteModelView.Evento.IdEvento;

            return participante;

        }
    }
}
