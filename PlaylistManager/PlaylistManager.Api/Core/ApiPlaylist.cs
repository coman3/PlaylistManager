using System.Collections.Generic;

namespace PlaylistManager.Api.Core
{
    public abstract class ApiPlaylist
    {
        public string Name { get; set; }
        public List<ApiTrack> Tracks { get; set; }
    }

    public abstract class ApiPlaylist<TItem> : ApiPlaylist
    {
        public TItem BasePlaylist { get; set; }

        protected ApiPlaylist(TItem basePlaylist)
        {
            BasePlaylist = basePlaylist;
        }
    }
}
