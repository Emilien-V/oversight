using UnityEngine;
using Dictionary;

namespace Utilities
{
    public static class GetData
    {
        private static Gouvernment _gouvernment;
        public static string TypeOfData(string data)
        {
            var typeOfData = JsonUtility.FromJson<TypeIdentification>(data);

            return typeOfData.type;
        }

        public static object GouvernmentData(string data)
        {
            var gouvernmentData = JsonUtility.FromJson<Gouvernment>(data);
            gouvernmentData.notification =
                JsonUtility.FromJson<GouvernmentNotification>(Convert.ObjectToString(gouvernmentData.notification));

            return gouvernmentData;
        }
    }
}