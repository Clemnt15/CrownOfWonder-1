using UnityEngine;

public class ObjectDestroyer : MonoBehaviour
{
    // R�f�rence au joueur
    public Transform player;

    // Rayon pour d�tecter les collisions avec les murs et les objets
    public float collisionRadius = 1f;

    // Couche pour les murs et les objets
    public LayerMask destroyLayer;

   

    void FixedUpdate()
    {
        // D�tecter les collisions avec les murs et les objets
        Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position, collisionRadius, destroyLayer);

        // D�truire les murs et les objets d�tect�s
        foreach (Collider2D collider in colliders)
        {
            Destroy(collider.gameObject);
        }
    }

    // Dessine une sph�re de d�tection dans l'�diteur Unity
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, collisionRadius);
    }
}
