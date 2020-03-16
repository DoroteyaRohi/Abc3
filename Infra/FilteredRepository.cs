﻿using Abc.Data.Common;
using Abc.Domain;
using Abc.Domain.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Abc.Infra
{
    public abstract class FilteredRepository<TDomain, TData> : SortedRepository<TDomain, TData>, ISearching 
        where TData : PeriodData, new() 
        where TDomain : Entity<TData>, new()
    {
        public string SearchString { get; set; }
        protected FilteredRepository(DbContext c, DbSet<TData> s) : base(c, s) {}

        protected internal override IQueryable<TData> createSqlQuery()
        {
            var query=  base.createSqlQuery();
            query = addFiltering(query);

            return query;

        }

        protected internal virtual IQueryable<TData> addFiltering(IQueryable<TData> query)
        {
            return query;
        }
    }
}