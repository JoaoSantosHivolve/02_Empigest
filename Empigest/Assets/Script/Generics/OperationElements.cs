using UnityEngine;
using UnityEngine.AI;

namespace Operation1
{
    public static class Elements_Operation1
    {
        // - SQM90
        public static SQM90Controller SQM90 =
            GameManager.Instance.Operation1.SQM90;

        // - Box
        public static FillBox Box =
            GameManager.Instance.Operation1.Box;
        // - Closed Box
        public static GameObject ClosedBox =
            GameManager.Instance.Operation1.ClosedBox;

        // - Man Box Filler
        public static HumanBoxFillerController BoxFiller =
            GameManager.Instance.Operation1.BoxFiller;
        // - Shelf
        public static Transform Shelf =
            GameManager.Instance.Operation1.Shelf;
        // - Obstacle
        public static NavMeshObstacle Obstacle =
            GameManager.Instance.Operation1.Obstacle;

        // - Man Box Picker
        public static HumanBoxPickerController BoxPicker =
            GameManager.Instance.Operation1.BoxPicker;
        // - Rolling Carpet
        public static Transform RollingCarpet =
            GameManager.Instance.Operation1.RollingCarpet;
    }
}

namespace Operation2
{
    public static class Elements_Operation2
    {
        // - SAC1500 Pallet
        public static SAC1500_Pallet SAC1500 =
            GameManager.Instance.Operation2.SAC1500;
    }
}

namespace Operation3
{
    public static class Elements_Operation3
    {
        // - Robotic Arm
        public static RoboticArm RoboticArm =
            GameManager.Instance.Operation3.RoboticArm;

        // - Pusher
        public static Pusher Pusher =
            GameManager.Instance.Operation3.Pusher;

        // - Tape Machine
        public static TapeMachine TapeMachine =
            GameManager.Instance.Operation3.TapeMachine;

        public static bool HasBox =
            GameManager.Instance.Operation3.hasBox;
        public static bool HasPallet =
            GameManager.Instance.Operation3.hasPallet;
    }
}

namespace Operation4
{
    public static class Elements_Operation4
    {
        // - SAC1500 Pallet
        public static SCR1600 SCR1600 =
            GameManager.Instance.Operation4.SCR1600;
    }
}