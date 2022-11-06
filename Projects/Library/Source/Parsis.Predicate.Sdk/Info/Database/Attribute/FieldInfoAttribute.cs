using System.Data;

namespace Parsis.Predicate.Sdk.ObjectInfo.Database.Attribute;
public class FieldInfoAttribute : System.Attribute
{
    public string Name
    {
        get;
        set;
    }

    public SqlDbType DataType
    {
        get;
        set;
    }

    public string Alias
    {
        get;
        set;
    }

    public string Title
    {
        get;
        set;
    }


    public FieldInfoAttribute(string name, SqlDbType dataType, string @alias = "", string title = "")
    {
        Name = name;
        DataType = dataType;
        Alias = alias;
        Title = title;
    }

}
