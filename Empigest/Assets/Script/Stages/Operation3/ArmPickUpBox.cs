using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Operation3
{
    public class ArmPickUpBox : Stage
    {
        public override void CheckExit()
        {
            if (Elements_Operation3.RoboticArm.CheckEndAnimation())
            {
                LeaveStage(Stages_Operation3.OP3StandBy);
            }
        }

        public override void Init()
        {
            Debug.Log("OP3 - ArmPickUpBox");
            Elements_Operation3.RoboticArm.Play_PickBox();
            StartCoroutine(StartPalletAnimation());
        }

        public override void StageUpdate()
        {

        }

        IEnumerator StartPalletAnimation()
        {
            yield return new WaitForSeconds(3.25f);
            GameManager.Instance.Operation3.palletReady = true;
            GameManager.Instance.Operation3.hasBox = false;
            GameManager.Instance.Operation3.hasPallet = false;
            GameManager.Instance.Operation3.Pallet.GetComponent<Animator>().Play("PalletMoving");
        }

       
    }
}