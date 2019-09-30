using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Operation1
{
    public class BoxFilling : Stage
    {
        public override void Init()
        {
            Debug.Log("Starting BoxFilling");
            Elements_Operation1.BoxFiller.Animator.Play(Elements_Operation1.BoxFiller.Anim_Pick);

            // Show Box Again
            Elements_Operation1.Box.gameObject.SetActive(true);
            Elements_Operation1.Box.Init();
        }

        public override void StageUpdate()
        {
            if (Elements_Operation1.BoxFiller.CheckEndAnimation())
                Elements_Operation1.Box.AddContent();
        }

        public override void CheckExit()
        {
            if(Elements_Operation1.Box.CheckIfFull())
            {
                LeaveStage(Stages_Operation1.DodgeEvent);
            }
        }
    }

}
