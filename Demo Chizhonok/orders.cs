//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Demo_Chizhonok
{
    using System;
    using System.Collections.Generic;
    
    public partial class orders
    {
        public int order_ID { get; set; }
        public System.DateTime date { get; set; }
        public string equpment_to_repair { get; set; }
        public string problem { get; set; }
        public string client { get; set; }
        public string status { get; set; }
        public Nullable<int> worker_id { get; set; }
        public Nullable<int> sparepart_id { get; set; }
    
        public virtual storage storage { get; set; }
        public virtual workers workers { get; set; }
    }
}
