// <copyright file="List12.cs" company="APIMatic">
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
    /// List12.
    /// </summary>
    public class List12
    {
        private string accountNumber;
        private string address;
        private string brandingDomainUrl;
        private string cellPhone;
        private string city;
        private string companyName;
        private string contactId;
        private string dateOfBirth;
        private string domainId;
        private string homePhone;
        private string firstName;
        private string locale;
        private string officePhone;
        private string officeExtPhone;
        private string requiresNewPassword;
        private string state;
        private string termsConditionId;
        private string userApiKey;
        private string userHashKey;
        private string password;
        private string zip;
        private string locationId;
        private string contactApiId;
        private string primaryLocationApiId;
        private int? termsAcceptedTs;
        private string termsAgreeIp;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "account_number", false },
            { "address", false },
            { "branding_domain_url", false },
            { "cell_phone", false },
            { "city", false },
            { "company_name", false },
            { "contact_id", false },
            { "date_of_birth", false },
            { "domain_id", false },
            { "home_phone", false },
            { "first_name", false },
            { "locale", false },
            { "office_phone", false },
            { "office_ext_phone", false },
            { "requires_new_password", false },
            { "state", false },
            { "terms_condition_id", false },
            { "user_api_key", false },
            { "user_hash_key", false },
            { "password", false },
            { "zip", false },
            { "location_id", false },
            { "contact_api_id", false },
            { "primary_location_api_id", false },
            { "terms_accepted_ts", false },
            { "terms_agree_ip", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="List12"/> class.
        /// </summary>
        public List12()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="List12"/> class.
        /// </summary>
        /// <param name="email">email.</param>
        /// <param name="lastName">last_name.</param>
        /// <param name="primaryLocationId">primary_location_id.</param>
        /// <param name="tz">tz.</param>
        /// <param name="username">username.</param>
        /// <param name="userTypeCode">user_type_code.</param>
        /// <param name="id">id.</param>
        /// <param name="status">status.</param>
        /// <param name="loginAttempts">login_attempts.</param>
        /// <param name="lastLoginTs">last_login_ts.</param>
        /// <param name="createdTs">created_ts.</param>
        /// <param name="modifiedTs">modified_ts.</param>
        /// <param name="createdUserId">created_user_id.</param>
        /// <param name="currentDateTime">current_date_time.</param>
        /// <param name="accountNumber">account_number.</param>
        /// <param name="address">address.</param>
        /// <param name="brandingDomainUrl">branding_domain_url.</param>
        /// <param name="cellPhone">cell_phone.</param>
        /// <param name="city">city.</param>
        /// <param name="companyName">company_name.</param>
        /// <param name="contactId">contact_id.</param>
        /// <param name="dateOfBirth">date_of_birth.</param>
        /// <param name="domainId">domain_id.</param>
        /// <param name="emailTrxReceipt">email_trx_receipt.</param>
        /// <param name="homePhone">home_phone.</param>
        /// <param name="firstName">first_name.</param>
        /// <param name="locale">locale.</param>
        /// <param name="officePhone">office_phone.</param>
        /// <param name="officeExtPhone">office_ext_phone.</param>
        /// <param name="requiresNewPassword">requires_new_password.</param>
        /// <param name="state">state.</param>
        /// <param name="termsConditionId">terms_condition_id.</param>
        /// <param name="uiPrefs">ui_prefs.</param>
        /// <param name="userApiKey">user_api_key.</param>
        /// <param name="userHashKey">user_hash_key.</param>
        /// <param name="password">password.</param>
        /// <param name="zip">zip.</param>
        /// <param name="locationId">location_id.</param>
        /// <param name="contactApiId">contact_api_id.</param>
        /// <param name="primaryLocationApiId">primary_location_api_id.</param>
        /// <param name="statusId">status_id.</param>
        /// <param name="termsAcceptedTs">terms_accepted_ts.</param>
        /// <param name="termsAgreeIp">terms_agree_ip.</param>
        public List12(
            string email,
            string lastName,
            string primaryLocationId,
            string tz,
            string username,
            Models.UserTypeCodeEnum userTypeCode,
            string id,
            bool status,
            double loginAttempts,
            int lastLoginTs,
            int createdTs,
            int modifiedTs,
            string createdUserId,
            string currentDateTime,
            string accountNumber = null,
            string address = null,
            string brandingDomainUrl = null,
            string cellPhone = null,
            string city = null,
            string companyName = null,
            string contactId = null,
            string dateOfBirth = null,
            string domainId = null,
            bool? emailTrxReceipt = null,
            string homePhone = null,
            string firstName = null,
            string locale = null,
            string officePhone = null,
            string officeExtPhone = null,
            string requiresNewPassword = null,
            string state = null,
            string termsConditionId = null,
            Models.UiPrefs uiPrefs = null,
            string userApiKey = null,
            string userHashKey = null,
            string password = null,
            string zip = null,
            string locationId = null,
            string contactApiId = null,
            string primaryLocationApiId = null,
            bool? statusId = null,
            int? termsAcceptedTs = null,
            string termsAgreeIp = null)
        {
            if (accountNumber != null)
            {
                this.AccountNumber = accountNumber;
            }

            if (address != null)
            {
                this.Address = address;
            }

            if (brandingDomainUrl != null)
            {
                this.BrandingDomainUrl = brandingDomainUrl;
            }

            if (cellPhone != null)
            {
                this.CellPhone = cellPhone;
            }

            if (city != null)
            {
                this.City = city;
            }

            if (companyName != null)
            {
                this.CompanyName = companyName;
            }

            if (contactId != null)
            {
                this.ContactId = contactId;
            }

            if (dateOfBirth != null)
            {
                this.DateOfBirth = dateOfBirth;
            }

            if (domainId != null)
            {
                this.DomainId = domainId;
            }

            this.Email = email;
            this.EmailTrxReceipt = emailTrxReceipt;
            if (homePhone != null)
            {
                this.HomePhone = homePhone;
            }

            if (firstName != null)
            {
                this.FirstName = firstName;
            }

            this.LastName = lastName;
            if (locale != null)
            {
                this.Locale = locale;
            }

            if (officePhone != null)
            {
                this.OfficePhone = officePhone;
            }

            if (officeExtPhone != null)
            {
                this.OfficeExtPhone = officeExtPhone;
            }

            this.PrimaryLocationId = primaryLocationId;
            if (requiresNewPassword != null)
            {
                this.RequiresNewPassword = requiresNewPassword;
            }

            if (state != null)
            {
                this.State = state;
            }

            if (termsConditionId != null)
            {
                this.TermsConditionId = termsConditionId;
            }

            this.Tz = tz;
            this.UiPrefs = uiPrefs;
            this.Username = username;
            if (userApiKey != null)
            {
                this.UserApiKey = userApiKey;
            }

            if (userHashKey != null)
            {
                this.UserHashKey = userHashKey;
            }

            this.UserTypeCode = userTypeCode;
            if (password != null)
            {
                this.Password = password;
            }

            if (zip != null)
            {
                this.Zip = zip;
            }

            if (locationId != null)
            {
                this.LocationId = locationId;
            }

            if (contactApiId != null)
            {
                this.ContactApiId = contactApiId;
            }

            if (primaryLocationApiId != null)
            {
                this.PrimaryLocationApiId = primaryLocationApiId;
            }

            this.StatusId = statusId;
            this.Id = id;
            this.Status = status;
            this.LoginAttempts = loginAttempts;
            this.LastLoginTs = lastLoginTs;
            this.CreatedTs = createdTs;
            this.ModifiedTs = modifiedTs;
            this.CreatedUserId = createdUserId;
            if (termsAcceptedTs != null)
            {
                this.TermsAcceptedTs = termsAcceptedTs;
            }

            if (termsAgreeIp != null)
            {
                this.TermsAgreeIp = termsAgreeIp;
            }

            this.CurrentDateTime = currentDateTime;
        }

        /// <summary>
        /// Account Number
        /// </summary>
        [JsonProperty("account_number")]
        public string AccountNumber
        {
            get
            {
                return this.accountNumber;
            }

            set
            {
                this.shouldSerialize["account_number"] = true;
                this.accountNumber = value;
            }
        }

        /// <summary>
        /// Address
        /// </summary>
        [JsonProperty("address")]
        public string Address
        {
            get
            {
                return this.address;
            }

            set
            {
                this.shouldSerialize["address"] = true;
                this.address = value;
            }
        }

        /// <summary>
        /// Branding Domain Url
        /// </summary>
        [JsonProperty("branding_domain_url")]
        public string BrandingDomainUrl
        {
            get
            {
                return this.brandingDomainUrl;
            }

            set
            {
                this.shouldSerialize["branding_domain_url"] = true;
                this.brandingDomainUrl = value;
            }
        }

        /// <summary>
        /// Cell Phone
        /// </summary>
        [JsonProperty("cell_phone")]
        public string CellPhone
        {
            get
            {
                return this.cellPhone;
            }

            set
            {
                this.shouldSerialize["cell_phone"] = true;
                this.cellPhone = value;
            }
        }

        /// <summary>
        /// City
        /// </summary>
        [JsonProperty("city")]
        public string City
        {
            get
            {
                return this.city;
            }

            set
            {
                this.shouldSerialize["city"] = true;
                this.city = value;
            }
        }

        /// <summary>
        /// Company Name
        /// </summary>
        [JsonProperty("company_name")]
        public string CompanyName
        {
            get
            {
                return this.companyName;
            }

            set
            {
                this.shouldSerialize["company_name"] = true;
                this.companyName = value;
            }
        }

        /// <summary>
        /// Contact
        /// </summary>
        [JsonProperty("contact_id")]
        public string ContactId
        {
            get
            {
                return this.contactId;
            }

            set
            {
                this.shouldSerialize["contact_id"] = true;
                this.contactId = value;
            }
        }

        /// <summary>
        /// Date Of Birth
        /// </summary>
        [JsonProperty("date_of_birth")]
        public string DateOfBirth
        {
            get
            {
                return this.dateOfBirth;
            }

            set
            {
                this.shouldSerialize["date_of_birth"] = true;
                this.dateOfBirth = value;
            }
        }

        /// <summary>
        /// Domain
        /// </summary>
        [JsonProperty("domain_id")]
        public string DomainId
        {
            get
            {
                return this.domainId;
            }

            set
            {
                this.shouldSerialize["domain_id"] = true;
                this.domainId = value;
            }
        }

        /// <summary>
        /// Email
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// Email Trx Receipt
        /// </summary>
        [JsonProperty("email_trx_receipt", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EmailTrxReceipt { get; set; }

        /// <summary>
        /// Home Phone
        /// </summary>
        [JsonProperty("home_phone")]
        public string HomePhone
        {
            get
            {
                return this.homePhone;
            }

            set
            {
                this.shouldSerialize["home_phone"] = true;
                this.homePhone = value;
            }
        }

        /// <summary>
        /// First Name
        /// </summary>
        [JsonProperty("first_name")]
        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            set
            {
                this.shouldSerialize["first_name"] = true;
                this.firstName = value;
            }
        }

        /// <summary>
        /// Last Name
        /// </summary>
        [JsonProperty("last_name")]
        public string LastName { get; set; }

        /// <summary>
        /// Locale
        /// </summary>
        [JsonProperty("locale")]
        public string Locale
        {
            get
            {
                return this.locale;
            }

            set
            {
                this.shouldSerialize["locale"] = true;
                this.locale = value;
            }
        }

        /// <summary>
        /// Office Phone
        /// </summary>
        [JsonProperty("office_phone")]
        public string OfficePhone
        {
            get
            {
                return this.officePhone;
            }

            set
            {
                this.shouldSerialize["office_phone"] = true;
                this.officePhone = value;
            }
        }

        /// <summary>
        /// Office Ext Phone
        /// </summary>
        [JsonProperty("office_ext_phone")]
        public string OfficeExtPhone
        {
            get
            {
                return this.officeExtPhone;
            }

            set
            {
                this.shouldSerialize["office_ext_phone"] = true;
                this.officeExtPhone = value;
            }
        }

        /// <summary>
        /// Primary Location ID
        /// </summary>
        [JsonProperty("primary_location_id")]
        public string PrimaryLocationId { get; set; }

        /// <summary>
        /// Requires New Password
        /// </summary>
        [JsonProperty("requires_new_password")]
        public string RequiresNewPassword
        {
            get
            {
                return this.requiresNewPassword;
            }

            set
            {
                this.shouldSerialize["requires_new_password"] = true;
                this.requiresNewPassword = value;
            }
        }

        /// <summary>
        /// State
        /// </summary>
        [JsonProperty("state")]
        public string State
        {
            get
            {
                return this.state;
            }

            set
            {
                this.shouldSerialize["state"] = true;
                this.state = value;
            }
        }

        /// <summary>
        /// Terms Condition
        /// </summary>
        [JsonProperty("terms_condition_id")]
        public string TermsConditionId
        {
            get
            {
                return this.termsConditionId;
            }

            set
            {
                this.shouldSerialize["terms_condition_id"] = true;
                this.termsConditionId = value;
            }
        }

        /// <summary>
        /// Time zone
        /// </summary>
        [JsonProperty("tz")]
        public string Tz { get; set; }

        /// <summary>
        /// Ui Prefs
        /// </summary>
        [JsonProperty("ui_prefs", NullValueHandling = NullValueHandling.Ignore)]
        public Models.UiPrefs UiPrefs { get; set; }

        /// <summary>
        /// Username
        /// </summary>
        [JsonProperty("username")]
        public string Username { get; set; }

        /// <summary>
        /// User Api Key
        /// </summary>
        [JsonProperty("user_api_key")]
        public string UserApiKey
        {
            get
            {
                return this.userApiKey;
            }

            set
            {
                this.shouldSerialize["user_api_key"] = true;
                this.userApiKey = value;
            }
        }

        /// <summary>
        /// User Hash Key
        /// </summary>
        [JsonProperty("user_hash_key")]
        public string UserHashKey
        {
            get
            {
                return this.userHashKey;
            }

            set
            {
                this.shouldSerialize["user_hash_key"] = true;
                this.userHashKey = value;
            }
        }

        /// <summary>
        /// User Type
        /// </summary>
        [JsonProperty("user_type_code")]
        public Models.UserTypeCodeEnum UserTypeCode { get; set; }

        /// <summary>
        /// Password
        /// </summary>
        [JsonProperty("password")]
        public string Password
        {
            get
            {
                return this.password;
            }

            set
            {
                this.shouldSerialize["password"] = true;
                this.password = value;
            }
        }

        /// <summary>
        /// Zip
        /// </summary>
        [JsonProperty("zip")]
        public string Zip
        {
            get
            {
                return this.zip;
            }

            set
            {
                this.shouldSerialize["zip"] = true;
                this.zip = value;
            }
        }

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
        /// ContactApi Id
        /// </summary>
        [JsonProperty("contact_api_id")]
        public string ContactApiId
        {
            get
            {
                return this.contactApiId;
            }

            set
            {
                this.shouldSerialize["contact_api_id"] = true;
                this.contactApiId = value;
            }
        }

        /// <summary>
        /// Primary LocationApi ID
        /// </summary>
        [JsonProperty("primary_location_api_id")]
        public string PrimaryLocationApiId
        {
            get
            {
                return this.primaryLocationApiId;
            }

            set
            {
                this.shouldSerialize["primary_location_api_id"] = true;
                this.primaryLocationApiId = value;
            }
        }

        /// <summary>
        /// Status
        /// </summary>
        [JsonProperty("status_id", NullValueHandling = NullValueHandling.Ignore)]
        public bool? StatusId { get; set; }

        /// <summary>
        /// User ID
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Status
        /// </summary>
        [JsonProperty("status")]
        public bool Status { get; set; }

        /// <summary>
        /// Login Attempts
        /// </summary>
        [JsonProperty("login_attempts")]
        public double LoginAttempts { get; set; }

        /// <summary>
        /// Last Login
        /// </summary>
        [JsonProperty("last_login_ts")]
        public int LastLoginTs { get; set; }

        /// <summary>
        /// Created Time Stamp
        /// </summary>
        [JsonProperty("created_ts")]
        public int CreatedTs { get; set; }

        /// <summary>
        /// Modified Time Stamp
        /// </summary>
        [JsonProperty("modified_ts")]
        public int ModifiedTs { get; set; }

        /// <summary>
        /// Created User
        /// </summary>
        [JsonProperty("created_user_id")]
        public string CreatedUserId { get; set; }

        /// <summary>
        /// Terms Accepted
        /// </summary>
        [JsonProperty("terms_accepted_ts")]
        public int? TermsAcceptedTs
        {
            get
            {
                return this.termsAcceptedTs;
            }

            set
            {
                this.shouldSerialize["terms_accepted_ts"] = true;
                this.termsAcceptedTs = value;
            }
        }

        /// <summary>
        /// Terms Agree Ip
        /// </summary>
        [JsonProperty("terms_agree_ip")]
        public string TermsAgreeIp
        {
            get
            {
                return this.termsAgreeIp;
            }

            set
            {
                this.shouldSerialize["terms_agree_ip"] = true;
                this.termsAgreeIp = value;
            }
        }

        /// <summary>
        /// Current Date Time
        /// </summary>
        [JsonProperty("current_date_time")]
        public string CurrentDateTime { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"List12 : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetAccountNumber()
        {
            this.shouldSerialize["account_number"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetAddress()
        {
            this.shouldSerialize["address"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetBrandingDomainUrl()
        {
            this.shouldSerialize["branding_domain_url"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCellPhone()
        {
            this.shouldSerialize["cell_phone"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCity()
        {
            this.shouldSerialize["city"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCompanyName()
        {
            this.shouldSerialize["company_name"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetContactId()
        {
            this.shouldSerialize["contact_id"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetDateOfBirth()
        {
            this.shouldSerialize["date_of_birth"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetDomainId()
        {
            this.shouldSerialize["domain_id"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetHomePhone()
        {
            this.shouldSerialize["home_phone"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetFirstName()
        {
            this.shouldSerialize["first_name"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetLocale()
        {
            this.shouldSerialize["locale"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetOfficePhone()
        {
            this.shouldSerialize["office_phone"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetOfficeExtPhone()
        {
            this.shouldSerialize["office_ext_phone"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetRequiresNewPassword()
        {
            this.shouldSerialize["requires_new_password"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetState()
        {
            this.shouldSerialize["state"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetTermsConditionId()
        {
            this.shouldSerialize["terms_condition_id"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetUserApiKey()
        {
            this.shouldSerialize["user_api_key"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetUserHashKey()
        {
            this.shouldSerialize["user_hash_key"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetPassword()
        {
            this.shouldSerialize["password"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetZip()
        {
            this.shouldSerialize["zip"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetLocationId()
        {
            this.shouldSerialize["location_id"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetContactApiId()
        {
            this.shouldSerialize["contact_api_id"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetPrimaryLocationApiId()
        {
            this.shouldSerialize["primary_location_api_id"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetTermsAcceptedTs()
        {
            this.shouldSerialize["terms_accepted_ts"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetTermsAgreeIp()
        {
            this.shouldSerialize["terms_agree_ip"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeAccountNumber()
        {
            return this.shouldSerialize["account_number"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeAddress()
        {
            return this.shouldSerialize["address"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeBrandingDomainUrl()
        {
            return this.shouldSerialize["branding_domain_url"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCellPhone()
        {
            return this.shouldSerialize["cell_phone"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCity()
        {
            return this.shouldSerialize["city"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCompanyName()
        {
            return this.shouldSerialize["company_name"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeContactId()
        {
            return this.shouldSerialize["contact_id"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDateOfBirth()
        {
            return this.shouldSerialize["date_of_birth"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDomainId()
        {
            return this.shouldSerialize["domain_id"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeHomePhone()
        {
            return this.shouldSerialize["home_phone"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeFirstName()
        {
            return this.shouldSerialize["first_name"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeLocale()
        {
            return this.shouldSerialize["locale"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeOfficePhone()
        {
            return this.shouldSerialize["office_phone"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeOfficeExtPhone()
        {
            return this.shouldSerialize["office_ext_phone"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeRequiresNewPassword()
        {
            return this.shouldSerialize["requires_new_password"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeState()
        {
            return this.shouldSerialize["state"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTermsConditionId()
        {
            return this.shouldSerialize["terms_condition_id"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeUserApiKey()
        {
            return this.shouldSerialize["user_api_key"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeUserHashKey()
        {
            return this.shouldSerialize["user_hash_key"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePassword()
        {
            return this.shouldSerialize["password"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeZip()
        {
            return this.shouldSerialize["zip"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeLocationId()
        {
            return this.shouldSerialize["location_id"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeContactApiId()
        {
            return this.shouldSerialize["contact_api_id"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePrimaryLocationApiId()
        {
            return this.shouldSerialize["primary_location_api_id"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTermsAcceptedTs()
        {
            return this.shouldSerialize["terms_accepted_ts"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTermsAgreeIp()
        {
            return this.shouldSerialize["terms_agree_ip"];
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

            return obj is List12 other &&
                ((this.AccountNumber == null && other.AccountNumber == null) || (this.AccountNumber?.Equals(other.AccountNumber) == true)) &&
                ((this.Address == null && other.Address == null) || (this.Address?.Equals(other.Address) == true)) &&
                ((this.BrandingDomainUrl == null && other.BrandingDomainUrl == null) || (this.BrandingDomainUrl?.Equals(other.BrandingDomainUrl) == true)) &&
                ((this.CellPhone == null && other.CellPhone == null) || (this.CellPhone?.Equals(other.CellPhone) == true)) &&
                ((this.City == null && other.City == null) || (this.City?.Equals(other.City) == true)) &&
                ((this.CompanyName == null && other.CompanyName == null) || (this.CompanyName?.Equals(other.CompanyName) == true)) &&
                ((this.ContactId == null && other.ContactId == null) || (this.ContactId?.Equals(other.ContactId) == true)) &&
                ((this.DateOfBirth == null && other.DateOfBirth == null) || (this.DateOfBirth?.Equals(other.DateOfBirth) == true)) &&
                ((this.DomainId == null && other.DomainId == null) || (this.DomainId?.Equals(other.DomainId) == true)) &&
                ((this.Email == null && other.Email == null) || (this.Email?.Equals(other.Email) == true)) &&
                ((this.EmailTrxReceipt == null && other.EmailTrxReceipt == null) || (this.EmailTrxReceipt?.Equals(other.EmailTrxReceipt) == true)) &&
                ((this.HomePhone == null && other.HomePhone == null) || (this.HomePhone?.Equals(other.HomePhone) == true)) &&
                ((this.FirstName == null && other.FirstName == null) || (this.FirstName?.Equals(other.FirstName) == true)) &&
                ((this.LastName == null && other.LastName == null) || (this.LastName?.Equals(other.LastName) == true)) &&
                ((this.Locale == null && other.Locale == null) || (this.Locale?.Equals(other.Locale) == true)) &&
                ((this.OfficePhone == null && other.OfficePhone == null) || (this.OfficePhone?.Equals(other.OfficePhone) == true)) &&
                ((this.OfficeExtPhone == null && other.OfficeExtPhone == null) || (this.OfficeExtPhone?.Equals(other.OfficeExtPhone) == true)) &&
                ((this.PrimaryLocationId == null && other.PrimaryLocationId == null) || (this.PrimaryLocationId?.Equals(other.PrimaryLocationId) == true)) &&
                ((this.RequiresNewPassword == null && other.RequiresNewPassword == null) || (this.RequiresNewPassword?.Equals(other.RequiresNewPassword) == true)) &&
                ((this.State == null && other.State == null) || (this.State?.Equals(other.State) == true)) &&
                ((this.TermsConditionId == null && other.TermsConditionId == null) || (this.TermsConditionId?.Equals(other.TermsConditionId) == true)) &&
                ((this.Tz == null && other.Tz == null) || (this.Tz?.Equals(other.Tz) == true)) &&
                ((this.UiPrefs == null && other.UiPrefs == null) || (this.UiPrefs?.Equals(other.UiPrefs) == true)) &&
                ((this.Username == null && other.Username == null) || (this.Username?.Equals(other.Username) == true)) &&
                ((this.UserApiKey == null && other.UserApiKey == null) || (this.UserApiKey?.Equals(other.UserApiKey) == true)) &&
                ((this.UserHashKey == null && other.UserHashKey == null) || (this.UserHashKey?.Equals(other.UserHashKey) == true)) &&
                this.UserTypeCode.Equals(other.UserTypeCode) &&
                ((this.Password == null && other.Password == null) || (this.Password?.Equals(other.Password) == true)) &&
                ((this.Zip == null && other.Zip == null) || (this.Zip?.Equals(other.Zip) == true)) &&
                ((this.LocationId == null && other.LocationId == null) || (this.LocationId?.Equals(other.LocationId) == true)) &&
                ((this.ContactApiId == null && other.ContactApiId == null) || (this.ContactApiId?.Equals(other.ContactApiId) == true)) &&
                ((this.PrimaryLocationApiId == null && other.PrimaryLocationApiId == null) || (this.PrimaryLocationApiId?.Equals(other.PrimaryLocationApiId) == true)) &&
                ((this.StatusId == null && other.StatusId == null) || (this.StatusId?.Equals(other.StatusId) == true)) &&
                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                this.Status.Equals(other.Status) &&
                this.LoginAttempts.Equals(other.LoginAttempts) &&
                this.LastLoginTs.Equals(other.LastLoginTs) &&
                this.CreatedTs.Equals(other.CreatedTs) &&
                this.ModifiedTs.Equals(other.ModifiedTs) &&
                ((this.CreatedUserId == null && other.CreatedUserId == null) || (this.CreatedUserId?.Equals(other.CreatedUserId) == true)) &&
                ((this.TermsAcceptedTs == null && other.TermsAcceptedTs == null) || (this.TermsAcceptedTs?.Equals(other.TermsAcceptedTs) == true)) &&
                ((this.TermsAgreeIp == null && other.TermsAgreeIp == null) || (this.TermsAgreeIp?.Equals(other.TermsAgreeIp) == true)) &&
                ((this.CurrentDateTime == null && other.CurrentDateTime == null) || (this.CurrentDateTime?.Equals(other.CurrentDateTime) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AccountNumber = {(this.AccountNumber == null ? "null" : this.AccountNumber == string.Empty ? "" : this.AccountNumber)}");
            toStringOutput.Add($"this.Address = {(this.Address == null ? "null" : this.Address == string.Empty ? "" : this.Address)}");
            toStringOutput.Add($"this.BrandingDomainUrl = {(this.BrandingDomainUrl == null ? "null" : this.BrandingDomainUrl == string.Empty ? "" : this.BrandingDomainUrl)}");
            toStringOutput.Add($"this.CellPhone = {(this.CellPhone == null ? "null" : this.CellPhone == string.Empty ? "" : this.CellPhone)}");
            toStringOutput.Add($"this.City = {(this.City == null ? "null" : this.City == string.Empty ? "" : this.City)}");
            toStringOutput.Add($"this.CompanyName = {(this.CompanyName == null ? "null" : this.CompanyName == string.Empty ? "" : this.CompanyName)}");
            toStringOutput.Add($"this.ContactId = {(this.ContactId == null ? "null" : this.ContactId == string.Empty ? "" : this.ContactId)}");
            toStringOutput.Add($"this.DateOfBirth = {(this.DateOfBirth == null ? "null" : this.DateOfBirth == string.Empty ? "" : this.DateOfBirth)}");
            toStringOutput.Add($"this.DomainId = {(this.DomainId == null ? "null" : this.DomainId == string.Empty ? "" : this.DomainId)}");
            toStringOutput.Add($"this.Email = {(this.Email == null ? "null" : this.Email == string.Empty ? "" : this.Email)}");
            toStringOutput.Add($"this.EmailTrxReceipt = {(this.EmailTrxReceipt == null ? "null" : this.EmailTrxReceipt.ToString())}");
            toStringOutput.Add($"this.HomePhone = {(this.HomePhone == null ? "null" : this.HomePhone == string.Empty ? "" : this.HomePhone)}");
            toStringOutput.Add($"this.FirstName = {(this.FirstName == null ? "null" : this.FirstName == string.Empty ? "" : this.FirstName)}");
            toStringOutput.Add($"this.LastName = {(this.LastName == null ? "null" : this.LastName == string.Empty ? "" : this.LastName)}");
            toStringOutput.Add($"this.Locale = {(this.Locale == null ? "null" : this.Locale == string.Empty ? "" : this.Locale)}");
            toStringOutput.Add($"this.OfficePhone = {(this.OfficePhone == null ? "null" : this.OfficePhone == string.Empty ? "" : this.OfficePhone)}");
            toStringOutput.Add($"this.OfficeExtPhone = {(this.OfficeExtPhone == null ? "null" : this.OfficeExtPhone == string.Empty ? "" : this.OfficeExtPhone)}");
            toStringOutput.Add($"this.PrimaryLocationId = {(this.PrimaryLocationId == null ? "null" : this.PrimaryLocationId == string.Empty ? "" : this.PrimaryLocationId)}");
            toStringOutput.Add($"this.RequiresNewPassword = {(this.RequiresNewPassword == null ? "null" : this.RequiresNewPassword == string.Empty ? "" : this.RequiresNewPassword)}");
            toStringOutput.Add($"this.State = {(this.State == null ? "null" : this.State == string.Empty ? "" : this.State)}");
            toStringOutput.Add($"this.TermsConditionId = {(this.TermsConditionId == null ? "null" : this.TermsConditionId == string.Empty ? "" : this.TermsConditionId)}");
            toStringOutput.Add($"this.Tz = {(this.Tz == null ? "null" : this.Tz == string.Empty ? "" : this.Tz)}");
            toStringOutput.Add($"this.UiPrefs = {(this.UiPrefs == null ? "null" : this.UiPrefs.ToString())}");
            toStringOutput.Add($"this.Username = {(this.Username == null ? "null" : this.Username == string.Empty ? "" : this.Username)}");
            toStringOutput.Add($"this.UserApiKey = {(this.UserApiKey == null ? "null" : this.UserApiKey == string.Empty ? "" : this.UserApiKey)}");
            toStringOutput.Add($"this.UserHashKey = {(this.UserHashKey == null ? "null" : this.UserHashKey == string.Empty ? "" : this.UserHashKey)}");
            toStringOutput.Add($"this.UserTypeCode = {this.UserTypeCode}");
            toStringOutput.Add($"this.Password = {(this.Password == null ? "null" : this.Password == string.Empty ? "" : this.Password)}");
            toStringOutput.Add($"this.Zip = {(this.Zip == null ? "null" : this.Zip == string.Empty ? "" : this.Zip)}");
            toStringOutput.Add($"this.LocationId = {(this.LocationId == null ? "null" : this.LocationId == string.Empty ? "" : this.LocationId)}");
            toStringOutput.Add($"this.ContactApiId = {(this.ContactApiId == null ? "null" : this.ContactApiId == string.Empty ? "" : this.ContactApiId)}");
            toStringOutput.Add($"this.PrimaryLocationApiId = {(this.PrimaryLocationApiId == null ? "null" : this.PrimaryLocationApiId == string.Empty ? "" : this.PrimaryLocationApiId)}");
            toStringOutput.Add($"this.StatusId = {(this.StatusId == null ? "null" : this.StatusId.ToString())}");
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id == string.Empty ? "" : this.Id)}");
            toStringOutput.Add($"this.Status = {this.Status}");
            toStringOutput.Add($"this.LoginAttempts = {this.LoginAttempts}");
            toStringOutput.Add($"this.LastLoginTs = {this.LastLoginTs}");
            toStringOutput.Add($"this.CreatedTs = {this.CreatedTs}");
            toStringOutput.Add($"this.ModifiedTs = {this.ModifiedTs}");
            toStringOutput.Add($"this.CreatedUserId = {(this.CreatedUserId == null ? "null" : this.CreatedUserId == string.Empty ? "" : this.CreatedUserId)}");
            toStringOutput.Add($"this.TermsAcceptedTs = {(this.TermsAcceptedTs == null ? "null" : this.TermsAcceptedTs.ToString())}");
            toStringOutput.Add($"this.TermsAgreeIp = {(this.TermsAgreeIp == null ? "null" : this.TermsAgreeIp == string.Empty ? "" : this.TermsAgreeIp)}");
            toStringOutput.Add($"this.CurrentDateTime = {(this.CurrentDateTime == null ? "null" : this.CurrentDateTime == string.Empty ? "" : this.CurrentDateTime)}");
        }
    }
}