public class VideoGameService : IVideoGameRepository
{
    private readonly List<VideoGame> games = new()
    {
        new VideoGame { Id = 1, Title = "The Legend of Zelda: Breath of the Wild", Genre = "Action-adventure", ReleaseYear = 2017 },
        new VideoGame { Id = 2, Title = "Super Mario Odyssey", Genre = "Platformer", ReleaseYear = 2017 },
        new VideoGame { Id = 3, Title = "Red Dead Redemption 2", Genre = "Action-adventure", ReleaseYear = 2018 },
        new VideoGame { Id = 4, Title = "The Witcher 3: Wild Hunt", Genre = "Action role-playing", ReleaseYear = 2015 },
        new VideoGame { Id = 5, Title = "God of War", Genre = "Action-adventure", ReleaseYear = 2018 }
    };

    public void Add(VideoGame game)
    {
        throw new NotImplementedException();
    }

    public List<VideoGame> GetAll()
    {
        return games.ToList();
    }

    public VideoGame? GetById(int id)
    {
        return games.FirstOrDefault(game => game.Id == id);
    }

    public async Task<List<VideoGame>> GetAllAsync()
    {
        await Task.Delay(1000);

        return games.ToList();
    }
}