using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MILTON_PROJECT.Models.Teachers
{
    public class TeachersAddress
    {
        public int Id { get; set; }

        public int Teachers_Id { get; set; }

        public long PhoneNumber { get; set; }

        public string Address1 { get; set; }

        public string Address2 { get; set; }

        public string PinCode { get; set; }
    }
}