using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueInitializer : MonoBehaviour
{
    public Dialogue dialogue;

    public void InitializerDialogue()
    {
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    }
}
