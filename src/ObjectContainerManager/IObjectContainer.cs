using System;
using System.Collections.Generic;
namespace DynamicObjectContainerManager
{
    public interface IObjectContainer
    {
        IKey MyKey
        {
            get;
        }

        Object MyObject
        {
            get;
        }


    }
}
