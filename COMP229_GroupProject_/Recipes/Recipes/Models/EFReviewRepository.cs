using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recipes.Models
{
    public class EFReviewRepository : IReviewRepository
    {
        private ApplicationDbContext context;

        public EFReviewRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }
        public IQueryable<AddedReviews> Reviews => context.Reviews;

    }
}
