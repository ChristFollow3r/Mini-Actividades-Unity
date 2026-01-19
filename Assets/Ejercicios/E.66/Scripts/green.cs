using UnityEngine;
using UnityEngine.SceneManagement;

public class green : MonoBehaviour
{

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) LoadRedScene();
    }


    void LoadRedScene()
    {
        SceneManager.LoadScene("e66_Red");
    }

    public void LoadBlueScene() // https://www.youtube.com/shorts/qCKmtIKmRyQ
    {
        SceneManager.LoadScene("e66_Blue");
    }

}
