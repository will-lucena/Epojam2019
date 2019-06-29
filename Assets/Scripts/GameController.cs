using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] private Movement movementScript;
    [SerializeField] private GameObject filterGO;
    [SerializeField] private Transform player;

    private void OnEnable()
    {
        DialogueManager.enableMovement += enableMovement;
        FadeoutBehavior.fadeOutDone += hideFilter;
        GateScript.loadNextPhase += changePhase;
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

    private void changePhase(GameObject toLoad, GameObject toUnload)
    {
        toUnload.SetActive(false);
        player.transform.position = toLoad.GetComponent<RoomScript>().getSpawnPoint();
        toLoad.SetActive(true);
    }
}
