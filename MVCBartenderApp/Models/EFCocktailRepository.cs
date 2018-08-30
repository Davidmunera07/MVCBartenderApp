using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCBartenderApp.Models
{
    public class EFCocktailRepository : ICocktailRepository
    {
        private ApplicationDbContext context;

        public EFCocktailRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }
        public IQueryable<Cocktail> Cocktails => context.Cocktails;
    }
}
