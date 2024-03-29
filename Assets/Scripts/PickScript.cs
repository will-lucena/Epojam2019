﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[RequireComponent(typeof(Collider2D))]


public class PickScript : MonoBehaviour
{
    public Action<ICollectable> pickObject;

    [SerializeField] private string pickInput;
    [SerializeField] private ICollectable collectableItem;

    private bool blockAction;

    private void Update()
    {
        if (Input.GetAxis(pickInput) != 0 && collectableItem && !blockAction)
        {
            blockAction = true;
            pickObject?.Invoke(collectableItem);
        }

        if (Input.GetAxis(pickInput) == 0 && blockAction)
        {
            blockAction = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        collectableItem = collision.GetComponent<ICollectable>();
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        collectableItem = null;
    }
}
