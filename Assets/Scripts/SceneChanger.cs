using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public string SCN_2; // Le nom de la scène à charger

    private void OnTriggerEnter(Collider other)
    {
        // Vérifie si le GameObject qui a déclenché le collider est le joueur
        if (other.CompareTag("Player"))
        {
            // Affiche un message de débogage indiquant que le joueur a déclenché le déclencheur
            Debug.Log("Le joueur a déclenché le changement de scène.");

            // Charge la nouvelle scène
            SceneManager.LoadScene(SCN_2);
        }
    }
}