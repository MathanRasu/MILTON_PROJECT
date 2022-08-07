using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MILTON_PROJECT.Models
{
    public class Students
    {
        public int Id { get; set; }

        public Int64 RegisterNo { get; set; }

        public string StudentName { get; set; }

        public int? Class { get; set; }

        public string BloodGroup { get; set; }

        public string RelationType { get; set; }

        public string RelationName { get; set; }

        public long? RelationContactNumber { get; set; }

        public int? StudentID { get; set; }

        public string Address1 { get; set; }

        public string Address2 { get; set; }

        public long? Permanent_Phone_Number { get; set; }

        public long? AlternativeNumber { get; set; }
    }
}