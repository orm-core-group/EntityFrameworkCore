// <auto-generated />
using System;
using System.Collections.Generic;
using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Scaffolding;
using Microsoft.EntityFrameworkCore.Sqlite.Storage.Internal;
using Microsoft.EntityFrameworkCore.Storage;

#pragma warning disable 219, 612, 618
#nullable disable

namespace TestNamespace
{
    public partial class FunctionTypeMappingContextModel
    {
        private FunctionTypeMappingContextModel()
            : base(skipDetectChanges: true, modelId: new Guid("00000000-0000-0000-0000-000000000000"), entityTypeCount: 0)
        {
        }

        partial void Initialize()
        {
            var functions = new Dictionary<string, IDbFunction>();
            var getSqlFragmentStatic = new RuntimeDbFunction(
                "Microsoft.EntityFrameworkCore.Scaffolding.CompiledModelRelationalTestBase+FunctionTypeMappingContext.GetSqlFragmentStatic(string)",
                this,
                typeof(string),
                "GetSqlFragmentStatic",
                storeType: "varchar",
                methodInfo: typeof(CompiledModelRelationalTestBase.FunctionTypeMappingContext).GetMethod(
                    "GetSqlFragmentStatic",
                    BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly,
                    null,
                    new Type[] { typeof(string) },
                    null),
                scalar: true,
                nullable: true);

            var param = getSqlFragmentStatic.AddParameter(
                "param",
                typeof(string),
                false,
                "TEXT");
            param.TypeMapping = SqliteStringTypeMapping.Default;

            getSqlFragmentStatic.TypeMapping = StringTypeMapping.Default.Clone(
                comparer: new ValueComparer<string>(
                    (string v1, string v2) => v1 == v2,
                    (string v) => v.GetHashCode(),
                    (string v) => v),
                keyComparer: new ValueComparer<string>(
                    (string v1, string v2) => v1 == v2,
                    (string v) => v.GetHashCode(),
                    (string v) => v),
                providerValueComparer: new ValueComparer<string>(
                    (string v1, string v2) => v1 == v2,
                    (string v) => v.GetHashCode(),
                    (string v) => v),
                mappingInfo: new RelationalTypeMappingInfo(
                    storeTypeName: "varchar",
                    dbType: System.Data.DbType.AnsiString));
            functions["Microsoft.EntityFrameworkCore.Scaffolding.CompiledModelRelationalTestBase+FunctionTypeMappingContext.GetSqlFragmentStatic(string)"] = getSqlFragmentStatic;

            AddAnnotation("Relational:DbFunctions", functions);
            AddRuntimeAnnotation("Relational:RelationalModel", CreateRelationalModel());
        }

        private IRelationalModel CreateRelationalModel()
        {
            var relationalModel = new RelationalModel(this);
            var getSqlFragmentStatic = (IRuntimeDbFunction)this.FindDbFunction("Microsoft.EntityFrameworkCore.Scaffolding.CompiledModelRelationalTestBase+FunctionTypeMappingContext.GetSqlFragmentStatic(string)")!;
            var getSqlFragmentStaticFunction = new StoreFunction(getSqlFragmentStatic, relationalModel);
            var paramFunctionParameter = getSqlFragmentStaticFunction.FindParameter("param")!;
            relationalModel.Functions.Add(
                ("GetSqlFragmentStatic", null, new[] { "TEXT" }),
                getSqlFragmentStaticFunction);
            return relationalModel.MakeReadOnly();
        }
    }
}
