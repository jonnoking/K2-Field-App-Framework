using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K2Field.Apps.Framework.Build
{
    public class AppBusinessAudit
    {

        public SmartObjectDefinition GetDefinition()
        {
            #region App Business Audit
            List<SmartObjectProperty> AppBusinessAuditProperties = new List<SmartObjectProperty>();
            AppBusinessAuditProperties.Add(new SmartObjectProperty()
            {
                Id = new Guid("6784bc80-504b-454e-81c1-06c6d76c330d"),
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
            AppBusinessAuditProperties.Add(new SmartObjectProperty()
            {
                Id = new Guid("96e61275-e815-4bfc-9fde-fefc672fd4be"),
                SystemName = "App Instance ID",
                DisplayName = "App Instance ID",
                DataType = SmODataType.AutoGuid,
                ExtendType = ExtendPropertyType.Default,
                Description = "App Instance ID",
                IsKey = false,
                IsRequired = false,
                IsUnique = false,
                IsSmartBox = true,
            });
            AppBusinessAuditProperties.Add(new SmartObjectProperty()
            {
                Id = new Guid("72301b5a-f2ff-4e59-a4c9-1383515cae5c"),
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
            AppBusinessAuditProperties.Add(new SmartObjectProperty()
            {
                Id = new Guid("6be11228-9bdb-46e4-ad99-32cfb487ac9b"),
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

            AppBusinessAuditProperties.Add(new SmartObjectProperty()
            {
                Id = new Guid("3dfb423b-0fb1-47bd-8644-fb89cb824085"),
                SystemName = "Type",
                DisplayName = "Type",
                DataType = SmODataType.Text,
                ExtendType = ExtendPropertyType.Default,
                Description = "Type",
                IsKey = false,
                IsRequired = false,
                IsUnique = false,
                IsSmartBox = true,
                MaxSize = 500
            });

            AppBusinessAuditProperties.Add(new SmartObjectProperty()
            {
                Id = new Guid("72301b5a-f2ff-4e59-a4c9-1383515cae5c"),
                SystemName = "Source",
                DisplayName = "Source",
                DataType = SmODataType.Text,
                ExtendType = ExtendPropertyType.Default,
                Description = "Source",
                IsKey = false,
                IsRequired = false,
                IsUnique = false,
                IsSmartBox = true,
                MaxSize = 500
            });

            AppBusinessAuditProperties.Add(new SmartObjectProperty()
            {
                Id = new Guid("20b9b65b-cf0a-4434-ad57-4907e4feeca0"),
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
            AppBusinessAuditProperties.Add(new SmartObjectProperty()
            {
                Id = new Guid("5438611e-08ed-44d8-8d83-4b21041b243a"),
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
            AppBusinessAuditProperties.Add(new SmartObjectProperty()
            {
                Id = new Guid("daa6b9d8-0994-4386-a1fc-2207a08079f7"),
                SystemName = "Created By FQN",
                DisplayName = "Created By FQN",
                DataType = SmODataType.Text,
                ExtendType = ExtendPropertyType.Default,
                Description = "Created By FQN",
                IsKey = false,
                IsRequired = false,
                IsUnique = false,
                IsSmartBox = true,
            });

            SmartObjectDefinition AppBusinessAudit = new SmartObjectDefinition()
            {
                Id = new Guid("5a3c77f1-731f-4930-a1ec-533dd8300ff3"),
                SystemName = "K2App.Core.SMO.AppBusinessAudit",
                DisplayName = "K2 App Core App Business Audit",
                ServiceInstanceId = new Guid(ServiceInstanceTypes.SmartBox),
                Properties = AppBusinessAuditProperties
            };

            #endregion App Business Audit


            return AppBusinessAudit;

        }

    }
}
