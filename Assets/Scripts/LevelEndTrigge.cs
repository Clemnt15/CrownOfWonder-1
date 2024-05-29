using UnityEngine;
using Cinemachine;
using System.Collections;

public class LevelEndTrigger : MonoBehaviour
{
    public CinemachineVirtualCamera nextLevelCamera; // Référence à la caméra du niveau suivant

    public float transitionDuration = 0.5f; // Durée de la transition en secondes
    public float disableDelay = 2.0f; // Délai avant de désactiver le déclencheur en secondes
    private IEnumerator coroutine;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Activer la caméra du niveau suivant avec une transition rapide
            nextLevelCamera.Priority = 10;

            // Désactiver la caméra actuelle 
            CinemachineVirtualCamera currentCamera = GetComponentInParent<CinemachineVirtualCamera>();
            if (currentCamera != null)
            {
                currentCamera.Priority = 0;
            }

            // Désactiver le déclencheur après un certain délai
            StartCoroutine(DisableTrigger());
        }
    }

    IEnumerator DisableTrigger()
    {
        // Attendre le délai spécifié avant de désactiver le déclencheur
        yield return new WaitForSeconds(disableDelay);

        // Désactiver le déclencheur
        gameObject.SetActive(false);
    }
}