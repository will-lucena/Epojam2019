using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CollectItem : MonoBehaviour
{
    public Action<ICollectable> pickObject;
    public Action showPickButton;
    public Action hidePickButton;

    [SerializeField] private string pickInput;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        showPickButton?.Invoke();
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        ICollectable item = collision.GetComponent<ICollectable>();

        if (item != null && Input.GetButton(pickInput))
        {
            pickObject?.Invoke(item);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        hidePickButton?.Invoke();
    }
}
