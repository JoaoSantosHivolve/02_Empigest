using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Stage : MonoBehaviour
{
    [HideInInspector] public Operation Operation;
    public abstract void Init();
    public abstract void StageUpdate();
    public abstract void CheckExit();

    public void LeaveStage(Stage stage)
    {
        stage.Init();
        Operation.Stage = stage;
    }
}