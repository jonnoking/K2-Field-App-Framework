using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K2Field.Apps.Framework.Build
{
    public class AppException
    {

        public SmartObjectDefinition GetDefinition()
        {
            #region App Exception
            List<SmartObjectProperty> AppExceptionProperties = new List<SmartObjectProperty>();
            AppExceptionProperties.Add(new SmartObjectProperty()
            {
                Id = new Guid("7e42ee3b-2d8b-4ef9-8e30-c307eef8c118"),
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
            AppExceptionProperties.Add(new SmartObjectProperty()
            {
                Id = new Guid("3e7771d5-8eff-4570-b063-98b4ac80c131"),
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
            AppExceptionProperties.Add(new SmartObjectProperty()
            {
                Id = new Guid("464e7bfe-9b93-474d-902c-4e78f3229206"),
                SystemName = "Message",
                DisplayName = "Message",
                DataType = SmODataType.Text,
                ExtendType = ExtendPropertyType.Default,
                Description = "Message",
                IsKey = false,
                IsRequired = false,
                IsUnique = false,
                IsSmartBox = true,
                MaxSize = 500
            });
            AppExceptionProperties.Add(new SmartObjectProperty()
            {
                Id = new Guid("71a66dc4-0c05-4047-a78e-113393afbe25"),
                SystemName = "Details",
                DisplayName = "Details",
                DataType = SmODataType.Memo,
                ExtendType = ExtendPropertyType.Default,
                Description = "Details",
                IsKey = false,
                IsRequired = false,
                IsUnique = false,
                IsSmartBox = true,
            });

            AppExceptionProperties.Add(new SmartObjectProperty()
            {
                Id = new Guid("bc3c0c19-8854-4e4d-b867-f65dba0bbec7"),
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

            AppExceptionProperties.Add(new SmartObjectProperty()
            {
                Id = new Guid("b1eb076b-ea42-45d4-a3ea-0133b4c0fe69"),
                SystemName = "Source Type",
                DisplayName = "Source Type",
                DataType = SmODataType.Text,
                ExtendType = ExtendPropertyType.Default,
                Description = "Source Type",
                IsKey = false,
                IsRequired = false,
                IsUnique = false,
                IsSmartBox = true,
                MaxSize = 500
            });

            AppExceptionProperties.Add(new SmartObjectProperty()
            {
                Id = new Guid("7919b05e-7447-40af-8182-d8fb42bc2238"),
                SystemName = "Source ID",
                DisplayName = "Source ID",
                DataType = SmODataType.Text,
                ExtendType = ExtendPropertyType.Default,
                Description = "Source ID",
                IsKey = false,
                IsRequired = false,
                IsUnique = false,
                IsSmartBox = true,
                MaxSize = 500
            });
            AppExceptionProperties.Add(new SmartObjectProperty()
            {
                Id = new Guid("12f2203b-047a-49da-ae78-75e3480d9019"),
                SystemName = "Source Name",
                DisplayName = "Source Name",
                DataType = SmODataType.Text,
                ExtendType = ExtendPropertyType.Default,
                Description = "Source Name",
                IsKey = false,
                IsRequired = false,
                IsUnique = false,
                IsSmartBox = true,
                MaxSize = 500
            });

            AppExceptionProperties.Add(new SmartObjectProperty()
            {
                Id = new Guid("180f39c2-ebc2-4b22-bb01-134cdae838d9"),
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

            AppExceptionProperties.Add(new SmartObjectProperty()
            {
                Id = new Guid("18b9037d-d9d7-4471-bd41-2dccf32e15cf"),
                SystemName = "Notes",
                DisplayName = "Notes",
                DataType = SmODataType.Memo,
                ExtendType = ExtendPropertyType.Default,
                Description = "Notes",
                IsKey = false,
                IsRequired = false,
                IsUnique = false,
                IsSmartBox = true,
            });

            AppExceptionProperties.Add(new SmartObjectProperty()
            {
                Id = new Guid("a7f4148d-1aa2-436a-96a1-237248eeb42b"),
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

            SmartObjectDefinition AppException = new SmartObjectDefinition()
            {
                Id = new Guid("0c020fc7-8611-4826-9399-904ba5873100"),
                SystemName = "K2App.Core.SMO.AppException",
                DisplayName = "K2 App Core App Exception",
                ServiceInstanceId = new Guid(ServiceInstanceTypes.SmartBox),
                Properties = AppExceptionProperties
            };

            #endregion App Exception


            return AppException;

        }

    }
}
