using System;

namespace CPTIntegrationDTOs
{
    /// <summary>
    /// LkpSegment DTO
    /// </summary>
    public class LkpSegmentDTO
    {
        /// <summary>
        /// SegmentId Member
        /// </summary>
        public long SegmentId { get; set; }

        /// <summary>
        /// SegmentCode Member
        /// </summary>
        public string SegmentCode { get; set; }

        /// <summary>
        /// SegmentName Member
        /// </summary>
        public string SegmentName { get; set; }

        /// <summary>
        /// SegmentDescription Member
        /// </summary>
        public string SegmentDescription { get; set; }

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