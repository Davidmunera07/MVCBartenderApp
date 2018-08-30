using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCBartenderApp.Models
{
    public interface ICocktailRepository
    {
         IQueryable<Cocktail> Cocktails { get; }
    }
}
