using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Data.Services.Client;
using System.Linq;
using System.Linq.Expressions;
using SilverlightArchitecture.Repository.SampleData;

namespace SilverlightArchitecture.Repository
{
    public abstract class Repository
    {
        protected IDataService Container;

        protected Repository(IDataService dataService)
        {
            Container = dataService;
        }
    }

    public class Repository<T> : Repository, IRepository<T> where T : BusinessBase
    {
        [ImportingConstructor]
        public Repository(IDataService dataService) : base(dataService) { }

        public void All(Action<IEnumerable<T>> action, object userState)
        {
            var query = Container.CreateQuery<T>();
            var serviceQuery = ((DataServiceQuery<T>)query);
            serviceQuery.BeginExecute(ar => action(serviceQuery.EndExecute(ar)), userState);
        }

        public void Find(Expression<Func<T, bool>> filter, Action<IEnumerable<T>> action, object userState)
        {
            var query = Container.CreateQuery<T>();
            query = query.Where(filter);
            var serviceQuery = ((DataServiceQuery<T>)query);
            serviceQuery.BeginExecute(ar => action(serviceQuery.EndExecute(ar)), userState);
        }

        public void Save(Action<IEnumerable<Exception>> action, object userState)
        {
            Container.BeginSaveChanges(ar => action(Container.EndSaveChanges(ar)), userState);
        }

        public void Insert(IEnumerable<T> saveables, Action<IEnumerable<T>> action, object userState)
        {
            Container.AddObjects(saveables);
        }

        public virtual void Dispose()
        {
        }
    }
}