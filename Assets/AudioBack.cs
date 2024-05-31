using UnityEngine;

public class AudioBack : MonoBehaviour
{
    [Header("--------- Audio Source ---------")]
    [SerializeField] private AudioSource musicSource;
    [SerializeField] private AudioSource SFXSource;

    [Header("--------- Audio Clip ---------")]
    public AudioClip mainmenu;
    public AudioClip death;
    public AudioClip jump;
    public AudioClip intro;
    public AudioClip background;

    [Header("--------- Volume Settings ---------")]
    [Range(0f, 1f)]
    public float musicVolume = 1.0f;

    private static AudioBack instance;

    private void Start()
    {
        // Assurez-vous qu'il n'y a qu'une seule instance de cet objet
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject); // Empêche la destruction de cet objet lors du changement de scène
        }
        else
        {
            Destroy(gameObject); // Détruit les instances supplémentaires pour éviter les doublons
            return;
        }

        // Configuration de la musique de fond
        musicSource.clip = background;
        musicSource.loop = true; // Permet à la musique de se répéter en boucle
        musicSource.volume = musicVolume;
        musicSource.Play();
    }

    private void Update()
    {
        // Mettre à jour le volume de la musique à chaque frame
        musicSource.volume = musicVolume;
    }
}