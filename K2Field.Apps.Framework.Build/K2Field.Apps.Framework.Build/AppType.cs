using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K2Field.Apps.Framework.Build
{
    public class AppType
    {
        public SmartObjectDefinition GetDefinition()
        {
            #region App Type
            List<SmartObjectProperty> AppTypeProperties = new List<SmartObjectProperty>();
            AppTypeProperties.Add(new SmartObjectProperty()
            {
                Id = new Guid("80171a5b-0252-4a6c-99c4-437b0cc22291"),
                SystemName = "ID",
                DisplayName = "ID",
                DataType = SmODataType.AutoGuid,
                ExtendType = ExtendPropertyType.UniqueIdAuto,
                Description = "ID",
                IsKey = true,
                IsRequired = true,
                IsUnique = true,
                IsSmartBox = true,
            });
            AppTypeProperties.Add(new SmartObjectProperty()
            {
                Id = new Guid("3343bc27-11f5-45a9-aeb5-d4ec1db24bf3"),
                SystemName = "Title",
                DisplayName = "Title",
                DataType = SmODataType.Text,
                ExtendType = ExtendPropertyType.Default,
                Description = "Title",
                IsKey = false,
                IsRequired = false,
                IsUnique = false,
                IsSmartBox = true,
                MaxSize = 500
            });
            AppTypeProperties.Add(new SmartObjectProperty()
            {
                Id = new Guid("06a714e5-7968-46f1-ae98-cd8f4655cd94"),
                SystemName = "Description",
                DisplayName = "Description",
                DataType = SmODataType.Memo,
                ExtendType = ExtendPropertyType.Default,
                Description = "Description",
                IsKey = false,
                IsRequired = false,
                IsUnique = false,
                IsSmartBox = true,
            });

            AppTypeProperties.Add(new SmartObjectProperty()
            {
                Id = new Guid("b1e95c0c-8137-4ec2-b5a2-b8541e9e260d"),
                SystemName = "Prefix",
                DisplayName = "Prefix",
                DataType = SmODataType.Text,
                ExtendType = ExtendPropertyType.Default,
                Description = "Prefix",
                IsKey = false,
                IsRequired = false,
                IsUnique = false,
                IsSmartBox = true,
            });

            AppTypeProperties.Add(new SmartObjectProperty()
            {
                Id = new Guid("69113266-1BBE-4FEF-AEA3-5C45E8847A99"),
                SystemName = "Icon",
                DisplayName = "Icon",
                DataType = SmODataType.Memo,
                ExtendType = ExtendPropertyType.Default,
                Description = "Icon",
                IsKey = false,
                IsRequired = false,
                IsUnique = false,
                IsSmartBox = true,
            });

            AppTypeProperties.Add(new SmartObjectProperty()
            {
                Id = new Guid("735CCBBF-83E2-43BF-BD7B-96673B4C0DDD"),
                SystemName = "Start Stage Id",
                DisplayName = "Start Stage Id",
                DataType = SmODataType.Text,
                ExtendType = ExtendPropertyType.Default,
                Description = "Start Stage Id",
                IsKey = false,
                IsRequired = false,
                IsUnique = false,
                IsSmartBox = true,
            });

            AppTypeProperties.Add(new SmartObjectProperty()
            {
                Id = new Guid("0c628ec3-ad6b-4a32-a43f-babbde402b3a"),
                SystemName = "Start Status Id",
                DisplayName = "Start Status Id",
                DataType = SmODataType.Text,
                ExtendType = ExtendPropertyType.Default,
                Description = "Start Status Id",
                IsKey = false,
                IsRequired = false,
                IsUnique = false,
                IsSmartBox = true,
            });
            AppTypeProperties.Add(new SmartObjectProperty()
            {
                Id = new Guid("5f2f0cd4-9d0b-4698-be5e-cadaeb0d0031"),
                SystemName = "Start KPI Id",
                DisplayName = "Start KPI Id",
                DataType = SmODataType.Guid,
                ExtendType = ExtendPropertyType.Default,
                Description = "Start KPI Id",
                IsKey = false,
                IsRequired = false,
                IsUnique = false,
                IsSmartBox = true,
            });
            AppTypeProperties.Add(new SmartObjectProperty()
            {
                Id = new Guid("caa7a92f-d5b8-42bd-835f-988d6d05a206"),
                SystemName = "Start Priority Id",
                DisplayName = "Start Priority Id",
                DataType = SmODataType.Guid,
                ExtendType = ExtendPropertyType.Default,
                Description = "Start Priority Id",
                IsKey = false,
                IsRequired = false,
                IsUnique = false,
                IsSmartBox = true,
            });
            AppTypeProperties.Add(new SmartObjectProperty()
            {
                Id = new Guid("42ba7e34-27f1-4ed0-b929-13fa0e458ce6"),
                SystemName = "Start Form",
                DisplayName = "Start Form",
                DataType = SmODataType.Memo,
                ExtendType = ExtendPropertyType.Default,
                Description = "Start Form",
                IsKey = false,
                IsRequired = false,
                IsUnique = false,
                IsSmartBox = true,
            });
            AppTypeProperties.Add(new SmartObjectProperty()
            {
                Id = new Guid("8744e514-4130-496e-aa82-df64738bd84f"),
                SystemName = "Update Form",
                DisplayName = "Update Form",
                DataType = SmODataType.Memo,
                Description = "Update Form",
                IsKey = false,
                IsRequired = false,
                IsUnique = false,
                IsSmartBox = true,
            });
            AppTypeProperties.Add(new SmartObjectProperty()
            {
                Id = new Guid("E35DB339-8262-4B81-A610-C89A391193E6"),
                SystemName = "View Form",
                DisplayName = "View Form",
                DataType = SmODataType.Memo,
                ExtendType = ExtendPropertyType.Default,
                Description = "View Form",
                IsKey = false,
                IsRequired = false,
                IsUnique = false,
                IsSmartBox = true,
            });
            AppTypeProperties.Add(new SmartObjectProperty()
            {
                Id = new Guid("031e6acd-56ce-4e5b-a9a3-4c011f4e2859"),
                SystemName = "Management Form",
                DisplayName = "Management Form",
                DataType = SmODataType.Memo,
                ExtendType = ExtendPropertyType.Default,
                Description = "Management Form",
                IsKey = false,
                IsRequired = false,
                IsUnique = false,
                IsSmartBox = true,
            });
            AppTypeProperties.Add(new SmartObjectProperty()
            {
                Id = new Guid("73276fa9-d0c2-4589-ae65-5f428409c046"),
                SystemName = "Expected Duration Minutes",
                DisplayName = "Expected Duration Minutes",
                DataType = SmODataType.Number,
                ExtendType = ExtendPropertyType.Default,
                Description = "Expected Duration Minutes",
                IsKey = false,
                IsRequired = false,
                IsUnique = false,
                IsSmartBox = true,
            });
            AppTypeProperties.Add(new SmartObjectProperty()
            {
                Id = new Guid("51c5a3a0-99b1-46a7-8c50-502dc04256c8"),
                SystemName = "Created On",
                DisplayName = "Created On",
                DataType = SmODataType.DateTime,
                ExtendType = ExtendPropertyType.Default,
                Description = "Created On",
                IsKey = false,
                IsRequired = false,
                IsUnique = false,
                IsSmartBox = true,
            });
            AppTypeProperties.Add(new SmartObjectProperty()
            {
                Id = new Guid("ee302f48-7164-4ac6-b4fd-192678c2eecd"),
                SystemName = "Created By",
                DisplayName = "Created By",
                DataType = SmODataType.Text,
                ExtendType = ExtendPropertyType.Default,
                Description = "Created By",
                IsKey = false,
                IsRequired = false,
                IsUnique = false,
                IsSmartBox = true,
            });
            AppTypeProperties.Add(new SmartObjectProperty()
            {
                Id = new Guid("8c07d39a-26e2-44b8-a05a-180321829a39"),
                SystemName = "Modified On",
                DisplayName = "Modified On",
                DataType = SmODataType.DateTime,
                ExtendType = ExtendPropertyType.Default,
                Description = "Modified On",
                IsKey = false,
                IsRequired = false,
                IsUnique = false,
                IsSmartBox = true,
            });
            AppTypeProperties.Add(new SmartObjectProperty()
            {
                Id = new Guid("f011ad91-7508-410a-bb40-0b24fb1e3f0d"),
                SystemName = "Modified By",
                DisplayName = "Modified By",
                DataType = SmODataType.Text,
                ExtendType = ExtendPropertyType.Default,
                Description = "Modified By",
                IsKey = false,
                IsRequired = false,
                IsUnique = false,
                IsSmartBox = true,
            });
            AppTypeProperties.Add(new SmartObjectProperty()
            {
                Id = new Guid("4392e79e-3dde-44f4-80f4-5dd9a1939ead"),
                SystemName = "Is Active",
                DisplayName = "Is Active",
                DataType = SmODataType.YesNo,
                ExtendType = ExtendPropertyType.Default,
                Description = "Is Active",
                IsKey = false,
                IsRequired = false,
                IsUnique = false,
                IsSmartBox = true,
            });
            AppTypeProperties.Add(new SmartObjectProperty()
            {
                Id = new Guid("4619e805-3dda-4041-b52b-54a0bae15046"),
                SystemName = "Is Deleted",
                DisplayName = "Is Deleted",
                DataType = SmODataType.YesNo,
                ExtendType = ExtendPropertyType.Default,
                Description = "Is Deleted",
                IsKey = false,
                IsRequired = false,
                IsUnique = false,
                IsSmartBox = true,
            });
            AppTypeProperties.Add(new SmartObjectProperty()
            {
                Id = new Guid("16422f43-4761-42d6-abc5-06cb635c8f2a"),
                SystemName = "Sort Order",
                DisplayName = "Sort Order",
                DataType = SmODataType.Number,
                ExtendType = ExtendPropertyType.Default,
                Description = "Sort Order",
                IsKey = false,
                IsRequired = false,
                IsUnique = false,
                IsSmartBox = true,
            });

            SmartObjectDefinition AppType = new SmartObjectDefinition()
            {
                Id = new Guid("5a82e2fc-cd5b-4346-b508-d01095a51de3"),
                SystemName = "K2App.Core.SMO.AppType",
                DisplayName = "K2 App Core App Type",
                ServiceInstanceId = new Guid(ServiceInstanceTypes.SmartBox),
                Properties = AppTypeProperties
            };

            #endregion App Type


            return AppType;
        }
    }
}
