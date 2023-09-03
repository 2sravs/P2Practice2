using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RainBowSchoolEF.Models
{
    
    public class Class
    {

        public int CId { get; set; }
        [Required]
        public string CName { get; set; }
    }
}

