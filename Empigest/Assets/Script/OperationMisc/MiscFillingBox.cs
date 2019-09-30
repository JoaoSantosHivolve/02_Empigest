using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiscFillingBox : MonoBehaviour
{
    private List<GameObject> boxes = new List<GameObject>();
    private int currentBox;

    public bool v;
    private void Start()
    {
        for (int i = 0; i < transform.Find("Boxes").childCount; i++)
            boxes.Add(transform.Find("Boxes").GetChild(i).gameObject);

        for (int i = 0; i < boxes.Count; i++)
            boxes[i].SetActive(false);

        currentBox = 0;
    }

    public void Update()
    {
        if (v)
        {
            v = false;
        AddBox();
        }
    }

    public void AddBox()
    {
        if(currentBox == boxes.Count)
        {
            for (int i = 0; i < boxes.Count; i++)
                boxes[i].SetActive(false);
            currentBox = 0;
        }
        boxes[currentBox].SetActive(true);
        currentBox++;
    }


}
