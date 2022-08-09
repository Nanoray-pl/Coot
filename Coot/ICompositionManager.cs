namespace Nanoray.Coot
{
    public interface ICompositionManager
    {
        TComposed Compose<TComposed>(params object[] targets)
            where TComposed : class;
    }
}
