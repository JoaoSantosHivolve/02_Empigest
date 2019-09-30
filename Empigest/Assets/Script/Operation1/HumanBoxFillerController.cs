using Generics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace Operation1
{
    public class HumanBoxFillerController : Agent
    {
        public readonly string Anim_Pick = "Man_Pick";
        public readonly string Anim_Drop = "Man_Drop";
        public readonly string Anim_Walk = "Man_Walk";
        public readonly string Anim_Idle = "Man_Idle";
        public readonly string Anim_Phone = "Man_Phone";

        [HideInInspector]
        public Animator Animator;
        public GameObject Object;
        public GameObject CellPhone;

        public void Init()
        {
            if(Animator == null)
                Animator = GetComponent<Animator>();
        }

        public void SetCellPhone(bool v)
        {
            CellPhone.SetActive(v);
        }

        public bool CheckEndAnimation()
        {
            if (Animator.GetCurrentAnimatorClipInfo(0).Length > 0)
            {
                if (Animator.GetCurrentAnimatorClipInfo(0)[0].clip.name == Anim_Drop)
                {
                    //Rotates Towards Box
                    RotateTowards(Elements_Operation1.Box.transform);

                    if (Animator.GetCurrentAnimatorStateInfo(0).normalizedTime > 0.6f)
                    {
                        Object.SetActive(false);
                    }

                    if (Animator.GetCurrentAnimatorStateInfo(0).normalizedTime > 1)
                    {
                        Animator.Play(Anim_Pick, -1, 0f);
                        return true;
                    }
                }
                else
                {
                    // Rotates towards shelf
                    RotateTowards(Elements_Operation1.Shelf);

                    if (Animator.GetCurrentAnimatorStateInfo(0).normalizedTime > 0.5f)
                    {
                        Object.SetActive(true);
                    }
                }
            }
            return false;
        }
    }
}