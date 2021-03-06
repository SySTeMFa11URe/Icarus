﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerWings : MonoBehaviour {
    bool wingsActive = false;
    bool stopDownMotion = false;
    bool inNatural = false;
    public float flySpeed = 0.1f;
    public RawImage wingIcon;
    private Rigidbody rbody;
    private float velocity;
    public Resources resource;
	// Use this for initialization
	void Start () {
        rbody = GetComponent<Rigidbody>();
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
	
	// Update is called once per frame
	void Update () {
        if(resource.getHealth() <= 0f)
        {
            transform.position = new Vector3(0, 8, 0);
            rbody.velocity = Vector3.zero;
            rbody.angularVelocity = Vector3.zero;
            resource.resetAll();
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("menu");
        }
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if(Cursor.lockState == CursorLockMode.Locked)
            {
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
            }
            else
            {
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
            }
        }
        if (transform.position.y <= -100)
        {
            transform.position = new Vector3(0, 8, 0);
            rbody.velocity = Vector3.zero;
            rbody.angularVelocity = Vector3.zero;
            resource.resetAll();
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            toggleWings();
        }
        if (resource.getMagic() <= 0)
        {
            wingsActive = false;
        }
        if (wingsActive)
        {
            //wingIcon.enabled = true;
            rbody.useGravity = false;
            if (Input.GetKeyDown(KeyCode.Space))
            {
                //transform.Translate(Vector3.up * flySpeed);
                rbody.velocity = Vector3.zero;
                rbody.angularVelocity = Vector3.zero;
            }
            if (Input.GetKey(KeyCode.Space))
            {
                //transform.Translate(Vector3.up * flySpeed);
                rbody.AddForce(Vector3.up * 13);
                resource.drainMagic(.1f);
            }
            else if(!(stopDownMotion))
            {
                //transform.Translate(Vector3.down * .05f);
                rbody.AddForce(Vector3.down * 40);
                resource.drainMagic(.02f);
            }
        }
        else
        {
            //wingIcon.enabled = false;
            rbody.useGravity = true;
        }
	}
    private void toggleWings()
    {
        if (wingsActive)
        {
            wingsActive = false;
        }
        else
        {
            wingsActive = true;
        }
    }
    public bool getWingState()
    {
        return wingsActive;
    }
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Floor") || other.gameObject.CompareTag("Grass"))
        {
            //rbody.velocity = Vector3.zero;
            //rbody.angularVelocity = Vector3.zero;
            //stopDownMotion = true;
            velocity = other.relativeVelocity.y;
            if (velocity > 10 && wingsActive == false)
            {
                resource.drainHealth(Mathf.Abs(velocity - 5f));
            }
        }
    }
    void OnCollisionExit(Collision other)
    {
        if (other.gameObject.CompareTag("Grass"))
        {
            inNatural = false;
        }
    }
    void OnCollisionStay(Collision other)
    {
        if (other.gameObject.CompareTag("Grass"))
        {
            inNatural = true;
        }
    }
    public bool isOnNatural()
    {
        return inNatural;
    }
    public bool isFlying()
    {
        return wingsActive;
    }
}
