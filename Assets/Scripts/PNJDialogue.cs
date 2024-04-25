using UnityEngine;
using UnityEngine.UI;

public class PNJDialogue : MonoBehaviour
{
    public string[] dialogueLines; // Tableau de dialogues du PNJ
    public Text dialogueText; // Texte pour afficher le dialogue
    private int currentLine = 0; // Ligne de dialogue actuelle

    void Start()
    {
        dialogueText.text = dialogueLines[currentLine]; // Afficher la première ligne de dialogue
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) // Declencher le dialogue lorsqu'une touche est pressée
        {
            if (currentLine < dialogueLines.Length - 1) // S'il reste des lignes de dialogue
            {
                currentLine++; // Passer a la prochaine ligne
                dialogueText.text = dialogueLines[currentLine]; // Afficher la nouvelle ligne de dialogue
            }
            else
            {
                // Fin du dialogue
                // Vous pouvez ajouter ici une logique pour fermer la boîte de dialogue
            }
        }
    }
}
