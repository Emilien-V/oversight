using UnityEngine;

namespace Utilities
{
    public static class Convert
    {
        private static object _json;
        private static string _jsonString;

        public static string ObjectToString(object data)
        {
            _json = new JSONObject(JsonUtility.ToJson(data));
            _jsonString = _json.ToString();

            return _jsonString;
        }

        public static object ObjectToJson(object data)
        {
            _json = new JSONObject(JsonUtility.ToJson(data));

            return _json;
        }
    }
}