﻿using FilmWebAPI.Core;
using FilmWebAPI.Core.Communication;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace FilmWebAPI.Requests.Get
{
    internal class GetUserFavoriteTvChannels : RequestBase<dynamic>
    {
        public GetUserFavoriteTvChannels() : base(Signature.Create("getUserFavouriteChannels", -1), FilmWebHttpMethod.Get)
        {
        }

        public override async Task<dynamic> Parse(HttpResponseMessage responseMessage)
        {
            throw new NotImplementedException();
        }
    }
}