using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Movement))]
[RequireComponent(typeof(SpriteRenderer))]
[RequireComponent(typeof(PickScript))]
[RequireComponent(typeof(Animator))]

public class PlayerController : MonoBehaviour
{
    private SpriteRenderer playerView;
    private PickScript pickScript;
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        playerView = GetComponent<SpriteRenderer>();
        pickScript = GetComponent<PickScript>();
        animator = GetComponent<Animator>();
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
        animator.SetBool("hasKnife", true);
    }

}
