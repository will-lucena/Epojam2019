using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogueManager : MonoBehaviour
{

    public static System.Action enableMovement;
    public TextMeshProUGUI dialogueText;

    private Queue<string> sentences;
    [SerializeField] private float delayBetweenTypes;
    [SerializeField] private GameObject buttonGO;

    public Dialogue dialogue;

    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();
        startDialogue(dialogue);
    }

    public void startDialogue(Dialogue dialoge)
    {
        sentences.Clear();

        foreach (string sentence in dialoge.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }

    IEnumerator typeSentence(string sentence)
    {
        dialogueText.text = "";

        foreach (char letter in sentence.ToCharArray())
        {
            dialogueText.text += letter;
            yield return new WaitForSeconds(delayBetweenTypes);
        }
        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }

        string sentence = sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(typeSentence(sentence));
    }

    private void EndDialogue()
    {
        buttonGO.SetActive(true);
    }

    public void startGame()
    {
        enableMovement?.Invoke();
        gameObject.SetActive(false);
    }
}
