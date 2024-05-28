using System.Collections;
using UnityEngine;

public class DeathScript : MonoBehaviour
{
    public GameObject startPoint;
    public GameObject player;
    public Animator playerAnimator; // Référence à l'Animator du joueur pour déclencher l'animation
    public MonoBehaviour playerController; // Référence au script de contrôle du joueur
    public Rigidbody2D playerRigidbody; // Référence au Rigidbody2D du joueur pour arrêter tous les mouvements physiques
    public MonoBehaviour playerDash; // Référence au script de dash du joueur

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

        // Désactivez le contrôle du joueur
        playerController.enabled = false;

        // Désactivez la capacité de dash du joueur
        playerDash.enabled = false;

        // Arrêtez le Rigidbody2D pour éviter tout mouvement physique
        playerRigidbody.velocity = Vector2.zero;
        playerRigidbody.angularVelocity = 0f;

        // Réinitialisez toutes les autres animations
        playerAnimator.SetBool("BoolRun", false);

        // Déclenchez l'animation de mort du joueur
        Debug.Log("Fonction");
        playerAnimator.SetBool("BoolDeath", true);

        // Attendez un court moment pour que l'animation de mort soit jouée
        yield return new WaitForSeconds(0.5f); // Vous pouvez ajuster cette durée selon la longueur de votre animation

        // Réinitialisez la position du joueur
        player.transform.position = startPoint.transform.position;

        // Réinitialisez l'animation de mort
        playerAnimator.SetBool("BoolDeath", false);

        // Réactivez le contrôle du joueur
        playerController.enabled = true;

        // Réactivez la capacité de dash du joueur
        playerDash.enabled = true;
    }
}
