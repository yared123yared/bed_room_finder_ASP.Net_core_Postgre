using Microsoft.AspNetCore.Mvc;
using Restaurant.DataAccess;
using Restaurant.Models;
using System;  
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Restaurant.Controllers  
{  
    [Route("api/[controller]")]  
    public class SSRController : ControllerBase  
    {  
        private readonly IDataAccessProvider<SmallStarRestaurant> _dataAccessProvider;  
  
        public  SSRController (IDataAccessProvider<SmallStarRestaurant> dataAccessProvider)  
        {  
            _dataAccessProvider = dataAccessProvider;  
        }  
  
        [HttpGet]  
        public async Task<IActionResult> GetData()
        {  
             var model = await _dataAccessProvider.GetData();  
            return Ok(model);
        }  
  
  [HttpPost]
       public async Task<IActionResult> CreateData(SmallStarRestaurant smallStarRestaurant)
        {
            Console.WriteLine("Creating smallRestaurant");
            
            await _dataAccessProvider.InsertData(smallStarRestaurant);
            return Ok(smallStarRestaurant);
        }
  
    //     [HttpGet("{id}")]  
    //     public Patient Details(string id)  
    //     {  
    //         return _dataAccessProvider.GetPatientSingleRecord(id);  
    //     }  
  
    //     [HttpPut]  
    //     public IActionResult Edit([FromBody]Patient patient)  
    //     {  
    //         if (ModelState.IsValid)  
    //         {  
    //             _dataAccessProvider.UpdatePatientRecord(patient);  
    //             return Ok();  
    //         }  
    //         return BadRequest();  
    //     }  
  
    //     [HttpDelete("{id}")]  
    //     public IActionResult DeleteConfirmed(string id)  
    //     {  
    //         var data = _dataAccessProvider.GetPatientSingleRecord(id);  
    //         if (data == null)  
    //         {  
    //             return NotFound();  
    //         }  
    //         _dataAccessProvider.DeletePatientRecord(id);  
    //         return Ok();  
    //     }  
    }  
}
