﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ReviewAnalyzer.Data;

#nullable disable

namespace ReviewAnalyzer.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220111190243_requiredReviewItem7")]
    partial class requiredReviewItem7
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.1");

            modelBuilder.Entity("ReviewAnalyzer.Data.Review", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("ReviewItemId")
                        .IsRequired()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Sentiment")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ReviewItemId");

                    b.ToTable("Reviews");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Content = "Content is not important right now",
                            ReviewItemId = 1,
                            Sentiment = "Neutral"
                        },
                        new
                        {
                            Id = 2,
                            Content = "Content is not important right now",
                            ReviewItemId = 1,
                            Sentiment = "Positive"
                        },
                        new
                        {
                            Id = 3,
                            Content = "Content is not important right now",
                            ReviewItemId = 1,
                            Sentiment = "Positive"
                        },
                        new
                        {
                            Id = 4,
                            Content = "Content is not important right now",
                            ReviewItemId = 1,
                            Sentiment = "Negative"
                        },
                        new
                        {
                            Id = 5,
                            Content = "Content is not important right now",
                            ReviewItemId = 1,
                            Sentiment = "Negative"
                        },
                        new
                        {
                            Id = 6,
                            Content = "Content is not important right now",
                            ReviewItemId = 1,
                            Sentiment = "Neutral"
                        },
                        new
                        {
                            Id = 7,
                            Content = "Content is not important right now",
                            ReviewItemId = 1,
                            Sentiment = "Neutral"
                        },
                        new
                        {
                            Id = 8,
                            Content = "Content is not important right now",
                            ReviewItemId = 1,
                            Sentiment = "Neutral"
                        },
                        new
                        {
                            Id = 9,
                            Content = "Content is not important right now",
                            ReviewItemId = 1,
                            Sentiment = "Positive"
                        },
                        new
                        {
                            Id = 10,
                            Content = "Content is not important right now",
                            ReviewItemId = 1,
                            Sentiment = "Neutral"
                        },
                        new
                        {
                            Id = 11,
                            Content = "Content is not important right now",
                            ReviewItemId = 1,
                            Sentiment = "Negative"
                        },
                        new
                        {
                            Id = 12,
                            Content = "Content is not important right now",
                            ReviewItemId = 1,
                            Sentiment = "Mixed"
                        },
                        new
                        {
                            Id = 13,
                            Content = "Content is not important right now",
                            ReviewItemId = 1,
                            Sentiment = "Negative"
                        },
                        new
                        {
                            Id = 14,
                            Content = "Content is not important right now",
                            ReviewItemId = 1,
                            Sentiment = "Positive"
                        },
                        new
                        {
                            Id = 15,
                            Content = "Content is not important right now",
                            ReviewItemId = 1,
                            Sentiment = "Neutral"
                        },
                        new
                        {
                            Id = 16,
                            Content = "Content is not important right now",
                            ReviewItemId = 1,
                            Sentiment = "Negative"
                        },
                        new
                        {
                            Id = 17,
                            Content = "Content is not important right now",
                            ReviewItemId = 1,
                            Sentiment = "Positive"
                        },
                        new
                        {
                            Id = 18,
                            Content = "Content is not important right now",
                            ReviewItemId = 1,
                            Sentiment = "Neutral"
                        },
                        new
                        {
                            Id = 19,
                            Content = "Content is not important right now",
                            ReviewItemId = 1,
                            Sentiment = "Negative"
                        },
                        new
                        {
                            Id = 20,
                            Content = "Content is not important right now",
                            ReviewItemId = 1,
                            Sentiment = "Negative"
                        },
                        new
                        {
                            Id = 21,
                            Content = "Content is not important right now",
                            ReviewItemId = 1,
                            Sentiment = "Positive"
                        },
                        new
                        {
                            Id = 22,
                            Content = "Content is not important right now",
                            ReviewItemId = 1,
                            Sentiment = "Neutral"
                        },
                        new
                        {
                            Id = 23,
                            Content = "Content is not important right now",
                            ReviewItemId = 1,
                            Sentiment = "Mixed"
                        },
                        new
                        {
                            Id = 24,
                            Content = "Content is not important right now",
                            ReviewItemId = 1,
                            Sentiment = "Mixed"
                        },
                        new
                        {
                            Id = 25,
                            Content = "Content is not important right now",
                            ReviewItemId = 1,
                            Sentiment = "Neutral"
                        },
                        new
                        {
                            Id = 26,
                            Content = "Content is not important right now",
                            ReviewItemId = 1,
                            Sentiment = "Negative"
                        },
                        new
                        {
                            Id = 27,
                            Content = "Content is not important right now",
                            ReviewItemId = 1,
                            Sentiment = "Mixed"
                        },
                        new
                        {
                            Id = 28,
                            Content = "Content is not important right now",
                            ReviewItemId = 1,
                            Sentiment = "Mixed"
                        },
                        new
                        {
                            Id = 29,
                            Content = "Content is not important right now",
                            ReviewItemId = 1,
                            Sentiment = "Mixed"
                        },
                        new
                        {
                            Id = 30,
                            Content = "Content is not important right now",
                            ReviewItemId = 1,
                            Sentiment = "Negative"
                        },
                        new
                        {
                            Id = 31,
                            Content = "Content is not important right now",
                            ReviewItemId = 1,
                            Sentiment = "Negative"
                        },
                        new
                        {
                            Id = 32,
                            Content = "Content is not important right now",
                            ReviewItemId = 1,
                            Sentiment = "Mixed"
                        },
                        new
                        {
                            Id = 33,
                            Content = "Content is not important right now",
                            ReviewItemId = 1,
                            Sentiment = "Positive"
                        },
                        new
                        {
                            Id = 34,
                            Content = "Content is not important right now",
                            ReviewItemId = 1,
                            Sentiment = "Mixed"
                        },
                        new
                        {
                            Id = 35,
                            Content = "Content is not important right now",
                            ReviewItemId = 1,
                            Sentiment = "Neutral"
                        },
                        new
                        {
                            Id = 36,
                            Content = "Content is not important right now",
                            ReviewItemId = 1,
                            Sentiment = "Neutral"
                        },
                        new
                        {
                            Id = 37,
                            Content = "Content is not important right now",
                            ReviewItemId = 1,
                            Sentiment = "Mixed"
                        },
                        new
                        {
                            Id = 38,
                            Content = "Content is not important right now",
                            ReviewItemId = 1,
                            Sentiment = "Mixed"
                        },
                        new
                        {
                            Id = 39,
                            Content = "Content is not important right now",
                            ReviewItemId = 1,
                            Sentiment = "Positive"
                        },
                        new
                        {
                            Id = 40,
                            Content = "Content is not important right now",
                            ReviewItemId = 1,
                            Sentiment = "Mixed"
                        },
                        new
                        {
                            Id = 41,
                            Content = "Content is not important right now",
                            ReviewItemId = 1,
                            Sentiment = "Negative"
                        },
                        new
                        {
                            Id = 42,
                            Content = "Content is not important right now",
                            ReviewItemId = 1,
                            Sentiment = "Positive"
                        },
                        new
                        {
                            Id = 43,
                            Content = "Content is not important right now",
                            ReviewItemId = 1,
                            Sentiment = "Negative"
                        },
                        new
                        {
                            Id = 44,
                            Content = "Content is not important right now",
                            ReviewItemId = 1,
                            Sentiment = "Mixed"
                        },
                        new
                        {
                            Id = 45,
                            Content = "Content is not important right now",
                            ReviewItemId = 1,
                            Sentiment = "Negative"
                        },
                        new
                        {
                            Id = 46,
                            Content = "Content is not important right now",
                            ReviewItemId = 1,
                            Sentiment = "Mixed"
                        },
                        new
                        {
                            Id = 47,
                            Content = "Content is not important right now",
                            ReviewItemId = 1,
                            Sentiment = "Negative"
                        },
                        new
                        {
                            Id = 48,
                            Content = "Content is not important right now",
                            ReviewItemId = 1,
                            Sentiment = "Mixed"
                        },
                        new
                        {
                            Id = 49,
                            Content = "Content is not important right now",
                            ReviewItemId = 1,
                            Sentiment = "Negative"
                        },
                        new
                        {
                            Id = 50,
                            Content = "Content is not important right now",
                            ReviewItemId = 1,
                            Sentiment = "Positive"
                        },
                        new
                        {
                            Id = 51,
                            Content = "Content is not important right now",
                            ReviewItemId = 1,
                            Sentiment = "Positive"
                        },
                        new
                        {
                            Id = 52,
                            Content = "Content is not important right now",
                            ReviewItemId = 1,
                            Sentiment = "Neutral"
                        },
                        new
                        {
                            Id = 53,
                            Content = "Content is not important right now",
                            ReviewItemId = 1,
                            Sentiment = "Positive"
                        },
                        new
                        {
                            Id = 54,
                            Content = "Content is not important right now",
                            ReviewItemId = 1,
                            Sentiment = "Positive"
                        },
                        new
                        {
                            Id = 55,
                            Content = "Content is not important right now",
                            ReviewItemId = 1,
                            Sentiment = "Mixed"
                        },
                        new
                        {
                            Id = 56,
                            Content = "Content is not important right now",
                            ReviewItemId = 1,
                            Sentiment = "Mixed"
                        },
                        new
                        {
                            Id = 57,
                            Content = "Content is not important right now",
                            ReviewItemId = 1,
                            Sentiment = "Positive"
                        },
                        new
                        {
                            Id = 58,
                            Content = "Content is not important right now",
                            ReviewItemId = 1,
                            Sentiment = "Positive"
                        },
                        new
                        {
                            Id = 59,
                            Content = "Content is not important right now",
                            ReviewItemId = 1,
                            Sentiment = "Negative"
                        },
                        new
                        {
                            Id = 60,
                            Content = "Content is not important right now",
                            ReviewItemId = 1,
                            Sentiment = "Mixed"
                        },
                        new
                        {
                            Id = 61,
                            Content = "Content is not important right now",
                            ReviewItemId = 1,
                            Sentiment = "Neutral"
                        },
                        new
                        {
                            Id = 62,
                            Content = "Content is not important right now",
                            ReviewItemId = 1,
                            Sentiment = "Mixed"
                        },
                        new
                        {
                            Id = 63,
                            Content = "Content is not important right now",
                            ReviewItemId = 1,
                            Sentiment = "Negative"
                        },
                        new
                        {
                            Id = 64,
                            Content = "Content is not important right now",
                            ReviewItemId = 1,
                            Sentiment = "Negative"
                        },
                        new
                        {
                            Id = 65,
                            Content = "Content is not important right now",
                            ReviewItemId = 1,
                            Sentiment = "Mixed"
                        },
                        new
                        {
                            Id = 66,
                            Content = "Content is not important right now",
                            ReviewItemId = 1,
                            Sentiment = "Positive"
                        },
                        new
                        {
                            Id = 67,
                            Content = "Content is not important right now",
                            ReviewItemId = 1,
                            Sentiment = "Positive"
                        },
                        new
                        {
                            Id = 68,
                            Content = "Content is not important right now",
                            ReviewItemId = 1,
                            Sentiment = "Positive"
                        },
                        new
                        {
                            Id = 69,
                            Content = "Content is not important right now",
                            ReviewItemId = 1,
                            Sentiment = "Negative"
                        });
                });

            modelBuilder.Entity("ReviewAnalyzer.Data.ReviewItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("ReviewItems");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Test"
                        });
                });

            modelBuilder.Entity("ReviewAnalyzer.Data.Review", b =>
                {
                    b.HasOne("ReviewAnalyzer.Data.ReviewItem", "ReviewItem")
                        .WithMany()
                        .HasForeignKey("ReviewItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ReviewItem");
                });
#pragma warning restore 612, 618
        }
    }
}
