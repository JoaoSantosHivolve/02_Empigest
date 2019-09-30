using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SAC1500_Pallet : MonoBehaviour
{
    public readonly string SACP_Wait = "SACP_Wait";
    public readonly string SACP_StackPallets = "SACP_StackPallets";
    public readonly string SACP_StackPallets_Misc = "SACP_StackPallets_Misc";

    [HideInInspector]
    public Animator Animator;

    public void Init()
    {
        Animator = GetComponent<Animator>();
    }

    public void Play_Wait()
    {
        Animator.Play(SACP_Wait, -1, 0f);
    }
    public void Play_StackPallets()
    {
        Animator.Play(SACP_StackPallets, -1, 0f);
    }
    public void Play_StackPallets_Misc()
    {
        Animator.Play(SACP_StackPallets_Misc, -1, 0f);
    }
}
