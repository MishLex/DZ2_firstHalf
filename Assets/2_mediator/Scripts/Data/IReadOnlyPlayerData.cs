using Mediator.Infrastructure;

namespace Mediator.Data
{
    public interface IReadOnlyPlayerData
    {
        IReadOnlyReactiveProperty<int> ReadOnlyHP { get; }
        IReadOnlyReactiveProperty<int> ReadOnlyLevel { get; }
    }
}