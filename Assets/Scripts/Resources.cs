﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Resources : MonoBehaviour {
    private float magic = 100f;
    private float health = 100f;
    private int wood = 0;
    private int sand = 0;
    private int iron = 0;
    public float timeUntilMagicRegen = 1f;
    public float regenSpeed = .1f;
    private float currentTime = 0f;
    public PlayerWings touching;
    public Image inventoryBack;
    public Text inventoryHeading;
    public Text woodAmount;
    public Text sandAmount;
    public Text ironAmount;
    private int selected = 1;
    private bool inventoryShowing = false;
    private bool pauseMenu = false;
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
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            selected = 1;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            selected = 2;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            selected = 3;
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            selected = 4;
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            if (inventoryShowing)
            {
                inventoryShowing = false;
            }
            else
            {
                inventoryShowing = true;
            }
        }
        if (inventoryShowing)
        {
            inventoryBack.enabled = true;
            inventoryHeading.enabled = true;
            woodAmount.enabled = true;
            sandAmount.enabled = true;
            ironAmount.enabled = true;
            woodAmount.text = "Wood: " + wood;
            sandAmount.text = "Sand: " + sand;
            ironAmount.text = "Iron: " + iron;
        }
        else
        {
            inventoryBack.enabled = false;
            inventoryHeading.enabled = false;
            woodAmount.enabled = false;
            sandAmount.enabled = false;
            ironAmount.enabled = false;
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
    public int getSelected()
    {
        return selected;
    }
    public void addWood(int amountToAdd)
    {
        wood += amountToAdd;
    }
    public void addSand(int amountToAdd)
    {
        sand += amountToAdd;
    }
    public void addIron(int amountToAdd)
    {
        iron += amountToAdd;
    }
    public int getWood()
    {
        return wood;
    }
    public int getSand()
    {
        return sand;
    }
    public int getIron()
    {
        return iron;
    }
    public bool getInvState()
    {
        return inventoryShowing;
    }
    public bool getPause()
    {
        return pauseMenu;
    }
    public void resetAll()
    {
        health = 100f;
        magic = 100f;
        wood = 0;
        sand = 0;
        iron = 0;
    }
}
