using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TastyFoodSolution.Data.Entities;

namespace TastyFoodSolution.Data.Configurations
{
    public class ReviewConfiguration : IEntityTypeConfiguration<Review>
    {
        public void Configure(EntityTypeBuilder<Review> builder)
        {
            builder.ToTable("Reviews");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.ReviewDate);

            builder.Property(x => x.Comment).IsRequired().HasMaxLength(200);

            builder.Property(x => x.Rate);

            builder.HasOne(x => x.AppUser).WithMany(x => x.Reviews).HasForeignKey(x => x.UserId);
        }
    }
}