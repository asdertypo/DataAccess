using System;
using System.Data.Entity;
using DataAccess.Models;
using System.ComponentModel.DataAnnotations;

namespace DataAccess.Models
{
    public enum Gender
    {
        男,女
    }
    public class Student
    {
        public int ID { get; set; }

        [Display(Name="姓名")]
        public string Name { get; set; }

        [Display(Name = "性别")]
        public Gender Gender{get;set;}

        [Display(Name = "身份证号码")]
        [StringLength(18,ErrorMessage="请输入正确的身份证号码！")]
        public string IdNum{get;set;}

        [Display(Name = "培训机构")]
        public string School{get;set;}

        [Display(Name = "培训时间")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime TrainingDate { get; set; }

        [Display(Name = "录入单位")]
        public int InstitutionId{get;set;}

        [Display(Name = "录入时间")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime InputDate { get; set; }

        public virtual Institution Institution { get; set; }
    }
}