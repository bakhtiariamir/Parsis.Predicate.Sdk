using Parsis.Predicate.Sdk.Builder.Database;
using Parsis.Predicate.Sdk.Contract;
using Parsis.Predicate.Sdk.Query;

namespace Parsis.Predicate.Sdk.Builder;
public abstract class SqlServerQueryGenerator<TObject> : QueryGeneratorFactory<TObject> where TObject : class
{
    public override IQuery<TObject> Init(ObjectQuery<TObject> query) => new SqlServerQuery<TObject>();
    
}

