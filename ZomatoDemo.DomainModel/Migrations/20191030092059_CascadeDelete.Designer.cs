﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ZomatoDemo.Web.Models;

namespace ZomatoDemo.DomainModel.Migrations
{
    [DbContext(typeof(ZomatoDbContext))]
    [Migration("20191030092059_CascadeDelete")]
    partial class CascadeDelete
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.3-rtm-32065")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("ZomatoDemo.DomainModel.Application_Classes.UserAC", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("DateOfBirth");

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FullName");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("ZomatoDemo.DomainModel.Models.City", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CityName");

                    b.HasKey("ID");

                    b.ToTable("City");
                });

            modelBuilder.Entity("ZomatoDemo.DomainModel.Models.Country", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CountryName");

                    b.HasKey("ID");

                    b.ToTable("Country");
                });

            modelBuilder.Entity("ZomatoDemo.DomainModel.Models.Dishes", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Costs");

                    b.Property<string>("DishesName");

                    b.Property<int?>("RestaurantID");

                    b.HasKey("ID");

                    b.HasIndex("RestaurantID");

                    b.ToTable("Dishes");
                });

            modelBuilder.Entity("ZomatoDemo.DomainModel.Models.DishesOrdered", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("DishesID");

                    b.Property<int>("ItemsCount");

                    b.Property<int?>("OrderDetailsID");

                    b.HasKey("ID");

                    b.HasIndex("DishesID");

                    b.HasIndex("OrderDetailsID");

                    b.ToTable("DishesOrdered");
                });

            modelBuilder.Entity("ZomatoDemo.DomainModel.Models.Likes", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ReviewsID");

                    b.Property<string>("UsersId");

                    b.HasKey("ID");

                    b.HasIndex("ReviewsID");

                    b.HasIndex("UsersId");

                    b.ToTable("Likes");
                });

            modelBuilder.Entity("ZomatoDemo.DomainModel.Models.Location", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CityID");

                    b.Property<int>("CountryID");

                    b.Property<string>("Locality");

                    b.Property<int?>("RestaurantID");

                    b.HasKey("ID");

                    b.HasIndex("CityID");

                    b.HasIndex("CountryID");

                    b.HasIndex("RestaurantID");

                    b.ToTable("Location");
                });

            modelBuilder.Entity("ZomatoDemo.DomainModel.Models.OrderDetails", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateTime");

                    b.Property<int?>("RestaurantID");

                    b.Property<string>("UserId");

                    b.HasKey("ID");

                    b.HasIndex("RestaurantID");

                    b.HasIndex("UserId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("ZomatoDemo.DomainModel.Models.Rating", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("AverageRating");

                    b.Property<int?>("RestaurantID");

                    b.Property<string>("UserId");

                    b.HasKey("ID");

                    b.HasIndex("RestaurantID");

                    b.HasIndex("UserId");

                    b.ToTable("Rating");
                });

            modelBuilder.Entity("ZomatoDemo.DomainModel.Models.Restaurant", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AverageCost");

                    b.Property<string>("ContactNumber");

                    b.Property<string>("CuisineType");

                    b.Property<string>("Description");

                    b.Property<string>("MoreInfo");

                    b.Property<string>("OpeningHours");

                    b.Property<string>("RestaurantName");

                    b.HasKey("ID");

                    b.ToTable("Restaurant");
                });

            modelBuilder.Entity("ZomatoDemo.DomainModel.Models.Review", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("LikesCount");

                    b.Property<int?>("RestaurantID");

                    b.Property<string>("ReviewTexts");

                    b.Property<string>("UserId");

                    b.HasKey("ID");

                    b.HasIndex("RestaurantID");

                    b.HasIndex("UserId");

                    b.ToTable("Review");
                });

            modelBuilder.Entity("ZomatoDemo.DomainModel.Models.UserFollow", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FolloweeId");

                    b.Property<string>("FollowerId");

                    b.HasKey("ID");

                    b.HasIndex("FolloweeId");

                    b.HasIndex("FollowerId");

                    b.ToTable("UserFollow");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("ZomatoDemo.DomainModel.Application_Classes.UserAC")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("ZomatoDemo.DomainModel.Application_Classes.UserAC")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ZomatoDemo.DomainModel.Application_Classes.UserAC")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("ZomatoDemo.DomainModel.Application_Classes.UserAC")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ZomatoDemo.DomainModel.Models.Dishes", b =>
                {
                    b.HasOne("ZomatoDemo.DomainModel.Models.Restaurant")
                        .WithMany("Dishes")
                        .HasForeignKey("RestaurantID");
                });

            modelBuilder.Entity("ZomatoDemo.DomainModel.Models.DishesOrdered", b =>
                {
                    b.HasOne("ZomatoDemo.DomainModel.Models.Dishes", "Dishes")
                        .WithMany()
                        .HasForeignKey("DishesID");

                    b.HasOne("ZomatoDemo.DomainModel.Models.OrderDetails")
                        .WithMany("DishesOrdered")
                        .HasForeignKey("OrderDetailsID");
                });

            modelBuilder.Entity("ZomatoDemo.DomainModel.Models.Likes", b =>
                {
                    b.HasOne("ZomatoDemo.DomainModel.Models.Review", "Reviews")
                        .WithMany()
                        .HasForeignKey("ReviewsID");

                    b.HasOne("ZomatoDemo.DomainModel.Application_Classes.UserAC", "Users")
                        .WithMany()
                        .HasForeignKey("UsersId");
                });

            modelBuilder.Entity("ZomatoDemo.DomainModel.Models.Location", b =>
                {
                    b.HasOne("ZomatoDemo.DomainModel.Models.City", "City")
                        .WithMany()
                        .HasForeignKey("CityID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ZomatoDemo.DomainModel.Models.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ZomatoDemo.DomainModel.Models.Restaurant")
                        .WithMany("Location")
                        .HasForeignKey("RestaurantID");
                });

            modelBuilder.Entity("ZomatoDemo.DomainModel.Models.OrderDetails", b =>
                {
                    b.HasOne("ZomatoDemo.DomainModel.Models.Restaurant", "Restaurant")
                        .WithMany()
                        .HasForeignKey("RestaurantID");

                    b.HasOne("ZomatoDemo.DomainModel.Application_Classes.UserAC", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("ZomatoDemo.DomainModel.Models.Rating", b =>
                {
                    b.HasOne("ZomatoDemo.DomainModel.Models.Restaurant", "Restaurant")
                        .WithMany()
                        .HasForeignKey("RestaurantID");

                    b.HasOne("ZomatoDemo.DomainModel.Application_Classes.UserAC", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("ZomatoDemo.DomainModel.Models.Review", b =>
                {
                    b.HasOne("ZomatoDemo.DomainModel.Models.Restaurant", "Restaurant")
                        .WithMany()
                        .HasForeignKey("RestaurantID");

                    b.HasOne("ZomatoDemo.DomainModel.Application_Classes.UserAC", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("ZomatoDemo.DomainModel.Models.UserFollow", b =>
                {
                    b.HasOne("ZomatoDemo.DomainModel.Application_Classes.UserAC", "Followee")
                        .WithMany()
                        .HasForeignKey("FolloweeId");

                    b.HasOne("ZomatoDemo.DomainModel.Application_Classes.UserAC", "Follower")
                        .WithMany()
                        .HasForeignKey("FollowerId");
                });
#pragma warning restore 612, 618
        }
    }
}
