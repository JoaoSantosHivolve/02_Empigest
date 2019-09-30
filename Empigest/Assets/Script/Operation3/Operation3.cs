using System.Collections;
using UnityEngine;

namespace Operation3
{
    public class Operation3 : Operation
    {
        [Header("Arm that controls the boxes and pallets")]
        public RoboticArm RoboticArm;

        [Header("Machine that pushes the box to the arm")]
        public Pusher Pusher;

        [Header("Machine that carries the box to next operation")]
        public SAC1500 SAC1500;

        [Header("Machine that tapes the boxes")]
        public TapeMachine TapeMachine;

        [Header("Operation Elementes")]
        public GameObject Pallet;
        public GameObject Box;
        public GameObject PalletPile;

        [Header("State of the operation")]
        public bool hasBox = true;
        public bool hasPallet = false;
        public bool palletStackFull = true;
        public bool canMove = false;
        public bool palletReady = false;

        private void Start()
        {
            RoboticArm.Init();
            Pusher.Init();
            SAC1500.Init();
            TapeMachine.Init();

            // Init all Stages of this operation
            Stage = Stages_Operation3.PusherTransport;
            Stage.Init();

            TapeMachine.Play_Ready();
        }

        private void FixedUpdate()
        {
            if (hasPallet)
                Pallet.SetActive(true);

            if (palletReady)
            {
                palletReady = false;
                StartCoroutine(StartSAC1500());
            }

            // ----- Hide/Show pallet pile
            if (palletStackFull)
                PalletPile.SetActive(true);
            else PalletPile.SetActive(false);
        }

        IEnumerator StartSAC1500()
        {
            yield return new WaitForSeconds(2f);
            GameManager.Instance.Operation3.SAC1500.Play_CarryBox();
            yield return new WaitForSeconds(1.23f);
            Pallet.SetActive(false);
            Pallet.transform.Find("FullPallet").gameObject.SetActive(false);
            Pallet.GetComponent<Animator>().Play("PalletIdleEmpty");
            
        }

    }
}