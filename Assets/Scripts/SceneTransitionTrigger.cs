
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransitionTrigger : MonoBehaviour
{
    public string sceneName; // Le nom de la scène à charger
    public Animator transitionAnimator;

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
        transitionAnimator.SetTrigger("Start"); // Déclenche l'animation de transition

        yield return new WaitForSeconds(transitionAnimator.GetCurrentAnimatorStateInfo(0).length);

        SceneManager.LoadScene(sceneName); // Charge la nouvelle scène
    }
}