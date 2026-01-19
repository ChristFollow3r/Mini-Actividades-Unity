using UnityEngine;
using UnityEngine.SceneManagement;

public class exitScript : MonoBehaviour
{
    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    public void GoBack()
    {
        SceneManager.LoadScene(70);
    }

}
