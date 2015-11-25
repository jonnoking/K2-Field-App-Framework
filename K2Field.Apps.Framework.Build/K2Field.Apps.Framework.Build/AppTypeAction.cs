using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K2Field.Apps.Framework.Build
{
    public class AppTypeAction
    {
        public SmartObjectDefinition GetDefinition()
        {
            #region App Type Action
            List<SmartObjectProperty> AppTypeActionProperties = new List<SmartObjectProperty>();
            AppTypeActionProperties.Add(new SmartObjectProperty()
            {
                Id = new Guid("{33584F58-FBAA-49E2-AFAF-1AFF17C4E3C9}"),
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
            AppTypeActionProperties.Add(new SmartObjectProperty()
            {
                Id = new Guid("{9BF2D650-D523-4B14-9B70-AC26C99B209D}"),
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
            AppTypeActionProperties.Add(new SmartObjectProperty()
            {
                Id = new Guid("{70276D72-34BF-4F0C-A98D-6B52BC46AB4B}"),
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
            AppTypeActionProperties.Add(new SmartObjectProperty()
            {
                Id = new Guid("{8A3D1F5C-CD1A-4979-A8F9-1AA4AF60A9F3}"),
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
            AppTypeActionProperties.Add(new SmartObjectProperty()
            {
                Id = new Guid("{C7F3992F-8274-4C7D-874B-D86E9BB598CB}"),
                SystemName = "Icon",
                DisplayName = "Icon",
                DataType = SmODataType.Image,
                ExtendType = ExtendPropertyType.Default,
                Description = "Icon",
                IsKey = false,
                IsRequired = false,
                IsUnique = false,
                IsSmartBox = true,
            });
            AppTypeActionProperties.Add(new SmartObjectProperty()
            {
                Id = new Guid("{0B0619A4-81A4-4370-B20D-BA105DB9238F}"),
                SystemName = "Action Form",
                DisplayName = "Action Form",
                DataType = SmODataType.Text,
                ExtendType = ExtendPropertyType.Default,
                Description = "Icon",
                IsKey = false,
                IsRequired = false,
                IsUnique = false,
                IsSmartBox = true,
                MaxSize = 500,
            });
            AppTypeActionProperties.Add(new SmartObjectProperty()
            {
                Id = new Guid("{B07122D9-82C8-4C8E-96BB-1B977ACBCFA9}"),
                SystemName = "Is Important",
                DisplayName = "Is Important",
                DataType = SmODataType.YesNo,
                ExtendType = ExtendPropertyType.Default,
                Description = "Is Important",
                IsKey = false,
                IsRequired = false,
                IsUnique = false,
                IsSmartBox = true,
            });
            AppTypeActionProperties.Add(new SmartObjectProperty()
            {
                Id = new Guid("{756B60A6-9D8D-4DC9-BE37-F810D70820E2}"),
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
            AppTypeActionProperties.Add(new SmartObjectProperty()
            {
                Id = new Guid("{C5350449-9E01-4348-823E-65A8FA94EC52}"),
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
            AppTypeActionProperties.Add(new SmartObjectProperty()
            {
                Id = new Guid("{6F26A498-C30A-4D5A-B4C7-2D2F4F2D9245}"),
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
            AppTypeActionProperties.Add(new SmartObjectProperty()
            {
                Id = new Guid("{2DBF8A78-366F-4338-93CA-F67B30A7766D}"),
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
            AppTypeActionProperties.Add(new SmartObjectProperty()
            {
                Id = new Guid("{3A4CDD31-1270-4024-B392-18CF2B3F9786}"),
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
            AppTypeActionProperties.Add(new SmartObjectProperty()
            {
                Id = new Guid("{FD13C80F-6B65-4D3A-A402-082206B11540}"),
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
            AppTypeActionProperties.Add(new SmartObjectProperty()
            {
                Id = new Guid("{7C55D04A-5204-4EA2-86FE-277FB3ECD1FB}"),
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



            SmartObjectDefinition AppTypeAction = new SmartObjectDefinition()
            {
                Id = new Guid("{1C4B0B36-DAC8-44D3-892F-737291FD3EA4}"),
                SystemName = "K2App_Core_SMO_AppTypeAction",
                DisplayName = "K2 App Core App Type Action",
                ServiceInstanceId = new Guid(ServiceInstanceTypes.SmartBox),
                Properties = AppTypeActionProperties
            };

            #endregion App Type Action


            return AppTypeAction;
        }
    }
}
