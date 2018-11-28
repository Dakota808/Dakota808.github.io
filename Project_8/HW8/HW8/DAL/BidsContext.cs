namespace HW8.DAL
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using HW8.Models;

    public partial class BidsContext : DbContext
    {
        public BidsContext()
            : base("name=BidsContext")
        {
        }

        public virtual DbSet<Bid> Bids { get; set; }
        public virtual DbSet<Buyer> Buyers { get; set; }
        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<Seller> Sellers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bid>()
                .Property(e => e.Prices)
                .IsUnicode(false);

            modelBuilder.Entity<Buyer>()
                .Property(e => e.BuyersName)
                .IsUnicode(false);

            modelBuilder.Entity<Buyer>()
                .HasMany(e => e.Bids)
                .WithOptional(e => e.Buyer)
                .HasForeignKey(e => e.Bider);

            modelBuilder.Entity<Item>()
                .Property(e => e.ItemName)
                .IsUnicode(false);

            modelBuilder.Entity<Item>()
                .Property(e => e.ItemDescription)
                .IsUnicode(false);

            modelBuilder.Entity<Item>()
                .HasMany(e => e.Bids)
                .WithOptional(e => e.Item1)
                .HasForeignKey(e => e.Item);

            modelBuilder.Entity<Seller>()
                .Property(e => e.SellersName)
                .IsUnicode(false);

            modelBuilder.Entity<Seller>()
                .HasMany(e => e.Items)
                .WithOptional(e => e.Seller1)
                .HasForeignKey(e => e.Seller);
        }
    }
}
