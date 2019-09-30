using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Operation1
{
    public class EmptyBoxTransportation : Stage
    {
        public override void Init()
        {
            Debug.Log("Starting EmptyBoxTransportation");
            // SQM90 Back to the beggining
            Elements_Operation1.SQM90.MoveToNextDestination();
        }
        public override void CheckExit()
        {
            if (Elements_Operation1.SQM90.CheckDestinationArrival())
                LeaveStage(Stages_Operation1.BoxFilling);
        }

        public override void StageUpdate()
        {

        }
    }
}