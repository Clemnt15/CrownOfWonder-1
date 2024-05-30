using UnityEngine;

public class DisableTriggerOnExit : MonoBehaviour
{
    private void OnTriggerExit2D(Collider2D other)
    {
        // Vérifie si l'objet qui sort du trigger est le joueur
        if (other.CompareTag("Player"))
        {
            // Désactive le trigger en changeant le collider en non-trigger
            GetComponent<Collider2D>().isTrigger = false;
        }
    }
}
