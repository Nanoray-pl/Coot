namespace Nanoray.Coot
{
    public interface ICompositionFactory<TComposed>
        where TComposed : class
    {
        CompositionInfo CompositionInfo { get; }

        TComposed Compose(params object[] targets);
    }
}
