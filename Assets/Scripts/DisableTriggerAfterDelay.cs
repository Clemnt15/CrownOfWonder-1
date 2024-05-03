using UnityEngine;

public class DisableTriggerAfterDelay : MonoBehaviour
{
    public float disableDelay = 2f; // D�lai en secondes avant de d�sactiver le d�clencheur
    private bool playerInside = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInside = true;
            Invoke("DisableCollider", disableDelay); // Appeler la fonction DisableCollider apr�s le d�lai sp�cifi�
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
            GetComponent<Collider>().isTrigger = false; // D�sactiver le d�clencheur du collider
        }
    }
}
