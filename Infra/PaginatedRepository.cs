﻿using Abc.Data.Common;
using Abc.Domain;
using Abc.Domain.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
namespace Abc.Infra
{
    public abstract class PaginatedRepository<TDomain, TData> : FilteredRepository<TDomain, TData>, IPaging 
        where TData : PeriodData, new() 
        where TDomain : Entity<TData>, new()
    {
        protected PaginatedRepository(DbContext c, DbSet<TData> s) : base(c, s) { }

        public int PageIndex { get; set; }
        public int TotalPages => getTotalPages(PageSize);

        public bool HasNextPage => PageIndex < TotalPages; //можно увидить след. стр только если индекс < общ.кол.
        public bool HasPreviousPage => PageIndex > 1; //можно увидить прошлую стр только если индекс >1
        public int PageSize { get; set; } = 5;

        internal int getTotalPages(in int pageSize)
        {
            var count = getItemsCount(); 
            var pages = countTotalPages(count, pageSize);

            return pages;
        } 

        internal int countTotalPages(int count, in int pageSize)
            =>(int)Math.Ceiling(count / (double)pageSize);
        
        
        internal int getItemsCount() => base.createSqlQuery().CountAsync().Result;

        protected internal override IQueryable<TData> createSqlQuery()
            =>addSkipAndTake(base.createSqlQuery());
        

        private IQueryable<TData> addSkipAndTake(IQueryable<TData> query)
        {
            if (PageIndex < 1) return query;

            return query
                    .Skip((PageIndex - 1) * PageSize)
                    .Take(PageSize);
        }
    }
}
