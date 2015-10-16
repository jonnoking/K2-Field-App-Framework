using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K2Field.Apps.Framework.Build
{
    public class AppStageAction
    {

        public SmartObjectDefinition GetDefinition()
        {
            #region App Stage Action
            List<SmartObjectProperty> AppStageActionProperties = new List<SmartObjectProperty>();
            AppStageActionProperties.Add(new SmartObjectProperty()
            {
                Id = new Guid("9a59b76c-76da-4bf0-a4a6-3f57708c9afc"),
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
            AppStageActionProperties.Add(new SmartObjectProperty()
            {
                Id = new Guid("1d167f7a-f8e3-4344-beec-e30b8f9758db"),
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
            AppStageActionProperties.Add(new SmartObjectProperty()
            {
                Id = new Guid("9ed1a320-767b-4c55-b13b-3be9c68d0ca1"),
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
            AppStageActionProperties.Add(new SmartObjectProperty()
            {
                Id = new Guid("19e42ec5-8708-4e41-82cd-194c59c8cae5"),
                SystemName = "App Stage ID",
                DisplayName = "App Stage ID",
                DataType = SmODataType.Guid,
                ExtendType = ExtendPropertyType.Default,
                Description = "App Stage ID",
                IsKey = false,
                IsRequired = false,
                IsUnique = false,
                IsSmartBox = true,
            });
            AppStageActionProperties.Add(new SmartObjectProperty()
            {
                Id = new Guid("27146894-9d62-45bd-82f0-1e58fe313fec"),
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
            AppStageActionProperties.Add(new SmartObjectProperty()
            {
                Id = new Guid("ee0dc06f-c4ed-4327-955c-8495d8d9cf7d"),
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
            AppStageActionProperties.Add(new SmartObjectProperty()
            {
                Id = new Guid("6d0ce4d3-ac1b-426a-8c81-33bb15940b20"),
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
            AppStageActionProperties.Add(new SmartObjectProperty()
            {
                Id = new Guid("e6e05070-c28c-4935-9e2f-bb450ca97806"),
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
            AppStageActionProperties.Add(new SmartObjectProperty()
            {
                Id = new Guid("3174aede-a2dc-4dc2-b989-6790bf629cd9"),
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
            AppStageActionProperties.Add(new SmartObjectProperty()
            {
                Id = new Guid("bb0c5688-9e62-4e4a-8a46-5b5ee82b04a9"),
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
            AppStageActionProperties.Add(new SmartObjectProperty()
            {
                Id = new Guid("43a4ce1a-8631-4e0f-a714-77edd2981549"),
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
            AppStageActionProperties.Add(new SmartObjectProperty()
            {
                Id = new Guid("e35de7be-6485-43b3-a1a2-0ede44dce446"),
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
            AppStageActionProperties.Add(new SmartObjectProperty()
            {
                Id = new Guid("aed87276-08aa-4c06-9f82-4b644cde9ea0"),
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
            AppStageActionProperties.Add(new SmartObjectProperty()
            {
                Id = new Guid("a00fac4c-38ab-4ea3-b747-1a549d8f7727"),
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



            SmartObjectDefinition AppStageAction = new SmartObjectDefinition()
            {
                Id = new Guid("e9de772e-3ab7-417a-b07d-3acf862fbddd"),
                SystemName = "K2App.Core.SMO.AppStageAction",
                DisplayName = "K2 App Core App Stage Action",
                ServiceInstanceId = new Guid(ServiceInstanceTypes.SmartBox),
                Properties = AppStageActionProperties
            };

            #endregion App Stage Action


            return AppStageAction;

        }

    }
}
