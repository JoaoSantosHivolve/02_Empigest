using Operation2;
using Operation3;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Operation3
{
    public class SAC1500 : MonoBehaviour
    {
        public readonly string SAC_Idle = "SAC_Idle";
        public readonly string SAC_CarryBox = "SAC_NewCarryBox";

        [HideInInspector]
        public Animator Animator;

        public void Init()
        {
            Animator = GetComponent<Animator>();
        }

        public void StartTapping()
        {
            Elements_Operation3.TapeMachine.Play_Tapping();
        }

        public void Play_CarryBox()
        {
            Animator.Play(SAC_CarryBox, -1, 0f);
        }
    }
}