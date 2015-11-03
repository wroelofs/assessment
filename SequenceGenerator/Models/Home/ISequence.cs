using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WouterRoelofs.Assessments.SequenceGenerator.Models.Home
{
    public interface ISequence
    {
        string Description { get; }
        IList<string> Sequence { get; }
    }
}