using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resources : MonoBehaviour {
    private float magic = 100f;
    private float health = 100f;
    public float timeUntilMagicRegen = 1f;
    public float regenSpeed = .1f;
    private float currentTime = 0f;
    public PlayerWings touching;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        currentTime += Time.deltaTime;
        if (currentTime >= timeUntilMagicRegen && magic <= 100f && touching.isOnNatural())
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
    public void drainHealth(float amountToDrain)
    {
        health -= amountToDrain;
    }
    public float getHealth()
    {
        return health;
    }
}
