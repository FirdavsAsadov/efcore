// <auto-generated />
using System;
using System.Collections.Generic;
using System.Net;
using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Scaffolding.Internal;
using Microsoft.EntityFrameworkCore.SqlServer.Storage.Internal;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Json;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#pragma warning disable 219, 612, 618
#nullable disable

namespace TestNamespace
{
    internal partial class OwnedType0EntityType
    {
        public static RuntimeEntityType Create(RuntimeModel model, RuntimeEntityType baseEntityType = null)
        {
            var runtimeEntityType = model.AddEntityType(
                "Microsoft.EntityFrameworkCore.Scaffolding.Internal.CSharpRuntimeModelCodeGeneratorTest+PrincipalDerived<Microsoft.EntityFrameworkCore.Scaffolding.Internal.CSharpRuntimeModelCodeGeneratorTest+DependentBase<byte?>>.ManyOwned#OwnedType",
                typeof(CSharpRuntimeModelCodeGeneratorTest.OwnedType),
                baseEntityType,
                sharedClrType: true,
                propertyCount: 13,
                servicePropertyCount: 1,
                foreignKeyCount: 1,
                keyCount: 1);

            var principalDerivedId = runtimeEntityType.AddProperty(
                "PrincipalDerivedId",
                typeof(long),
                afterSaveBehavior: PropertySaveBehavior.Throw,
                sentinel: 0L);
            principalDerivedId.TypeMapping = SqlServerLongTypeMapping.Default.Clone(
                comparer: new ValueComparer<long>(
                    (long v1, long v2) => v1 == v2,
                    (long v) => v.GetHashCode(),
                    (long v) => v),
                keyComparer: new ValueComparer<long>(
                    (long v1, long v2) => v1 == v2,
                    (long v) => v.GetHashCode(),
                    (long v) => v),
                providerValueComparer: new ValueComparer<long>(
                    (long v1, long v2) => v1 == v2,
                    (long v) => v.GetHashCode(),
                    (long v) => v));
            principalDerivedId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var principalDerivedAlternateId = runtimeEntityType.AddProperty(
                "PrincipalDerivedAlternateId",
                typeof(Guid),
                afterSaveBehavior: PropertySaveBehavior.Throw,
                sentinel: new Guid("00000000-0000-0000-0000-000000000000"));
            principalDerivedAlternateId.TypeMapping = GuidTypeMapping.Default.Clone(
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
                mappingInfo: new RelationalTypeMappingInfo(
                    storeTypeName: "uniqueidentifier"));
            principalDerivedAlternateId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var id = runtimeEntityType.AddProperty(
                "Id",
                typeof(int),
                valueGenerated: ValueGenerated.OnAdd,
                afterSaveBehavior: PropertySaveBehavior.Throw,
                sentinel: 0);
            id.TypeMapping = IntTypeMapping.Default.Clone(
                comparer: new ValueComparer<int>(
                    (int v1, int v2) => v1 == v2,
                    (int v) => v,
                    (int v) => v),
                keyComparer: new ValueComparer<int>(
                    (int v1, int v2) => v1 == v2,
                    (int v) => v,
                    (int v) => v),
                providerValueComparer: new ValueComparer<int>(
                    (int v1, int v2) => v1 == v2,
                    (int v) => v,
                    (int v) => v));
            id.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            var details = runtimeEntityType.AddProperty(
                "Details",
                typeof(string),
                propertyInfo: typeof(CSharpRuntimeModelCodeGeneratorTest.OwnedType).GetProperty("Details", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(CSharpRuntimeModelCodeGeneratorTest.OwnedType).GetField("_details", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            details.TypeMapping = SqlServerStringTypeMapping.Default.Clone(
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
                    storeTypeName: "nvarchar(max)",
                    dbType: System.Data.DbType.String),
                storeTypePostfix: StoreTypePostfix.None);
            details.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var number = runtimeEntityType.AddProperty(
                "Number",
                typeof(int),
                propertyInfo: typeof(CSharpRuntimeModelCodeGeneratorTest.OwnedType).GetProperty("Number", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(CSharpRuntimeModelCodeGeneratorTest.OwnedType).GetField("<Number>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: 0);
            number.TypeMapping = IntTypeMapping.Default.Clone(
                comparer: new ValueComparer<int>(
                    (int v1, int v2) => v1 == v2,
                    (int v) => v,
                    (int v) => v),
                keyComparer: new ValueComparer<int>(
                    (int v1, int v2) => v1 == v2,
                    (int v) => v,
                    (int v) => v),
                providerValueComparer: new ValueComparer<int>(
                    (int v1, int v2) => v1 == v2,
                    (int v) => v,
                    (int v) => v));
            number.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var refTypeArray = runtimeEntityType.AddProperty(
                "RefTypeArray",
                typeof(IPAddress[]),
                propertyInfo: typeof(CSharpRuntimeModelCodeGeneratorTest.OwnedType).GetProperty("RefTypeArray", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(CSharpRuntimeModelCodeGeneratorTest.OwnedType).GetField("_refTypeArray", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            refTypeArray.TypeMapping = SqlServerStringTypeMapping.Default.Clone(
                comparer: new ListComparer<IPAddress>(new ValueComparer<IPAddress>(
                    (IPAddress v1, IPAddress v2) => v1 == null && v2 == null || v1 != null && v2 != null && v1.Equals(v2),
                    (IPAddress v) => v.GetHashCode(),
                    (IPAddress v) => v)),
                keyComparer: new ListComparer<IPAddress>(new ValueComparer<IPAddress>(
                    (IPAddress v1, IPAddress v2) => v1 == null && v2 == null || v1 != null && v2 != null && v1.Equals(v2),
                    (IPAddress v) => v.GetHashCode(),
                    (IPAddress v) => v)),
                providerValueComparer: new ValueComparer<string>(
                    (string v1, string v2) => v1 == v2,
                    (string v) => v.GetHashCode(),
                    (string v) => v),
                mappingInfo: new RelationalTypeMappingInfo(
                    storeTypeName: "nvarchar(max)",
                    dbType: System.Data.DbType.String),
                converter: new CollectionToJsonStringConverter<IPAddress>(new JsonCollectionReaderWriter<IPAddress[], IPAddress[], IPAddress>(
                    new JsonConvertedValueReaderWriter<IPAddress, string>(
                        JsonStringReaderWriter.Instance,
                        new ValueConverter<IPAddress, string>(
                            (IPAddress v) => v.ToString(),
                            (string v) => IPAddress.Parse(v))))),
                storeTypePostfix: StoreTypePostfix.None,
                jsonValueReaderWriter: new JsonCollectionReaderWriter<IPAddress[], IPAddress[], IPAddress>(
                    new JsonConvertedValueReaderWriter<IPAddress, string>(
                        JsonStringReaderWriter.Instance,
                        new ValueConverter<IPAddress, string>(
                            (IPAddress v) => v.ToString(),
                            (string v) => IPAddress.Parse(v)))),
                elementMapping: SqlServerStringTypeMapping.Default.Clone(
                    comparer: new ValueComparer<IPAddress>(
                        (IPAddress v1, IPAddress v2) => v1 == null && v2 == null || v1 != null && v2 != null && v1.Equals(v2),
                        (IPAddress v) => v.GetHashCode(),
                        (IPAddress v) => v),
                    keyComparer: new ValueComparer<IPAddress>(
                        (IPAddress v1, IPAddress v2) => v1 == null && v2 == null || v1 != null && v2 != null && v1.Equals(v2),
                        (IPAddress v) => v.GetHashCode(),
                        (IPAddress v) => v),
                    providerValueComparer: new ValueComparer<string>(
                        (string v1, string v2) => v1 == v2,
                        (string v) => v.GetHashCode(),
                        (string v) => v),
                    mappingInfo: new RelationalTypeMappingInfo(
                        storeTypeName: "nvarchar(45)",
                        size: 45,
                        dbType: System.Data.DbType.String),
                    converter: new ValueConverter<IPAddress, string>(
                        (IPAddress v) => v.ToString(),
                        (string v) => IPAddress.Parse(v)),
                    jsonValueReaderWriter: new JsonConvertedValueReaderWriter<IPAddress, string>(
                        JsonStringReaderWriter.Instance,
                        new ValueConverter<IPAddress, string>(
                            (IPAddress v) => v.ToString(),
                            (string v) => IPAddress.Parse(v)))));
            refTypeArray.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var refTypeEnumerable = runtimeEntityType.AddProperty(
                "RefTypeEnumerable",
                typeof(IEnumerable<string>),
                propertyInfo: typeof(CSharpRuntimeModelCodeGeneratorTest.OwnedType).GetProperty("RefTypeEnumerable", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(CSharpRuntimeModelCodeGeneratorTest.OwnedType).GetField("_refTypeEnumerable", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            refTypeEnumerable.TypeMapping = SqlServerStringTypeMapping.Default.Clone(
                comparer: new ListComparer<string>(new ValueComparer<string>(
                    (string v1, string v2) => v1 == v2,
                    (string v) => v.GetHashCode(),
                    (string v) => v)),
                keyComparer: new ListComparer<string>(new ValueComparer<string>(
                    (string v1, string v2) => v1 == v2,
                    (string v) => v.GetHashCode(),
                    (string v) => v)),
                providerValueComparer: new ValueComparer<string>(
                    (string v1, string v2) => v1 == v2,
                    (string v) => v.GetHashCode(),
                    (string v) => v),
                mappingInfo: new RelationalTypeMappingInfo(
                    storeTypeName: "nvarchar(max)",
                    dbType: System.Data.DbType.String),
                converter: new CollectionToJsonStringConverter<string>(new JsonCollectionReaderWriter<IEnumerable<string>, List<string>, string>(
                    JsonStringReaderWriter.Instance)),
                storeTypePostfix: StoreTypePostfix.None,
                jsonValueReaderWriter: new JsonCollectionReaderWriter<IEnumerable<string>, List<string>, string>(
                    JsonStringReaderWriter.Instance),
                elementMapping: SqlServerStringTypeMapping.Default.Clone(
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
                        storeTypeName: "nvarchar(max)",
                        dbType: System.Data.DbType.String),
                    storeTypePostfix: StoreTypePostfix.None));
            refTypeEnumerable.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var refTypeIList = runtimeEntityType.AddProperty(
                "RefTypeIList",
                typeof(IList<string>),
                propertyInfo: typeof(CSharpRuntimeModelCodeGeneratorTest.OwnedType).GetProperty("RefTypeIList", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(CSharpRuntimeModelCodeGeneratorTest.OwnedType).GetField("_refTypeIList", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            refTypeIList.TypeMapping = SqlServerStringTypeMapping.Default.Clone(
                comparer: new ListComparer<string>(new ValueComparer<string>(
                    (string v1, string v2) => v1 == v2,
                    (string v) => v.GetHashCode(),
                    (string v) => v)),
                keyComparer: new ListComparer<string>(new ValueComparer<string>(
                    (string v1, string v2) => v1 == v2,
                    (string v) => v.GetHashCode(),
                    (string v) => v)),
                providerValueComparer: new ValueComparer<string>(
                    (string v1, string v2) => v1 == v2,
                    (string v) => v.GetHashCode(),
                    (string v) => v),
                mappingInfo: new RelationalTypeMappingInfo(
                    storeTypeName: "nvarchar(max)",
                    dbType: System.Data.DbType.String),
                converter: new CollectionToJsonStringConverter<string>(new JsonCollectionReaderWriter<IList<string>, List<string>, string>(
                    JsonStringReaderWriter.Instance)),
                storeTypePostfix: StoreTypePostfix.None,
                jsonValueReaderWriter: new JsonCollectionReaderWriter<IList<string>, List<string>, string>(
                    JsonStringReaderWriter.Instance),
                elementMapping: SqlServerStringTypeMapping.Default.Clone(
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
                        storeTypeName: "nvarchar(max)",
                        dbType: System.Data.DbType.String),
                    storeTypePostfix: StoreTypePostfix.None));
            refTypeIList.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var refTypeList = runtimeEntityType.AddProperty(
                "RefTypeList",
                typeof(List<IPAddress>),
                propertyInfo: typeof(CSharpRuntimeModelCodeGeneratorTest.OwnedType).GetProperty("RefTypeList", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(CSharpRuntimeModelCodeGeneratorTest.OwnedType).GetField("_refTypeList", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            refTypeList.TypeMapping = SqlServerStringTypeMapping.Default.Clone(
                comparer: new ListComparer<IPAddress>(new ValueComparer<IPAddress>(
                    (IPAddress v1, IPAddress v2) => v1 == null && v2 == null || v1 != null && v2 != null && v1.Equals(v2),
                    (IPAddress v) => v.GetHashCode(),
                    (IPAddress v) => v)),
                keyComparer: new ListComparer<IPAddress>(new ValueComparer<IPAddress>(
                    (IPAddress v1, IPAddress v2) => v1 == null && v2 == null || v1 != null && v2 != null && v1.Equals(v2),
                    (IPAddress v) => v.GetHashCode(),
                    (IPAddress v) => v)),
                providerValueComparer: new ValueComparer<string>(
                    (string v1, string v2) => v1 == v2,
                    (string v) => v.GetHashCode(),
                    (string v) => v),
                mappingInfo: new RelationalTypeMappingInfo(
                    storeTypeName: "nvarchar(max)",
                    dbType: System.Data.DbType.String),
                converter: new CollectionToJsonStringConverter<IPAddress>(new JsonCollectionReaderWriter<List<IPAddress>, List<IPAddress>, IPAddress>(
                    new JsonConvertedValueReaderWriter<IPAddress, string>(
                        JsonStringReaderWriter.Instance,
                        new ValueConverter<IPAddress, string>(
                            (IPAddress v) => v.ToString(),
                            (string v) => IPAddress.Parse(v))))),
                storeTypePostfix: StoreTypePostfix.None,
                jsonValueReaderWriter: new JsonCollectionReaderWriter<List<IPAddress>, List<IPAddress>, IPAddress>(
                    new JsonConvertedValueReaderWriter<IPAddress, string>(
                        JsonStringReaderWriter.Instance,
                        new ValueConverter<IPAddress, string>(
                            (IPAddress v) => v.ToString(),
                            (string v) => IPAddress.Parse(v)))),
                elementMapping: SqlServerStringTypeMapping.Default.Clone(
                    comparer: new ValueComparer<IPAddress>(
                        (IPAddress v1, IPAddress v2) => v1 == null && v2 == null || v1 != null && v2 != null && v1.Equals(v2),
                        (IPAddress v) => v.GetHashCode(),
                        (IPAddress v) => v),
                    keyComparer: new ValueComparer<IPAddress>(
                        (IPAddress v1, IPAddress v2) => v1 == null && v2 == null || v1 != null && v2 != null && v1.Equals(v2),
                        (IPAddress v) => v.GetHashCode(),
                        (IPAddress v) => v),
                    providerValueComparer: new ValueComparer<string>(
                        (string v1, string v2) => v1 == v2,
                        (string v) => v.GetHashCode(),
                        (string v) => v),
                    mappingInfo: new RelationalTypeMappingInfo(
                        storeTypeName: "nvarchar(45)",
                        size: 45,
                        dbType: System.Data.DbType.String),
                    converter: new ValueConverter<IPAddress, string>(
                        (IPAddress v) => v.ToString(),
                        (string v) => IPAddress.Parse(v)),
                    jsonValueReaderWriter: new JsonConvertedValueReaderWriter<IPAddress, string>(
                        JsonStringReaderWriter.Instance,
                        new ValueConverter<IPAddress, string>(
                            (IPAddress v) => v.ToString(),
                            (string v) => IPAddress.Parse(v)))));
            refTypeList.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var valueTypeArray = runtimeEntityType.AddProperty(
                "ValueTypeArray",
                typeof(DateTime[]),
                propertyInfo: typeof(CSharpRuntimeModelCodeGeneratorTest.OwnedType).GetProperty("ValueTypeArray", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(CSharpRuntimeModelCodeGeneratorTest.OwnedType).GetField("_valueTypeArray", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            valueTypeArray.TypeMapping = SqlServerStringTypeMapping.Default.Clone(
                comparer: new ListComparer<DateTime>(new ValueComparer<DateTime>(
                    (DateTime v1, DateTime v2) => v1.Equals(v2),
                    (DateTime v) => v.GetHashCode(),
                    (DateTime v) => v)),
                keyComparer: new ListComparer<DateTime>(new ValueComparer<DateTime>(
                    (DateTime v1, DateTime v2) => v1.Equals(v2),
                    (DateTime v) => v.GetHashCode(),
                    (DateTime v) => v)),
                providerValueComparer: new ValueComparer<string>(
                    (string v1, string v2) => v1 == v2,
                    (string v) => v.GetHashCode(),
                    (string v) => v),
                mappingInfo: new RelationalTypeMappingInfo(
                    storeTypeName: "nvarchar(max)",
                    dbType: System.Data.DbType.String),
                converter: new CollectionToJsonStringConverter<DateTime>(new JsonCollectionReaderWriter<DateTime[], DateTime[], DateTime>(
                    JsonDateTimeReaderWriter.Instance)),
                storeTypePostfix: StoreTypePostfix.None,
                jsonValueReaderWriter: new JsonCollectionReaderWriter<DateTime[], DateTime[], DateTime>(
                    JsonDateTimeReaderWriter.Instance),
                elementMapping: SqlServerDateTimeTypeMapping.Default.Clone(
                    comparer: new ValueComparer<DateTime>(
                        (DateTime v1, DateTime v2) => v1.Equals(v2),
                        (DateTime v) => v.GetHashCode(),
                        (DateTime v) => v),
                    keyComparer: new ValueComparer<DateTime>(
                        (DateTime v1, DateTime v2) => v1.Equals(v2),
                        (DateTime v) => v.GetHashCode(),
                        (DateTime v) => v),
                    providerValueComparer: new ValueComparer<DateTime>(
                        (DateTime v1, DateTime v2) => v1.Equals(v2),
                        (DateTime v) => v.GetHashCode(),
                        (DateTime v) => v)));
            valueTypeArray.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var valueTypeEnumerable = runtimeEntityType.AddProperty(
                "ValueTypeEnumerable",
                typeof(IEnumerable<byte>),
                propertyInfo: typeof(CSharpRuntimeModelCodeGeneratorTest.OwnedType).GetProperty("ValueTypeEnumerable", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(CSharpRuntimeModelCodeGeneratorTest.OwnedType).GetField("_valueTypeEnumerable", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            valueTypeEnumerable.TypeMapping = SqlServerStringTypeMapping.Default.Clone(
                comparer: new ListComparer<byte>(new ValueComparer<byte>(
                    (byte v1, byte v2) => v1 == v2,
                    (byte v) => (int)v,
                    (byte v) => v)),
                keyComparer: new ListComparer<byte>(new ValueComparer<byte>(
                    (byte v1, byte v2) => v1 == v2,
                    (byte v) => (int)v,
                    (byte v) => v)),
                providerValueComparer: new ValueComparer<string>(
                    (string v1, string v2) => v1 == v2,
                    (string v) => v.GetHashCode(),
                    (string v) => v),
                mappingInfo: new RelationalTypeMappingInfo(
                    storeTypeName: "nvarchar(max)",
                    dbType: System.Data.DbType.String),
                converter: new CollectionToJsonStringConverter<byte>(new JsonCollectionReaderWriter<IEnumerable<byte>, List<byte>, byte>(
                    JsonByteReaderWriter.Instance)),
                storeTypePostfix: StoreTypePostfix.None,
                jsonValueReaderWriter: new JsonCollectionReaderWriter<IEnumerable<byte>, List<byte>, byte>(
                    JsonByteReaderWriter.Instance),
                elementMapping: SqlServerByteTypeMapping.Default.Clone(
                    comparer: new ValueComparer<byte>(
                        (byte v1, byte v2) => v1 == v2,
                        (byte v) => (int)v,
                        (byte v) => v),
                    keyComparer: new ValueComparer<byte>(
                        (byte v1, byte v2) => v1 == v2,
                        (byte v) => (int)v,
                        (byte v) => v),
                    providerValueComparer: new ValueComparer<byte>(
                        (byte v1, byte v2) => v1 == v2,
                        (byte v) => (int)v,
                        (byte v) => v)));
            valueTypeEnumerable.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var valueTypeIList = runtimeEntityType.AddProperty(
                "ValueTypeIList",
                typeof(IList<byte>),
                propertyInfo: typeof(CSharpRuntimeModelCodeGeneratorTest.OwnedType).GetProperty("ValueTypeIList", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(CSharpRuntimeModelCodeGeneratorTest.OwnedType).GetField("<ValueTypeIList>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            valueTypeIList.TypeMapping = SqlServerStringTypeMapping.Default.Clone(
                comparer: new ListComparer<byte>(new ValueComparer<byte>(
                    (byte v1, byte v2) => v1 == v2,
                    (byte v) => (int)v,
                    (byte v) => v)),
                keyComparer: new ListComparer<byte>(new ValueComparer<byte>(
                    (byte v1, byte v2) => v1 == v2,
                    (byte v) => (int)v,
                    (byte v) => v)),
                providerValueComparer: new ValueComparer<string>(
                    (string v1, string v2) => v1 == v2,
                    (string v) => v.GetHashCode(),
                    (string v) => v),
                mappingInfo: new RelationalTypeMappingInfo(
                    storeTypeName: "nvarchar(max)",
                    dbType: System.Data.DbType.String),
                converter: new CollectionToJsonStringConverter<byte>(new JsonCollectionReaderWriter<IList<byte>, List<byte>, byte>(
                    JsonByteReaderWriter.Instance)),
                storeTypePostfix: StoreTypePostfix.None,
                jsonValueReaderWriter: new JsonCollectionReaderWriter<IList<byte>, List<byte>, byte>(
                    JsonByteReaderWriter.Instance),
                elementMapping: SqlServerByteTypeMapping.Default.Clone(
                    comparer: new ValueComparer<byte>(
                        (byte v1, byte v2) => v1 == v2,
                        (byte v) => (int)v,
                        (byte v) => v),
                    keyComparer: new ValueComparer<byte>(
                        (byte v1, byte v2) => v1 == v2,
                        (byte v) => (int)v,
                        (byte v) => v),
                    providerValueComparer: new ValueComparer<byte>(
                        (byte v1, byte v2) => v1 == v2,
                        (byte v) => (int)v,
                        (byte v) => v)));
            valueTypeIList.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var valueTypeList = runtimeEntityType.AddProperty(
                "ValueTypeList",
                typeof(List<short>),
                propertyInfo: typeof(CSharpRuntimeModelCodeGeneratorTest.OwnedType).GetProperty("ValueTypeList", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(CSharpRuntimeModelCodeGeneratorTest.OwnedType).GetField("_valueTypeList", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            valueTypeList.TypeMapping = SqlServerStringTypeMapping.Default.Clone(
                comparer: new ListComparer<short>(new ValueComparer<short>(
                    (short v1, short v2) => v1 == v2,
                    (short v) => (int)v,
                    (short v) => v)),
                keyComparer: new ListComparer<short>(new ValueComparer<short>(
                    (short v1, short v2) => v1 == v2,
                    (short v) => (int)v,
                    (short v) => v)),
                providerValueComparer: new ValueComparer<string>(
                    (string v1, string v2) => v1 == v2,
                    (string v) => v.GetHashCode(),
                    (string v) => v),
                mappingInfo: new RelationalTypeMappingInfo(
                    storeTypeName: "nvarchar(max)",
                    dbType: System.Data.DbType.String),
                converter: new CollectionToJsonStringConverter<short>(new JsonCollectionReaderWriter<List<short>, List<short>, short>(
                    JsonInt16ReaderWriter.Instance)),
                storeTypePostfix: StoreTypePostfix.None,
                jsonValueReaderWriter: new JsonCollectionReaderWriter<List<short>, List<short>, short>(
                    JsonInt16ReaderWriter.Instance),
                elementMapping: SqlServerShortTypeMapping.Default.Clone(
                    comparer: new ValueComparer<short>(
                        (short v1, short v2) => v1 == v2,
                        (short v) => (int)v,
                        (short v) => v),
                    keyComparer: new ValueComparer<short>(
                        (short v1, short v2) => v1 == v2,
                        (short v) => (int)v,
                        (short v) => v),
                    providerValueComparer: new ValueComparer<short>(
                        (short v1, short v2) => v1 == v2,
                        (short v) => (int)v,
                        (short v) => v)));
            valueTypeList.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var context = runtimeEntityType.AddServiceProperty(
                "Context",
                propertyInfo: typeof(CSharpRuntimeModelCodeGeneratorTest.OwnedType).GetProperty("Context", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                serviceType: typeof(DbContext));

            var key = runtimeEntityType.AddKey(
                new[] { principalDerivedId, principalDerivedAlternateId, id });
            runtimeEntityType.SetPrimaryKey(key);

            return runtimeEntityType;
        }

        public static RuntimeForeignKey CreateForeignKey1(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
        {
            var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("PrincipalDerivedId"), declaringEntityType.FindProperty("PrincipalDerivedAlternateId") },
                principalEntityType.FindKey(new[] { principalEntityType.FindProperty("Id"), principalEntityType.FindProperty("AlternateId") }),
                principalEntityType,
                deleteBehavior: DeleteBehavior.Cascade,
                required: true,
                ownership: true);

            var manyOwned = principalEntityType.AddNavigation("ManyOwned",
                runtimeForeignKey,
                onDependent: false,
                typeof(ICollection<CSharpRuntimeModelCodeGeneratorTest.OwnedType>),
                fieldInfo: typeof(CSharpRuntimeModelCodeGeneratorTest.PrincipalDerived<CSharpRuntimeModelCodeGeneratorTest.DependentBase<byte?>>).GetField("ManyOwned", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                eagerLoaded: true);

            return runtimeForeignKey;
        }

        public static void CreateAnnotations(RuntimeEntityType runtimeEntityType)
        {
            runtimeEntityType.AddAnnotation("Relational:ContainerColumnName", "ManyOwned");
            runtimeEntityType.AddAnnotation("Relational:FunctionName", null);
            runtimeEntityType.AddAnnotation("Relational:Schema", null);
            runtimeEntityType.AddAnnotation("Relational:SqlQuery", null);
            runtimeEntityType.AddAnnotation("Relational:TableName", "PrincipalBase");
            runtimeEntityType.AddAnnotation("Relational:ViewName", null);
            runtimeEntityType.AddAnnotation("Relational:ViewSchema", null);

            Customize(runtimeEntityType);
        }

        static partial void Customize(RuntimeEntityType runtimeEntityType);
    }
}
