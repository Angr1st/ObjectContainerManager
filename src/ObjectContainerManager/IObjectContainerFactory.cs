using System;
using System.Collections.Generic;
namespace DynamicObjectContainerManager
{
    public interface IObjectContainerFactory
    {
        IObjectContainer CreateContainer(object leObjectToBePutIntoContainer, IKey key);
    }
}
