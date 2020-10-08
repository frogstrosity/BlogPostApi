using System;

namespace BlogPostApi.Data
{
    public interface IEntity
    {
        Guid Id { get; set; }
    }
}