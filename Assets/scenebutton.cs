using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    // Nom de la sc�ne � charger
    public string sceneName;

    // M�thode appel�e lorsque le bouton est cliqu�
    public void ChangeToScene()
    {
        // Charger la sc�ne sp�cifi�e
        SceneManager.LoadScene(sceneName);
    }
}
