
namespace Asteroid
{
    public interface IGameHandler
    {
        IGameHandler Handle();
        IGameHandler SetNext(IGameHandler gameHandler);
    }
}
