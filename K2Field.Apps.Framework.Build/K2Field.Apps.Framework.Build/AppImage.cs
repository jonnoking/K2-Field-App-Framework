using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K2Field.Apps.Framework.Build
{
    public class AppImage
    {

        public SmartObjectDefinition GetDefinition()
        {
            #region App Image
            List<SmartObjectProperty> AppImageProperties = new List<SmartObjectProperty>();
            AppImageProperties.Add(new SmartObjectProperty()
            {
                Id = new Guid("414371F7-D3F7-4F8B-AC99-9136F27BAD80"),
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
            AppImageProperties.Add(new SmartObjectProperty()
            {
                Id = new Guid("A5C7B114-823F-470E-8225-CA834030D7D3"),
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
            AppImageProperties.Add(new SmartObjectProperty()
            {
                Id = new Guid("04110DDA-CB56-452E-97B2-3A0754D54B9F"),
                SystemName = "Image",
                DisplayName = "Image",
                DataType = SmODataType.Memo,
                ExtendType = ExtendPropertyType.Default,
                Description = "Image",
                IsKey = false,
                IsRequired = false,
                IsUnique = false,
                IsSmartBox = true,
            });
            AppImageProperties.Add(new SmartObjectProperty()
            {
                Id = new Guid("82d3db5b-13dc-46c5-97d1-f68b30b3c09f"),
                SystemName = "Width",
                DisplayName = "Width",
                DataType = SmODataType.Number,
                ExtendType = ExtendPropertyType.Default,
                Description = "Width",
                IsKey = false,
                IsRequired = false,
                IsUnique = false,
                IsSmartBox = true,
            });
            AppImageProperties.Add(new SmartObjectProperty()
            {
                Id = new Guid("C16B9C00-AA6F-4F7F-8A25-28924BCA02A1"),
                SystemName = "Height",
                DisplayName = "Height",
                DataType = SmODataType.Number,
                ExtendType = ExtendPropertyType.Default,
                Description = "Height",
                IsKey = false,
                IsRequired = false,
                IsUnique = false,
                IsSmartBox = true,
            });

            SmartObjectDefinition AppImage = new SmartObjectDefinition()
            {
                Id = new Guid("2B6767B7-B2EA-4258-AF7C-420CC45BE68F"),
                SystemName = "K2App_Core_SMO_AppImage",
                DisplayName = "K2 App Core App Image",
                ServiceInstanceId = new Guid(ServiceInstanceTypes.SmartBox),
                Properties = AppImageProperties
            };

            #endregion App Image


            return AppImage;

        }
    }
}
