using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CPTIntegrationDTOs
{
    /// <summary>
    /// StatusChangeLog DTO
    /// </summary>
    public class StatusChangeLogDTO
    {
        /// <summary>
        /// StatusChangeLogId Member
        /// </summary>
        [Required]
        public long StatusChangeLogId { get; set; }

        /// <summary>
        /// ScenarioId Member
        /// </summary>
        public long ScenarioId { get; set; }

        /// <summary>
        /// ChangeUserCode Member
        /// </summary>
        [Required]
        [StringLength(100)]
        public string ChangeUserCode { get; set; }

        /// <summary>
        /// ChangeRoleId Member
        /// </summary>
        public long ChangeRoleId { get; set; }

        /// <summary>
        /// StatusId Member
        /// </summary>
        public long StatusId { get; set; }
    }
}