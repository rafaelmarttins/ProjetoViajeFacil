﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using ViajeFacil.Dominio.EF;

namespace ViajeFacil.Repository.Base
{
    public class GenericRepository<TDominio> where TDominio : class
    {
        private ViajeFacilContexto context;

        private DbSet<TDominio> table;

        public GenericRepository(ViajeFacilContexto context)
        {
            this.context = context;
            this.table = this.context.Set<TDominio>();
        }

        public IQueryable<TDominio> Browseable(Expression<Func<TDominio, bool>>? predicate = null)
        {
            if (predicate == null)
            {
                return this.table.AsQueryable();
            }
            else
            {
                return this.table.Where(predicate);
            }
        }

        public IQueryable<TDominio> GetAll(int? take = null, int? skip = null)
        {
            if (skip == null)
            {
                return this.table;
            }
            else
            {
                return this.table.Skip(skip.Value).Take(take.Value);
            }
        }

        public IQueryable<TDominio> Searchable(int? take = null, int? skip = null, Expression<Func<TDominio, bool>>? predicate = null)
        {
            if (skip == null)
            {
                if (predicate == null)
                {
                    return this.table;
                }
                else
                {
                    return this.table.Where(predicate);
                }
            }
            else
            {
                if (predicate == null)
                {
                    return this.table.Skip(skip.Value).Take(take.Value);
                }
                else
                {
                    return this.table.Where(predicate).Skip(skip.Value).Take(take.Value);
                }
            }
        }

        public TDominio? GetById(object id)
        {
            return this.table.Find(id);
        }

        public TDominio? Insert(TDominio obj)
        {
            this.table.Add(obj);
            this.context.SaveChanges();
            return obj;
        }

        public TDominio? Update(TDominio obj)
        {
            this.table.Attach(obj);
            this.context.Entry(obj).State = EntityState.Modified;
            this.context.SaveChanges();
            return obj;
        }

        public TDominio? Delete(object id)
        {
            TDominio? tabelaExistente = this.GetById(id);
            this.table.Remove(tabelaExistente);
            this.context.SaveChanges();
            return tabelaExistente;
        }

        public void Save()
        {
            this.context.SaveChanges();
        }
    }
}
