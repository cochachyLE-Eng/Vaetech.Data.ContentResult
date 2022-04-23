using System;

namespace Vaetech.Data.ContentResult.Events
{
    public delegate void EntityEventHandler<T>(object sender, EntityEventArgs<T> e);
    public class EntityEventArgs<T> : EventArgs
    {
        public T Entity { get; set; }
        public EntityEventArgs(T entity) => Entity = entity;
    }
}
