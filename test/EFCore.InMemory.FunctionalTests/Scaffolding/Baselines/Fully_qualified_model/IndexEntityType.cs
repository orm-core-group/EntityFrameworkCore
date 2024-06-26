// <auto-generated />
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using Microsoft.EntityFrameworkCore.InMemory.Storage.Internal;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Scaffolding;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Json;

#pragma warning disable 219, 612, 618
#nullable disable

namespace Scaffolding
{
    internal partial class IndexEntityType
    {
        public static RuntimeEntityType Create(RuntimeModel model, RuntimeEntityType baseEntityType = null)
        {
            var runtimeEntityType = model.AddEntityType(
                "Microsoft.EntityFrameworkCore.Scaffolding.CompiledModelInMemoryTest+Index",
                typeof(CompiledModelInMemoryTest.Index),
                baseEntityType,
                propertyCount: 1,
                keyCount: 1);

            var id = runtimeEntityType.AddProperty(
                "Id",
                typeof(Guid),
                propertyInfo: typeof(CompiledModelInMemoryTest.Index).GetProperty("Id", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(CompiledModelInMemoryTest.Index).GetField("<Id>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                valueGenerated: ValueGenerated.OnAdd,
                afterSaveBehavior: PropertySaveBehavior.Throw,
                sentinel: new Guid("00000000-0000-0000-0000-000000000000"));
            id.SetGetter(
                (CompiledModelInMemoryTest.Index entity) => ReadId(entity),
                (CompiledModelInMemoryTest.Index entity) => ReadId(entity) == new Guid("00000000-0000-0000-0000-000000000000"),
                (CompiledModelInMemoryTest.Index instance) => ReadId(instance),
                (CompiledModelInMemoryTest.Index instance) => ReadId(instance) == new Guid("00000000-0000-0000-0000-000000000000"));
            id.SetSetter(
                (CompiledModelInMemoryTest.Index entity, Guid value) => WriteId(entity, value));
            id.SetMaterializationSetter(
                (CompiledModelInMemoryTest.Index entity, Guid value) => WriteId(entity, value));
            id.SetAccessors(
                (InternalEntityEntry entry) => entry.FlaggedAsStoreGenerated(0) ? entry.ReadStoreGeneratedValue<Guid>(0) : entry.FlaggedAsTemporary(0) && ReadId((CompiledModelInMemoryTest.Index)entry.Entity) == new Guid("00000000-0000-0000-0000-000000000000") ? entry.ReadTemporaryValue<Guid>(0) : ReadId((CompiledModelInMemoryTest.Index)entry.Entity),
                (InternalEntityEntry entry) => ReadId((CompiledModelInMemoryTest.Index)entry.Entity),
                (InternalEntityEntry entry) => entry.ReadOriginalValue<Guid>(id, 0),
                (InternalEntityEntry entry) => entry.ReadRelationshipSnapshotValue<Guid>(id, 0),
                (ValueBuffer valueBuffer) => valueBuffer[0]);
            id.SetPropertyIndexes(
                index: 0,
                originalValueIndex: 0,
                shadowIndex: -1,
                relationshipIndex: 0,
                storeGenerationIndex: 0);
            id.TypeMapping = InMemoryTypeMapping.Default.Clone(
                comparer: new ValueComparer<Guid>(
                    (Guid v1, Guid v2) => v1 == v2,
                    (Guid v) => v.GetHashCode(),
                    (Guid v) => v),
                keyComparer: new ValueComparer<Guid>(
                    (Guid v1, Guid v2) => v1 == v2,
                    (Guid v) => v.GetHashCode(),
                    (Guid v) => v),
                providerValueComparer: new ValueComparer<Guid>(
                    (Guid v1, Guid v2) => v1 == v2,
                    (Guid v) => v.GetHashCode(),
                    (Guid v) => v),
                clrType: typeof(Guid),
                jsonValueReaderWriter: JsonGuidReaderWriter.Instance);
            id.SetCurrentValueComparer(new EntryCurrentValueComparer<Guid>(id));

            var key = runtimeEntityType.AddKey(
                new[] { id });
            runtimeEntityType.SetPrimaryKey(key);

            return runtimeEntityType;
        }

        public static void CreateAnnotations(RuntimeEntityType runtimeEntityType)
        {
            var id = runtimeEntityType.FindProperty("Id")!;
            runtimeEntityType.SetOriginalValuesFactory(
                (InternalEntityEntry source) =>
                {
                    var entity = (CompiledModelInMemoryTest.Index)source.Entity;
                    return (ISnapshot)new Snapshot<Guid>(((ValueComparer<Guid>)id.GetValueComparer()).Snapshot(source.GetCurrentValue<Guid>(id)));
                });
            runtimeEntityType.SetStoreGeneratedValuesFactory(
                () => (ISnapshot)new Snapshot<Guid>(((ValueComparer<Guid>)id.GetValueComparer()).Snapshot(default(Guid))));
            runtimeEntityType.SetTemporaryValuesFactory(
                (InternalEntityEntry source) => (ISnapshot)new Snapshot<Guid>(default(Guid)));
            runtimeEntityType.SetShadowValuesFactory(
                (IDictionary<string, object> source) => Snapshot.Empty);
            runtimeEntityType.SetEmptyShadowValuesFactory(
                () => Snapshot.Empty);
            runtimeEntityType.SetRelationshipSnapshotFactory(
                (InternalEntityEntry source) =>
                {
                    var entity = (CompiledModelInMemoryTest.Index)source.Entity;
                    return (ISnapshot)new Snapshot<Guid>(((ValueComparer<Guid>)id.GetKeyValueComparer()).Snapshot(source.GetCurrentValue<Guid>(id)));
                });
            runtimeEntityType.Counts = new PropertyCounts(
                propertyCount: 1,
                navigationCount: 0,
                complexPropertyCount: 0,
                originalValueCount: 1,
                shadowCount: 0,
                relationshipCount: 1,
                storeGeneratedCount: 1);

            Customize(runtimeEntityType);
        }

        static partial void Customize(RuntimeEntityType runtimeEntityType);

        [UnsafeAccessor(UnsafeAccessorKind.Field, Name = "<Id>k__BackingField")]
        extern static ref Guid GetId(CompiledModelInMemoryTest.Index @this);

        public static Guid ReadId(CompiledModelInMemoryTest.Index @this)
            => GetId(@this);

        public static void WriteId(CompiledModelInMemoryTest.Index @this, Guid value)
            => GetId(@this) = value;
    }
}
