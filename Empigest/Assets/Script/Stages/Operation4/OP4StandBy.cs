using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Operation4
{
    public class OP4StandBy : Stage
    {

        public override void Init()
        {

        }

        public override void CheckExit()
        {

        }

        public override void StageUpdate()
        {
            if(GameManager.Instance.Operation4.isContentReady
                && !GameManager.Instance.Operation4.isStoring)
            {
                GameManager.Instance.Operation4.isContentReady = false;
                GameManager.Instance.Operation4.isStoring = true;
                GameManager.Instance.Operation4.SCR1600.Play_StoragePallets();
            }
        }
    }
}