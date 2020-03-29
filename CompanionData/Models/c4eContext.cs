using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CompanionData.Models
{
    public partial class c4eContext : DbContext
    {
        public c4eContext()
        {
        }

        public c4eContext(DbContextOptions<c4eContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Buyer> Buyer { get; set; }
        public virtual DbSet<Chatcontent> Chatcontent { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<Ordercontent> Ordercontent { get; set; }
        public virtual DbSet<Orderfoto> Orderfoto { get; set; }
        public virtual DbSet<Orderoffer> Orderoffer { get; set; }
        public virtual DbSet<Person> Person { get; set; }
        public virtual DbSet<Personservice> Personservice { get; set; }
        public virtual DbSet<Personservicephotolink> Personservicephotolink { get; set; }
        public virtual DbSet<Personservicetype> Personservicetype { get; set; }
        public virtual DbSet<Seller> Seller { get; set; }
        public virtual DbSet<Servicetype> Servicetype { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Buyer>(entity =>
            {
                entity.ToTable("buyer");

                entity.HasIndex(e => e.Personid)
                    .HasName("fk_person_buyer_idx");

                entity.Property(e => e.Personid).HasColumnName("personid");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.Buyer)
                    .HasForeignKey(d => d.Personid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_buyer_person");
            });

            modelBuilder.Entity<Chatcontent>(entity =>
            {
                entity.ToTable("chatcontent");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Begin)
                    .HasColumnName("begin")
                    .HasColumnType("datetime");

                entity.Property(e => e.End)
                    .HasColumnName("end")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.ToTable("order");

                entity.HasIndex(e => e.Orderbuyerid)
                    .HasName("fk_order_buyer_idx");

                entity.HasIndex(e => e.Ordersellerid)
                    .HasName("fk_order_seller_idx");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Additionalinfo)
                    .HasColumnName("additionalinfo")
                    .HasColumnType("longtext")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.OrderNo)
                    .HasColumnName("orderNo")
                    .HasColumnType("char(40)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Orderbegindatetime)
                    .HasColumnName("orderbegindatetime")
                    .HasColumnType("datetime");

                entity.Property(e => e.Orderbuyerid).HasColumnName("orderbuyerid");

                entity.Property(e => e.Orderenddatetime)
                    .HasColumnName("orderenddatetime")
                    .HasColumnType("datetime");

                entity.Property(e => e.Ordersellerid).HasColumnName("ordersellerid");

                entity.HasOne(d => d.Orderbuyer)
                    .WithMany(p => p.Order)
                    .HasForeignKey(d => d.Orderbuyerid)
                    .HasConstraintName("fk_order_buyer");

                entity.HasOne(d => d.Orderseller)
                    .WithMany(p => p.Order)
                    .HasForeignKey(d => d.Ordersellerid)
                    .HasConstraintName("fk_order_seller");
            });

            modelBuilder.Entity<Ordercontent>(entity =>
            {
                entity.ToTable("ordercontent");

                entity.HasIndex(e => e.Orderid)
                    .HasName("fk_order_ordercontent_idx");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Begin)
                    .HasColumnName("begin")
                    .HasColumnType("datetime");

                entity.Property(e => e.End)
                    .HasColumnName("end")
                    .HasColumnType("datetime");

                entity.Property(e => e.Orderid).HasColumnName("orderid");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.Ordercontent)
                    .HasForeignKey(d => d.Orderid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_order_ordercontent");
            });

            modelBuilder.Entity<Orderfoto>(entity =>
            {
                entity.ToTable("orderfoto");

                entity.HasIndex(e => e.Orderid)
                    .HasName("fk_foto_order_idx");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Link)
                    .HasColumnName("link")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Orderid).HasColumnName("orderid");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.Orderfoto)
                    .HasForeignKey(d => d.Orderid)
                    .HasConstraintName("fk_foto_order");
            });

            modelBuilder.Entity<Orderoffer>(entity =>
            {
                entity.ToTable("orderoffer");

                entity.HasIndex(e => e.ChatcontentId)
                    .HasName("fk_orderoffer_chatcontent_idx");

                entity.HasIndex(e => e.OrderId)
                    .HasName("fk_order_orderoffer_idx");

                entity.HasIndex(e => e.SellerId)
                    .HasName("fk_seller_orderoffer_idx");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Activ)
                    .HasColumnName("activ")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.BuyerOrderCost).HasColumnName("buyerOrderCost");

                entity.Property(e => e.ChatcontentId).HasColumnName("chatcontent_id");

                entity.Property(e => e.OrderCost).HasColumnName("orderCost");

                entity.Property(e => e.OrderId).HasColumnName("order_id");

                entity.Property(e => e.SellerId).HasColumnName("seller_id");

                entity.HasOne(d => d.Chatcontent)
                    .WithMany(p => p.Orderoffer)
                    .HasForeignKey(d => d.ChatcontentId)
                    .HasConstraintName("fk_orderoffer_chatcontent");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.Orderoffer)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("fk_order_orderoffer");

                entity.HasOne(d => d.Seller)
                    .WithMany(p => p.Orderoffer)
                    .HasForeignKey(d => d.SellerId)
                    .HasConstraintName("fk_seller_orderoffer");
            });

            modelBuilder.Entity<Person>(entity =>
            {
                entity.ToTable("person");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AdditionalInfo)
                    .HasColumnName("additionalInfo")
                    .HasColumnType("longtext")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Firstname)
                    .HasColumnName("firstname")
                    .HasColumnType("char(40)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("char(40)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Nickname)
                    .IsRequired()
                    .HasColumnName("nickname")
                    .HasColumnType("varchar(40)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Telefon)
                    .HasColumnName("telefon")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");
            });

            modelBuilder.Entity<Personservice>(entity =>
            {
                entity.ToTable("personservice");

                entity.HasIndex(e => e.Sellerid)
                    .HasName("fk_personservice_seller_idx");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Additionalinfo)
                    .HasColumnName("additionalinfo")
                    .HasColumnType("longtext")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Sellerid).HasColumnName("sellerid");

                entity.HasOne(d => d.Seller)
                    .WithMany(p => p.Personservice)
                    .HasForeignKey(d => d.Sellerid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_personservice_seller");
            });

            modelBuilder.Entity<Personservicephotolink>(entity =>
            {
                entity.ToTable("personservicephotolink");

                entity.HasIndex(e => e.Personserviceid)
                    .HasName("fk_personservice_photolink_idx");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Link)
                    .HasColumnName("link")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Personserviceid).HasColumnName("personserviceid");

                entity.HasOne(d => d.Personservice)
                    .WithMany(p => p.Personservicephotolink)
                    .HasForeignKey(d => d.Personserviceid)
                    .HasConstraintName("fk_personservice_photolink");
            });

            modelBuilder.Entity<Personservicetype>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("personservicetype");

                entity.HasIndex(e => e.Personserviceid)
                    .HasName("fk_servicetype_person_idx");

                entity.HasIndex(e => e.Servicetypeid)
                    .HasName("fk_personservice_type_idx");

                entity.Property(e => e.Personserviceid).HasColumnName("personserviceid");

                entity.Property(e => e.Servicetypeid).HasColumnName("servicetypeid");

                entity.HasOne(d => d.Personservice)
                    .WithMany()
                    .HasForeignKey(d => d.Personserviceid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_servicetype_person");

                entity.HasOne(d => d.Servicetype)
                    .WithMany()
                    .HasForeignKey(d => d.Servicetypeid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_personservice_type");
            });

            modelBuilder.Entity<Seller>(entity =>
            {
                entity.ToTable("seller");

                entity.HasIndex(e => e.Personid)
                    .HasName("fk_person_idx");

                entity.Property(e => e.Personid).HasColumnName("personid");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.Seller)
                    .HasForeignKey(d => d.Personid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_seller_person");
            });

            modelBuilder.Entity<Servicetype>(entity =>
            {
                entity.ToTable("servicetype");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Additionalinfo)
                    .HasColumnName("additionalinfo")
                    .HasColumnType("longtext")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Name)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
