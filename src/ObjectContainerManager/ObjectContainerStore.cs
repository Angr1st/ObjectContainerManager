using System;
using System.Collections.Generic;
namespace DynamicObjectContainerManager
{
    [Serializable]
    public class ObjectContainerStore : IObjectContainerStore
    {
        private Dictionary<IKey, IObjectContainer> ObjectStorage;

        public ObjectContainerStore()
        {
            ObjectStorage = new Dictionary<IKey, IObjectContainer>();
        }

        public List<IObjectContainer> GetContainersByName(string name)
        {
            return GetContainersBy((x) => x.Name == name ? true : false);
        }

        public List<IObjectContainer> GetContainersByType(Type type)
        {
            return GetContainersBy((x) => x.ObjectType == type ? true : false);
        }

        private List<IObjectContainer> GetContainersBy(Func<IKey, bool> searchExpression)
        {
            List<IObjectContainer> results = new List<IObjectContainer>();
            foreach (var item in ObjectStorage)
            {
                if (searchExpression.Invoke(item.Key))
                {
                    results.Add(item.Value);
                }
            }
            return results;
        }

        public IObjectContainer GetContainer(IKey key)
        {
            if (key.IsSearchKey)
            {
                return GetContainersByName(key.Name)[0];
            }
            else
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

        private List<IKey> GetListOfKeysBy(Func<IKey, bool> searchExpression)
        {
            List<IKey> KeyList = new List<IKey>();
            foreach (var container in ObjectStorage)
            {
                if (searchExpression.Invoke(container.Key))
                {
                    KeyList.Add(container.Key);
                }
            }
            return KeyList;
        }

        private void DeleteContainersBy(Func<IKey, bool> searchExpression)
        {
            foreach (var key in GetListOfKeysBy(searchExpression))
            {
                DeleteContainer(key);
            }
        }


        public void DeleteContainersByType(Type type)
        {
            DeleteContainersBy((x) => x.ObjectType == type ? true : false);
        }

        public void DeleteContainersByName(string name)
        {
            DeleteContainersBy((x) => x.Name == name ? true : false);
        }

        public void DeleteContainer(IKey key)
        {
            ObjectStorage.Remove(key);
        }
    }
}
