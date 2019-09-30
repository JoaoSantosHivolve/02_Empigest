using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Operation1
{
    public class BoxPlacement : Stage
    {
        public override void Init()
        {
            Debug.Log("Starting BoxPlacement");

            SetAsObstacle(false);
            // Move Man back to the start
            Elements_Operation1.BoxFiller.MoveToNextDestination();
            Elements_Operation1.BoxFiller.Animator.SetBool("Walk", true);

            // TODO: Play Sound -- "Por favor retirar a caixa"
            if(PointOfViewController.Instance.currentPov == 0)
                GameManager.Instance.Operation1.PlaySound();

            // Start 2nd man Animation
            Elements_Operation1.BoxPicker.Animator.Play(Elements_Operation1.BoxPicker.Anim_PickBox);
        }

        public override void StageUpdate()
        {
            // Change man animation to idle
            if(Elements_Operation1.BoxFiller.CheckDestinationArrival())
            {
                Elements_Operation1.BoxFiller.Animator.SetBool("Walk", false);
                Elements_Operation1.BoxFiller.RotateTowards(Elements_Operation1.Shelf);
            }


        }

        public override void CheckExit()
        {
            if (Elements_Operation1.BoxPicker.CheckEndAnimation())
            {
                GameManager.Instance.Operation3.canMove = true;
                LeaveStage(Stages_Operation1.EmptyBoxTransportation);
            }
        }

        private void SetAsObstacle(bool v)
        {
            Elements_Operation1.Obstacle.gameObject.SetActive(v);
            Elements_Operation1.BoxFiller.GetNavMeshAgent().enabled = !v;
        }
    }
}