using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MILTON_PROJECT.Models
{
    public class StudentAddress
    {
        public int Id { get; set; }

        public int? StudentID { get; set; }

        public string Address1 { get; set; }

        public string Address2 { get; set; }

        public long? Permanent_Phone_Number { get; set; }

        public long? AlternativeNumber { get; set; }
    }
}