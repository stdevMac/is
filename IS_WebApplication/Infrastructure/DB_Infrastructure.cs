using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Domain;

namespace IS_WebApplication.Infrastructure
{
    public class DB_Infrastructure : DbContext, IDataSource
    {
        //public DbSet<Pais> PaicesTable { get; set; }
        //public DbSet<Provincia> ProvinciasTable { get; set; }

        //public DB_Infrastructure() : base("DefaultConnection")
        //{
        //}

        //public IQueryable<Provincia> Provincias
        //{ get { return ProvinciasTable; } }

        //public IQueryable<Pais> Paices { get { return PaicesTable; } }

        public DbSet<Country> CountriesTable { get; set; }
        public DbSet<State> StatesTable { get; set; }
        public DbSet<Region> RegionsTable { get; set; }

        public DB_Infrastructure(): base("DefaultConnection") { }

        public IQueryable<Country> Countries
        {
            get
            {
                return CountriesTable;
            }
        }

        public IQueryable<Region> Regions
        {
            get
            {
                return RegionsTable;
            }
        }

        public IQueryable<State> States
        {
            get
            {
                return StatesTable;
            }
        }

        public object RegionTable { get; internal set; }
    }
}