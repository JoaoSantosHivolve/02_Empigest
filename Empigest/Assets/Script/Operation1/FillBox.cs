using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Operation1
{
    public class FillBox : MonoBehaviour
    {
        [Header("Content inside the box")]
        public List<GameObject> Content;

        private int Count;

        public void Init()
        {
            ClearBox();
        }

        public void AddContent()
        {
            if(Count < Content.Count)
            {
                Content[Count].SetActive(true);
                Count++;
            }
        }

        public bool CheckIfFull()
        {
            if (Count == Content.Count)
            {
                Count = 0;
                return true;
            }
            return false;
        }


        private void ClearBox()
        {
            foreach (GameObject go in Content)
            {
                go.SetActive(false);
            }

            Count = 0;
        }
    }
}
