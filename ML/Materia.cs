using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ML
{
    public class Materia
    {
        public int IdMateria { get; set; }

        [Required]
        [StringLength(10)]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }

        [Required]
        [Display(Name ="Costos $")]
        public decimal costo { get; set; }
        public List<object> Materias { get; set; }

    }
}
