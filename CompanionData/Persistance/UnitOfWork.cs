using Companion.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Transactions;

namespace Companion.Persistance
{
    public class UnitOfWork : IUnitOfWork
    {
        private TransactionScope transaction;
        public void StartTransaction()
        {
            this.transaction = new TransactionScope();
        }
        public void CommitTransaction()
        {
            this.transaction.Complete();
        }

        public void Dispose()
        {
            this.transaction.Dispose();
        }
    }
}
