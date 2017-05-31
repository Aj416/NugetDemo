using System;

namespace CPTIntegrationDTOs
{
    /// <summary>
    /// LkpCustomer DTO
    /// </summary>
    public class LkpCustomerDTO
    {
        /// <summary>
        /// Customer Id Member
        /// </summary>
        public long CustomerId { get; set; }

        /// <summary>
        /// CCAN Member
        /// </summary>
        public string CCAN { get; set; }

        /// <summary>
        /// CustomerName Member
        /// </summary>
        public string CustomerName { get; set; }

        /// <summary>
        /// LegalName Member
        /// </summary>
        public string LegalName { get; set; }

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
        /// CreditLevel Member
        /// </summary>
        public string CreditLevel { get; set; }

        /// <summary>
        /// LGDLevel Member
        /// </summary>
        public string LGDLevel { get; set; }

        /// <summary>
        /// CreditLimit Member
        /// </summary>
        public Nullable<decimal> CreditLimit { get; set; }

        /// <summary>
        /// CreditNotes Member
        /// </summary>
        public string CreditNotes { get; set; }

        /// <summary>
        /// AnnualSpend Member
        /// </summary>
        public decimal AnnualSpend { get; set; }

        /// <summary>
        /// IBR Member
        /// </summary>
        public Nullable<decimal> IBR { get; set; }

        /// <summary>
        /// CustomerRunRateDLRS Member
        /// </summary>
        public Nullable<decimal> CustomerRunRateDLRS { get; set; }

        /// <summary>
        /// SalesAEFRSName Member
        /// </summary>
        public string SalesAEFRSName { get; set; }

        /// <summary>
        /// SalesAEFSRPhone Member
        /// </summary>
        public string SalesAEFSRPhone { get; set; }

        /// <summary>
        /// SalesAEFSREmail Member
        /// </summary>
        public string SalesAEFSREmail { get; set; }

        /// <summary>
        /// Indexed Member
        /// </summary>
        public bool Indexed { get; set; }

        /// <summary>
        /// EOLConcessions Member
        /// </summary>
        public bool EOLConcessions { get; set; }

        /// <summary>
        /// MLA Member
        /// </summary>
        public bool MLA { get; set; }

        /// <summary>
        /// SalesRestricted Member
        /// </summary>
        public bool SalesRestricted { get; set; }

        /// <summary>
        /// EndDate Member
        /// </summary>
        public Nullable<DateTime> EndDate { get; set; }

        /// <summary>
        /// Notes Member
        /// </summary>
        public string Notes { get; set; }

        /// <summary>
        /// CreateDate Member
        /// </summary>
        public DateTime CreateDate { get; set; }

        /// <summary>
        /// CreatedBy Member
        /// </summary>
        public string CreatedBy { get; set; }

        /// <summary>
        /// CreatedByRoleId Member
        /// </summary>
        public long CreatedByRoleId { get; set; }

        /// <summary>
        /// ChangeDate Member
        /// </summary>
        public DateTime ChangeDate { get; set; }

        /// <summary>
        /// ChangedBy Member
        /// </summary>
        public string ChangedBy { get; set; }

        /// <summary>
        /// ChangedByRoleId Member
        /// </summary>
        public long ChangedByRoleId { get; set; }
    }
}