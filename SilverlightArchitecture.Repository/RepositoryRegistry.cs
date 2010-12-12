using System;
using System.Collections.Generic;
using MefContrib.Hosting.Generics;

namespace SilverlightArchitecture.Repository
{
    public class RepositoryRegistry : IGenericContractRegistry
    {
        public IEnumerable<GenericContractTypeMapping> GetMappings()
        {
            yield return new GenericContractTypeMapping(typeof(IRepository<>), typeof(Repository<>));
        }
    }
}