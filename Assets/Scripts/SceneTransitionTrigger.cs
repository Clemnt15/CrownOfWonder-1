using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransitionTrigger : MonoBehaviour
{
    public string sceneName; // Le nom de la scène à charger
    public Animator transitionAnimator; // L'animator de transition
    public float transitionTime = 1f; // Temps de la transition (doit correspondre à la durée de l'animation)

    private bool hasPlayerEntered = false; // Variable pour suivre si le joueur a déjà déclenché la transition

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && !hasPlayerEntered)
        {
            StartCoroutine(LoadSceneWithTransition());
            hasPlayerEntered = true; // Marque que le joueur a déjà déclenché la transition
        }
    }

    IEnumerator LoadSceneWithTransition()
    {
        transitionAnimator.SetTrigger("Crossfade_start"); // Déclenche l'animation de transition

        // Attend la durée de l'animation de transition
        yield return new WaitForSeconds(transitionTime);

        SceneManager.LoadScene(sceneName); // Charge la nouvelle scène
    }
}
