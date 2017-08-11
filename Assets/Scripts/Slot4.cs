using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slot4 : MonoBehaviour
{
    public Resources resource;
    public Image slot;
    public Color inActive;
    public Color active;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (resource.getSelected() == 4)
        {
            slot.color = active;
        }
        else
        {
            slot.color = inActive;
        }
    }
}
