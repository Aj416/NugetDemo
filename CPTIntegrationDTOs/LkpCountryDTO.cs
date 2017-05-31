using System;

namespace CPTIntegrationDTOs
{
    /// <summary>
    /// LkpCountry DTO
    /// </summary>
    public class LkpCountryDTO
    {
        /// <summary>
        /// CountryId Member
        /// </summary>
        public long CountryId { get; set; }

        /// <summary>
        /// CountryCode Member
        /// </summary>
        public string CountryCode { get; set; }

        /// <summary>
        /// CountryName Member
        /// </summary>
        public string CountryName { get; set; }

        /// <summary>
        /// CountryDescription Member
        /// </summary>
        public string CountryDescription { get; set; }

        /// <summary>
        /// EndDate Member
        /// </summary>
        public Nullable<DateTime> EndDate { get; set; }

        /// <summary>
        /// LastModified Member
        /// </summary>
        public DateTime LastModified { get; set; }

        /// <summary>
        /// CurrencyId Member
        /// </summary>
        public long CurrencyId { get; set; }

        /// <summary>
        /// CurrencyCode Member
        /// </summary>
        public string CurrencyCode { get; set; }

        /// <summary>
        /// CurrencyName Member
        /// </summary>
        public string CurrencyName { get; set; }

        /// <summary>
        /// Active Member
        /// </summary>
        public bool Active { get; set; }
    }
}