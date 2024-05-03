using UnityEngine;

public class DisableTriggerAfterDelay : MonoBehaviour
{
    public float disableDelay = 2f; // Délai en secondes avant de désactiver le déclencheur
    private bool playerInside = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInside = true;
            Invoke("DisableCollider", disableDelay); // Appeler la fonction DisableCollider après le délai spécifié
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInside = false;
        }
    }

    private void DisableCollider()
    {
        if (playerInside)
        {
            GetComponent<Collider>().isTrigger = false; // Désactiver le déclencheur du collider
        }
    }
}
