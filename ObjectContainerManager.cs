using System;

namespace ObjectContainerManager
{
    public class ObjectContainerManager
    {
private IObjectContainerStore ObjectContainerStore;
private IObjectContainerFactory ObjectContainerFactory;
private IKeyFactory KeyFactory;

        public ObjectContainerManager(IObjectContainerStore objectContainerStore, IObjectContainerFactory objectContainerFactory, IKeyFactory keyFactory)
        {
            ObjectContainerStore = objectContainerStore;
            ObjectContainerFactory = objectContainerFactory;
            KeyFactory = keyFactory;
        }

        public void AddContainer(IObjectContainer container )
        {
            ObjectContainerStore.Add(container);
        }

public void DeleteContainer(IKey key)
{
    ObjectContainerStore.DeleteContainer(key);
}

        public void DeleteContainersByName(string name)
        {
            ObjectContainerStore.DeleteContainersByName(name);
        }

    }
}
