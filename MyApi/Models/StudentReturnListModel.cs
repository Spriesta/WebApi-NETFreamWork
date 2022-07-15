using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyApi.Models
{
    public class StudentReturnListModel
    {
        public int id { get; set; }
        public string sName { get; set; }
        public string sAge { get; set; }
        public string sSchoolNum { get; set; }
        public string sClass { get; set; }
        public string sMail { get; set; }
        public string sFrom { get; set; }
        public string sGender { get; set; }
        public DateTime? sRegisterDate { get; set; }
        public string sTC { get; set; }
        public string sDebt { get; set; }
        public int sfailed { get; set; }
    }
}