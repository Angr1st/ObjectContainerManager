using System;
using System.Collections.Generic;
namespace ObjectContainerManager
{
    public interface IObjectContainerFactory
    {
IObjectContainer CreateContainer(object leObjectToBePutIntoContainer, Type leObjectsType, string leName, IKeyFactory keyGenerator);
    }
}
