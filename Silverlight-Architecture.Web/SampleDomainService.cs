using System.Data;
using System.Linq;
using System.ServiceModel.DomainServices.EntityFramework;
using System.ServiceModel.DomainServices.Hosting;
using SilverlightArchitecture.Data;

namespace SilverlightArchitecture.Web
{
    // Implements application logic using the SampleContainer context.
    // TODO: Add your application logic to these methods or in additional methods.
    // TODO: Wire up authentication (Windows/ASP.NET Forms) and uncomment the following to disable anonymous access
    // Also consider adding roles to restrict access as appropriate.
    // [RequiresAuthentication]
    [EnableClientAccess]
    public class SampleDomainService : LinqToEntitiesDomainService<SampleContainer>
    {
        // TODO:
        // Consider constraining the results of your query method.  If you need additional input you can
        // add parameters to this method or create additional query methods with different names.
        // To support paging you will need to add ordering to the 'BusinessBases' query.
        public IQueryable<BusinessBase> GetBusinessBases()
        {
            return ObjectContext.BusinessBases;
        }

        public void InsertBusinessBase(BusinessBase businessBase)
        {
            if ((businessBase.EntityState != EntityState.Detached))
            {
                ObjectContext.ObjectStateManager.ChangeObjectState(businessBase, EntityState.Added);
            }
            else
            {
                ObjectContext.BusinessBases.AddObject(businessBase);
            }
        }

        public void UpdateBusinessBase(BusinessBase currentBusinessBase)
        {
            ObjectContext.BusinessBases.AttachAsModified(currentBusinessBase, ChangeSet.GetOriginal(currentBusinessBase));
        }

        public void DeleteBusinessBase(BusinessBase businessBase)
        {
            if ((businessBase.EntityState == EntityState.Detached))
            {
                ObjectContext.BusinessBases.Attach(businessBase);
            }
            ObjectContext.BusinessBases.DeleteObject(businessBase);
        }
    }
}