
using System.Collections.Generic;  
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Restaurant.Models;

namespace Restaurant.DataAccess  
{
    public class SSRDataAccessProvider : IDataAccessProvider<SmallStarRestaurant>
    {   
         private readonly PostgreSqlContext _context;  
  
        public SSRDataAccessProvider(PostgreSqlContext context)  
        {  
            _context = context;  
        } 

        public Task<bool> DeleteData(SmallStarRestaurant service)
        {
            throw new System.NotImplementedException();
        }

        public Task<List<SmallStarRestaurant>> GetData()
        {
           
             return  _context.smallStarRestaurant
                     .FromSqlRaw("select Restaurantid, ssrid, restaurantname,city,subcity,ownername,smtype, getBedRoomPrice(SmallStarRestaurant) as bedroomprice from SmallStarRestaurant;").ToListAsync();
        }

        public Task<SmallStarRestaurant> GetDataById(int id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<SmallStarRestaurant> InsertData(SmallStarRestaurant service)
        {
               _context.smallStarRestaurant.Add(service);

            await _context.SaveChangesAsync();
            return service;
        }

        public Task<SmallStarRestaurant> UpdateData(SmallStarRestaurant service)
        {
            throw new System.NotImplementedException();
        }
    }
}