//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsAppADO.NET
{
    using System;
    using System.Collections.Generic;
    
    public partial class NumberofLayers
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NumberofLayers()
        {
            this.Table_Numbers1 = new HashSet<Table_Numbers1>();
            this.User_data1 = new HashSet<User_data1>();
        }
    
        public int NumberofLayersId { get; set; }
        public string NumberofLayer { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Table_Numbers1> Table_Numbers1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<User_data1> User_data1 { get; set; }
    }
}