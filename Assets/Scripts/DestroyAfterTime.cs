using UnityEngine;

public class DestroyAfterTime : MonoBehaviour
{
    // Temps en secondes avant la destruction de l'objet
    public float timeBeforeDestruction = 5.0f;

    // Cette fonction est appel�e au d�but
    void Start()
    {
        // D�truire l'objet apr�s un certain temps
        Destroy(gameObject, timeBeforeDestruction);
    }
}
