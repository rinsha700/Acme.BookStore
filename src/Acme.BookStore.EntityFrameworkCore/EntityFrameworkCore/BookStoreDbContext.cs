<<<<<<< HEAD
﻿using Acme.BookStore.BankAccounts;
using Acme.BookStore.Books;
using Acme.BookStore.Departments;
using Acme.BookStore.Educamps;
using Acme.BookStore.Parties;
using Acme.BookStore.UserAdressess;
using Acme.BookStore.Users;
=======
﻿using Acme.BookStore.Books;
using Acme.BookStore.Parties;
>>>>>>> ab7e28665a8817470cab72f508d91c6603497a96
using Acme.BookStore.UserTypes;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.AuditLogging.EntityFrameworkCore;
using Volo.Abp.BackgroundJobs.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.Modeling;
using Volo.Abp.FeatureManagement.EntityFrameworkCore;
using Volo.Abp.Identity;
using Volo.Abp.Identity.EntityFrameworkCore;
using Volo.Abp.IdentityServer.EntityFrameworkCore;
using Volo.Abp.PermissionManagement.EntityFrameworkCore;
using Volo.Abp.SettingManagement.EntityFrameworkCore;
using Volo.Abp.TenantManagement;
using Volo.Abp.TenantManagement.EntityFrameworkCore;

namespace Acme.BookStore.EntityFrameworkCore;

