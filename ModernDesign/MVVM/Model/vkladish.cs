//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ModernDesign.MVVM.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class vkladish
    {
        public int id_vkladish { get; set; }
        public System.DateTime date_vidachi_book { get; set; }
        public Nullable<System.DateTime> date_vozvrata_book { get; set; }
    
        public virtual examplar examplar { get; set; }
    }
}