using System.Collections.Generic;

namespace PlaylistManager.Api.Core
{
    public abstract class ApiAlbum
    {
        
        public string Name { get; set; }
        public List<ApiArtist> Artists { get; set; }
    }
    public abstract class ApiAlbum<TItem> : ApiAlbum
    {
        protected ApiAlbum(TItem baseItem)
        {
            BaseAlbum = baseItem;
        }
        public TItem BaseAlbum { get; set; }
    }
}