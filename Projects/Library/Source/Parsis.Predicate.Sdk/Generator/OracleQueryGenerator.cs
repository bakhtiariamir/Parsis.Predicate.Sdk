using Parsis.Predicate.Sdk.Contract;
using Parsis.Predicate.Sdk.Generator.Database;

namespace Parsis.Predicate.Sdk.Generator;
public abstract class OracleQueryGenerator : QueryGeneratorFactory
{
    public override IQuery Init()
    {
        return new OracleQuery();
    }
}

