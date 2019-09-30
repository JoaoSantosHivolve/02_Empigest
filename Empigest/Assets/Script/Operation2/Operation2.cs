using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Operation2
{
    public class Operation2 : Operation
    {
        [Header("Machine that fills the pallet pile")]
        public SAC1500_Pallet SAC1500;


        private void Start()
        {
            SAC1500.Init();

            // Init all Stages of this operation
            Stage = Stages_Operation2.OP2StandBy;
            Stage.Init();
        }



        private void FixedUpdate()
        {
            if(!GameManager.Instance.Operation3.palletStackFull)
            {
                if (SAC1500.Animator.GetCurrentAnimatorClipInfo(0).Length > 0)
                {
                    if(SAC1500.Animator.GetCurrentAnimatorClipInfo(0)[0].clip.name == "SACP_Wait")
                    {
                        SAC1500.Play_StackPallets();
                        StartCoroutine(SetPalletFull());
                    }
                }
            }
            else
            {
                if (SAC1500.Animator.GetCurrentAnimatorClipInfo(0).Length > 0)
                {
                    if (SAC1500.Animator.GetCurrentAnimatorClipInfo(0)[0].clip.name == "SACP_Wait")
                    {
                        SAC1500.Play_StackPallets_Misc();
                    }
                }
            }
        }

        IEnumerator SetPalletFull()
        {
            yield return new WaitForSeconds(8f);
            GameManager.Instance.Operation3.palletStackFull = true;
        }
    }
}
