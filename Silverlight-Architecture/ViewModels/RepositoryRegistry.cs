using System.Collections.Generic;
using MefContrib.Hosting.Generics;

namespace SilverlightArchitecture
{
    public class RepositoryRegistry : IGenericContractRegistry
    {
        public IEnumerable<GenericContractTypeMapping> GetMappings()
        {
            yield return new GenericContractTypeMapping(typeof(IModelRepository<>), typeof(ModelRepository<>));
        }
    }
}