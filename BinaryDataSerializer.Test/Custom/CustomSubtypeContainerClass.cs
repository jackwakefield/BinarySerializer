﻿namespace BinaryDataSerialization.Test.Custom
{
    public class CustomSubtypeContainerClass
    {
        [FieldOrder(0)]
        public byte Indicator { get; set; }

        [FieldOrder(1)]
        [FieldOffset(50)]
        [FieldLength(100)]
        [Subtype(nameof(Indicator), 1, typeof(CustomSubtypeCustomClass))]
        public CustomSubtypeBaseClass Inner { get; set; }
    }
}
