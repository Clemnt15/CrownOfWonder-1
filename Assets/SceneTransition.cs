using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class SceneTransition : MonoBehaviour
{
    // Nombre de secondes avant de changer de scène
    [Tooltip("Temps en secondes avant de changer de scène")]
    public float delay = 5f;

    // Nom de la scène à charger
    [Tooltip("Nom de la scène à charger")]
    public string sceneName;

    private void Start()
    {
        // Démarrer la coroutine pour attendre et changer de scène
        StartCoroutine(WaitAndLoadScene());
    }

    private IEnumerator WaitAndLoadScene()
    {
        // Attendre le nombre de secondes spécifié
        yield return new WaitForSeconds(delay);

        // Charger la scène spécifiée
        SceneManager.LoadScene(sceneName);
    }
}
