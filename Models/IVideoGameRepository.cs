public interface IVideoGameRepository
{
    List<VideoGame> GetAll();
    VideoGame? GetById(int id);
    void Add(VideoGame game);
}