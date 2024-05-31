using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;


public class resetMenu : MonoBehaviour
{
    public string CREDIT;
    public void Ending()
    {
        SceneManager.LoadScene(CREDIT);
    }

}
