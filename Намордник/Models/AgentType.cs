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
    
    public partial class AgentType
    {
        public AgentType()
        {
            this.Agent = new HashSet<Agent>();
        }
    
        public int ID { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }
    
        public virtual ICollection<Agent> Agent { get; set; }
    }
}
