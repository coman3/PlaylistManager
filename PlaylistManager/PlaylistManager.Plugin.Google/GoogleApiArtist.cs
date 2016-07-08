using GoogleMusicApi.Structure;
using PlaylistManager.Api.Core;

namespace PlaylistManager.Plugin.Google
{
    public class GoogleApiArtist : ApiArtist<Artist>
    {
        protected GoogleApiArtist(Artist baseArtist) : base(baseArtist)
        {
        }
    }
}