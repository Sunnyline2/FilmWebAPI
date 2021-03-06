﻿using System;
using System.Net.Http;

namespace FilmWebAPI.Requests.Get
{
    public class GetFilmUserRecommendation : RequestBase<dynamic>
    {
        public GetFilmUserRecommendation(long movieId) : base(Signature.Create("getFilmUserRecommendation", movieId), FilmWebHttpMethod.Get)
        {
        }

        public override System.Threading.Tasks.Task<dynamic> Parse(HttpResponseMessage responseMessage)
        {
            throw new NotImplementedException();
        }
    }
}