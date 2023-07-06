using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZaferTurizm.Domain;

namespace ZaferTurizm.DataAccess.Configurations
{
    public class VehicleModelConfiguration : IEntityTypeConfiguration<VehicleModel>
    {
        public void Configure(EntityTypeBuilder<VehicleModel> builder)
        {
            builder.ToTable("VehicleModel");
            builder.HasKey(x => x.Id);
            builder.Property(x=>x.Name).IsRequired().HasColumnType("varchar(50)");
            builder.HasOne(vmo => vmo.VehicleMake)
                   .WithMany() 
                   .HasForeignKey(vmo => vmo.VehicleMakeId)
                   .OnDelete(DeleteBehavior.NoAction);
            


                
        }
    }
}
