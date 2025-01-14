﻿using System;

namespace BinaryDataSerialization
{
    /// <summary>
    ///     Used to specify the length of fixed-length collection items such as byte arrays and fixed-length strings.
    /// </summary>
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
    public sealed class ItemLengthAttribute : FieldBindingBaseAttribute, ILengthAttribute, IConstAttribute
    {
        /// <summary>
        ///     Initializes a new instance of the ItemLength class with a constant length.
        /// </summary>
        /// <param name="length">The fixed-size length of the decorated member.</param>
        public ItemLengthAttribute(ulong length)
        {
            ConstLength = length;
        }

        /// <summary>
        ///     Initializes a new instance of the ItemLength class with a path pointing to a binding source member.
        ///     <param name="lengthPath">A path to the source member.</param>
        /// </summary>
        public ItemLengthAttribute(string lengthPath)
            : base(lengthPath)
        {
        }

        /// <summary>
        ///     Get constant value or null if not constant.
        /// </summary>
        public object GetConstValue()
        {
            return ConstLength;
        }

        /// <summary>
        ///     Used to specify a constant field length.  This will be used if no binding is specified.
        /// </summary>
        public ulong ConstLength { get; }
    }
}
