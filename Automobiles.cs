using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDD_cars.Data
{
    public class Automobiles
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AID { get; set; }

        public string AName { get; set; }

        public int Year { get; set; }
        public string Color { get; set; }
        public string Engine { get; set; }
        public int MID { get; set; }


        [ForeignKey("MID")]
        public Manufacturers ManID { get; set; }


    }
}
