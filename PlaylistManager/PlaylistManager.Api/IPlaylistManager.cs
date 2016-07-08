using System.Collections.Generic;
using PlaylistManager.Api.Core;

namespace PlaylistManager.Api
{
    public interface IPlaylistManager<TSession, TTrack, TPlaylist>
        where TSession : ApiSession
         where TTrack : ApiTrack
        where TPlaylist : ApiPlaylist
    {
        void CreateSession(TSession session);
        TPlaylist CreatePlaylist(string name);
        void AddTrack(TPlaylist playlist, params TTrack[] tracks);
        void DeletePlaylist(TPlaylist playlist);
        List<TPlaylist> GetPlaylists();
        List<TTrack> GetTracks(TPlaylist playlist);
    }
}