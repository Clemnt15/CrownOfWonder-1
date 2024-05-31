using UnityEngine;

public class AudioIntro : MonoBehaviour
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
    [Range(0f, 1f)] // Pour ajouter un slider dans l'inspecteur
    public float musicVolume = 1.0f;

    private void Start()
    {
        musicSource.clip = mainmenu;
        musicSource.Play();
        musicSource.volume = musicVolume; // Assurez-vous que le volume initial est défini
    }

    private void Update()
    {
        // Mettre à jour le volume de la musique à chaque frame
        musicSource.volume = musicVolume;
    }
}