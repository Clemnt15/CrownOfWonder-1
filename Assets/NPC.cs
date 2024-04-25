using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class NPC : MonoBehaviour
{
    public GameObject dialoguePanel;
    public Text dialogueText;
    public string[] dialogue;
    private int index;
    public KeyCode keyToPress;

    public float typingSpeed = 0.05f; // Vitesse de dactylographie du texte
    public AudioClip typingSound; // Son de dactylographie

    private Coroutine currentCoroutine; // Coroutine actuelle pour arrêter la dactylographie si nécessaire

    void Update()
    {
        if (Input.GetKeyDown(keyToPress) && dialoguePanel.activeSelf)
        {
            DisplayNextLine();
        }
    }

    public void StartDialogue()
    {
        dialoguePanel.SetActive(true);
        index = 0;
        currentCoroutine = StartCoroutine(TypeDialogue());
    }

    void DisplayNextLine()
    {
        if (index < dialogue.Length - 1)
        {
            StopCoroutine(currentCoroutine);
            index++;
            currentCoroutine = StartCoroutine(TypeDialogue());
        }
        else
        {
            EndDialogue();
        }
    }

    IEnumerator TypeDialogue()
    {
        dialogueText.text = "";
        foreach (char letter in dialogue[index].ToCharArray())
        {
            dialogueText.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
    }

    void EndDialogue()
    {
        dialoguePanel.SetActive(false);
        index = 0; // Réinitialise l'index pour permettre de recommencer le dialogue
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            StartDialogue();
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            EndDialogue();
        }
    }
}
