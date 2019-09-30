using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Operation : MonoBehaviour
{
    [Header("Current Stage")]
    public Stage Stage;
    public Action Act;


    private void Awake()
    {
        InitStages();
    }

    public void Update()
    {
        Stage.StageUpdate();
        Stage.CheckExit();
    }

    private void InitStages()
    {
        foreach (Stage stage in transform.Find("Stages").GetComponents<Stage>())
        {
            stage.Operation = this;
        }
    }
}
