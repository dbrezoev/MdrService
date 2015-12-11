using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MdrSearchHttp.Models
{
    public class Member
    {
        public string MemberName { get; set; }

        public string CallDate { get; set; }

        public string CallerFirstName { get; set; }

        public string CallerLastName { get; set; }

        public string CallerRelationship { get; set; }

        public string CallStatus { get; set; }

        public string CallerPhoneNumber { get; set; }

        public int CallDuration { get; set; }

        public string CallType { get; set; }

        public string AnotherCallProperty { get; set; }
    }
}