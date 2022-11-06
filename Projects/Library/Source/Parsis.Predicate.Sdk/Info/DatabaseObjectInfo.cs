using System;
using Parsis.Predicate.Sdk.Contract;

namespace Parsis.Predicate.Sdk.Info;

public abstract class DatabaseObjectInfo<TObject> : ObjectInfo<TObject>, IDatabaseObjectInfo<TObject> where TObject : class
{
    public string Table
    {
        get;
    }

    public string Schema
    {
        get;
    }

    protected DatabaseObjectInfo(string table, string schema)
    {
        Table = table;
        Schema = schema;
    }
}