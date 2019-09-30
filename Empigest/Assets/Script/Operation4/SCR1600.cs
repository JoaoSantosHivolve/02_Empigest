using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SCR1600 : MonoBehaviour
{
    public readonly string SCR_Wait = "SCR_Wait";
    public readonly string SCR_StoragePallet = "SCR_StoragePallet";

    [HideInInspector]
    public Animator Animator;

    public void Init()
    {
        Animator = GetComponent<Animator>();
    }

    public void HideTapeMachineBox()
    {
        GameManager.Instance.Operation3.TapeMachine.Play_Empty();
    }
    public void SetIsStoringFalse()
    {
        GameManager.Instance.Operation4.isStoring = false;
    }

    public void Play_Wait()
    {
        Animator.Play(SCR_Wait, -1, 0f);
    }
    public void Play_StoragePallets()
    {
        Animator.Play(SCR_StoragePallet);
    }
}
