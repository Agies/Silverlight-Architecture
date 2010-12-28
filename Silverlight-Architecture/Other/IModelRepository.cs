using System.ComponentModel.Composition;

namespace SilverlightArchitecture
{
    [InheritedExport]
    public interface IModelRepository<TModel> where TModel : class 
    {
        TModel Get();
    }
}