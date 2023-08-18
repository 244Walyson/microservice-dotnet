using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace geekshopping.productApi.model.Base
{
    public class BaseEntity
    {
        [Key]
        [Column("id")]
        public long Id  { get; set; }
    }
}
