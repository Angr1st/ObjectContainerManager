using System;

namespace DynamicObjectContainerManager
{
    [Serializable]
    public class Key : IKey
    {
        private string _name;
        private int _number;
        private Type _type;
        public Key(string name, Type type, int number)
        {
            _number = number;
            _name = name;
            _type = type;
        }

        public string Name
        {
            get
            {
                return _name;
            }
        }
        public Type ObjectType
        {
            get
            {
                return _type;
            }
        }
        public int Number
        {
            get
            {
                return _number;
            }
        }

        public bool IsSearchKey
        {
            get
            {
                if (_number == -1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

    }
}
