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
                Description = "Title",
                IsKey = false,
                IsRequired = false,
                IsUnique = false,
                IsSmartBox = true,
                MaxSize = 500
            });
            AppTypeProperties.Add(new SmartObjectProperty()
            {
                Id = new Guid("b1e95c0c-8137-4ec2-b5a2-b8541e9e260d"),
                SystemName = "Prefix",
                DisplayName = "Prefix",
                DataType = SmODataType.Text,
                Description = "Prefix",
                IsKey = false,
                IsRequired = false,
                IsUnique = false,
                IsSmartBox = true,
            });
            AppTypeProperties.Add(new SmartObjectProperty()
            {
                Id = new Guid("b1e95c0c-8137-4ec2-b5a2-b8541e9e260d"),
                SystemName = "Icon",
                DisplayName = "Icon",
                DataType = SmODataType.Text,
                Description = "Icon",
                IsKey = false,
                IsRequired = false,
                IsUnique = false,
                IsSmartBox = true,
            });
            AppTypeProperties.Add(new SmartObjectProperty()
            {
                Id = new Guid("6415cfda-4395-42ff-8b70-dc44353fcfb5"),
                SystemName = "Start Stage Id",
                DisplayName = "Start Stage Id",
                DataType = SmODataType.Text,
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
