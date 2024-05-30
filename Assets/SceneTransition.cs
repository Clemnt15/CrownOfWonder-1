using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class SceneTransition : MonoBehaviour
{
    // Nombre de secondes avant de changer de sc�ne
    [Tooltip("Temps en secondes avant de changer de sc�ne")]
    public float delay = 5f;

    // Nom de la sc�ne � charger
    [Tooltip("Nom de la sc�ne � charger")]
    public string sceneName;

    private void Start()
    {
        // D�marrer la coroutine pour attendre et changer de sc�ne
        StartCoroutine(WaitAndLoadScene());
    }

    private IEnumerator WaitAndLoadScene()
    {
        // Attendre le nombre de secondes sp�cifi�
        yield return new WaitForSeconds(delay);

        // Charger la sc�ne sp�cifi�e
        SceneManager.LoadScene(sceneName);
    }
}
