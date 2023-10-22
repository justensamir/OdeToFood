using OdeToFood.Business.Services;
using OdeToFood.Data.Data;
using OdeToFood.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdeToFood.Business.Repositories
{
    public class RestaurantRepository : GenericRepository<Restaurant>, IResturantRepository
    {
        public RestaurantRepository(OdeToFoodDbContext context) : base(context)
        {
        }
    }
}
