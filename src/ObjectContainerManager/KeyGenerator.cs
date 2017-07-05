using System;

namespace DynamicObjectContainerManager
{
    [Serializable]
    public class KeyGenerator : IKeyFactory
    {
        private int _objectCounter = 0;

        private int ObjectCounter
        {
            get
            {
                _objectCounter++;
                return _objectCounter - 1;
            }
        }
        public IKey CreateKey(Type LeObjectConcreteType, string LeObjectsName)
        {
            return new Key(LeObjectsName, LeObjectConcreteType, ObjectCounter);
        }

        public IKey CreateSearchKey(string LeObjectName)
        {
            return new Key(LeObjectName, null, -1);
        }
    }
}
