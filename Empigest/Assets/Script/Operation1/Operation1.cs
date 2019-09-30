using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace Operation1
{
    public class Operation1 : Operation
    {
        [Header("Machine that carries the box")]
        public SQM90Controller SQM90;

        [Header("Box the machine carries")]
        public FillBox Box;
        public GameObject ClosedBox;

        [Header("Human that fills the box")]
        public HumanBoxFillerController BoxFiller;
        public Transform Shelf;
        public NavMeshObstacle Obstacle;

        [Header("Human that picks the box")]
        public HumanBoxPickerController BoxPicker;
        public Transform RollingCarpet;

        public AudioClip PickUpSound;
        public AudioSource AudioSource;

        // Start is called before the first frame update
        void Start()
        {
            // Init operation elements
            BoxFiller.Init();
            BoxPicker.Init();
            Box.Init();

            AudioSource.clip = PickUpSound;

            // Init all Stages of this operation
            Stage = Stages_Operation1.BoxFilling;
            Stage.Init();
        }

        public void PlaySound()
        {
            AudioSource.Play();
        }
    }
}
