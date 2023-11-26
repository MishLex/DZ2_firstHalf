using Mediator.Infrastructure;

namespace Mediator.Data
{
    public class PlayerData : IReadOnlyPlayerData
    {
        public ReactiveProperty<int> Level { get; } = new();
        public ReactiveProperty<int> HP { get; } = new();

        public IReadOnlyReactiveProperty<int> ReadOnlyHP => Level;
        public IReadOnlyReactiveProperty<int> ReadOnlyLevel => HP;
    }
}
