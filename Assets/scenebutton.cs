using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    // Nom de la scène à charger
    public string sceneName;

    // Méthode appelée lorsque le bouton est cliqué
    public void ChangeToScene()
    {
        // Charger la scène spécifiée
        SceneManager.LoadScene(sceneName);
    }
}
