using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Operation4
{
    public class Operation4 : Operation
    {
        [Header("Machine that storages the pallets")]
        public SCR1600 SCR1600;

        [Header("State of the operation")]
        public bool isContentReady;
        public bool isStoring;

        private void Start()
        {
            SCR1600.Init();

            // Init all Stages of this operation
            Stage = Stages_Operation4.OP4StandBy;
            Stage.Init();
        }
    }
}
