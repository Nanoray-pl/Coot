using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nanoray.Coot
{
    public class CompositionFactory<TComposed> : ICompositionFactory<TComposed>
        where TComposed : class
    {
        public CompositionInfo CompositionInfo { get; init; }

        public CompositionFactory(CompositionInfo compositionInfo)
        {
            this.CompositionInfo = compositionInfo;
        }

        public TComposed Compose(params object[] targets)
        {
            throw new NotImplementedException();
        }
    }
}
