using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    public static System.Action<Sprite> notifyDeath;

    [SerializeField] private Sprite drop;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

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
