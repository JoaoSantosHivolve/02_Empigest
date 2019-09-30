using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointOfViewController : Singleton<PointOfViewController>
{
    public List<Transform> POVs = new List<Transform>();
    public int currentPov = 0;

    private void Start()
    {
        transform.position = POVs[currentPov].position;
    }

    private void Update()
    {
        //RaycastHit hit;
        //
        //if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity))
        //{
        //    Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);
        //
        //    if(hit.collider.tag == "POV")
        //    {
        //        hit.collider.GetComponent<Animator>().SetBool("Selected", true);
        //        SelectedPOV = hit.collider.gameObject;
        //    }
        //    else
        //    {
        //        if(SelectedPOV != null)
        //        {
        //            SelectedPOV.GetComponent<Animator>().SetBool("Selected", false);
        //            SelectedPOV = null;
        //        }
        //    }
        //}

        // is player using a controller?
        if (OVRInput.GetActiveController() == OVRInput.Controller.LTrackedRemote ||
            OVRInput.GetActiveController() == OVRInput.Controller.RTrackedRemote)
        {
            // yes, are they touching the touchpad?
            if (OVRInput.Get(OVRInput.Touch.PrimaryTouchpad))
            {
                // yes, let's require an actual click rather than just a touch.
                if(OVRInput.GetDown(OVRInput.Button.PrimaryTouchpad))
                {
                    NextLocation();
                }
                //if (OVRInput.Get(OVRInput.Button.PrimaryTouchpad))
                //{
                //    NextLocation();
                //}
            }
        }
        else if (OVRInput.GetDown(OVRInput.Touch.PrimaryTouchpad)) // finger on HMD pad?
        {
            // not using controller, same behavior as before.
            NextLocation();
            //Vector2 touchPosition = OVRInput.Get(OVRInput.Axis2D.PrimaryTouchpad);
            //ProcessHMDClickAtPosition(touchPosition);
        }

    }

    private void NextLocation()
    {
        if (currentPov + 1 == POVs.Count)
            currentPov = 0;
        else currentPov++;

        transform.position = POVs[currentPov].position;
    }
}
////android:name="com.unity3d.player.UnityPlayerActivity"