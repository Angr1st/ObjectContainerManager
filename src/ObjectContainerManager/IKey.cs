using System;

namespace DynamicObjectContainerManager
{
    public interface IKey
    {
         string Name
        {
            get;
        }
         Type ObjectType
         {
             get;
         }
          int Number
          {
              get;
          }

        bool IsSearchKey
        {
            get;
        }
    }
}
