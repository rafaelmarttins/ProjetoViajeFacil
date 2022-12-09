﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

using ViajeFacil.Dominio.EF;
using ViajeFacil.Poco;
using ViajeFacil.Service.Base;

namespace ViajeFacil.Service.Viagem
{
    public class ParticipanteEventoService : GenericService<ParticipanteEvento, ParticipanteEventoPoco>
    {
        public ParticipanteEventoService(ViajeFacilContexto context) : base(context) 
        { }

        public override List<ParticipanteEventoPoco> Consultar(Expression<Func<ParticipanteEvento, bool>>? predicate = null)
        {
            IQueryable<ParticipanteEvento> query;
            if (predicate == null)
            {
                query = this.genrepo.Browseable(null);
            }
            else
            {
                query = this.genrepo.Browseable(predicate);
            }
            return this.ConverterPara(query);
        }

        public override List<ParticipanteEventoPoco> Listar(int? take = null, int? skip = null)
        {
            IQueryable<ParticipanteEvento> query;
            if (skip == null)
            {
                query = this.genrepo.GetAll();
            }
            else
            {
                query = this.genrepo.GetAll(take, skip);
            }
            return ConverterPara(query);
        }

        public override List<ParticipanteEventoPoco> ConverterPara(IQueryable<ParticipanteEvento> query)
        {
            return query.Select(par =>
                    new ParticipanteEventoPoco()
                    {
                        CodigoParticipante = par.CodigoParticipante,
                        Pagamento = par.Pagamento,
                        Sugestao = par.Sugestao,
                        Avaliacao = par.Avaliacao,
                        CodigoEvento = par.CodigoEvento,
                        CodigoUsuario = par.CodigoUsuario
                    }
            )
            .ToList();
        }
    }
}
