//-----------------------------------------------------------------------
// <copyright file="ModelEntity.cs" company="Sergio Inzunza">
//    Sergio Inzunza and Contributors
// </copyright>
//-----------------------------------------------------------------------
// This file is part of User Model for Context-Aware Recommender Systems (UM4RS) and is dual licensed under MS-PL and Apache 2.0.
// https://github.com/inxunxa/UM4RS

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace UM4RS
{
    /// <summary>
    /// Generic Class for Model Objects.
    /// Extend this class to any new Class that needs to have Persistance.
    /// This class will inherit the CRUD basic operations.
    /// </summary>
    /// <typeparam name="TObject"></typeparam>
    public abstract class ModelEntity<TObject> : IDisposable where TObject : class, IBaseEntity
    {
        static ModelORM ModelOrm = new ModelORM();

        #region -- CLASS METHODS -- 

        /// <summary>
        /// Returns a single object with a primary key of the provided id
        /// </summary>
        /// <remarks>Synchronous</remarks>
        /// <param name="id">The primary key of the object to fetch</param>
        /// <param name="nagivationProperties">Object properties (that are in another tables) to include when loading it</param>
        /// <returns>A single object with the provided primary key or null</returns>
        public static TObject Get(int id)
        {
            //ModelOrm.Configuration.ProxyCreationEnabled = false;
            return ModelOrm.Set<TObject>().Find(id);
        }

        /// <summary>
        /// Returns a ICollection of objects that fullfil the provided query
        /// </summary>
        /// <param name="query">The query to search for</param>
        /// <returns>The of objects that fullfil the query</returns>
        public static ICollection<TObject> Get(Expression<Func<TObject, bool>> query, params Expression<Func<TObject, object>>[] nagivationProperties)
        {
            //return ModelOrm.Set<TObject>().Where(query).ToList();
            ModelOrm.Configuration.ProxyCreationEnabled = false;
            IQueryable<TObject> dbQuery = ModelOrm.Set<TObject>();

            dbQuery = nagivationProperties.Aggregate(dbQuery, (current, nagivationProperty) => current.Include(nagivationProperty));
            // ^ refactor of:
            /*
             * foreach (Expression<Func<T, object>> nagivationProperty in nagivationProperties)
                dbQuery = dbQuery.Include<T, object>(nagivationProperty);
             */

            ICollection<TObject> data;
            if (query != null)
                data = dbQuery.Where(query).ToList();
            else
                data = dbQuery.ToList();

            return data;
        }

        /// <summary>
        /// Returns a single object with a primary key of the provided id
        /// </summary>
        /// <remarks>Asynchronous</remarks>
        /// <param name="id">The primary key of the object to fetch</param>
        /// <returns>A single object with the provided primary key or null</returns>
        public static async Task<TObject> GetAsync(int id)
        {
            return await ModelOrm.Set<TObject>().FindAsync(id);
        }

        /// <summary>
        /// Gets a collection of all objects in the database
        /// </summary>
        /// <remarks>Synchronous</remarks>
        /// <returns>An ICollection of every object in the database</returns>
        public static ICollection<TObject> GetAll()
        {
            return ModelOrm.Set<TObject>().ToList();
        }

        /// <summary>
        /// Gets a collection of all objects in the database
        /// </summary>
        /// <remarks>Asynchronous</remarks>
        /// <returns>An ICollection of every object in the database</returns>
        public static async Task<ICollection<TObject>> GetAllAsync()
        {
            return await ModelOrm.Set<TObject>().ToListAsync();
        }

        /// <summary>
        /// Returns a single object which matches the provided expression
        /// </summary>
        /// <remarks>Synchronous</remarks>
        /// <param name="match">A Linq expression filter to find a single result</param>
        /// <returns>A single object which matches the expression filter. 
        /// If more than one object is found or if zero are found, null is returned</returns>
        public static TObject Find(Expression<Func<TObject, bool>> match)
        {
            return ModelOrm.Set<TObject>().SingleOrDefault(match);
        }

        /// <summary>
        /// Returns a single object which matches the provided expression
        /// </summary>
        /// <remarks>Asynchronous</remarks>
        /// <param name="match">A Linq expression filter to find a single result</param>
        /// <returns>A single object which matches the expression filter. 
        /// If more than one object is found or if zero are found, null is returned</returns>
        public static async Task<TObject> FindAsync(Expression<Func<TObject, bool>> match)
        {
            return await ModelOrm.Set<TObject>().SingleOrDefaultAsync(match);
        }

        /// <summary>
        /// Returns a collection of objects which match the provided expression
        /// </summary>
        /// <remarks>Synchronous</remarks>
        /// <param name="match">A linq expression filter to find one or more results</param>
        /// <returns>An ICollection of object which match the expression filter</returns>
        public static ICollection<TObject> FindAll(Expression<Func<TObject, bool>> match)
        {
            return ModelOrm.Set<TObject>().Where(match).ToList();
        }

        /// <summary>
        /// Returns a collection of objects which match the provided expression
        /// </summary>
        /// <remarks>Asynchronous</remarks>
        /// <param name="match">A linq expression filter to find one or more results</param>
        /// <returns>An ICollection of object which match the expression filter</returns>
        public static async Task<ICollection<TObject>> FindAllAsync(Expression<Func<TObject, bool>> match)
        {
            return await ModelOrm.Set<TObject>().Where(match).ToListAsync();
        }

        /// <summary>
        /// Saves a new or modified object into the database and commits the change
        /// </summary>
        /// <remarks>Synchronous</remarks>
        /// <param name="t">The object to Save</param>
        /// <returns>The resulting object including its primary key after the Save</returns>
        public static TObject Save(TObject t)
        {
            if (t == null) return null;
            if (t.Id > 0)
            {
                // update the object
                ModelOrm.Entry(t).State = EntityState.Modified;
            }
            else
            {
                // add the new object
                ModelOrm.Set<TObject>().Add(t);
            }

            ModelOrm.SaveChanges();
            return t;
        }

        /// <summary>
        /// Inserts a single object to the database and commits the change
        /// </summary>
        /// <remarks>Asynchronous</remarks>
        /// <param name="t">The object to insert</param>
        /// <returns>The resulting object including its primary key after the insert</returns>
        public static async Task<TObject> SaveAsync(TObject t)
        {
            if (t == null) return null;
            if (t.Id > 0)
            {
                // update the object
                ModelOrm.Entry(t).State = EntityState.Modified;
            }
            else
            {
                // add the new object
                ModelOrm.Set<TObject>().Add(t);
            }

            await ModelOrm.SaveChangesAsync();
            return t;
        }

        /// <summary>
        /// Inserts a collection of objects into the database and commits the changes
        /// </summary>
        /// <remarks>Synchronous</remarks>
        /// <param name="tList">An IEnumerable list of objects to insert</param>
        /// <returns>The IEnumerable resulting list of inserted objects including the primary keys</returns>
        public static IEnumerable<TObject> SaveAll(IEnumerable<TObject> tList)
        {
            ModelOrm.Set<TObject>().AddRange(tList);
            ModelOrm.SaveChanges();
            return tList;
        }

        /// <summary>
        /// Inserts a collection of objects into the database and commits the changes
        /// </summary>
        /// <remarks>Asynchronous</remarks>
        /// <param name="tList">An IEnumerable list of objects to insert</param>
        /// <returns>The IEnumerable resulting list of inserted objects including the primary keys</returns>
        public static async Task<IEnumerable<TObject>> SaveAllAsync(IEnumerable<TObject> tList)
        {
            ModelOrm.Set<TObject>().AddRange(tList);
            await ModelOrm.SaveChangesAsync();
            return tList;
        }

        /// <summary>
        /// Deletes a single object from the database and commits the change
        /// </summary>
        /// <remarks>Synchronous</remarks>
        /// <param name="t">The object to delete</param>
        public static void Delete(TObject t)
        {
            ModelOrm.Set<TObject>().Remove(t);
            ModelOrm.SaveChanges();
        }

        /// <summary>
        /// Deletes a single object from the database and commits the change
        /// </summary>
        /// <remarks>Asynchronous</remarks>
        /// <param name="t">The object to delete</param>
        public async Task<int> DeleteAsync(TObject t)
        {
            ModelOrm.Set<TObject>().Remove(t);
            return await ModelOrm.SaveChangesAsync();
        }

        /// <summary>
        /// Gets the count of the number of objects in the database
        /// </summary>
        /// <remarks>Synchronous</remarks>
        /// <returns>The count of the number of objects</returns>
        public static int Count()
        {
            return ModelOrm.Set<TObject>().Count();
        }

        /// <summary>
        /// Gets the count of the number of objects in the database
        /// </summary>
        /// <remarks>Asynchronous</remarks>
        /// <returns>The count of the number of objects</returns>
        public static async Task<int> CountAsync()
        {
            return await ModelOrm.Set<TObject>().CountAsync();
        }
        #endregion

        #region -- INSTANCE METHODS --

        /// <summary>
        /// Save the current objecto to database
        /// </summary>
        public virtual void Save()
        {
            var baseEntity = this as TObject;
            Debug.Assert(baseEntity != null);//assert that its not violated
            ModelOrm.Set<TObject>().Add(baseEntity);
            ModelOrm.SaveChanges();            
        }

        #endregion

        public virtual void Dispose()
        {
            ModelOrm?.Dispose();
        }
    }

}
