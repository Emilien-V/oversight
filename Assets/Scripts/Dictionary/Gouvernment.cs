using UnityEngine.Playables;

namespace Dictionary
{
    [System.Serializable]
    public class Gouvernment
    {
        public string type;
        public int score;
        public GouvernmentNotification notification;
    }

    [System.Serializable]
    public class GouvernmentNotification
    {
        public int value;
        public string label;
    }
}