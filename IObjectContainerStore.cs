using System;
using System.Collections.Generic;
namespace ObjectContainerManager
{
    public interface IObjectContainerStore
    {
     List<IObjectContainer> GetContainersByName(string name);
     IObjectContainer GetContainer(IKey key);
     bool DoesContainerExist(IObjectContainer container);
     void Add(IObjectContainer container);
     void DeleteContainersByName(string name);
     void DeleteContainer(IKey key);
    }
}
