using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DataAccess.Models;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace DataAccess.Models
{
    public class Institution
    {
        public int InstitutionId { get; set; }

        [Display(Name="录入机构名称")]
        public string InstitutionName { get; set; }

        [Display(Name="创建时间")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime CreateDate { get; set; }
    }
}