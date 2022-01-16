using System.ComponentModel.DataAnnotations;

namespace Restaurant.Models  
{  
    public class Restaurant
    {
        [Key]
        public int restaurantid { get; set; }
     
        public string restaurantname { get; set; }  
        public string city { get; set; }  
        public string subcity { get; set; }  
        public string ownername { get; set; }  
        public float bedroomprice { get; set; }  
     
    }  
}