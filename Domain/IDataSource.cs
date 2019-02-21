using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public interface IDataSource
    {
        
        IQueryable<Country> Countries { get; }
        IQueryable<Region> Regions { get; }
        IQueryable<State> States { get; }
    }
}
