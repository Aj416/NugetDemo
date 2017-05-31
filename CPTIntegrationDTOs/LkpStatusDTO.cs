using System;

namespace CPTIntegrationDTOs
{
    /// <summary>
    /// LkpStatus DTO
    /// </summary>
    public class LkpStatusDTO
    {
        /// <summary>
        /// StatusId Member
        /// </summary>
        public long StatusId { get; set; }

        /// <summary>
        /// StatusCode Member
        /// </summary>
        public string StatusCode { get; set; }

        /// <summary>
        /// StatusName Member
        /// </summary>
        public string StatusName { get; set; }

        /// <summary>
        /// StatusDescription Member
        /// </summary>
        public string StatusDescription { get; set; }

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