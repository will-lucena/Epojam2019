using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] private Movement movementScript;
    [SerializeField] private GameObject filterGO;

    private void OnEnable()
    {
        DialogueManager.enableMovement += enableMovement;
        FadeoutBehavior.fadeOutDone += hideFilter;
    }

    private void Start()
    {
        movementScript.enabled = false;
    }

    private void enableMovement()
    {
        movementScript.enabled = true;
        filterGO.SetActive(false);
    }

    private void hideFilter()
    {
        filterGO.SetActive(false);
    }
}
