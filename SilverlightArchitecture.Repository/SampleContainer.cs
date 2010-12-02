using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Browser;

namespace SilverlightArchitecture.Repository.SampleData
{
    public interface IDataService
    {
        IQueryable<T> CreateQuery<T>();
        IAsyncResult BeginSaveChanges(AsyncCallback callback, object userState);
        IEnumerable<Exception> EndSaveChanges(IAsyncResult ar);
        void AddObjects<T>(IEnumerable<T> saveables) where T : BusinessBase;
    }

    public partial class SampleContainer : IDataService
    {
        public SampleContainer()
            : base(new Uri(HtmlPage.Document.DocumentUri, "Sample.svc"))
        {
            
        }

        public IQueryable<T> CreateQuery<T>()
        {
            return CreateQuery<T>(typeof(T).Name).OfType<T>();
        }

        public new IEnumerable<Exception> EndSaveChanges(IAsyncResult ar)
        {
            return base.EndSaveChanges(ar).Select(r => r.Error);
        }

        public void AddObjects<T>(IEnumerable<T> saveables) where T : BusinessBase
        {
            foreach (var saveable in saveables)
            {
                AddToBusinessBases(saveable);
            }
        }
    }
}