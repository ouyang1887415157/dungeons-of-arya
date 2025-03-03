﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    private bool isOpen = false;


    private void Start()
    {
        gameObject.SetActive(true);
    }

    public void OpenDoor()
    {
        if (!isOpen)
        {
            isOpen = true;
            gameObject.SetActive(false); // Hide the door (or trigger an animation)
        }
    }
}
