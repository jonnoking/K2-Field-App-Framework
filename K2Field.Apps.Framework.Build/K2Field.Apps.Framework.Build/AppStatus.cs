using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K2Field.Apps.Framework.Build
{
    public class AppStatus
    {

        public SmartObjectDefinition GetDefinition()
        {
            #region App Status
            List<SmartObjectProperty> AppStatusProperties = new List<SmartObjectProperty>();
            AppStatusProperties.Add(new SmartObjectProperty()
            {
                Id = new Guid("848b95c5-8c19-4126-b2c6-607c74379acb"),
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
            AppStatusProperties.Add(new SmartObjectProperty()
            {
                Id = new Guid("0b78f957-9c78-4a93-879b-f9eb5598cc97"),
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
            AppStatusProperties.Add(new SmartObjectProperty()
            {
                Id = new Guid("8e4f908a-9167-4585-b53f-2a6004d2b487"),
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
            AppStatusProperties.Add(new SmartObjectProperty()
            {
                Id = new Guid("c6f17c74-7082-499a-884b-85a7f88973b6"),
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
            AppStatusProperties.Add(new SmartObjectProperty()
            {
                Id = new Guid("b3c5f0a5-3963-4818-8ed2-2d5bdc1232b6"),
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
            AppStatusProperties.Add(new SmartObjectProperty()
            {
                Id = new Guid("f472c4e5-2156-4f4c-bf39-860ff690017f"),
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
            AppStatusProperties.Add(new SmartObjectProperty()
            {
                Id = new Guid("c89cb3fb-025e-4735-b686-4a53ffec075e"),
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
            AppStatusProperties.Add(new SmartObjectProperty()
            {
                Id = new Guid("8cccc872-b6a7-483b-abb0-5e451fceede5"),
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
            AppStatusProperties.Add(new SmartObjectProperty()
            {
                Id = new Guid("5a8a2dce-4587-4ece-90cb-86a6ab81d46d"),
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
            AppStatusProperties.Add(new SmartObjectProperty()
            {
                Id = new Guid("bb66578c-32dc-41c5-a4fa-b8701f5f1246"),
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
            AppStatusProperties.Add(new SmartObjectProperty()
            {
                Id = new Guid("85973573-35fe-4e68-bd07-7e7fadc6d9ba"),
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



            SmartObjectDefinition AppStatus = new SmartObjectDefinition()
            {
                Id = new Guid("7d89eee6-cda0-4e74-b47c-296acd4959a7"),
                SystemName = "K2App.Core.SMO.AppStatus",
                DisplayName = "K2 App Core App Status",
                ServiceInstanceId = new Guid(ServiceInstanceTypes.SmartBox),
                Properties = AppStatusProperties
            };

            #endregion App Status


            return AppStatus;

        }

    }
}
