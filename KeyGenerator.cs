using System;

namespace ObjectContainerManager
{
    public class KeyGenerator:IKeyFactory
    {
        private int _objectCounter = 0;

        private int ObjectCounter
        {
get
{
_objectCounter++;
return _objectCounter-1;
}
        }
        public IKey CreateKey(object LeObject,Type LeObjectConcreteType, string LeObjectsName)
        {
            return new Key(LeObjectsName, LeObjectConcreteType, ObjectCounter);
        }
    }
}
