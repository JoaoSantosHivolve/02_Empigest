using Operation3;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Operation3
{
    public class OP3StandBy : Stage
    {
        public override void CheckExit()
        {
            if (!GameManager.Instance.Operation3.hasPallet 
                && !GameManager.Instance.Operation3.palletReady
                && GameManager.Instance.Operation3.palletStackFull)
            {
                LeaveStage(Stages_Operation3.ArmPickUpPallet);
            }

            if (GameManager.Instance.Operation3.hasPallet 
                && GameManager.Instance.Operation3.hasBox)
            {
                LeaveStage(Stages_Operation3.ArmPickUpBox);
            }

            if(GameManager.Instance.Operation3.canMove)
            {
                LeaveStage(Stages_Operation3.PusherTransport);
            }
        }

        public override void Init()
        {

        }
        public override void StageUpdate()
        {

        }


      
    }
}
