// <copyright file="Data5.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace FortisAPI.Standard.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using FortisAPI.Standard;
    using FortisAPI.Standard.Utilities;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// Data5.
    /// </summary>
    public class Data5
    {
        private Models.ActionEnum? action;
        private string locationId;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "action", true },
            { "location_id", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="Data5"/> class.
        /// </summary>
        public Data5()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Data5"/> class.
        /// </summary>
        /// <param name="clientToken">client_token.</param>
        /// <param name="action">action.</param>
        /// <param name="methods">methods.</param>
        /// <param name="amount">amount.</param>
        /// <param name="taxAmount">tax_amount.</param>
        /// <param name="locationId">location_id.</param>
        public Data5(
            string clientToken,
            Models.ActionEnum? action = Models.ActionEnum.Sale,
            List<Models.Method> methods = null,
            int? amount = null,
            int? taxAmount = null,
            string locationId = null)
        {
            this.Action = action;
            this.Methods = methods;
            this.Amount = amount;
            this.TaxAmount = taxAmount;
            if (locationId != null)
            {
                this.LocationId = locationId;
            }

            this.ClientToken = clientToken;
        }

        /// <summary>
        /// The action to be performed
        /// </summary>
        [JsonProperty("action", ItemConverterType = typeof(StringEnumConverter))]
        public Models.ActionEnum? Action
        {
            get
            {
                return this.action;
            }

            set
            {
                this.shouldSerialize["action"] = true;
                this.action = value;
            }
        }

        /// <summary>
        /// Byt default the system will try to offer all the availables payment methods from your account. But if you like, you can specify exactly what services you want to use.
        /// </summary>
        [JsonProperty("methods", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.Method> Methods { get; set; }

        /// <summary>
        /// Gets or sets Amount.
        /// </summary>
        [JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)]
        public int? Amount { get; set; }

        /// <summary>
        /// Gets or sets TaxAmount.
        /// </summary>
        [JsonProperty("tax_amount", NullValueHandling = NullValueHandling.Ignore)]
        public int? TaxAmount { get; set; }

        /// <summary>
        /// Location ID
        /// </summary>
        [JsonProperty("location_id")]
        public string LocationId
        {
            get
            {
                return this.locationId;
            }

            set
            {
                this.shouldSerialize["location_id"] = true;
                this.locationId = value;
            }
        }

        /// <summary>
        /// A JWT to be used to create the elements.
        /// > This is a one-time only use token.
        /// > Do not store for long term use, it expires after 48 hours.
        /// </summary>
        [JsonProperty("client_token")]
        public string ClientToken { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Data5 : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetAction()
        {
            this.shouldSerialize["action"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetLocationId()
        {
            this.shouldSerialize["location_id"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeAction()
        {
            return this.shouldSerialize["action"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeLocationId()
        {
            return this.shouldSerialize["location_id"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (obj == this)
            {
                return true;
            }

            return obj is Data5 other &&
                ((this.Action == null && other.Action == null) || (this.Action?.Equals(other.Action) == true)) &&
                ((this.Methods == null && other.Methods == null) || (this.Methods?.Equals(other.Methods) == true)) &&
                ((this.Amount == null && other.Amount == null) || (this.Amount?.Equals(other.Amount) == true)) &&
                ((this.TaxAmount == null && other.TaxAmount == null) || (this.TaxAmount?.Equals(other.TaxAmount) == true)) &&
                ((this.LocationId == null && other.LocationId == null) || (this.LocationId?.Equals(other.LocationId) == true)) &&
                ((this.ClientToken == null && other.ClientToken == null) || (this.ClientToken?.Equals(other.ClientToken) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Action = {(this.Action == null ? "null" : this.Action.ToString())}");
            toStringOutput.Add($"this.Methods = {(this.Methods == null ? "null" : $"[{string.Join(", ", this.Methods)} ]")}");
            toStringOutput.Add($"this.Amount = {(this.Amount == null ? "null" : this.Amount.ToString())}");
            toStringOutput.Add($"this.TaxAmount = {(this.TaxAmount == null ? "null" : this.TaxAmount.ToString())}");
            toStringOutput.Add($"this.LocationId = {(this.LocationId == null ? "null" : this.LocationId == string.Empty ? "" : this.LocationId)}");
            toStringOutput.Add($"this.ClientToken = {(this.ClientToken == null ? "null" : this.ClientToken == string.Empty ? "" : this.ClientToken)}");
        }
    }
}