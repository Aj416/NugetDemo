using System;

namespace CPTIntegrationDTOs
{
    /// <summary>
    /// LkpEquipProductType DTO
    /// </summary>
    public class LkpEquipProductTypeDTO
    {
        /// <summary>
        /// EquipProductTypeId Member
        /// </summary>
        public long EquipProductTypeId { get; set; }

        /// <summary>
        /// EquipProductTypeCode Member
        /// </summary>
        public string EquipProductTypeCode { get; set; }

        /// <summary>
        /// EquipProductTypeName Member
        /// </summary>
        public string EquipProductTypeName { get; set; }

        /// <summary>
        /// EquipProductTypeDescription Member
        /// </summary>
        public string EquipProductTypeDescription { get; set; }

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