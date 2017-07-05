using System;
using System.Runtime.Serialization;

// This project can output the Class library as a NuGet Package.
// To enable this option, right-click on the project and select the Properties menu item. In the Build tab select "Produce outputs on build".
namespace DynamicObjectContainerManager
{
    [Serializable]
    public class ObjectContainerManager : IObjectContainerManager, ISerializable
    {
        private IObjectContainerStore _objectContainerStore;
        private IObjectContainerFactory _objectContainerFactory;
        private IKeyFactory _keyFactory;

        public IObjectContainerStore ObjectContainerStore
        {
            get
            {
                return _objectContainerStore;
            }
        }

        public IObjectContainerFactory ObjectContainerFactory
        {
            get
            {
                return _objectContainerFactory;
            }
        }

        public IKeyFactory KeyFactory
        {
            get
            {
                return _keyFactory;
            }
        }

        public ObjectContainerManager(IObjectContainerStore objectContainerStore, IObjectContainerFactory objectContainerFactory, IKeyFactory keyFactory)
        {
            _objectContainerStore = objectContainerStore;
            _objectContainerFactory = objectContainerFactory;
            _keyFactory = keyFactory;
        }

        public ObjectContainerManager(SerializationInfo info, StreamingContext context)
        {
            _objectContainerStore = (ObjectContainerStore)info.GetValue("objectContainerStore", typeof(ObjectContainerStore));
            _objectContainerFactory = (ObjectContainerFactory)info.GetValue("objectContainerFactory", typeof(ObjectContainerFactory));
            _keyFactory = (KeyGenerator)info.GetValue("keyfactory", typeof(KeyGenerator));
        }

        public void AddToContainer(object LeObject, Type LeObjectConcreteType, string LeObjectsName)
        {
            _objectContainerStore.Add(_objectContainerFactory.CreateContainer(LeObject, _keyFactory.CreateKey(LeObjectConcreteType, LeObjectsName)));
        }


        public void DeleteContainer(IKey key)
        {
            _objectContainerStore.DeleteContainer(key);
        }

        public IObjectContainer GetObjectContainer(IKey key)
        {
            return _objectContainerStore.GetContainer(key);
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("objectContainerStore", ObjectContainerStore, typeof(ObjectContainerStore));
            info.AddValue("objectContainerFactory", ObjectContainerFactory, typeof(ObjectContainerFactory));
            info.AddValue("keyfactory", KeyFactory, typeof(KeyGenerator));
        }
    }
}
