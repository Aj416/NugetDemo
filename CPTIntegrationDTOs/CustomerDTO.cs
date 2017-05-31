using System;
using System.ComponentModel.DataAnnotations;

namespace CPTIntegrationDTOs
{
    /// <summary>
    /// Customer DTO
    /// </summary>
    public class CustomerDTO
    {
        /// <summary>
        /// CustomerId Member
        /// </summary>
        [Required]
        public long CustomerId { get; set; }

        /// <summary>
        /// CreatedBy Member
        /// </summary>
        [Required]
        [MaxLength(100)]
        public string CreatedBy { get; set; }

        /// <summary>
        /// CreatedByRoleId Member
        /// </summary>
        [Required]
        public long CreatedByRoleId { get; set; }

        /// <summary>
        /// ChangedBy Member
        /// </summary>
        [Required]
        [MaxLength(100)]
        public string ChangedBy { get; set; }

        /// <summary>
        /// ChangedByRoleId Member
        /// </summary>
        [Required]
        public long ChangedByRoleId { get; set; }

        /// <summary>
        /// CustomerName Member
        /// </summary>
        [Required]
        [MaxLength(250)]
        public string CustomerName { get; set; }

        /// <summary>
        /// LegalName Member
        /// </summary>
        [MaxLength(250)]
        public string LegalName { get; set; }

        /// <summary>
        /// CCAN Member
        /// </summary>
        [MaxLength(50)]
        public string CCAN { get; set; }

        /// <summary>
        /// Notes Member
        /// </summary>
        [MaxLength(1000)]
        public string Notes { get; set; }

        /// <summary>
        /// SegmentId Member
        /// </summary>
        [Required]
        public long SegmentId { get; set; }

        /// <summary>
        /// CreditLimit Member
        /// </summary>
        public Nullable<decimal> CreditLimit { get; set; }

        /// <summary>
        /// CreditNotes Member
        /// </summary>
        [MaxLength(1000)]
        public string CreditNotes { get; set; }

        /// <summary>
        /// AnnualSpend Member
        /// </summary>
        [Required]
        public decimal AnnualSpend { get; set; }

        /// <summary>
        /// IBR Member
        /// </summary>
        public Nullable<decimal> IBR { get; set; }

        /// <summary>
        /// CustomerRunRateDLRS Member
        /// </summary>
        public Nullable<decimal>  CustomerRunRateDLRS { get; set; }

        /// <summary>
        /// SalesAEFRSName Member
        /// </summary>
        [MaxLength(100)]
        public string SalesAEFRSName{ get; set; }

        /// <summary>
        /// SalesAEFSRPhone Member
        /// </summary>
        [MaxLength(50)]
        public string SalesAEFSRPhone{ get; set; }

        /// <summary>
        /// SalesAEFSREmail Member
        /// </summary>
        [MaxLength(100)]
        public string SalesAEFSREmail { get; set; }

        /// <summary>
        /// Indexed Member
        /// </summary>
        [Required]
        public bool Indexed { get; set; }

        /// <summary>
        /// IndexDate Member
        /// </summary>
        public Nullable<DateTime> IndexDate { get; set; }

        /// <summary>
        /// EOLConcessions Member
        /// </summary>
        [Required]
        public bool EOLConcessions { get; set; }

        /// <summary>
        /// MLA Member
        /// </summary>
        [Required]
        public bool MLA { get; set; }

        /// <summary>
        /// CountryId Member
        /// </summary>
        [Required]
        public long CountryId { get; set; }

        /// <summary>
        /// LGDLevel Member
        /// </summary>
        [Required]
        [MaxLength(50)]
        public string LGDLevel { get; set; }

        /// <summary>
        /// CreditLevel Member
        /// </summary>
        [Required]
        [MaxLength(50)]
        public string CreditLevel { get; set; }

        /// <summary>
        /// SalesRestricted Member
        /// </summary>
        [Required]
        public bool SalesRestricted { get; set; }
    }
}