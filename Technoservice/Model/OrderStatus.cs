//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Technoservice.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class OrderStatus
    {
        public OrderStatus()
        {
            this.Order = new HashSet<Order>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
    
        public virtual ICollection<Order> Order { get; set; }
    }
}
