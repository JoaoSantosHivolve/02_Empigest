namespace Operation1
{
    public static class Stages_Operation1
    {
        public static BoxFilling BoxFilling =
            GameManager.Instance.Operation1.transform.Find("Stages")
                .GetComponent<BoxFilling>();
        public static DodgeEvent DodgeEvent =
            GameManager.Instance.Operation1.transform.Find("Stages")
                .GetComponent<DodgeEvent>();
        public static FullBoxTransportation FullBoxTransportation =
            GameManager.Instance.Operation1.transform.Find("Stages")
                .GetComponent<FullBoxTransportation>();
        public static BoxPlacement BoxPlacement =
            GameManager.Instance.Operation1.transform.Find("Stages")
                .GetComponent<BoxPlacement>();
        public static EmptyBoxTransportation EmptyBoxTransportation =
            GameManager.Instance.Operation1.transform.Find("Stages")
                .GetComponent<EmptyBoxTransportation>();
    }
}
namespace Operation2
{
    public static class Stages_Operation2
    {
        public static OP2StandBy OP2StandBy =
            GameManager.Instance.Operation2.transform.Find("Stages")
                .GetComponent<OP2StandBy>();
       
    }
}
namespace Operation3
{
    public static class Stages_Operation3
    {
        public static OP3StandBy OP3StandBy =
            GameManager.Instance.Operation3.transform.Find("Stages")
                .GetComponent<OP3StandBy>();
        public static PusherTransport PusherTransport =
            GameManager.Instance.Operation3.transform.Find("Stages")
                .GetComponent<PusherTransport>();
        public static ArmPickUpBox ArmPickUpBox =
            GameManager.Instance.Operation3.transform.Find("Stages")
                .GetComponent<ArmPickUpBox>();
        public static ArmPickUpPallet ArmPickUpPallet =
            GameManager.Instance.Operation3.transform.Find("Stages")
                .GetComponent<ArmPickUpPallet>();
    }
}

namespace Operation4
{
    public static class Stages_Operation4
    {
        public static OP4StandBy OP4StandBy =
            GameManager.Instance.Operation4.transform.Find("Stages")
                .GetComponent<OP4StandBy>();

    }
}