using UnityEngine;

public class TriggerAnimationOnObject : MonoBehaviour
{
    public Animator targetAnimator; // L'Animator de l'objet cible
    public string animationTriggerName; // Le nom du trigger de l'animation

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            targetAnimator.SetTrigger(animationTriggerName); // Déclenche l'animation sur l'objet cible
        }
    }
}
