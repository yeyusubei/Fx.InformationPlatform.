//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Fx.Domain.FxGoods.Mapping
{
    #pragma warning disable 1573
    using System.Data.Entity.ModelConfiguration;
    using Fx.Entity.FxGoods;
    
    internal partial class GoodsBuyLogs_Mapping : EntityTypeConfiguration<GoodsBuyLog>
    {
        public GoodsBuyLogs_Mapping()
        {                        
              this.HasKey(t => t.GoodsBuyLogId);        
              this.ToTable("GoodsBuyLog","Goods");
              this.Property(t => t.GoodsBuyLogId).HasColumnName("GoodsBuyLogId");
              this.Property(t => t.OperteName).HasColumnName("OperteName").HasMaxLength(32);
              this.Property(t => t.Source).HasColumnName("Source").HasMaxLength(32);
              this.Property(t => t.OperteTime).HasColumnName("OperteTime");
         }
    }
}
