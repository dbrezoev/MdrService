using MdrSearchHttp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;

namespace MdrSearchHttp.Controllers
{
    public class SearchMembersController
    {
        [RoutePrefix("api/members")]
        [EnableCors("*","*","*")]
        public class SearchMemberController : ApiController
        {
            private string[] relationships = new string[] { "friend", "father", "son", "daughter" };
            private string[] callStatuses = new string[] { "successfull", "unsuccessfull" };

            [HttpGet]
            [Route("mocked-data")]
            public IHttpActionResult GetMockedData()
            {
                var random = new Random();

                var result = new List<Member>();
                var date = "12/10/2015";
                for (int i = 1; i <= 100; i++)
                {
                    var current = new Member
                    {
                        MemberName = "Name " + i,
                        CallDate = date,
                        CallerFirstName = "Caller FName " + i,
                        CallerLastName = "Caller LName " + i,
                        CallerRelationship = this.relationships[random.Next(0, relationships.Length)],
                        CallStatus = this.callStatuses[random.Next(0, callStatuses.Length)],
                        CallerPhoneNumber = "+359 88 " + i,
                        CallDuration = 100 + i,
                        CallType = "Any type",
                        AnotherCallProperty = "Another info"
                    };

                    result.Add(current);
                }

                return Ok(result);
            }

            [HttpGet]
            [Route("more-mocked-data")]
            public IHttpActionResult GetMoreMockedData()
            {
                var random = new Random();

                var result = new List<ComplexMember>();
                var date = "12/10/2015";
                for (int i = 1; i <= 100; i++)
                {
                    var current = new ComplexMember
                    {
                        MemberName = "Name " + i,
                        CallDate = date,
                        CallerFirstName = "Caller FName " + i,
                        CallerLastName = "Caller LName " + i,
                        CallerRelationship = this.relationships[random.Next(0, relationships.Length)],
                        CallStatus = this.callStatuses[random.Next(0, callStatuses.Length)],
                        CallerPhoneNumber = "+359 88 " + i,
                        CallDuration = 100 + i,
                        CallType = "Any type",
                        AnotherCallProperty = "Another info",
                        AdditionalProperty1 = i,
                        AdditionalProperty2 = i,
                        AdditionalProperty3 = i,
                        AdditionalProperty4 = i,
                        AdditionalProperty5 = i,
                        AdditionalProperty6 = i,
                        AdditionalProperty7 = i,
                        AdditionalProperty8 = i,
                        AdditionalProperty9 = i,
                        AdditionalProperty10 = i,
                        AdditionalProperty11 = i,
                        AdditionalProperty12 = i,
                        AdditionalProperty13 = i,
                        AdditionalProperty14 = i,
                        AdditionalProperty15 = i,
                        AdditionalProperty16 = i,
                        AdditionalProperty17 = i,
                        AdditionalProperty18 = i,
                        AdditionalProperty19 = i,
                        AdditionalProperty20 = i
                    };

                    result.Add(current);
                }

                return Ok(result);
            }
        }
    }
}