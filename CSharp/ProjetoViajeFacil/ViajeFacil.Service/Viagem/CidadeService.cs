using System;
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
    public class CidadeService : GenericService<Cidade, CidadePoco>
    {
        public CidadeService(ViajeFacilContexto context) : base(context) 
        { }

        public override List<CidadePoco> Consultar(Expression<Func<Cidade, bool>>? predicate = null)
        {
            IQueryable<Cidade> query;
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

        public override List<CidadePoco> Listar(int? take = null, int? skip = null)
        {
            IQueryable<Cidade> query;
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

        public override List<CidadePoco> Vasculhar(int? take = null, int? skip = null, Expression<Func<Cidade, bool>>? predicate = null)
        {
            IQueryable<Cidade> query;
            if (skip == null)
            {
                if (predicate == null)
                {
                    query = this.genrepo.Browseable(null);
                }
                else
                {
                    query = this.genrepo.Browseable(predicate);
                }
            }
            else
            {
                if (predicate == null)
                {
                    query = this.genrepo.GetAll(take, skip);
                }
                else
                {
                    query = this.genrepo.Searchable(take, skip, predicate);
                }
            }
            return this.ConverterPara(query);
        }

        public override List<CidadePoco> ConverterPara(IQueryable<Cidade> query)
        {
            return query.Select(cid =>
                    new CidadePoco()
                    {
                        CodigoCidade = cid.CodigoCidade,
                        Nome = cid.Nome,
                        CodigoIbge7 = cid.CodigoIbge7,
                        SiglaUf = cid.SiglaUf,
                        CodigoEstado = cid.CodigoEstado
                    }
            )
            .ToList();
        }
    }
}
