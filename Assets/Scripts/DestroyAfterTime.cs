using UnityEngine;

public class DestroyAfterTime : MonoBehaviour
{
    // Temps en secondes avant la destruction de l'objet
    public float timeBeforeDestruction = 5.0f;

    // Cette fonction est appelée au début
    void Start()
    {
        // Détruire l'objet après un certain temps
        Destroy(gameObject, timeBeforeDestruction);
    }
}
