using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ICollectable : MonoBehaviour
{
    [SerializeField] private GameObject canvas;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        canvas.SetActive(true);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        canvas.SetActive(false);
    }
}
