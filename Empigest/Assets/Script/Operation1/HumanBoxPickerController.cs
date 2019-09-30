using Generics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Operation1
{
    public class HumanBoxPickerController : Agent
    {
        public readonly string Anim_Idle = "Man_Idle";
        public readonly string Anim_PickBox = "Man_PickBox";
        public readonly string Anim_DropBox = "Man_DropBox";

        [HideInInspector]
        public Animator Animator;
        public GameObject Object;

        public void Init()
        {
            if (Animator == null)
                Animator = GetComponent<Animator>();
        }


        public bool CheckEndAnimation()
        {
            if (Animator.GetCurrentAnimatorClipInfo(0).Length > 0)
            {
                if (Animator.GetCurrentAnimatorClipInfo(0)[0].clip.name == Anim_DropBox)
                {
                    //Rotates Towards Box
                    RotateTowards(Elements_Operation1.RollingCarpet);

                    if (Animator.GetCurrentAnimatorStateInfo(0).normalizedTime > 0.5f)
                    {
                        //Animator.Play(Anim_Idle);
                        Object.SetActive(false);
                        return true;
                    }
                }
                else
                {
                    // Rotates towards shelf
                    RotateTowards(Elements_Operation1.Box.transform);

                    if (Animator.GetCurrentAnimatorStateInfo(0).normalizedTime > 0.5f)
                    {
                        Object.SetActive(true);
                        Elements_Operation1.ClosedBox.SetActive(false);
                    }
                }
            }

            return false;
        }
    }
}