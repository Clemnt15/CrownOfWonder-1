using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathScript : MonoBehaviour
{
    public GameObject startPoint;
    public GameObject Player;
    public Animator playerAnimator; // Référence à l'Animator du joueur pour déclencher l'animation

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            StartCoroutine(TransitionAndRespawn());
        }
    }

    IEnumerator TransitionAndRespawn()
    {
        // Déclenchez ici l'animation de mort du joueur
        if (playerAnimator != null)
        {
            playerAnimator.SetTrigger("Death"); // Assurez-vous que "Death" est le nom du paramètre de déclenchement dans l'Animator
        }

        // Attendez un court moment pour que l'animation de mort soit jouée
        yield return new WaitForSeconds(1.5f); // Vous pouvez ajuster cette durée selon la longueur de votre animation

        // Réinitialisez la position du joueur
        Player.transform.position = startPoint.transform.position;
    }
}
