//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Demo_exam
{
    using System;
    using System.Collections.Generic;
    
    public partial class Goods
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Goods()
        {
            this.OrderGoods = new HashSet<OrderGoods>();
        }
    
        public int Id { get; set; }
        public string Category { get; set; }
        public int Discount { get; set; }
        public string Discription { get; set; }
        public Nullable<bool> GoodsImage { get; set; }
        public string Manufacture { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderGoods> OrderGoods { get; set; }
    }
}