using System;
using System.Collections.Generic;
namespace ObjectContainerManager
{
    public class ObjectContainerFactory:IObjectContainerFactory
    {
        public IObjectContainer CreateContainer(object leObject, Type leObjectsType, string leName, IKeyFactory keyGenerator)
        {
            return new ObjectContainer(leObject, keyGenerator.CreateKey(leObject, leObjectsType,leName));
        }
    }
}
