namespace PlaylistManager.Api.Core
{
    public abstract class ApiArtist
    {
        public string Name { get; set; }
    }

    public abstract class ApiArtist<TItem> : ApiArtist
    {
        public TItem BaseArtist { get; set; }

        protected ApiArtist(TItem baseArtist)
        {
            BaseArtist = baseArtist;
        }
    }
}