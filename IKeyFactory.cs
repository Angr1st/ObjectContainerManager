using System;

namespace ObjectContainerManager
{
    public interface IKeyFactory
    {
        IKey CreateKey(object LeObject,Type LeObjectConcreteType, string LeObjectsName);
    }
}
