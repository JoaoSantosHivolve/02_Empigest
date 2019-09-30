using Operation3;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OperationMisc : MonoBehaviour
{
    public RoboticArm Arm;
    public Pusher Pusher;
    public BoxCarrier BoxCarrier;

    public bool isReady;

    [Header("Box that slowly fills on a loop")]
    public MiscFillingBox Box;


    private void Start()
    {
        Arm.Init();
        Pusher.Init();
        BoxCarrier.Init();
    }

    // Update is called once per frame
    void Update()
    {
        if (Arm.Animator.GetCurrentAnimatorClipInfo(0).Length > 0
            && Arm.Animator.GetCurrentAnimatorClipInfo(0)[0].clip.name == "Arm_Idle 1"
            && isReady)
        {
            isReady = false;
            Arm.Play_PickBox();
        }
    }
}
