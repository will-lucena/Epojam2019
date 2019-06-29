using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateScript : MonoBehaviour
{
    public static System.Action<GameObject, GameObject> loadNextPhase;
    [SerializeField] private GameObject nextPhase;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            loadNextPhase?.Invoke(nextPhase, transform.parent.gameObject);
        }
    }
}
