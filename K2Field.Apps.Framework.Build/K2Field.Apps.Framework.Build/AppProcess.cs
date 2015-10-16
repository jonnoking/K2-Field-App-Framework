using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K2Field.Apps.Framework.Build
{
    public class AppProcess
    {

        public SmartObjectDefinition GetDefinition()
        {
            #region App Process
            List<SmartObjectProperty> AppProcessProperties = new List<SmartObjectProperty>();
            AppProcessProperties.Add(new SmartObjectProperty()
            {
                Id = new Guid("278cc710-e6b5-4ea0-8c59-44614a0e2b5d"),
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
            AppProcessProperties.Add(new SmartObjectProperty()
            {
                Id = new Guid("ad91fb25-8220-4584-a52c-523cb97a5754"),
                SystemName = "App Instance ID",
                DisplayName = "App Instance ID",
                DataType = SmODataType.Guid,
                ExtendType = ExtendPropertyType.Default,
                Description = "App Instance ID",
                IsKey = false,
                IsRequired = false,
                IsUnique = false,
                IsSmartBox = true,
            });
            AppProcessProperties.Add(new SmartObjectProperty()
            {
                Id = new Guid("3f943ee8-e1ed-4012-ad8c-33d124cd5155"),
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
            AppProcessProperties.Add(new SmartObjectProperty()
            {
                Id = new Guid("89a97e98-f520-46d8-854a-261e404ed99f"),
                SystemName = "Process Name",
                DisplayName = "Process Name",
                DataType = SmODataType.Text,
                ExtendType = ExtendPropertyType.Default,
                Description = "Process Instance Name",
                IsKey = false,
                IsRequired = false,
                IsUnique = false,
                IsSmartBox = true,
                MaxSize = 500
            });
            AppProcessProperties.Add(new SmartObjectProperty()
            {
                Id = new Guid("8d4ce733-6049-492e-b352-873a9a2c4665"),
                SystemName = "Process Folder",
                DisplayName = "Process Folder",
                DataType = SmODataType.Text,
                ExtendType = ExtendPropertyType.Default,
                Description = "Process Folder",
                IsKey = false,
                IsRequired = false,
                IsUnique = false,
                IsSmartBox = true,
                MaxSize = 500
            });
            AppProcessProperties.Add(new SmartObjectProperty()
            {
                Id = new Guid("495ddde5-2d68-4bee-988d-779410933135"),
                SystemName = "Folio",
                DisplayName = "Folio",
                DataType = SmODataType.Text,
                ExtendType = ExtendPropertyType.Default,
                Description = "Folio",
                IsKey = false,
                IsRequired = false,
                IsUnique = false,
                IsSmartBox = true,
                MaxSize = 500
            });
            AppProcessProperties.Add(new SmartObjectProperty()
            {
                Id = new Guid("541478e6-3e2f-476e-bda9-84bc5df8910c"),
                SystemName = "Originator",
                DisplayName = "Originator",
                DataType = SmODataType.Text,
                ExtendType = ExtendPropertyType.Default,
                Description = "Originator",
                IsKey = false,
                IsRequired = false,
                IsUnique = false,
                IsSmartBox = true,
                MaxSize = 500
            });
            AppProcessProperties.Add(new SmartObjectProperty()
            {
                Id = new Guid("072be15d-73ca-47b7-96d2-e939ca0e85b9"),
                SystemName = "Originator FQN",
                DisplayName = "Originator FQN",
                DataType = SmODataType.Text,
                ExtendType = ExtendPropertyType.Default,
                Description = "Originator FQN",
                IsKey = false,
                IsRequired = false,
                IsUnique = false,
                IsSmartBox = true,
                MaxSize = 500
            });
            AppProcessProperties.Add(new SmartObjectProperty()
            {
                Id = new Guid("270ce6c1-93d9-42c7-bd89-00ca58cf8618"),
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
            AppProcessProperties.Add(new SmartObjectProperty()
            {
                Id = new Guid("61b4b488-351b-4427-84c1-3d4a406b6377"),
                SystemName = "KPI",
                DisplayName = "KPI",
                DataType = SmODataType.Text,
                ExtendType = ExtendPropertyType.Default,
                Description = "KPI",
                IsKey = false,
                IsRequired = false,
                IsUnique = false,
                IsSmartBox = true,
            });
            AppProcessProperties.Add(new SmartObjectProperty()
            {
                Id = new Guid("c8b2cf9f-b292-425d-a924-220851d5b430"),
                SystemName = "Priority",
                DisplayName = "Priority",
                DataType = SmODataType.Text,
                ExtendType = ExtendPropertyType.Default,
                Description = "Priority",
                IsKey = false,
                IsRequired = false,
                IsUnique = false,
                IsSmartBox = true,
            });
            AppProcessProperties.Add(new SmartObjectProperty()
            {
                Id = new Guid("2a379df6-c7e2-4666-abdd-991526dd5ee6"),
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
            AppProcessProperties.Add(new SmartObjectProperty()
            {
                Id = new Guid("6c532c38-19c7-45f0-93f3-bcca93236b9a"),
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
            AppProcessProperties.Add(new SmartObjectProperty()
            {
                Id = new Guid("a3a8e2fa-8fcc-40ee-9ba0-934429c082e2"),
                SystemName = "Completed On",
                DisplayName = "Completed On",
                DataType = SmODataType.DateTime,
                ExtendType = ExtendPropertyType.Default,
                Description = "Completed On",
                IsKey = false,
                IsRequired = false,
                IsUnique = false,
                IsSmartBox = true,
            });
            AppProcessProperties.Add(new SmartObjectProperty()
            {
                Id = new Guid("fb72d552-14d7-4a81-a0b1-37f2b06db9f1"),
                SystemName = "Final Activity",
                DisplayName = "Final Activity",
                DataType = SmODataType.Text,
                ExtendType = ExtendPropertyType.Default,
                Description = "Final Activity",
                IsKey = false,
                IsRequired = false,
                IsUnique = false,
                IsSmartBox = true,
                MaxSize = 500
            });
            AppProcessProperties.Add(new SmartObjectProperty()
            {
                Id = new Guid("ac7e7357-0b02-4612-9210-94c5186328a4"),
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
            AppProcessProperties.Add(new SmartObjectProperty()
            {
                Id = new Guid("9d458c80-c419-45c2-9b2a-8382a62ce045"),
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
            AppProcessProperties.Add(new SmartObjectProperty()
            {
                Id = new Guid("532b58ce-a0c1-4e02-8aba-0ab6b0afb776"),
                SystemName = "Is Primary",
                DisplayName = "Is Primary",
                DataType = SmODataType.YesNo,
                ExtendType = ExtendPropertyType.Default,
                Description = "Is Primary",
                IsKey = false,
                IsRequired = false,
                IsUnique = false,
                IsSmartBox = true,
            });
            AppProcessProperties.Add(new SmartObjectProperty()
            {
                Id = new Guid("ee7b097b-555d-4df3-aa01-87a69127963d"),
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



            SmartObjectDefinition AppProcess = new SmartObjectDefinition()
            {
                Id = new Guid("74c9793e-e9cc-44b7-8f03-465b40abe117"),
                SystemName = "K2App.Core.SMO.AppProcess",
                DisplayName = "K2 App CoreApp Process",
                ServiceInstanceId = new Guid(ServiceInstanceTypes.SmartBox),
                Properties = AppProcessProperties
            };

            #endregion App Process


            return AppProcess;

        }

    }
}
