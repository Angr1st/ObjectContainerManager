using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DynamicObjectContainerManager
{
    public interface IObjectContainerManager
    {
        IObjectContainerStore ObjectContainerStore
        {
            get;
        }

        IObjectContainerFactory ObjectContainerFactory
        {
            get;
        }

        IKeyFactory KeyFactory
        {
            get;
        }


        void AddToContainer(object LeObject, Type LeObjectConcreteType, string LeObjectsName);

        void DeleteContainer(IKey key);

        IObjectContainer GetObjectContainer(IKey key);
    }
}
