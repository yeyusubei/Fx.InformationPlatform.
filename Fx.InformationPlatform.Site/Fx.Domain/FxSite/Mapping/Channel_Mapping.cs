//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Fx.Domain.FxSite.Mapping
{
    #pragma warning disable 1573
    using System.Data.Entity.ModelConfiguration;
    using Fx.Entity.FxSite;
    
    internal partial class Channel_Mapping : EntityTypeConfiguration<Channel>
    {
        public Channel_Mapping()
        {                        
              this.HasKey(t => t.ChannelId);        
              this.ToTable("Channel","Site");
              this.Property(t => t.ChannelId).HasColumnName("ChannelId");
              this.Property(t => t.ChannelName).HasColumnName("ChannelName").HasMaxLength(20);
              this.Property(t => t.Description).HasColumnName("Description").HasMaxLength(256);
         }
    }
}