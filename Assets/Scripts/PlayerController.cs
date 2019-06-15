using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    private SpriteRenderer playerView;
    private CollectItem pickScript;

    // Start is called before the first frame update
    void Start()
    {
        playerView = GetComponent<SpriteRenderer>();
        pickScript = GetComponent<CollectItem>();
        pickScript.pickObject += collectItem;
        Monster.notifyDeath += updateSprite;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void atk()
    {

    }

    public void evade()
    {

    }

    private void updateSprite(Sprite sprite)
    {
        playerView.sprite = sprite;
    }

    private void collectItem(ICollectable item)
    {
        item.transform.SetParent(transform);
    }

}
