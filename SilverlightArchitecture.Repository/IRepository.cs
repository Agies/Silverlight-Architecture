using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace SilverlightArchitecture.Repository
{
    public interface IRepository : IDisposable
    {
        
    }

    public interface IRepository<T> : IRepository
    {
        void All(Action<IEnumerable<T>> action, object userState);
        void Find(Expression<Func<T, bool>> filter, Action<IEnumerable<T>> action, object userState);
        void Save(Action<IEnumerable<Exception>> action, object userState);
    }
}
