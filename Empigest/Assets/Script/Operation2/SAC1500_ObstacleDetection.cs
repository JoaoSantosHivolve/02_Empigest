using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SAC1500_ObstacleDetection : MonoBehaviour
{
    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = transform.parent.GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Obstacle")
        {
            StartCoroutine(ObstacleMovement());
        }
    }

    IEnumerator ObstacleMovement()
    {
        anim.speed = 0;

        yield return new WaitForSeconds(2f);

        anim.speed = 1;
    }
}
