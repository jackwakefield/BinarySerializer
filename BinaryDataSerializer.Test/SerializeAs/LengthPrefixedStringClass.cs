﻿namespace BinaryDataSerialization.Test.SerializeAs
{
    public class LengthPrefixedStringClass
    {
        [SerializeAs(SerializedType.LengthPrefixedString)]
        public string Value { get; set; }
    }
}
