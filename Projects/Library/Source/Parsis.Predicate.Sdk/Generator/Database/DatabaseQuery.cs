using Parsis.Predicate.Sdk.Contract;

namespace Parsis.Predicate.Sdk.Generator.Database;
public abstract class DatabaseQuery<TObject> : BaseQuery<TObject>, IDatabaseQuery<TObject> where TObject : class
{
    protected DatabaseQueryContext DatabaseQueryContext
    {
        get;
    }

    protected DatabaseQuery(DatabaseQueryContext databaseQueryContext) => DatabaseQueryContext = databaseQueryContext;

    public abstract Task GenerateColumn();

    public abstract Task GenerateWhereClause();

    public abstract Task GeneratePagingClause();

    public abstract Task GenerateOrderByClause();

    public abstract Task GenerateJoinClause();

    public abstract Task GenerateGroupByClause();
}

