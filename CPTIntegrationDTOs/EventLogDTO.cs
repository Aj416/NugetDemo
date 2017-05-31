using System;
using System.ComponentModel.DataAnnotations;

namespace CPTIntegrationDTOs
{
    /// <summary>
    /// EventLog DTO
    /// </summary>
    public class EventLogDTO
    {
        /// <summary>
        /// EventLogId Member
        /// </summary>
        [Required]
        public long EventLogId { get; set; }

        /// <summary>
        /// EventCode Member
        /// </summary>
        [Required]
        [StringLength(50)]
        public string EventCode { get; set; }

        /// <summary>
        /// UserCode Member
        /// </summary>
        [Required]
        [StringLength(100)]
        public string UserCode { get; set; }

        /// <summary>
        /// Computer Member
        /// </summary>
        [Required]
        [StringLength(100)]
        public string Computer { get; set; }

        /// <summary>
        /// RoleId Member
        /// </summary>
        public Nullable<long> RoleId { get; set; }

        /// <summary>
        /// Description Member
        /// </summary>
        [StringLength(2000)]
        public string Description { get; set; }
    }
}