[ReplaceDbContext(typeof(IIdentityDbContext))]
[ReplaceDbContext(typeof(ITenantManagementDbContext))]
[ConnectionStringName("Default")]
public class BookStoreDbContext :
    AbpDbContext<BookStoreDbContext>,
    IIdentityDbContext,
    ITenantManagementDbContext
{
    /* Add DbSet properties for your Aggregate Roots / Entities here. */

    #region Entities from the modules

    /* Notice: We only implemented IIdentityDbContext and ITenantManagementDbContext
     * and replaced them for this DbContext. This allows you to perform JOIN
     * queries for the entities of these modules over the repositories easily. You
     * typically don't need that for other modules. But, if you need, you can
     * implement the DbContext interface of the needed module and use ReplaceDbContext
     * attribute just like IIdentityDbContext and ITenantManagementDbContext.
     *
     * More info: Replacing a DbContext of a module ensures that the related module
     * uses this DbContext on runtime. Otherwise, it will use its own DbContext class.
     */

    //Identity
    public DbSet<IdentityUser> Users { get; set; }
    public DbSet<IdentityRole> Roles { get; set; }
    public DbSet<IdentityClaimType> ClaimTypes { get; set; }
    public DbSet<OrganizationUnit> OrganizationUnits { get; set; }
    public DbSet<IdentitySecurityLog> SecurityLogs { get; set; }
    public DbSet<IdentityLinkUser> LinkUsers { get; set; }
   


    // Tenant Management
    public DbSet<Tenant> Tenants { get; set; }
    public DbSet<TenantConnectionString> TenantConnectionStrings { get; set; }

    public DbSet<Book> Books { get; set; }
    public DbSet<UserType> UserTypes { get; set; }
    public DbSet<Party> Parties { get; set; }
    public DbSet<Department> Departments { get; set; }
    //public DbSet<User> Users1 { get; set; }
    //public DbSet<UserAddress> UserAddressess { get; set; }
    //public DbSet<BankAccount> BankAccounts { get; set; }

<<<<<<< HEAD
=======
    public DbSet<UserType> UserTypes { get; set; }
    public DbSet<Partie> Parties { get; set; }




    #endregion
>>>>>>> ab7e28665a8817470cab72f508d91c6603497a96

    #endregion
    public DbSet<Educamp> Educamps { get; set; }
    public BookStoreDbContext(DbContextOptions<BookStoreDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        /* Include modules to your migration db context */

        builder.ConfigurePermissionManagement();
        builder.ConfigureSettingManagement();
        builder.ConfigureBackgroundJobs();
        builder.ConfigureAuditLogging();
        builder.ConfigureIdentity();
        builder.ConfigureIdentityServer();
        builder.ConfigureFeatureManagement();
        builder.ConfigureTenantManagement();


        /* Configure your own tables/entities inside here */

        //builder.Entity<YourEntity>(b =>
        //{
        //    b.ToTable(BookStoreConsts.DbTablePrefix + "YourEntities", BookStoreConsts.DbSchema);
        //    b.ConfigureByConvention(); //auto configure for the base class props
        //    //...
        //});
        builder.Entity<Book>(b =>
        {
            b.ToTable(BookStoreConsts.DbTablePrefix + "Books",
                BookStoreConsts.DbSchema);
            b.ConfigureByConvention(); //auto configure for the base class props
            b.Property(x => x.Name).IsRequired().HasMaxLength(128);
        });

        builder.Entity<UserType>(b =>
        {
<<<<<<< HEAD
            b.ToTable(BookStoreConsts.DbTablePrefix + "UserTypes", BookStoreConsts.DbSchema);
            b.ConfigureByConvention(); //auto configure for the base class props

            b.Property(x => x.Name).IsRequired().HasMaxLength(100);
            b.Property(x => x.Code).IsRequired().HasMaxLength(100);

            //...
        });

        builder.Entity<Party>(b =>
        {
            b.ToTable(BookStoreConsts.DbTablePrefix + "Parties", BookStoreConsts.DbSchema);
            b.ConfigureByConvention(); //auto configure for the base class props

            b.Property(x => x.Name).IsRequired().HasMaxLength(100);
            b.Property(x => x.Code).IsRequired().HasMaxLength(100);

            //...
        });

        builder.Entity<Department>(b =>
        {
            b.ToTable(BookStoreConsts.DbTablePrefix + "Departments", BookStoreConsts.DbSchema);
            b.ConfigureByConvention(); //auto configure for the base class props

            b.Property(x => x.Name).IsRequired().HasMaxLength(100);
            b.Property(x => x.Code).IsRequired().HasMaxLength(100);

            //...
        });

        builder.Entity<User>(b =>
        {
            b.ToTable(BookStoreConsts.DbTablePrefix + "Users1", BookStoreConsts.DbSchema);
            b.ConfigureByConvention(); //auto configure for the base class props

            b.Property(x => x.Name).IsRequired().HasMaxLength(100);
            b.Property(x => x.Age).IsRequired().HasMaxLength(100);

            //...
        });

        builder.Entity<UserAddress>(b =>
        {
            b.ToTable(BookStoreConsts.DbTablePrefix + "UserAddressess", BookStoreConsts.DbSchema);
            b.ConfigureByConvention(); //auto configure for the base class props

            b.Property(x => x.Address1).IsRequired().HasMaxLength(100);
            b.Property(x => x.Address2).IsRequired().HasMaxLength(100);
            b.Property(x => x.Country).IsRequired().HasMaxLength(100);
            b.HasOne(x => x.Users).WithOne(x => x.UserAddressess).HasForeignKey<UserAddress>(x => x.UserId);

            //...
        });
        //var address = builder.Entity<UserAddress>();
        ////address.HasKey(x => x.Id);//PK
        //address.HasOne(ad => ad.Users)
        //       .WithOne(us => us.UserAddressess)
        //       .HasForeignKey<UserAddress>(us => us.UserId)
        //       .OnDelete(DeleteBehavior.Cascade);



        builder.Entity<BankAccount>(b =>
        {
            b.ToTable(BookStoreConsts.DbTablePrefix + "BankAccounts", BookStoreConsts.DbSchema);
            b.ConfigureByConvention(); //auto configure for the base class props

            b.Property(x => x.Name).IsRequired().HasMaxLength(100);
            b.Property(x => x.AccountNo).IsRequired().HasMaxLength(100);
            b.Property(x => x.Address).IsRequired().HasMaxLength(100);
            b.HasOne(x => x.Users).WithMany(x => x.BankAccounts).HasForeignKey(x => x.UserId);
=======
            b.ToTable(BookStoreConsts.DbTablePrefix + "UserTypes",
                BookStoreConsts.DbSchema);
            b.ConfigureByConvention(); //auto configure for the base class props
            b.Property(x => x.Name).IsRequired().HasMaxLength(100);
            b.Property(x => x.Code).IsRequired().HasMaxLength(100);

        });

        builder.Entity<Partie>(b =>
        {
            b.ToTable(BookStoreConsts.DbTablePrefix + "Parties",
                BookStoreConsts.DbSchema);
            b.ConfigureByConvention(); //auto configure for the base class props
            b.Property(x => x.Name).IsRequired().HasMaxLength(100);
            b.Property(x => x.Code).IsRequired().HasMaxLength(100);
>>>>>>> ab7e28665a8817470cab72f508d91c6603497a96

        });


            
        });


    }
}
