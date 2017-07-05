using System;

namespace DynamicObjectContainerManager
{
    public interface IKeyFactory
    {
        IKey CreateKey(Type LeObjectConcreteType, string LeObjectsName);
        IKey CreateSearchKey(string LeObjectName);
    }
}
