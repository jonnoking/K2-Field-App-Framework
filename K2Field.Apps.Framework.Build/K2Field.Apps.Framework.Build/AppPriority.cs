using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K2Field.Apps.Framework.Build
{
    public class AppPriority
    {

        public SmartObjectDefinition GetDefinition()
        {
            #region App Priority
            List<SmartObjectProperty> AppPriorityProperties = new List<SmartObjectProperty>();
            AppPriorityProperties.Add(new SmartObjectProperty()
            {
                Id = new Guid("9ea784c1-d5af-45b4-bc45-750acc399a86"),
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
            AppPriorityProperties.Add(new SmartObjectProperty()
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
            AppPriorityProperties.Add(new SmartObjectProperty()
            {
                Id = new Guid("99cdb9e1-e140-4b86-a2f9-e5174eb4c9c6"),
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
            AppPriorityProperties.Add(new SmartObjectProperty()
            {
                Id = new Guid("58A881FF-0723-4FCC-93B5-A5A1A9638102"),
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



            SmartObjectDefinition AppPriority = new SmartObjectDefinition()
            {
                Id = new Guid("74c9793e-e9cc-44b7-8f03-465b40abe117"),
                SystemName = "K2App.Core.SMO.AppPriority",
                DisplayName = "K2 App Core App Priority",
                ServiceInstanceId = new Guid(ServiceInstanceTypes.SmartBox),
                Properties = AppPriorityProperties
            };

            #endregion App Priority


            return AppPriority;

        }

    }

}
