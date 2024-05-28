using System.Collections;
using UnityEngine;

public class DeathScript : MonoBehaviour
{
    public GameObject startPoint;
    public GameObject player;
    public Animator playerAnimator; // R�f�rence � l'Animator du joueur pour d�clencher l'animation
    public MonoBehaviour playerController; // R�f�rence au script de contr�le du joueur
    public Rigidbody2D playerRigidbody; // R�f�rence au Rigidbody2D du joueur pour arr�ter tous les mouvements physiques
    public MonoBehaviour playerDash; // R�f�rence au script de dash du joueur

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            StartCoroutine(TransitionAndRespawn());
        }
    }

    IEnumerator TransitionAndRespawn()
    {
        Debug.Log("Coroutine");

        // D�sactivez le contr�le du joueur
        playerController.enabled = false;

        // D�sactivez la capacit� de dash du joueur
        playerDash.enabled = false;

        // Arr�tez le Rigidbody2D pour �viter tout mouvement physique
        playerRigidbody.velocity = Vector2.zero;
        playerRigidbody.angularVelocity = 0f;

        // R�initialisez toutes les autres animations
        playerAnimator.SetBool("BoolRun", false);

        // D�clenchez l'animation de mort du joueur
        Debug.Log("Fonction");
        playerAnimator.SetBool("BoolDeath", true);

        // Attendez un court moment pour que l'animation de mort soit jou�e
        yield return new WaitForSeconds(0.5f); // Vous pouvez ajuster cette dur�e selon la longueur de votre animation

        // R�initialisez la position du joueur
        player.transform.position = startPoint.transform.position;

        // R�initialisez l'animation de mort
        playerAnimator.SetBool("BoolDeath", false);

        // R�activez le contr�le du joueur
        playerController.enabled = true;

        // R�activez la capacit� de dash du joueur
        playerDash.enabled = true;
    }
}
