//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Намордник.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProductType
    {
        public ProductType()
        {
            this.Product = new HashSet<Product>();
        }
    
        public int ID { get; set; }
        public string Title { get; set; }
        public double DefectedPercent { get; set; }
    
        public virtual ICollection<Product> Product { get; set; }
    }
}
