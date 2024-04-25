using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraTrigger : MonoBehaviour
{
    public CinemachineVirtualCamera virtualCamera; // Référence à la caméra Cinemachine

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Désactiver le suivi de la caméra lorsque le joueur entre dans le déclencheur
            virtualCamera.enabled = false;
        }
        Debug.Log("Le joueur a déclenché le changement de scène.");
    }
}
