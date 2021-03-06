﻿using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FilmWebAPI.Requests.Get
{
    public class GetFilmPolishTitle : RequestBase<string>
    {
        private const int POLISH_TITLE_INDEX = 0;

        public GetFilmPolishTitle(ulong movieId)
            : base(Signature.Create("getFilmInfoFull", movieId), FilmWebHttpMethod.Get)
        {
        }

        public override async Task<string> Parse(HttpResponseMessage responseMessage)
        {
            var jsonBody = await base.GetJsonBody(responseMessage);
            var json = JsonConvert.DeserializeObject<JArray>(Regex.Replace(jsonBody, "t(s?):(\\d+)$", string.Empty));

            return json[POLISH_TITLE_INDEX].ToString();
        }
    }
}
