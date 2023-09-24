using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ReadBlobAndStoreInSQL.Models.Database
{
    [Table("tbl_contract")]
    public partial class TblContract
    {
        [Key]
        [Column("contract_id")]
        [StringLength(50)]
        [Unicode(false)]
        public string ContractId { get; set; }
        [Column("contract_name")]
        [StringLength(50)]
        [Unicode(false)]
        public string ContractName { get; set; }
        [Column("counterparty")]
        [StringLength(50)]
        [Unicode(false)]
        public string Counterparty { get; set; }
        [Column("price", TypeName = "decimal(18, 2)")]
        public decimal? Price { get; set; }
    }
}
