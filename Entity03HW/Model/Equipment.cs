using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity03HW.Model
{
    [Table("Equipment")]
    public partial class Equipment
    {
         [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Equipment()
        {
            
        }

        [Key]
        public int intEquipmentID { get; set; }

        [StringLength(50)]
        public string intGarageRoom { get; set; }

        public int intManufacturerID { get; set; }
        public int intModelID { get; set; }

        [StringLength(4)]
        public string strManufYear { get; set; }

        public int intSNPrefixID { get; set; }
        public virtual Manufacturer Manufacturer { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<TableEquipmentHistory> TableEquipmentHistories { get; set; }

     //   [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual Model Model { get; set; }

    }
    }
