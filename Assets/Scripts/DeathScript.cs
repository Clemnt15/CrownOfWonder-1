using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathScript : MonoBehaviour
{
    public GameObject startPoint;
    public GameObject Player;
    public Animator playerAnimator; // R�f�rence � l'Animator du joueur pour d�clencher l'animation

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            StartCoroutine(TransitionAndRespawn());
        }
    }

    IEnumerator TransitionAndRespawn()
    {
        // D�clenchez ici l'animation de mort du joueur
        if (playerAnimator != null)
        {
            playerAnimator.SetTrigger("Death"); // Assurez-vous que "Death" est le nom du param�tre de d�clenchement dans l'Animator
        }

        // Attendez un court moment pour que l'animation de mort soit jou�e
        yield return new WaitForSeconds(1.5f); // Vous pouvez ajuster cette dur�e selon la longueur de votre animation

        // R�initialisez la position du joueur
        Player.transform.position = startPoint.transform.position;
    }
}
