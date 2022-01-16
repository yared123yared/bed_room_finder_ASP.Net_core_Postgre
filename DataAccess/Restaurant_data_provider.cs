
using System.Collections.Generic;  
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.DataAccess  
{
    public class DataAccessProvider : IDataAccessProvider<Restaurant.Models.Restaurant>
    {
        public Task<bool> DeleteData(Models.Restaurant service)
        {
            throw new System.NotImplementedException();
        }

        public Task<List<Models.Restaurant>> GetData()
        {
            throw new System.NotImplementedException();
        }

        public Task<Models.Restaurant> GetDataById(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<Models.Restaurant> InsertData(Models.Restaurant service)
        {
            throw new System.NotImplementedException();
        }

        public Task<Models.Restaurant> UpdateData(Models.Restaurant service)
        {
            throw new System.NotImplementedException();
        }
    }
}