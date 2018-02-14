using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity03HW.Model
{
    
        [Table("Model")]
        public partial class Model
        {
            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
            public Model()
            {
               // TableEquipmentHistories = new HashSet<TableEquipmentHistory>();
            }

            [Key]
            public int intModelID { get; set; }

            [StringLength(50)]
            public string strName { get; set; }

            public int intManufacturerID { get; set; }
        
            public virtual ICollection<Equipment> Equipments { get; set; }

            //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
            //public virtual ICollection<TableEquipmentHistory> TableEquipmentHistories { get; set; }
        }
}
