using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JCC.Data.Infrastructure
{
    public interface IDatabaseFactory : IDisposable
    {
        JCCContext DataContext { get; }
    }

}
