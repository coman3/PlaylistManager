using System.Collections.Generic;

namespace PlaylistManager.Api.Core
{
    public abstract class ApiTrack
    {
        public string Name { get; set; }
        public ApiAlbum ApiAlbum { get; set; }
        public List<ApiArtist> Artists { get; set; }
    }

    public abstract class ApiTrack<TItem> : ApiTrack
    {
        protected ApiTrack(TItem baseTrack)
        {
            BaseTrack = baseTrack;
        }
        public TItem BaseTrack { get; set; }
    }
}