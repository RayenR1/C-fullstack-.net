﻿using AM.ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Infrastructure.Configurations
{
    public class FlightConfiguration : IEntityTypeConfiguration<Flight>
    {
        public void Configure(EntityTypeBuilder<Flight> builder)
        {
         //builder.HasMany(f=>f.Passengers).WithMany(p => p.Flights).UsingEntity("Reservation");
         builder.HasOne(f => f.MyPlane).WithMany(p=>p.Flights).HasForeignKey(f=>f.PlaneId);
        }
    }
}
