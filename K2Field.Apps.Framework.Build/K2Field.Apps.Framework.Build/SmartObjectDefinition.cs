using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K2Field.Apps.Framework.Build
{
    public class SmartObjectDefinition
    {
        public Guid Id { get; set; }
        public string SystemName { get; set; }
        public string DisplayName { get; set; }

        public List<SmartObjectProperty> Properties { get; set; }

        //methods?

        public Guid ServiceInstanceId { get; set; }
    }

    public class SmartObjectProperty
    {
        public Guid Id { get; set; }
        public string SystemName { get; set; }
        public string DisplayName { get; set; }
        public string Description { get; set; }
        public string DataType { get; set; }
        public int? Size { get; set; }
        public bool IsKey { get; set; }
        public bool IsRequired { get; set; }
        public bool IsUnique { get; set; }
        public bool IsSmartBox { get; set; }
    }

    public enum SmODataTypes
    {
        Text,
        
    }
}
