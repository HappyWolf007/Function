//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Function
{
    using System;
    using System.Collections.Generic;
    
    public partial class Partner_product
    {
        public int ID { get; set; }
        public Nullable<int> product_id { get; set; }
        public Nullable<int> partner_id { get; set; }
        public Nullable<int> quantity_of_products { get; set; }
        public Nullable<System.DateTime> sale_date { get; set; }
    
        public virtual Partners Partners { get; set; }
        public virtual Product Product { get; set; }
    }
}
