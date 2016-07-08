using System.Collections.Generic;
using GoogleMusicApi.Structure;
using PlaylistManager.Api.Core;

namespace PlaylistManager.Plugin.Google
{
    public class GoogleApiTrack : ApiTrack<Track>
    {
        protected GoogleApiTrack(Track baseTrack) : base(baseTrack)
        {
        }
    }
}