using System;

namespace Nanoray.Coot
{
    public class CompositionManager : ICompositionManager
    {
        public TComposed Compose<TComposed>(params object[] targets) where TComposed : class
        {
            throw new NotImplementedException();
        }
    }
}
