using System;
using System.Collections.Generic;
namespace DynamicObjectContainerManager
{
    public interface IObjectContainerStore
    {
        IObjectContainer GetContainer(IKey key);
        bool DoesContainerExist(IObjectContainer container);
        void Add(IObjectContainer container);
        void DeleteContainer(IKey key);
    }
}
