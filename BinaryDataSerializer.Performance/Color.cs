﻿using BinaryDataSerialization;

namespace BinaryDataSerializer.Performance
{
    public enum Color
    {
        [SerializeAsEnum("r")]
        Red,
        [SerializeAsEnum("g")]
        Green,
        [SerializeAsEnum("b")]
        Blue
    }
}
