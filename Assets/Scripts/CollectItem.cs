using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CollectItem : MonoBehaviour
{
    public Action<ICollectable> pickObject;
    public Action showPickButton;
    public Action hidePickButton;

    [SerializeField] private KeyCode pickInput;
    [SerializeField] private ICollectable collectableItem;

    private void Update()
    {
        if (Input.GetKeyDown(pickInput) && collectableItem)
        {
            pickObject?.Invoke(collectableItem);
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
