using Parsis.Predicate.Sdk.Contract;

namespace Parsis.Predicate.Sdk.Generator;
public abstract class BaseQuery<TObject> : IQuery<TObject> where TObject : class
{
    public abstract Task Generate();
}

