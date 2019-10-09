using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDD_cars.Data
{
    public class Manufacturers
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int MID { get; set; }

        [Display(Name= "Manufacturer Name")]
        public string MName { get; set; }

        [Display(Name = "Manufacturer Head")]
        public string MHead { get; set; }
    }
}
