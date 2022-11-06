using Parsis.Predicate.Sdk.Contract;
using Parsis.Predicate.Sdk.Query;

namespace Parsis.Predicate.Sdk.Generator; 
public abstract class QueryGeneratorFactory<TObject> : IQueryGeneratorFactory<TObject> where TObject : class
{
    public abstract IQuery Init(ObjectQuery<TObject> query);
}

