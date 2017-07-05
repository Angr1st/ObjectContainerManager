using System;
using System.Collections.Generic;
namespace DynamicObjectContainerManager
{
    [Serializable]
    public class ObjectContainerFactory : IObjectContainerFactory
    {
        public IObjectContainer CreateContainer(object leObject, IKey key)
        {
            return new ObjectContainer(leObject, key);
        }
    }
}
