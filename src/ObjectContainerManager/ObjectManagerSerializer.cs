using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace DynamicObjectContainerManager
{
    public class ObjectManagerSerializer
    {
        public static void SerializeItem(string fileName, IFormatter formatter, ObjectContainerManager objectToSerialize)
        {
            FileStream s = new FileStream(fileName, FileMode.Create);
            formatter.Serialize(s, objectToSerialize);
            s.Close();
        }


        public static ObjectContainerManager DeserializeItem(string fileName, IFormatter formatter)
        {
            FileStream s = new FileStream(fileName, FileMode.Open);
            ObjectContainerManager t = (ObjectContainerManager)formatter.Deserialize(s);
            return t;
        }
    }
}
