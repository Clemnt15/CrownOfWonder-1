using UnityEngine;

public class ObjectDestroyer : MonoBehaviour
{
    // Référence au joueur
    public Transform player;

    // Rayon pour détecter les collisions avec les murs et les objets
    public float collisionRadius = 1f;

    // Couche pour les murs et les objets
    public LayerMask destroyLayer;

   

    void FixedUpdate()
    {
        // Détecter les collisions avec les murs et les objets
        Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position, collisionRadius, destroyLayer);

        // Détruire les murs et les objets détectés
        foreach (Collider2D collider in colliders)
        {
            Destroy(collider.gameObject);
        }
    }

    // Dessine une sphère de détection dans l'éditeur Unity
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, collisionRadius);
    }
}
