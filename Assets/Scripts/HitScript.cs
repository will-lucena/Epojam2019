using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class HitScript : MonoBehaviour
{
    public Action<ICollectable> pickObject;
    public Action showPickButton;
    public Action hidePickButton;

    [SerializeField] private string hitInput;

    private bool blockAction;

    private void Update()
    {
        if (Input.GetAxis(hitInput) != 0 && !blockAction)
        {
            Debug.Log("hit");
            blockAction = true;
        }

        if (Input.GetAxis(hitInput) == 0 && blockAction)
        {
            blockAction = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {

        }
        showPickButton?.Invoke();
        Debug.Log("Press space");
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        hidePickButton?.Invoke();
        Debug.Log("out of zone space");
    }
}
