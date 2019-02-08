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
        /// �J�����_���t
        /// </summary>
        public DbSet<Calendar> Calendars { get; set; }
        /// <summary>
        /// ���i�敪
        /// </summary>
        public DbSet<ProductCategory> ProductCategories { get; set; }
        /// <summary>
        /// �s���{��
        /// </summary>
        public DbSet<Region> Regions { get; set; }
        /// <summary>
        /// �^�����
        /// </summary>
        public DbSet<Shipper> Shippers { get; set; }
        /// <summary>
        /// �d����
        /// </summary>
        public DbSet<Supplier> Suppliers { get; set; }
        /// <summary>
        /// ���Ӑ�
        /// </summary>
        public DbSet<Customer> Customers { get; set; }
        /// �Ј�
        /// </summary>
        public DbSet<Employee> Employees { get; set; }
        /// <summary>
        /// ���i
        /// </summary>
        public DbSet<Product> Products { get; set; }
        /// <summary>
        /// ��
        /// </summary>
        public DbSet<Order> Orders { get; set; }
        /// <summary>
        /// �󒍖���
        /// </summary>
        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //����ł͍폜���Ɏq�e�[�u�����폜����
            //���̃g���K��L���ɂ���Ƒ��d�̊O���L�[�Q�ƂɎ��s���邽�߁A������
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
        }
    }
}
