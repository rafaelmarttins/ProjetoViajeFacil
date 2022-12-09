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
    public class EstadoService : GenericService<Estado, EstadoPoco>
    {
        public EstadoService(ViajeFacilContexto context) : base(context) 
        { }
        public override List<EstadoPoco> Consultar(Expression<Func<Estado, bool>>? predicate = null)
        {
            IQueryable<Estado> query;
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

        public override List<EstadoPoco> Listar(int? take = null, int? skip = null)
        {
            IQueryable<Estado> query;
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

        public override List<EstadoPoco> ConverterPara(IQueryable<Estado> query)
        {
            return query.Select(est =>
                    new EstadoPoco()
                    {
                        CodigoEstado = est.CodigoEstado,
                        Nome = est.Nome,
                        CodigoUf = est.CodigoUf,
                        SiglaUf = est.SiglaUf,
                        CodigoRegiao = est.CodigoRegiao
                    }
            )
            .ToList();
        }
    }
}
