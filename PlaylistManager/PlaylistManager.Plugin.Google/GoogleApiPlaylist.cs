using System.Collections.Generic;
using GoogleMusicApi.Structure;
using PlaylistManager.Api.Core;

namespace PlaylistManager.Plugin.Google
{
    public class GoogleApiPlaylist : ApiPlaylist<Playlist>
    {
        protected GoogleApiPlaylist(Playlist basePlaylist) : base(basePlaylist)
        {
        }
    }
}
