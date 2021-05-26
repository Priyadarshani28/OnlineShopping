using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CRMDemoApp.Models
{
    [Serializable]
    public class Customer
    {
        public int Id { get; set; }

        [DisplayName(" Customer Name")]
        public string Name { get; set; }

        [DisplayName("Location")]
        
        public string Location { get; set; }

        [DisplayName("ContactNumber")]
        
        public int ContactNumber { get; set; }

        [DisplayName("Age")]
        public int Age { get; set; }
      
        [DisplayName(" Email")]
        public string Email { get; set; }
    }
}
