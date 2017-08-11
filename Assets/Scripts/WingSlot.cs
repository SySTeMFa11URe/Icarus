using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WingSlot : MonoBehaviour {
    public PlayerWings wingState;
    public Image slot;
    public Color inActive;
    public Color active;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(wingState.isFlying())
        {
            slot.color = active;
        }
        else
        {
            slot.color = inActive;
        }
	}
}
