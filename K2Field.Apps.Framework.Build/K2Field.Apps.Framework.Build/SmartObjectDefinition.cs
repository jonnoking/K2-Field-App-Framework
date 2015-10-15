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
        public string Description { get; set; }

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
        public SmODataType DataType { get; set; }
        public ExtendPropertyType ExtendType { get; set; }
        public int? MaxSize { get; set; }
        public bool IsKey { get; set; }
        public bool IsRequired { get; set; }
        public bool IsUnique { get; set; }
        public bool IsSmartBox { get; set; }
    }

    public enum SmODataType
    {
        Text = 0,
        Memo = 1,
        Number = 2,
        Decimal = 3,
        Autonumber = 4,
        YesNo = 5,
        DateTime = 6,
        Image = 7,
        File = 8,
        HyperLink = 9,
        MultiValue = 10,
        XML = 11,
        Guid = 12,
        AutoGuid = 13,
        Date = 14,
        Time = 15,
    }

    public enum ExtendPropertyType
    {
        Defined = 0,
        UniqueIdAuto = 1,
        UniqueAuto = 2,
        UniqueID = 3,
        Default = 4,
    }

}
