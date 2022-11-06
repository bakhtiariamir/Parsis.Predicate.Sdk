using System.Data;

namespace Parsis.Predicate.Sdk.Generator.Database;
public class TableField
{
    public string Name
    {
        get;
        init;
    }

    public SqlDbType Type
    {
        get;
        init;
    }

    public TableField(string name, SqlDbType type)
    {
        Name = name;
        Type = type;
    }
}
