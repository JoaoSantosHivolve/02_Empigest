using Operation3;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PusherTransport : Stage
{

    public override void Init()
    {
        Elements_Operation3.Pusher.Play_MovingBox();
    }

    public override void StageUpdate()
    {
    }

    public override void CheckExit()
    {
        if(Elements_Operation3.Pusher.CheckEndAnimation())
        {
            GameManager.Instance.Operation3.hasBox = true;
            GameManager.Instance.Operation3.canMove = false;
            Elements_Operation3.Pusher.Play_WBox();
            LeaveStage(Stages_Operation3.OP3StandBy);
        }
    }
}
