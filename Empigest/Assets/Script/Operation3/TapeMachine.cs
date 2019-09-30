using UnityEngine;

public class TapeMachine : MonoBehaviour
{
    public readonly string Tape_Empty = "Tape_Empty";
    public readonly string Tape_Tapping = "Tape_Tapping";
    public readonly string Tape_Ready = "Tape_Ready";

    [HideInInspector]
    public Animator Animator;

    public void Init()
    {
        Animator = GetComponent<Animator>();
    }

    public void SetContentReady()
    {
        GameManager.Instance.Operation4.isContentReady = true;
    }

    public void Play_Empty()
    {
        Animator.Play(Tape_Empty, -1, 0f);
    }
    public void Play_Tapping()
    {
        Animator.Play(Tape_Tapping, -1, 0f);
    }
    public void Play_Ready()
    {
        Animator.Play(Tape_Ready, -1, 0f);
    }
}
