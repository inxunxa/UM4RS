//-----------------------------------------------------------------------
// <copyright file="ModelORM.cs" company="Sergio Inzunza">
//    Sergio Inzunza and Contributors
// </copyright>
//-----------------------------------------------------------------------
// This file is part of User Model for Context-Aware Recommender Systems (UM4RS) and is dual licensed under MS-PL and Apache 2.0.
// https://github.com/inxunxa/UM4RS

using System.Data.Entity;
using System.Data.Entity.Core;
using System.Data.Entity.ModelConfiguration.Conventions;
using UM4RS.Activity;
using UM4RS.Context.Location;
using UM4RS.Item;

namespace UM4RS
{
    /// <summary>
    /// Maps the defined classes to Database Tables.
    /// </summary>
    public class ModelORM : DbContext
    {
        /// <summary>
        /// Recreate the DataBase (set at the begining od the programm)
        /// </summary>
        /// <remarks>
        /// If set to TRUE, ALL DATA WILL BE LOST. Use for Testing purposes
        /// </remarks>
        public static bool RecreateDataBase { get; set; } = false;

        /// <summary>
        /// The connection string to the Database Server that will be used to persiste the model data
        /// </summary>
        public static string ConString { get; set; }
       
        public ModelORM()
        {
            // Warning: TO TEST ONLY
            if (RecreateDataBase)
                Database.SetInitializer<ModelORM>(new DropCreateDatabaseAlways<ModelORM>());

            if (string.IsNullOrEmpty(ConString))
            {
                #if (DEBUG && !MYTEST)
                    ConString = @"Data Source=.\SQLEXPRESS;Initial Catalog=UM4RS;Integrated Security=True";
                #elif (!DEBUG && MYTEST)
                    throw new EntityException("Cant connect to DataBase. ConString have not been set");
                #endif
            }
            this.Database.Connection.ConnectionString = ConString;
        }               

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // avoid having the table name pluralized            
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public virtual DbSet<User.User> Users { get; set; }

        public DbSet<Context.Context> Contexts { get; set; }
         
        public DbSet<Video> Videos { get; set; }
        
        public DbSet<Rating> Ratings { get; set; }

        public DbSet<Place> Places { get; set; }

        public DbSet<Hotel> Hotels { get; set; }

        public DbSet<Address> Addresses { get; set; }

        public DbSet<View> Views { get; set; }

        public DbSet<Eat> Eats { get; set; }

        public DbSet<Listen> Listens { get; set; }

        public DbSet<Audio> Audios { get; set; }

        public DbSet<Travel> Travels { get; set; }

        public DbSet<Purchase> Purchases { get; set; }
    }
}
