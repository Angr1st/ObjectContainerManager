using System;

namespace ObjectContainerManager
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
    }
}
