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

    internal partial class GoodsBuyInfo_Mapping : EntityTypeConfiguration<GoodsBuyInfo>
    {
        public GoodsBuyInfo_Mapping()
        {
            this.HasKey(t => t.GoodsBuyInfoId);
            this.ToTable("GoodsBuyInfo", "Goods");
            this.Property(t => t.GoodsBuyInfoId).HasColumnName("GoodsBuyInfoId");
            this.Property(t => t.GoodsconditonId).HasColumnName("GoodsconditonId");
            this.Property(t => t.GoodsConditionMsg).HasColumnName("GoodsConditionMsg");
            this.Property(t => t.PublishTitle).HasColumnName("PublishTitle");
            this.Property(t => t.CatagroyId).HasColumnName("CatagroyId");
            this.Property(t => t.Price).HasColumnName("Price");
            this.Property(t => t.IsChange).HasColumnName("IsChange");
            this.Property(t => t.ChangeMsg).HasColumnName("ChangeMsg");
            this.Property(t => t.AreaId).HasColumnName("AreaId");
            this.Property(t => t.CityId).HasColumnName("CityId");
            this.Property(t => t.PublishUserEmail).HasColumnName("PublishUserEmail");
            this.Property(t => t.Mark).HasColumnName("Mark");
            this.Property(t => t.Controller).HasColumnName("Controller");
            this.Property(t => t.Action).HasColumnName("Action");
            this.Property(t => t.UserAccount).HasColumnName("UserAccount");
            this.Property(t => t.CreatedTime).HasColumnName("CreatedTime");
            this.Property(t => t.IsDelete).HasColumnName("IsDelete");
            this.Property(t => t.IsPublish).HasColumnName("IsPublish");
        }
    }
}