using UnityEngine;

public class TriggerActivation : MonoBehaviour
{
    public MonoBehaviour scriptToActivate; // Référence vers le script à activer

    // Cette méthode est appelée lorsque quelque chose entre dans le trigger
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Vérifie si l'objet qui entre est le joueur
        {
            // Vérifie si le script à activer existe et n'est pas déjà activé
            if (scriptToActivate != null && !scriptToActivate.enabled)
            {
                scriptToActivate.enabled = true; // Active le script
            }
        }
    }
}
