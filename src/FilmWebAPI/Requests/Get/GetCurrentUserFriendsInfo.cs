﻿using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace FilmWebAPI.Requests.Get
{
    public class GetCurrentUserFriendsInfo : RequestBase<dynamic>
    {
        public GetCurrentUserFriendsInfo() : base(Signature.Create("getUsersInfoShort"), FilmWebHttpMethod.Get)
        {
        }

        public override async Task<dynamic> Parse(HttpResponseMessage responseMessage)
        {
            throw new NotImplementedException();
        }
    }
}