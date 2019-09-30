using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Operation3
{
    public class ArmPickUpPallet : Stage
    {
        private readonly float timeTillPalletAppears = 3.2f;

        public override void Init()
        {
            Debug.Log("OP3 - ArmPickUpPallet");
            Elements_Operation3.RoboticArm.Play_PickPallet();
            StartCoroutine(ShowPallet());
        }

        public override void StageUpdate()
        {

        }

        public override void CheckExit()
        {
            if(Elements_Operation3.RoboticArm.CheckEndAnimation())
            {
                Elements_Operation3.RoboticArm.Play_Idle();
                LeaveStage(Stages_Operation3.OP3StandBy);
            }
        }

        IEnumerator ShowPallet()
        {
            yield return new WaitForSeconds(timeTillPalletAppears);
            GameManager.Instance.Operation3.hasPallet = true;
            GameManager.Instance.Operation3.palletStackFull = false;
        }
    }
}
