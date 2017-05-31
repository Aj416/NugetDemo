using System;

namespace CPTIntegrationDTOs
{
    /// <summary>
    /// LkpProbabilityOfDefault DTO
    /// </summary>
    public class LkpProbabilityOfDefaultDTO
    {
        /// <summary>
        /// ProbabilityOfDefaultId Member
        /// </summary>
        public long ProbabilityOfDefaultId { get; set; }

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
        /// CreditLevel Member
        /// </summary>
        public string CreditLevel { get; set; }

        /// <summary>
        /// ProbabilityOfDefaultPct Member
        /// </summary>
        public decimal ProbabilityOfDefaultPct { get; set; }

        /// <summary>
        /// StartDate Member
        /// </summary>
        public DateTime StartDate { get; set; }

        /// <summary>
        /// EndDate Member
        /// </summary>
        public Nullable<DateTime> EndDate { get; set; }

        /// <summary>
        /// LastModified Member
        /// </summary>
        public DateTime LastModified { get; set; }

        /// <summary>
        /// Active Member
        /// </summary>
        public bool Active { get; set; }
    }
}