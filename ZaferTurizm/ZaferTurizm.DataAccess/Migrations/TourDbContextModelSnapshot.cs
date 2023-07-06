﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ZaferTurizm.DataAccess;

#nullable disable

namespace ZaferTurizm.DataAccess.Migrations
{
    [DbContext(typeof(TourDbContext))]
    partial class TourDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ZaferTurizm.Domain.BusTrip", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2(0)");

                    b.Property<decimal>("Price")
                        .HasColumnType("money");

                    b.Property<int>("RouteId")
                        .HasColumnType("int");

                    b.Property<int>("VehicleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RouteId");

                    b.HasIndex("VehicleId");

                    b.ToTable("BusTrip", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Date = new DateTime(2023, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Price = 200m,
                            RouteId = 2,
                            VehicleId = 1
                        });
                });

            modelBuilder.Entity("ZaferTurizm.Domain.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("City", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Adana"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Adıyaman"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Afyon"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Ağrı"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Aksaray"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Amasya"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Ankara"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Antalya"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Ardahan"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Artvin"
                        },
                        new
                        {
                            Id = 11,
                            Name = "Aydın"
                        },
                        new
                        {
                            Id = 12,
                            Name = "Balıkesir"
                        },
                        new
                        {
                            Id = 13,
                            Name = "Bartın"
                        },
                        new
                        {
                            Id = 14,
                            Name = "Batman"
                        },
                        new
                        {
                            Id = 15,
                            Name = "Bayburt"
                        },
                        new
                        {
                            Id = 16,
                            Name = "Bilecik"
                        },
                        new
                        {
                            Id = 17,
                            Name = "Bingöl"
                        },
                        new
                        {
                            Id = 18,
                            Name = "Bitlis"
                        },
                        new
                        {
                            Id = 19,
                            Name = "Bolu"
                        },
                        new
                        {
                            Id = 20,
                            Name = "Burdur"
                        },
                        new
                        {
                            Id = 21,
                            Name = "Bursa"
                        },
                        new
                        {
                            Id = 22,
                            Name = "Çanakkale"
                        },
                        new
                        {
                            Id = 23,
                            Name = "Çankırı"
                        },
                        new
                        {
                            Id = 24,
                            Name = "Çorum"
                        },
                        new
                        {
                            Id = 25,
                            Name = "Denizli"
                        },
                        new
                        {
                            Id = 26,
                            Name = "Diyarbakır"
                        },
                        new
                        {
                            Id = 27,
                            Name = "Düzce"
                        },
                        new
                        {
                            Id = 28,
                            Name = "Edirne"
                        },
                        new
                        {
                            Id = 29,
                            Name = "Elazığ"
                        },
                        new
                        {
                            Id = 30,
                            Name = "Erzincan"
                        },
                        new
                        {
                            Id = 31,
                            Name = "Erzurum"
                        },
                        new
                        {
                            Id = 32,
                            Name = "Eskişehir"
                        },
                        new
                        {
                            Id = 33,
                            Name = "Gaziantep"
                        },
                        new
                        {
                            Id = 34,
                            Name = "Giresun"
                        },
                        new
                        {
                            Id = 35,
                            Name = "Gümüşhane"
                        },
                        new
                        {
                            Id = 36,
                            Name = "Hakkari"
                        },
                        new
                        {
                            Id = 37,
                            Name = "Hatay"
                        },
                        new
                        {
                            Id = 38,
                            Name = "Iğdır"
                        },
                        new
                        {
                            Id = 39,
                            Name = "Isparta"
                        },
                        new
                        {
                            Id = 40,
                            Name = "İstanbul"
                        },
                        new
                        {
                            Id = 41,
                            Name = "İzmir"
                        },
                        new
                        {
                            Id = 42,
                            Name = "Kahramanmaraş"
                        },
                        new
                        {
                            Id = 43,
                            Name = "Karabük"
                        },
                        new
                        {
                            Id = 44,
                            Name = "Karaman"
                        },
                        new
                        {
                            Id = 45,
                            Name = "Kars"
                        },
                        new
                        {
                            Id = 46,
                            Name = "Kastamonu"
                        },
                        new
                        {
                            Id = 47,
                            Name = "Kayseri"
                        },
                        new
                        {
                            Id = 48,
                            Name = "Kırıkkale"
                        },
                        new
                        {
                            Id = 49,
                            Name = "Kırklareli"
                        },
                        new
                        {
                            Id = 50,
                            Name = "Kırşehir"
                        },
                        new
                        {
                            Id = 51,
                            Name = "Kilis"
                        },
                        new
                        {
                            Id = 52,
                            Name = "Kocaeli"
                        },
                        new
                        {
                            Id = 53,
                            Name = "Konya"
                        },
                        new
                        {
                            Id = 54,
                            Name = "Kütahya"
                        },
                        new
                        {
                            Id = 55,
                            Name = "Malatya"
                        },
                        new
                        {
                            Id = 56,
                            Name = "Manisa"
                        },
                        new
                        {
                            Id = 57,
                            Name = "Mardin"
                        },
                        new
                        {
                            Id = 58,
                            Name = "Mersin"
                        },
                        new
                        {
                            Id = 59,
                            Name = "Muğla"
                        },
                        new
                        {
                            Id = 60,
                            Name = "Muş"
                        },
                        new
                        {
                            Id = 61,
                            Name = "Nevşehir"
                        },
                        new
                        {
                            Id = 62,
                            Name = "Niğde"
                        },
                        new
                        {
                            Id = 63,
                            Name = "Ordu"
                        },
                        new
                        {
                            Id = 64,
                            Name = "Osmaniye"
                        },
                        new
                        {
                            Id = 65,
                            Name = "Rize"
                        },
                        new
                        {
                            Id = 66,
                            Name = "Sakarya"
                        },
                        new
                        {
                            Id = 67,
                            Name = "Samsun"
                        },
                        new
                        {
                            Id = 68,
                            Name = "Siirt"
                        },
                        new
                        {
                            Id = 69,
                            Name = "Sinop"
                        },
                        new
                        {
                            Id = 70,
                            Name = "Sivas"
                        },
                        new
                        {
                            Id = 71,
                            Name = "Şanlıurfa"
                        },
                        new
                        {
                            Id = 72,
                            Name = "Şırnak"
                        },
                        new
                        {
                            Id = 73,
                            Name = "Tekirdağ"
                        },
                        new
                        {
                            Id = 74,
                            Name = "Tokat"
                        },
                        new
                        {
                            Id = 75,
                            Name = "Trabzon"
                        },
                        new
                        {
                            Id = 76,
                            Name = "Tunceli"
                        },
                        new
                        {
                            Id = 77,
                            Name = "Uşak"
                        },
                        new
                        {
                            Id = 78,
                            Name = "Van"
                        },
                        new
                        {
                            Id = 79,
                            Name = "Yalova"
                        },
                        new
                        {
                            Id = 80,
                            Name = "Yozgat"
                        },
                        new
                        {
                            Id = 81,
                            Name = "Zonguldak"
                        });
                });

            modelBuilder.Entity("ZaferTurizm.Domain.Passenger", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<int>("Gender")
                        .HasColumnType("int")
                        .HasColumnName("Cinsiyet");

                    b.Property<string>("IdentityNumber")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Passenger", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = 31,
                            FirstName = "Arda",
                            Gender = 2,
                            IdentityNumber = "",
                            LastName = "Korkmaz",
                            PhoneNumber = "05552313234"
                        });
                });

            modelBuilder.Entity("ZaferTurizm.Domain.Route", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ArrivalCityId")
                        .HasColumnType("int");

                    b.Property<int>("DepartureCityId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ArrivalCityId");

                    b.HasIndex("DepartureCityId");

                    b.ToTable("Route", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 2,
                            ArrivalCityId = 37,
                            DepartureCityId = 40
                        },
                        new
                        {
                            Id = 3,
                            ArrivalCityId = 46,
                            DepartureCityId = 8
                        },
                        new
                        {
                            Id = 1,
                            ArrivalCityId = 40,
                            DepartureCityId = 41
                        },
                        new
                        {
                            Id = 4,
                            ArrivalCityId = 1,
                            DepartureCityId = 7
                        });
                });

            modelBuilder.Entity("ZaferTurizm.Domain.Ticket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("BusTripId")
                        .HasColumnType("int");

                    b.Property<decimal>("PaidAmount")
                        .HasColumnType("money");

                    b.Property<int>("PassengerId")
                        .HasColumnType("int");

                    b.Property<int>("SeatNumber")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BusTripId");

                    b.HasIndex("PassengerId");

                    b.ToTable("Ticket", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BusTripId = 1,
                            PaidAmount = 200m,
                            PassengerId = 1,
                            SeatNumber = 1
                        });
                });

            modelBuilder.Entity("ZaferTurizm.Domain.Vehicle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ImagesUrl")
                        .IsRequired()
                        .HasColumnType("varchar(1000)");

                    b.Property<string>("PlateNumber")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<int>("VehicleDefinitionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("VehicleDefinitionId");

                    b.ToTable("Vehicle", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ImagesUrl = "",
                            PlateNumber = "34 ABC 34",
                            VehicleDefinitionId = 1
                        },
                        new
                        {
                            Id = 2,
                            ImagesUrl = "",
                            PlateNumber = "34 MRT 34",
                            VehicleDefinitionId = 2
                        },
                        new
                        {
                            Id = 3,
                            ImagesUrl = "",
                            PlateNumber = "34 BSR 34",
                            VehicleDefinitionId = 3
                        },
                        new
                        {
                            Id = 4,
                            ImagesUrl = "",
                            PlateNumber = "31 MST 31",
                            VehicleDefinitionId = 3
                        });
                });

            modelBuilder.Entity("ZaferTurizm.Domain.VehicleDefinition", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("HasToilet")
                        .HasColumnType("bit");

                    b.Property<bool>("HasWifi")
                        .HasColumnType("bit");

                    b.Property<int>("SeatCount")
                        .HasColumnType("int");

                    b.Property<int>("VehicleModelId")
                        .HasColumnType("int");

                    b.Property<string>("Year")
                        .IsRequired()
                        .HasColumnType("varchar(4)")
                        .HasColumnName("AracınUretimYili");

                    b.HasKey("Id");

                    b.HasIndex("VehicleModelId");

                    b.ToTable("VehicleDefinition", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            HasToilet = true,
                            HasWifi = false,
                            SeatCount = 25,
                            VehicleModelId = 20,
                            Year = "2020"
                        },
                        new
                        {
                            Id = 2,
                            HasToilet = true,
                            HasWifi = true,
                            SeatCount = 48,
                            VehicleModelId = 20,
                            Year = "2022"
                        },
                        new
                        {
                            Id = 3,
                            HasToilet = true,
                            HasWifi = true,
                            SeatCount = 52,
                            VehicleModelId = 23,
                            Year = "2023"
                        });
                });

            modelBuilder.Entity("ZaferTurizm.Domain.VehicleMake", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("VehicleMake", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Mercedes"
                        },
                        new
                        {
                            Id = 2,
                            Name = "MAN"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Neoplan"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Otokar"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Volvo"
                        });
                });

            modelBuilder.Entity("ZaferTurizm.Domain.VehicleModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<int>("VehicleMakeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("VehicleMakeId");

                    b.ToTable("VehicleModel", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 20,
                            Name = "Focus",
                            VehicleMakeId = 1
                        },
                        new
                        {
                            Id = 21,
                            Name = "Octavia",
                            VehicleMakeId = 1
                        },
                        new
                        {
                            Id = 22,
                            Name = "404",
                            VehicleMakeId = 1
                        },
                        new
                        {
                            Id = 23,
                            Name = "Arda",
                            VehicleMakeId = 1
                        },
                        new
                        {
                            Id = 24,
                            Name = "BBara",
                            VehicleMakeId = 1
                        },
                        new
                        {
                            Id = 25,
                            Name = "Merdo",
                            VehicleMakeId = 1
                        });
                });

            modelBuilder.Entity("ZaferTurizm.Domain.BusTrip", b =>
                {
                    b.HasOne("ZaferTurizm.Domain.Route", "Route")
                        .WithMany()
                        .HasForeignKey("RouteId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("ZaferTurizm.Domain.Vehicle", "Vehicle")
                        .WithMany()
                        .HasForeignKey("VehicleId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Route");

                    b.Navigation("Vehicle");
                });

            modelBuilder.Entity("ZaferTurizm.Domain.Route", b =>
                {
                    b.HasOne("ZaferTurizm.Domain.City", "ArrivalCity")
                        .WithMany()
                        .HasForeignKey("ArrivalCityId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("ZaferTurizm.Domain.City", "DepartureCity")
                        .WithMany()
                        .HasForeignKey("DepartureCityId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("ArrivalCity");

                    b.Navigation("DepartureCity");
                });

            modelBuilder.Entity("ZaferTurizm.Domain.Ticket", b =>
                {
                    b.HasOne("ZaferTurizm.Domain.BusTrip", "BusTrip")
                        .WithMany()
                        .HasForeignKey("BusTripId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("ZaferTurizm.Domain.Passenger", "Passenger")
                        .WithMany()
                        .HasForeignKey("PassengerId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("BusTrip");

                    b.Navigation("Passenger");
                });

            modelBuilder.Entity("ZaferTurizm.Domain.Vehicle", b =>
                {
                    b.HasOne("ZaferTurizm.Domain.VehicleDefinition", "VehicleDefinition")
                        .WithMany()
                        .HasForeignKey("VehicleDefinitionId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("VehicleDefinition");
                });

            modelBuilder.Entity("ZaferTurizm.Domain.VehicleDefinition", b =>
                {
                    b.HasOne("ZaferTurizm.Domain.VehicleModel", "VehicleModel")
                        .WithMany()
                        .HasForeignKey("VehicleModelId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("VehicleModel");
                });

            modelBuilder.Entity("ZaferTurizm.Domain.VehicleModel", b =>
                {
                    b.HasOne("ZaferTurizm.Domain.VehicleMake", "VehicleMake")
                        .WithMany()
                        .HasForeignKey("VehicleMakeId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("VehicleMake");
                });
#pragma warning restore 612, 618
        }
    }
}
