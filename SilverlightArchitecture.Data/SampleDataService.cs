
namespace SilverlightArchitecture.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Data;
    using System.Linq;
    using System.ServiceModel.DomainServices.EntityFramework;
    using System.ServiceModel.DomainServices.Hosting;
    using System.ServiceModel.DomainServices.Server;


    // Implements application logic using the SampleContainer context.
    // TODO: Add your application logic to these methods or in additional methods.
    // TODO: Wire up authentication (Windows/ASP.NET Forms) and uncomment the following to disable anonymous access
    // Also consider adding roles to restrict access as appropriate.
    // [RequiresAuthentication]
    [EnableClientAccess()]
    public class SampleDataService : LinqToEntitiesDomainService<SampleContainer>
    {

        // TODO:
        // Consider constraining the results of your query method.  If you need additional input you can
        // add parameters to this method or create additional query methods with different names.
        // To support paging you will need to add ordering to the 'BusinessBases' query.
        public IQueryable<BusinessBase> GetBusinessBases()
        {
            return this.ObjectContext.BusinessBases;
        }

        public void InsertBusinessBase(BusinessBase businessBase)
        {
            if ((businessBase.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(businessBase, EntityState.Added);
            }
            else
            {
                this.ObjectContext.BusinessBases.AddObject(businessBase);
            }
        }

        public void UpdateBusinessBase(BusinessBase currentBusinessBase)
        {
            this.ObjectContext.BusinessBases.AttachAsModified(currentBusinessBase, this.ChangeSet.GetOriginal(currentBusinessBase));
        }

        public void DeleteBusinessBase(BusinessBase businessBase)
        {
            if ((businessBase.EntityState == EntityState.Detached))
            {
                this.ObjectContext.BusinessBases.Attach(businessBase);
            }
            this.ObjectContext.BusinessBases.DeleteObject(businessBase);
        }
    }
}


