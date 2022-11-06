using Parsis.Predicate.Sdk.Type;

namespace Parsis.Predicate.Sdk.Generator.Database;
public class DatabaseQueryContext
{
    public string Table
    {
        get;
        init;
    }

    public string Schema
    {
        get;
        init;
    }

    public ICollection<TableField> Fields
    {
        get;
        init;
    } = new List<TableField>();

    public QueryType QueryType
    {
        get;
        init;
    }

    public IDictionary<string, string> QueryParts
    {
        get;
        set;
    } = new Dictionary<string, string>();


    public DatabaseQueryContext(string table, string schema = "dbo", QueryType queryType = QueryType.Select)
    {
        Table = table;
        Schema = schema;
        QueryType = queryType;
    }

}