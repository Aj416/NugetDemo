using System;

namespace CPTIntegrationDTOs
{
    /// <summary>
    /// LkpLossGivenDefault DTO
    /// </summary>
    public class LkpLossGivenDefaultDTO
    {
        /// <summary>
        /// LossGivenDefaultId Member
        /// </summary>
        public long LossGivenDefaultId { get; set; }

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
        /// LGDLevel Member
        /// </summary>
        public string LGDLevel { get; set; }

        /// <summary>
        /// LGDPct Member
        /// </summary>
        public decimal LGDPct { get; set; }

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