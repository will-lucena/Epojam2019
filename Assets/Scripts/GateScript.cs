using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateScript : MonoBehaviour
{
    public static System.Action<GameObject, GameObject> loadNextPhase;
    [SerializeField] private GameObject nextPhase;
    [SerializeField] private Transform player;
    [SerializeField] private Transform spawnPoint;

    private void OnEnable()
    {
        Debug.Log(gameObject.name);
        player.transform.position = spawnPoint.position;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("coe");

        if (collision.gameObject.CompareTag("Player"))
        {
            loadNextPhase?.Invoke(nextPhase, transform.parent.gameObject);
        }
    }
}
