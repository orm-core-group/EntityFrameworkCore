// <auto-generated />
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

#pragma warning disable 219, 612, 618
#nullable disable

namespace TestNamespace
{
    public partial class DbContextModel
    {
        private DbContextModel()
            : base(skipDetectChanges: false, modelId: new Guid("00000000-0000-0000-0000-000000000000"), entityTypeCount: 1)
        {
        }

        partial void Initialize()
        {
            var dependentDerived = DependentDerivedEntityType.Create(this);

            DependentDerivedEntityType.CreateAnnotations(dependentDerived);

            AddRuntimeAnnotation("Relational:RelationalModel", CreateRelationalModel());
        }

        private IRelationalModel CreateRelationalModel()
        {
            var relationalModel = new RelationalModel(this);

            var dependentDerived = FindEntityType("Microsoft.EntityFrameworkCore.Scaffolding.CompiledModelTestBase+DependentDerived<int>")!;

            var defaultTableMappings = new List<TableMappingBase<ColumnMappingBase>>();
            dependentDerived.SetRuntimeAnnotation("Relational:DefaultMappings", defaultTableMappings);
            var microsoftEntityFrameworkCoreScaffoldingCompiledModelTestBaseDependentDerivedintTableBase = new TableBase("Microsoft.EntityFrameworkCore.Scaffolding.CompiledModelTestBase+DependentDerived<int>", null, relationalModel);
            var dataColumnBase = new ColumnBase<ColumnMappingBase>("Data", "TEXT", microsoftEntityFrameworkCoreScaffoldingCompiledModelTestBaseDependentDerivedintTableBase)
            {
                IsNullable = true
            };
            microsoftEntityFrameworkCoreScaffoldingCompiledModelTestBaseDependentDerivedintTableBase.Columns.Add("Data", dataColumnBase);
            var idColumnBase = new ColumnBase<ColumnMappingBase>("Id", "INTEGER", microsoftEntityFrameworkCoreScaffoldingCompiledModelTestBaseDependentDerivedintTableBase);
            microsoftEntityFrameworkCoreScaffoldingCompiledModelTestBaseDependentDerivedintTableBase.Columns.Add("Id", idColumnBase);
            relationalModel.DefaultTables.Add("Microsoft.EntityFrameworkCore.Scaffolding.CompiledModelTestBase+DependentDerived<int>", microsoftEntityFrameworkCoreScaffoldingCompiledModelTestBaseDependentDerivedintTableBase);
            var microsoftEntityFrameworkCoreScaffoldingCompiledModelTestBaseDependentDerivedintMappingBase = new TableMappingBase<ColumnMappingBase>(dependentDerived, microsoftEntityFrameworkCoreScaffoldingCompiledModelTestBaseDependentDerivedintTableBase, null);
            microsoftEntityFrameworkCoreScaffoldingCompiledModelTestBaseDependentDerivedintTableBase.AddTypeMapping(microsoftEntityFrameworkCoreScaffoldingCompiledModelTestBaseDependentDerivedintMappingBase, false);
            defaultTableMappings.Add(microsoftEntityFrameworkCoreScaffoldingCompiledModelTestBaseDependentDerivedintMappingBase);
            RelationalModel.CreateColumnMapping((ColumnBase<ColumnMappingBase>)idColumnBase, dependentDerived.FindProperty("Id")!, microsoftEntityFrameworkCoreScaffoldingCompiledModelTestBaseDependentDerivedintMappingBase);
            RelationalModel.CreateColumnMapping((ColumnBase<ColumnMappingBase>)dataColumnBase, dependentDerived.FindProperty("Data")!, microsoftEntityFrameworkCoreScaffoldingCompiledModelTestBaseDependentDerivedintMappingBase);

            var tableMappings = new List<TableMapping>();
            dependentDerived.SetRuntimeAnnotation("Relational:TableMappings", tableMappings);
            var dependentDerivedintTable = new Table("DependentDerived<int>", null, relationalModel);
            var idColumn = new Column("Id", "INTEGER", dependentDerivedintTable);
            dependentDerivedintTable.Columns.Add("Id", idColumn);
            var dataColumn = new Column("Data", "TEXT", dependentDerivedintTable)
            {
                IsNullable = true
            };
            dependentDerivedintTable.Columns.Add("Data", dataColumn);
            var pK_DependentDerivedint = new UniqueConstraint("PK_DependentDerived<int>", dependentDerivedintTable, new[] { idColumn });
            dependentDerivedintTable.PrimaryKey = pK_DependentDerivedint;
            var pK_DependentDerivedintUc = RelationalModel.GetKey(this,
                "Microsoft.EntityFrameworkCore.Scaffolding.CompiledModelTestBase+DependentDerived<int>",
                new[] { "Id" });
            pK_DependentDerivedint.MappedKeys.Add(pK_DependentDerivedintUc);
            RelationalModel.GetOrCreateUniqueConstraints(pK_DependentDerivedintUc).Add(pK_DependentDerivedint);
            dependentDerivedintTable.UniqueConstraints.Add("PK_DependentDerived<int>", pK_DependentDerivedint);
            relationalModel.Tables.Add(("DependentDerived<int>", null), dependentDerivedintTable);
            var dependentDerivedintTableMapping = new TableMapping(dependentDerived, dependentDerivedintTable, null);
            dependentDerivedintTable.AddTypeMapping(dependentDerivedintTableMapping, false);
            tableMappings.Add(dependentDerivedintTableMapping);
            RelationalModel.CreateColumnMapping(idColumn, dependentDerived.FindProperty("Id")!, dependentDerivedintTableMapping);
            RelationalModel.CreateColumnMapping(dataColumn, dependentDerived.FindProperty("Data")!, dependentDerivedintTableMapping);
            return relationalModel.MakeReadOnly();
        }
    }
}
