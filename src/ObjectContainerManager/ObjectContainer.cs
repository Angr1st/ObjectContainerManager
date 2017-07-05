using System;
using System.Collections.Generic;
namespace DynamicObjectContainerManager
{
    [Serializable]
    public class ObjectContainer : IObjectContainer
    {
        private IKey _key;
        private Object _object;
        public IKey MyKey
        {
            get
            {
                return _key;
            }
        }

        public Object MyObject
        {
            get
            {
                return _object;
            }
        }
        public ObjectContainer(Object leObject, IKey myKey)
        {
            _object = leObject;
            _key = myKey;
        }
    }
}
