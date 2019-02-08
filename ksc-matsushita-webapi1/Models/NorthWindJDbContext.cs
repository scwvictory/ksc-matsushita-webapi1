namespace ksc_matsushita_webapi1.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration.Conventions;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class NorthWindJDbContext : DbContext
    {
        public NorthWindJDbContext()
            : base("name=NorthWindJ")
        {
        }

        /// <summary>
        /// カレンダ日付
        /// </summary>
        public DbSet<Calendar> Calendars { get; set; }
        /// <summary>
        /// 商品区分
        /// </summary>
        public DbSet<ProductCategory> ProductCategories { get; set; }
        /// <summary>
        /// 都道府県
        /// </summary>
        public DbSet<Region> Regions { get; set; }
        /// <summary>
        /// 運送会社
        /// </summary>
        public DbSet<Shipper> Shippers { get; set; }
        /// <summary>
        /// 仕入先
        /// </summary>
        public DbSet<Supplier> Suppliers { get; set; }
        /// <summary>
        /// 得意先
        /// </summary>
        public DbSet<Customer> Customers { get; set; }
        /// 社員
        /// </summary>
        public DbSet<Employee> Employees { get; set; }
        /// <summary>
        /// 商品
        /// </summary>
        public DbSet<Product> Products { get; set; }
        /// <summary>
        /// 受注
        /// </summary>
        public DbSet<Order> Orders { get; set; }
        /// <summary>
        /// 受注明細
        /// </summary>
        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //既定では削除時に子テーブルを削除する
            //このトリガを有効にすると多重の外部キー参照に失敗するため、無効化
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
        }
    }
}
