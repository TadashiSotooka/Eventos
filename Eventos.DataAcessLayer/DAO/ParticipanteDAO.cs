using Eventos.DataAcessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Eventos.DataAcessLayer.DAO
{
    public class ParticipanteDAO
    {
        public List<Participante> ObterTodos()
        {
            using (var database = new Database())
            {

                return database.Participantes.ToList();
            }
        }
        public void Inserir(Participante participante)
        {
            using (var database = new Database())
            {
                database.Participantes.Add(participante);
                database.SaveChanges();
            }

        }

        public Participante ObterPorId(int id)
        {
            using (var database = new Database())
            {
                return database.Participantes.Find(id);
            }
        }

        public void Deletar(int id)
        {
            using (var database = new Database())
            {
                var participante = ObterPorId(id);
                database.Participantes.Remove(participante);
                database.SaveChanges();
            }
        }

        public void Atualizar(Participante participante)
        {

            using (var database = new Database())
            {
                database.Participantes.Update(participante);
                database.SaveChanges();
            }

        }
    }
}
