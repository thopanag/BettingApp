﻿// <auto-generated />
using System;
using BettingApp.Services.Wallets.API.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BettingApp.Services.Wallets.API.Infrastructure.Migrations.Wallets
{
    [DbContext(typeof(WalletsContext))]
    partial class WalletsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BettingApp.Services.Wallets.API.Model.Transaction", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("Amount");

                    b.Property<DateTime>("DateTimeCreated")
                        .HasColumnType("datetime2")
                        .HasColumnName("DateTimeCreated");

                    b.Property<string>("IdentifierId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("IdentifierId");

                    b.Property<string>("IdentifierName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("IdentifierName");

                    b.Property<int>("TransactionTypeId")
                        .HasColumnType("int")
                        .HasColumnName("TransactionTypeId");

                    b.Property<string>("TransactionTypeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("TransactionTypeName");

                    b.Property<decimal>("WalletBalanceAfter")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("WalletBalanceAfter");

                    b.Property<decimal>("WalletBalanceBefore")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("WalletBalanceBefore");

                    b.Property<string>("WalletId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("WalletId");

                    b.HasKey("Id");

                    b.HasIndex("TransactionTypeId");

                    b.HasIndex("WalletId");

                    b.ToTable("transactions");
                });

            modelBuilder.Entity("BettingApp.Services.Wallets.API.Model.TransactionType", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasDefaultValue(1);

                    b.Property<string>("IdentifierName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.ToTable("transactionType");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IdentifierName = "requestId",
                            Name = "TopUp"
                        },
                        new
                        {
                            Id = 2,
                            IdentifierName = "requestId",
                            Name = "Withdraw"
                        },
                        new
                        {
                            Id = 3,
                            IdentifierName = "betId",
                            Name = "BetPayment"
                        },
                        new
                        {
                            Id = 4,
                            IdentifierName = "betId",
                            Name = "BetWinnings"
                        },
                        new
                        {
                            Id = 5,
                            IdentifierName = "betId",
                            Name = "BetRefund"
                        },
                        new
                        {
                            Id = 6,
                            IdentifierName = "gamblerId",
                            Name = "WelcomeBonus"
                        });
                });

            modelBuilder.Entity("BettingApp.Services.Wallets.API.Model.Wallet", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<decimal>("Balance")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("Balance");

                    b.Property<string>("GamblerId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("GamblerId");

                    b.Property<DateTime>("LastTimeUpdated")
                        .HasColumnType("datetime2")
                        .HasColumnName("LastTimeUpdated");

                    b.Property<string>("LastTransactionId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("LastTransactionId");

                    b.Property<decimal>("PreviousBalance")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("PreviousBalance");

                    b.Property<decimal>("TotalTopUpAmount")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("TotalTopUpAmount");

                    b.Property<int>("TotalTransactions")
                        .HasColumnType("int")
                        .HasColumnName("TotalTransactions");

                    b.Property<decimal>("TotalWageredAmount")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("TotalWageredAmount");

                    b.Property<decimal>("TotalWinningsAmount")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("TotalWinningsAmount");

                    b.Property<decimal>("TotalWithdrawAmount")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("TotalWithdrawAmount");

                    b.HasKey("Id");

                    b.HasAlternateKey("GamblerId");

                    b.ToTable("wallets");
                });

            modelBuilder.Entity("BettingApp.Services.Wallets.API.Model.Transaction", b =>
                {
                    b.HasOne("BettingApp.Services.Wallets.API.Model.TransactionType", "TransactionType")
                        .WithMany()
                        .HasForeignKey("TransactionTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BettingApp.Services.Wallets.API.Model.Wallet", null)
                        .WithMany("Transactions")
                        .HasForeignKey("WalletId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TransactionType");
                });

            modelBuilder.Entity("BettingApp.Services.Wallets.API.Model.Wallet", b =>
                {
                    b.Navigation("Transactions");
                });
#pragma warning restore 612, 618
        }
    }
}
