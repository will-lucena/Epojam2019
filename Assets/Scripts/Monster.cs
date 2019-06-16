using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider2D))]

public class Monster : MonoBehaviour
{
    public static System.Action<Sprite> notifyDeath;

    [SerializeField] private Sprite drop;

    private void die()
    {
        notifyDeath?.Invoke(drop);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            die();
            gameObject.SetActive(false);
        }
    }
}
