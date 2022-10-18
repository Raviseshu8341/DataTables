using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCore.Core.Model
{
    public class DataDetail
    {
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        public string password { get; set; }
        public string Re_Type_Password { get; set; }
        public bool? Is_Delete { get; set; }      
        public DateTime? Create_Time_Stamp { get; set; }
        public DateTime? Update_Time_Stamp { get; set; }
    }
}
