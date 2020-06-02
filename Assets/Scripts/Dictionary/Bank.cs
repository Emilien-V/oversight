namespace Dictionary
{
    [System.Serializable]
    public class Bank
    {
        public string type;
        public int money;
        public BankNotification notification;
    }

    [System.Serializable]
    public class BankNotification
    {
        public string deal;
        public int value;
        public string label;
    }
}