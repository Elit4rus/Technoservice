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
    
    public partial class Feedback
    {
        public Feedback()
        {
            this.Order = new HashSet<Order>();
        }
    
        public int Id { get; set; }
        public string Comment { get; set; }
        public int Rate { get; set; }
    
        public virtual ICollection<Order> Order { get; set; }
    }
}
