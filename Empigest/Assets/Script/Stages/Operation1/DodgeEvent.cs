using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Operation1
{
    public class DodgeEvent : Stage
    {
        private float time = 0;
        private readonly float waitingTime = 6;
        private bool isInPosition = false;

        public override void Init()
        {
            Debug.Log("Starting DodgeEvent");
            // -> Reset SQM90 verification
            isInPosition = false;

            // -> Change box appearance
            Elements_Operation1.Box.gameObject.SetActive(false);
            Elements_Operation1.ClosedBox.SetActive(true);

            // -> Change Human Animation
            Elements_Operation1.BoxFiller.Animator.Play(Elements_Operation1.BoxFiller.Anim_Walk);
            Elements_Operation1.BoxFiller.Animator.SetBool("Walk", true);

            // -> Box Filler Human walk around
            Elements_Operation1.BoxFiller.MoveToNextDestination();
        }

        public override void StageUpdate()
        {
            if(Elements_Operation1.BoxFiller.CheckDestinationArrival()
                && !isInPosition)
            {
                isInPosition = true;
                //Elements_Operation1.BoxFiller.GetNavMeshAgent().isStopped = true;
                //Elements_Operation1.BoxFiller.Animator.Play(Elements_Operation1.BoxFiller.Anim_Phone);
                //Elements_Operation1.BoxFiller.Animator.SetBool("Walk", false);
                StartCoroutine(PlayPhoneAnimation());
                StartCoroutine(MoveSQM90());
            }
            if(isInPosition)
            {
                Elements_Operation1.BoxFiller.RotateTowards(Elements_Operation1.SQM90.transform);
            }
        }

        public override void CheckExit()
        {
            if (Elements_Operation1.SQM90.CheckDestinationArrival())
            {
                if(WaitIsOver())
                {
                    // Create obstacle for the machine to dodge at the beggining of FullBoxTransportation
                    SetAsObstacle(true);
                    Elements_Operation1.BoxFiller.Animator.Play(Elements_Operation1.BoxFiller.Anim_Idle);
                

                    LeaveStage(Stages_Operation1.FullBoxTransportation);
                }
            }
        }

        IEnumerator PlayPhoneAnimation()
        {
            yield return new WaitForSeconds(0.3f);
            Elements_Operation1.BoxFiller.Animator.Play(Elements_Operation1.BoxFiller.Anim_Phone);
            Elements_Operation1.BoxFiller.SetCellPhone(true);
            Elements_Operation1.BoxFiller.Animator.SetBool("Walk", false);
        }

        IEnumerator MoveSQM90()
        {
            yield return new WaitForSeconds(1.3f);
            Elements_Operation1.BoxFiller.SetCellPhone(false);
            Elements_Operation1.SQM90.MoveToNextDestination();

        }

        private bool WaitIsOver()
        {
            time += Time.deltaTime;
            if (time > waitingTime)
            {
                time = 0;
                return true;
            }
            return false;
        }

        private void SetAsObstacle(bool v)
        {
            Elements_Operation1.BoxFiller.GetNavMeshAgent().enabled = !v;
            Elements_Operation1.Obstacle.gameObject.SetActive(v);
        }
    }
}