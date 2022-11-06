using System;
using Parsis.Predicate.Sdk.Contract;
using Parsis.Predicate.Sdk.DataType;

namespace Parsis.Predicate.Sdk.Info;

public abstract class SqlServerObjectInfo<TObject> : DatabaseObjectInfo<TObject>, ISqlServerObjectInfo<TObject> where TObject : class
{
    public override ObjectInfoType Type => ObjectInfoType.DatabaseSqlServer;
    protected SqlServerObjectInfo(string table, string schema) : base(table, schema)
    {

    }
}