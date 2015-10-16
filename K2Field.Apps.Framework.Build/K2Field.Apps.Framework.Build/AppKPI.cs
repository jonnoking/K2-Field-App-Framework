using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K2Field.Apps.Framework.Build
{
    public class AppKPI
    {

        public SmartObjectDefinition GetDefinition()
        {
            #region App KPI
            List<SmartObjectProperty> AppKPIProperties = new List<SmartObjectProperty>();
            AppKPIProperties.Add(new SmartObjectProperty()
            {
                Id = new Guid("868639c3-b7b0-4bd6-b3dc-101c80ce7b48"),
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
            AppKPIProperties.Add(new SmartObjectProperty()
            {
                Id = new Guid("fcd6471e-e288-4ea5-ba9e-ba32d5695745"),
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
            AppKPIProperties.Add(new SmartObjectProperty()
            {
                Id = new Guid("28a62585-80bd-45af-a61f-a2c561dbc48b"),
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



            SmartObjectDefinition AppKPI = new SmartObjectDefinition()
            {
                Id = new Guid("c501ff73-20ef-44ac-a5fe-9e35fc92df79"),
                SystemName = "K2App.Core.SMO.AppKPI",
                DisplayName = "K2 App Core App KPI",
                ServiceInstanceId = new Guid(ServiceInstanceTypes.SmartBox),
                Properties = AppKPIProperties
            };

            #endregion App KPI


            return AppKPI;

        }

    }
}
