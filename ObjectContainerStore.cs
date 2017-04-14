using System;
using System.Collections.Generic;
namespace ObjectContainerManager
{
    public class ObjectContainerStore:IObjectContainerStore
    {
        private Dictionary<IKey, IObjectContainer> ObjectStorage;

public ObjectContainerStore()
{
    ObjectStorage = new Dictionary<IKey, IObjectContainer>();
}

    public List<IObjectContainer> GetContainersByName(string name)
    {
        List<IObjectContainer> results = new List<IObjectContainer>();
        foreach (var item in ObjectStorage)
        {
            if (item.Key.Name == name)
            {
                results.Add(item.Value);
            }
        }
        return results;
    }

        public IObjectContainer GetContainer(IKey key)
        {
return ObjectStorage[key];
        }

     public bool DoesContainerExist(IObjectContainer container)
     {
if (ObjectStorage.ContainsKey(container.MyKey) && ObjectStorage.ContainsValue(container))
{
    return true;
}
return false;
     }

     public void Add(IObjectContainer container)
     {
ObjectStorage.Add(container.MyKey, container);
     }

     public void DeleteContainersByName(string name)
     {
         List<IKey> toBeDeleted = new List<IKey>();
foreach (var container in ObjectStorage)
{
    if (container.Key.Name == name)
    {
        toBeDeleted.Add(container.Key);
    }
}
foreach (var key in toBeDeleted)
{
    DeleteContainer(key);
}
     }

     public void DeleteContainer(IKey key)
     {
ObjectStorage.Remove(key);
     }
    }
}
