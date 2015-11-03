using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WouterRoelofs.Assessments.SequenceGenerator.Models.Home
{
    public class Input
    {
        [Required]
        [Range(0, int.MaxValue)]
        public int Number { get; set; }
    }
}