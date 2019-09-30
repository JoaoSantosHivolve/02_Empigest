using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Operation1
{
    public class FullBoxTransportation : Stage
    {
        public override void Init()
        {
            Debug.Log("Starting FullBoxTransportation");
            Elements_Operation1.SQM90.MoveToNextDestination();
        }

        public override void StageUpdate()
        {

        }

        public override void CheckExit()
        {
            if (!GameManager.Instance.Operation3.palletReady)
            {
                if (Elements_Operation1.SQM90.CheckDestinationArrival())
                {
                    LeaveStage(Stages_Operation1.BoxPlacement);
                }
            }
        }
    }
}