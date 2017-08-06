using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resources : MonoBehaviour {
    private float magic = 100f;
    public float timeUntilMagicRegen = 1f;
    public float regenSpeed = .1f;
    private float currentTime = 0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        currentTime += Time.deltaTime;
        if (currentTime >= timeUntilMagicRegen && magic != 100)
        {
            magic += regenSpeed;
        }
    }
    public void drainMagic(float amountToDrain)
    {
        magic-=amountToDrain;
        currentTime = 0f;
    }
    public float getMagic()
    {
        return magic;
    }
}
