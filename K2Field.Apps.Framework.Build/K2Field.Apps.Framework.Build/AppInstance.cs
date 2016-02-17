using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K2Field.Apps.Framework.Build
{
    public class AppInstance
    {

        public SmartObjectDefinition GetDefinition()
        {
            #region App Instance
            List<SmartObjectProperty> AppInstanceProperties = new List<SmartObjectProperty>();
            AppInstanceProperties.Add(new SmartObjectProperty()
            {
                Id = new Guid("3acbf0a2-0578-4f9d-ba7c-c2ccc7104587"),
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
            AppInstanceProperties.Add(new SmartObjectProperty()
            {
                Id = new Guid("17097cd3-4772-4bea-942b-95672d1a26b1"),
                SystemName = "Business Object ID",
                DisplayName = "Business Object ID",
                DataType = SmODataType.Text,
                ExtendType = ExtendPropertyType.Default,
                Description = "Business Object ID",
                IsKey = false,
                IsRequired = false,
                IsUnique = false,
                IsSmartBox = true,
                MaxSize = 100
            });
            AppInstanceProperties.Add(new SmartObjectProperty()
            {
                Id = new Guid("503c1e04-a8c4-491f-8cfc-9975d7210d52"),
                SystemName = "Name",
                DisplayName = "Name",
                DataType = SmODataType.Text,
                ExtendType = ExtendPropertyType.Default,
                Description = "Name",
                IsKey = false,
                IsRequired = false,
                IsUnique = false,
                IsSmartBox = true,
                MaxSize = 500
            });
            AppInstanceProperties.Add(new SmartObjectProperty()
            {
                Id = new Guid("3646d6e8-d8a7-4200-886f-107dd7562b1e"),
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

            AppInstanceProperties.Add(new SmartObjectProperty()
            {
                Id = new Guid("{F1F648CE-9174-4C46-BE9A-71355A7425D7}"),
                SystemName = "Reference",
                DisplayName = "Reference",
                DataType = SmODataType.Text,
                ExtendType = ExtendPropertyType.Default,
                Description = "Reference",
                IsKey = false,
                IsRequired = false,
                IsUnique = false,
                IsSmartBox = true,
            });
            AppInstanceProperties.Add(new SmartObjectProperty()
            {
                Id = new Guid("f9d57343-c424-4700-8989-e53c80530091"),
                SystemName = "Due Date",
                DisplayName = "Due Date",
                DataType = SmODataType.DateTime,
                ExtendType = ExtendPropertyType.Default,
                Description = "Due Date",
                IsKey = false,
                IsRequired = false,
                IsUnique = false,
                IsSmartBox = true,
            });
            AppInstanceProperties.Add(new SmartObjectProperty()
            {
                Id = new Guid("d0271eba-1fcc-4118-8821-db64ab7e4565"),
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
            AppInstanceProperties.Add(new SmartObjectProperty()
            {
                Id = new Guid("649262bb-a7c0-40a4-9e69-006c84aa6808"),
                SystemName = "Percentage Complete",
                DisplayName = "Percentage Complete",
                DataType = SmODataType.Number,
                ExtendType = ExtendPropertyType.Default,
                Description = "Percentage Complete",
                IsKey = false,
                IsRequired = false,
                IsUnique = false,
                IsSmartBox = true,
            });
            AppInstanceProperties.Add(new SmartObjectProperty()
            {
                Id = new Guid("70a14e54-9e14-4a90-86b5-bbc9c789ac15"),
                SystemName = "Parent Application Instance ID",
                DisplayName = "Parent Application Instance ID",
                DataType = SmODataType.Guid,
                ExtendType = ExtendPropertyType.Default,
                Description = "Parent Application Instance ID",
                IsKey = false,
                IsRequired = false,
                IsUnique = false,
                IsSmartBox = true,
            });
            AppInstanceProperties.Add(new SmartObjectProperty()
            {
                Id = new Guid("50fd94db-822a-4fd9-8dae-0bb932384bb3"),
                SystemName = "App Type ID",
                DisplayName = "App Type ID",
                DataType = SmODataType.Guid,
                ExtendType = ExtendPropertyType.Default,
                Description = "App Type ID",
                IsKey = false,
                IsRequired = false,
                IsUnique = false,
                IsSmartBox = true,
            });
            AppInstanceProperties.Add(new SmartObjectProperty()
            {
                Id = new Guid("7a1d979e-2cf2-436c-94d0-2de8e330b071"),
                SystemName = "App Type",
                DisplayName = "App Type",
                DataType = SmODataType.Text,
                ExtendType = ExtendPropertyType.Default,
                Description = "App Type",
                IsKey = false,
                IsRequired = false,
                IsUnique = false,
                IsSmartBox = true,
                MaxSize = 500
            });

            AppInstanceProperties.Add(new SmartObjectProperty()
            {
                Id = new Guid("1cc7cc20-ac1f-4a56-977d-6ac12de4c946"),
                SystemName = "Status ID",
                DisplayName = "Status ID",
                DataType = SmODataType.Guid,
                ExtendType = ExtendPropertyType.Default,
                Description = "Status ID",
                IsKey = false,
                IsRequired = false,
                IsUnique = false,
                IsSmartBox = true,
            });
            AppInstanceProperties.Add(new SmartObjectProperty()
            {
                Id = new Guid("6b5cb9a9-cd87-41a6-a93b-1244a343850e"),
                SystemName = "Status",
                DisplayName = "Status",
                DataType = SmODataType.Text,
                ExtendType = ExtendPropertyType.Default,
                Description = "Status",
                IsKey = false,
                IsRequired = false,
                IsUnique = false,
                IsSmartBox = true,
                MaxSize = 500
            });

            AppInstanceProperties.Add(new SmartObjectProperty()
            {
                Id = new Guid("0f430501-ea17-4b2d-a863-0d8d9154b215"),
                SystemName = "Stage ID",
                DisplayName = "Stage ID",
                DataType = SmODataType.Guid,
                ExtendType = ExtendPropertyType.Default,
                Description = "Stage ID",
                IsKey = false,
                IsRequired = false,
                IsUnique = false,
                IsSmartBox = true,
            });
            AppInstanceProperties.Add(new SmartObjectProperty()
            {
                Id = new Guid("44532415-6c23-4cde-ba74-0fbaf91f558c"),
                SystemName = "Stage",
                DisplayName = "Stage",
                DataType = SmODataType.Text,
                ExtendType = ExtendPropertyType.Default,
                Description = "Stage",
                IsKey = false,
                IsRequired = false,
                IsUnique = false,
                IsSmartBox = true,
                MaxSize = 500
            });

            AppInstanceProperties.Add(new SmartObjectProperty()
            {
                Id = new Guid("2512a813-a5b4-4754-975d-fae7f977e575"),
                SystemName = "Priority ID",
                DisplayName = "Priority ID",
                DataType = SmODataType.Guid,
                ExtendType = ExtendPropertyType.Default,
                Description = "Priority ID",
                IsKey = false,
                IsRequired = false,
                IsUnique = false,
                IsSmartBox = true,
            });
            AppInstanceProperties.Add(new SmartObjectProperty()
            {
                Id = new Guid("8ba1f048-44a6-4d2f-a007-50cab3d03c02"),
                SystemName = "Priority",
                DisplayName = "Priority",
                DataType = SmODataType.Text,
                ExtendType = ExtendPropertyType.Default,
                Description = "Priority",
                IsKey = false,
                IsRequired = false,
                IsUnique = false,
                IsSmartBox = true,
                MaxSize = 500
            });

            AppInstanceProperties.Add(new SmartObjectProperty()
            {
                Id = new Guid("ab54a95c-d393-468d-881e-8639012d2f03"),
                SystemName = "KPI ID",
                DisplayName = "KPI ID",
                DataType = SmODataType.Guid,
                ExtendType = ExtendPropertyType.Default,
                Description = "KPI ID",
                IsKey = false,
                IsRequired = false,
                IsUnique = false,
                IsSmartBox = true,
            });
            AppInstanceProperties.Add(new SmartObjectProperty()
            {
                Id = new Guid("6a9b3697-a043-4ab3-a142-b6806efc551e"),
                SystemName = "KPI",
                DisplayName = "KPI",
                DataType = SmODataType.Text,
                ExtendType = ExtendPropertyType.Default,
                Description = "KPI",
                IsKey = false,
                IsRequired = false,
                IsUnique = false,
                IsSmartBox = true,
                MaxSize = 500
            });
            AppInstanceProperties.Add(new SmartObjectProperty()
            {
                Id = new Guid("e17705fe-67bb-464e-bed9-6f730de45377"),
                SystemName = "View Flow Url",
                DisplayName = "View Flow Url",
                DataType = SmODataType.Memo,
                ExtendType = ExtendPropertyType.Default,
                Description = "View Flow Url",
                IsKey = false,
                IsRequired = false,
                IsUnique = false,
                IsSmartBox = true,
            });

            AppInstanceProperties.Add(new SmartObjectProperty()
            {
                Id = new Guid("e17705fe-67bb-464e-bed9-6f730de45377"),
                SystemName = "Process Instance ID",
                DisplayName = "Process Instance ID",
                DataType = SmODataType.Number,
                ExtendType = ExtendPropertyType.Default,
                Description = "Process Instance ID",
                IsKey = false,
                IsRequired = false,
                IsUnique = false,
                IsSmartBox = true,
            });

            AppInstanceProperties.Add(new SmartObjectProperty()
            {
                Id = new Guid("8927b10c-49c2-4fb9-a0a8-d9f24b32bb07"),
                SystemName = "Owner",
                DisplayName = "Owner",
                DataType = SmODataType.Text,
                ExtendType = ExtendPropertyType.Default,
                Description = "Owner",
                IsKey = false,
                IsRequired = false,
                IsUnique = false,
                IsSmartBox = true,
                MaxSize = 300
            });

            AppInstanceProperties.Add(new SmartObjectProperty()
            {
                Id = new Guid("6a23d5e2-a00b-4ae6-82df-63a49002897b"),
                SystemName = "Owner FQN",
                DisplayName = "Owner FQN",
                DataType = SmODataType.Text,
                ExtendType = ExtendPropertyType.Default,
                Description = "Owner FQN",
                IsKey = false,
                IsRequired = false,
                IsUnique = false,
                IsSmartBox = true,
                MaxSize = 300
            });

            AppInstanceProperties.Add(new SmartObjectProperty()
            {
                Id = new Guid("de2f386a-2a9a-4ede-b39e-678ab5b2617c"),
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
            AppInstanceProperties.Add(new SmartObjectProperty()
            {
                Id = new Guid("03c2ebfa-037d-42fd-836a-de2126d0deb1"),
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
            AppInstanceProperties.Add(new SmartObjectProperty()
            {
                Id = new Guid("8dd2d328-7d8f-43cb-9b9a-be3813634748"),
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
            AppInstanceProperties.Add(new SmartObjectProperty()
            {
                Id = new Guid("9bfbee9c-cf17-42eb-997b-5c68398d76cc"),
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
            AppInstanceProperties.Add(new SmartObjectProperty()
            {
                Id = new Guid("8ddf1b5c-1844-4c5a-ad2a-c363eae8c5d3"),
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
            AppInstanceProperties.Add(new SmartObjectProperty()
            {
                Id = new Guid("1a636d4f-b5f2-460e-b31d-95f7f041484b"),
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
            AppInstanceProperties.Add(new SmartObjectProperty()
            {
                Id = new Guid("b289a61e-c961-4ee3-9528-9f028e56626a"),
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
            AppInstanceProperties.Add(new SmartObjectProperty()
            {
                Id = new Guid("b289a61e-c961-4ee3-9528-9f028e56626a"),
                SystemName = "Record Identifier",
                DisplayName = "Record Identifier",
                DataType = SmODataType.Text,
                ExtendType = ExtendPropertyType.Default,
                Description = "Record Identifier",
                IsKey = false,
                IsRequired = false,
                IsUnique = false,
                IsSmartBox = true,
                MaxSize = 100
            });

            SmartObjectDefinition AppInstance = new SmartObjectDefinition()
            {
                Id = new Guid("9b9c753b-b8cc-4108-80c6-ba14141d8f6f"),
                SystemName = "K2App_Core_SMO_AppInstance",
                DisplayName = "K2 App Core App Instance",
                ServiceInstanceId = new Guid(ServiceInstanceTypes.SmartBox),
                Properties = AppInstanceProperties
            };

            #endregion App Instance


            return AppInstance;

        }

    }
}
