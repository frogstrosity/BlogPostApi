using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogPostApi.Models;

namespace BlogPostApi.Data.Static
{
    public class StaticDataRepository<TEntity> : IRepository<TEntity> where TEntity : class, IEntity
    {
        public Task<TEntity> Add(TEntity entity)
        {
            throw new System.NotImplementedException();
        }

        public Task<TEntity> Delete(Guid id)
        {
            throw new System.NotImplementedException();
        }

        public Task<TEntity> Get(Guid id)
        {
            if(typeof(TEntity) == typeof(Post))
            {
                return Task.FromResult(Posts.FirstOrDefault(x => x.Id == id));
            }
            else
            {
                throw new System.NotImplementedException();
            }
        }

        public Task<List<TEntity>> GetAll()
        {
            Console.WriteLine(typeof(TEntity));

            if(typeof(TEntity) == typeof(Post))
            {
                //move to in memory data store
                return Task.FromResult(Posts);
            }
            else
            {
                throw new System.NotImplementedException();
            }
        }

        public Task<TEntity> Update(TEntity entity)
        {
            throw new System.NotImplementedException();
        }

        private static readonly List<TEntity> Posts = new List<TEntity>()
        {
            new Post() 
            { 
                Id = Guid.NewGuid(),
                Title = "How (not) to Blog",
                Tagline = "There are a lot of good reasons to blog, this is not one of them",
                Text = "If I learn to create my own blog and write about that I might fulfill both these goals. It also might just end up being a monstrosity. Either way I hope to learn someting on the way",
                AdditionalInfo = "lorem ipsum. Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."
            } as TEntity,
            new Post() 
            { 
                Id = Guid.NewGuid(),
                Title = "How (not) to Learn React",
                Tagline = "doing the frontends",
                Text = "adding basic static layout using components",
                AdditionalInfo = "lorem ipsum. Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."
            } as TEntity,

        };

    }
}
