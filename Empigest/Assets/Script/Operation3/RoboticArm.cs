using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Operation3
{
    public class RoboticArm : MonoBehaviour
    {
        public readonly string PickPallet = "Arm_PickPallet";
        public readonly string PickBox = "Arm_PickBox";
        public readonly string Idle = "Arm_Idle";

        public GameObject Pallet;
        public GameObject Box;

        [HideInInspector]
        public Animator Animator;

        public void Init()
        {
            Animator = GetComponent<Animator>();
        }

        public bool CheckEndAnimation()
        {
            if (Animator.GetCurrentAnimatorStateInfo(0).normalizedTime > 1f)
                return true;
            return false;
        }

        public void Play_PickPallet()
        {
            Animator.Play(PickPallet);
        }
        public void Play_PickBox()
        {
            Animator.Play(PickBox);
        }
        public void Play_Idle()
        {
            Animator.Play(Idle);
        }

        public void SetPalletEmpty()
        {
            GameManager.Instance.Operation3.palletStackFull = false;
        }
        public void ChangePusherAnim()
        {
            Elements_Operation3.Pusher.Play_NoBox();
        }
        public void AddBox()
        {
            GameManager.Instance.OperationMisc.Box.AddBox();
        }
        public void HideBox()
        {
            GameManager.Instance.OperationMisc.Pusher.Play_NoBox();
        }
    }
}