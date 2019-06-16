using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PickScript : MonoBehaviour
{
    public Action<ICollectable> pickObject;
    public Action showPickButton;
    public Action hidePickButton;

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
        showPickButton?.Invoke();
        collectableItem = collision.GetComponent<ICollectable>();
        Debug.Log("Press space");
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        hidePickButton?.Invoke();
        Debug.Log("out of zone space");
    }
}
