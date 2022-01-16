using System.ComponentModel.DataAnnotations;

namespace Restaurant.Models  
{  
    public class SmallStarRestaurant
    {   
         [Key]
        public int ssrid { get; set; }
        public string smtype { get; set; }

        // navigational element
        public string restaurantname { get; set; }  
        public string city { get; set; }  
        public string subcity { get; set; }  
        public string ownername { get; set; }  
        public float bedroomprice { get; set; }  

        public Restaurant Restaurant { get; set; }
    
     
       
    } 
    public enum  bed_room_type
{
    single,
    Double
   
}
}