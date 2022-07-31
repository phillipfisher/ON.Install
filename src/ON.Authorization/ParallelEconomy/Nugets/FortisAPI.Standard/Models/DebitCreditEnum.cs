// <copyright file="DebitCreditEnum.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace FortisAPI.Standard.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;
    using FortisAPI.Standard;
    using FortisAPI.Standard.Utilities;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// DebitCreditEnum.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DebitCreditEnum
    {
        /// <summary>
        /// D.
        /// </summary>
        [EnumMember(Value = "D")]
        D,

        /// <summary>
        /// C.
        /// </summary>
        [EnumMember(Value = "C")]
        C
    }
}