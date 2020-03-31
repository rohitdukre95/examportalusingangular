using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExamPortalAngular.Models
{
    public class Position:BaseEntity
    {
        [Required]
        public string PositionDescription { get; set; }
    }
}
