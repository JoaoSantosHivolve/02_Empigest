using Generics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxCarrier : Agent
{
    private Animator Anim;
    private bool state = false;

    private readonly string Man_Walk = "Man_Walk";
    private readonly string Man_PickBox = "Man_PickBox";
    private readonly string Man_CarryBox = "Man_CarryBox";
    private readonly string Man_DropBox = "Man_DropBox";

    public bool hasArrived = false;
    private bool hasInteractedWithBox = false;
    [Header("Box the human carries")]
    public GameObject Box;

    public void Init()
    {
        Anim = GetComponent<Animator>();
        MoveToNextDestination();
    }

    // Update is called once per frame
    void Update()
    {
        if(CheckDestinationArrival())
        {
            if(!hasArrived)
            {
                state = !state;
                hasArrived = true;
                Anim.SetBool("hasBox", state);
            }
            if (Anim.GetCurrentAnimatorClipInfo(0).Length > 0)
            {
                if (Anim.GetCurrentAnimatorClipInfo(0)[0].clip.name == Man_PickBox
                    || Anim.GetCurrentAnimatorClipInfo(0)[0].clip.name == Man_DropBox)
                {
                    if (Anim.GetCurrentAnimatorStateInfo(0).normalizedTime > 0.8f)
                    {
                        hasArrived = false;
                        MoveToNextDestination();
                        hasInteractedWithBox = false;
                    }

                    if(!hasInteractedWithBox)
                    {
                        if(Anim.GetCurrentAnimatorClipInfo(0)[0].clip.name == Man_DropBox
                            && Anim.GetCurrentAnimatorStateInfo(0).normalizedTime > 0.6f)
                        {
                            hasInteractedWithBox = true;
                            Box.SetActive(false);
                            StartCoroutine(ReadyContent());
                            GameManager.Instance.OperationMisc.Pusher.Play_MovingBox();
                        }

                        if (Anim.GetCurrentAnimatorClipInfo(0)[0].clip.name == Man_PickBox
                            && Anim.GetCurrentAnimatorStateInfo(0).normalizedTime > 0.35f)
                        {
                            hasInteractedWithBox = true;
                            Box.SetActive(true);
                        }
                    }
                }
            }
        }
    }

    IEnumerator ReadyContent()
    {
        yield return new WaitForSeconds(4.9f);
        GameManager.Instance.OperationMisc.isReady = true;
    }
}
