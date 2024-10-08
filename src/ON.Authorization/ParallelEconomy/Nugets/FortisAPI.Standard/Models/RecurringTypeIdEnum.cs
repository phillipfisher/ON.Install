// <copyright file="RecurringTypeIdEnum.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace FortisAPI.Standard.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;
    using APIMatic.Core.Utilities.Converters;
    using FortisAPI.Standard;
    using FortisAPI.Standard.Utilities;
    using Newtonsoft.Json;

    /// <summary>
    /// RecurringTypeIdEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum RecurringTypeIdEnum
    {
        /// <summary>
        /// O.
        /// </summary>
        [EnumMember(Value = "o")]
        O,

        /// <summary>
        /// I.
        /// </summary>
        [EnumMember(Value = "i")]
        I
    }
}