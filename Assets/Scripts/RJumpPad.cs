using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RJumpPad : MonoBehaviour
{
    public float bounceForce = 15f; // La force de rebond

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Rigidbody2D rb = collision.gameObject.GetComponent<Rigidbody2D>();
            if (rb != null)
            {
                // Calcul de la direction du rebond (vers la droite par défaut)
                Vector2 bounceDirection = transform.right;

                // Appliquer une force horizontale dans la direction du rebond
                rb.AddForce(bounceDirection * bounceForce, ForceMode2D.Impulse);
            }
        }
    }
}