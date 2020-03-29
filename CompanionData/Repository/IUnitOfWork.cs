using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Companion.Repository
{
    public interface IUnitOfWork : IDisposable
    {
        void CommitTransaction();
        void StartTransaction();
    }
}
