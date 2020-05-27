using FilmWebAPI.Core;
using FilmWebAPI.Core.Communication;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace FilmWebAPI.Requests.Get
{
    internal class GetPersonFilmsLead : RequestBase<dynamic>
    {
        public GetPersonFilmsLead(long personId, int limit) : base(Signature.Create("getPersonFilmsLead", personId, limit), FilmWebHttpMethod.Get)
        {
        }

        public override async Task<dynamic> Parse(HttpResponseMessage responseMessage)
        {
            throw new NotImplementedException();
        }
    }
}