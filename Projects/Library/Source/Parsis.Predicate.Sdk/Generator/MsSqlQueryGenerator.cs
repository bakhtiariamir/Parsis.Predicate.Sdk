using Parsis.Predicate.Sdk.Contract;
using Parsis.Predicate.Sdk.Generator.Database;
using Parsis.Predicate.Sdk.Query;

namespace Parsis.Predicate.Sdk.Generator;
public abstract class MsSqlQueryGenerator<TObject> : QueryGeneratorFactory<TObject> where TObject : class
{
    public override IQuery Init(ObjectQuery<TObject> query)
    {
        return new MsSqlQuery();
    }
}

