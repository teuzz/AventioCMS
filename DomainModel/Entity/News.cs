//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DomainModel.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class News
    {
        public long Id { get; set; }
        public long Title { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public long TextId { get; set; }
        public long ShortDescriptionId { get; set; }
        public Nullable<long> ProductId { get; set; }
        public Nullable<long> ImageId { get; set; }
    
        public virtual Image Image { get; set; }
        public virtual Product Products { get; set; }
        public virtual Text TitleText { get; set; }
        public virtual Text ShortDescriptionText { get; set; }
        public virtual Text DescriptionText { get; set; }
    }
}
