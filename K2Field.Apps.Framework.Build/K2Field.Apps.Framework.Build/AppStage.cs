using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K2Field.Apps.Framework.Build
{
    public class AppStage
    {

        public SmartObjectDefinition GetDefinition()
        {
            #region App Stage
            List<SmartObjectProperty> AppStageProperties = new List<SmartObjectProperty>();
            AppStageProperties.Add(new SmartObjectProperty()
            {
                Id = new Guid("e40966e7-a543-44e9-8112-72d1949a3d01"),
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
            AppStageProperties.Add(new SmartObjectProperty()
            {
                Id = new Guid("5e842a88-c033-423f-bb48-540fa02bdbb3"),
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
            AppStageProperties.Add(new SmartObjectProperty()
            {
                Id = new Guid("9b232d25-b69b-47ba-aff4-34c8f05429bd"),
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
            AppStageProperties.Add(new SmartObjectProperty()
            {
                Id = new Guid("82d3db5b-13dc-46c5-97d1-f68b30b3c09f"),
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
            AppStageProperties.Add(new SmartObjectProperty()
            {
                Id = new Guid("b8ca9c32-ae37-4e11-90fb-676c5b2a2442"),
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
            AppStageProperties.Add(new SmartObjectProperty()
            {
                Id = new Guid("c4e6be27-c5c3-46cf-b79f-dae6b82fea22"),
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
            AppStageProperties.Add(new SmartObjectProperty()
            {
                Id = new Guid("1ce0d378-a221-4f68-ac3c-95d0f5f3726f"),
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
            AppStageProperties.Add(new SmartObjectProperty()
            {
                Id = new Guid("6a0c05be-7fda-4d8c-8e0d-940bfeefbcda"),
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
            AppStageProperties.Add(new SmartObjectProperty()
            {
                Id = new Guid("daf6d1ab-31b4-48a5-89cc-0ee101232f59"),
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
            AppStageProperties.Add(new SmartObjectProperty()
            {
                Id = new Guid("17bc2ed1-96a3-4a43-b26f-15944d60648b"),
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
            AppStageProperties.Add(new SmartObjectProperty()
            {
                Id = new Guid("41a91519-fe65-4285-8b92-8ae400fdaeb5"),
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



            SmartObjectDefinition AppStage = new SmartObjectDefinition()
            {
                Id = new Guid("6d8facc6-40da-4a74-b8cc-f9bec1b9cc25"),
                SystemName = "K2App.Core.SMO.AppStage",
                DisplayName = "K2 App Core App Stage",
                ServiceInstanceId = new Guid(ServiceInstanceTypes.SmartBox),
                Properties = AppStageProperties
            };

            #endregion App Stage


            return AppStage;

        }

    }
