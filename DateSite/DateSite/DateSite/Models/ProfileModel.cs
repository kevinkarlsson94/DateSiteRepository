using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DateSite.Models
{
    public class ProfileModel
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public Nullable<int> Age { get; set; }

    }
}