using UnityEngine;
using Dictionary;

namespace Utilities
{
    public static class Identification
    {
        public static string TypeOfData(string data)
        {
            var typeOfData = JsonUtility.FromJson<TypeIdentification>(data);

            return typeOfData.type;
        }
    }
}