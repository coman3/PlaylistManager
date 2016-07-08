using System.Collections.Generic;
using GoogleMusicApi.Structure;
using PlaylistManager.Api.Core;

namespace PlaylistManager.Plugin.Google
{
    public class GoogleApiAlbum : ApiAlbum<Album>
    {
        public GoogleApiAlbum(Album baseItem) : base(baseItem)
        {

        }
    }
}