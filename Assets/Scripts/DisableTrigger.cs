using UnityEngine;

public class DisableTrigger : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Vérifie si l'objet qui entre dans le trigger est le joueur
        if (other.CompareTag("Player"))
        {
            // Désactive le trigger en changeant le collider en non-trigger
            GetComponent<Collider2D>().isTrigger = false;
        }
    }
}
