using FilmWebAPI.Core;
using FilmWebAPI.Core.Communication;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace FilmWebAPI.Requests.Get
{
    internal class GetUserFriendFilmVote : RequestBase<dynamic>
    {
        public GetUserFriendFilmVote(long movieId, long userId) : base(Signature.Create("getUserFriendsFilmVotesByFilm", movieId, userId), FilmWebHttpMethod.Get)
        {
        }

        public override async Task<dynamic> Parse(HttpResponseMessage responseMessage)
        {
            throw new NotImplementedException();
        }
    }
}