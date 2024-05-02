using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("SCN_1"); // Remplacez "NomDeVotreSceneDeJeu" par le nom de la sc�ne � charger pour commencer le jeu
    }

    public void OpenOptions()
    {
        SceneManager.LoadScene("OPTIONS"); // Remplacez "Options" par le nom de la sc�ne contenant les options
    }

    public void QuitGame()
    {
        Debug.Log("QUIT"); // Affiche un message dans la console pour indiquer que le jeu est quitt�
        Application.Quit(); // Ferme l'application
    }
}