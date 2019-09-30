using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pusher : MonoBehaviour
{
    public readonly string Pusher_MovingBox = "Pusher_MovingBox";
    public readonly string Pusher_NoBox = "Pusher_NoBox";
    public readonly string Pusher_WBox = "Pusher_WBox";

    [HideInInspector]
    public Animator Animator;

    public void Init()
    {
        Animator = GetComponent<Animator>();
        //Play_WBox();
    }

    public bool CheckEndAnimation()
    {
        if (Animator.GetCurrentAnimatorStateInfo(0).normalizedTime > 1f)
            return true;
        return false;
    }

    public void Play_MovingBox()
    {
        Animator.Play(Pusher_MovingBox);
    }
    public void Play_NoBox()
    {
        Animator.Play(Pusher_NoBox);
    }
    public void Play_WBox()
    {
        Animator.Play(Pusher_WBox);
    }
}
