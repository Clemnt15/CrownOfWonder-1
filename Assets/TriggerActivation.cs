using UnityEngine;

public class TriggerActivation : MonoBehaviour
{
    public MonoBehaviour scriptToActivate; // R�f�rence vers le script � activer

    // Cette m�thode est appel�e lorsque quelque chose entre dans le trigger
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // V�rifie si l'objet qui entre est le joueur
        {
            // V�rifie si le script � activer existe et n'est pas d�j� activ�
            if (scriptToActivate != null && !scriptToActivate.enabled)
            {
                scriptToActivate.enabled = true; // Active le script
            }
        }
    }
}
