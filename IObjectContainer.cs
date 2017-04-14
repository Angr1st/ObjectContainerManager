using System;
using System.Collections.Generic;
namespace ObjectContainerManager
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
