using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private Button button;
    [SerializeField] private Transform canvas;
    private int scenes;


    void Start()
    {
        for (int i = 0; i < 68; i++) // The magic number is mine, Pau is a genius.
        {
            int sceneIndex = i;
            Button newButton = Instantiate(button, canvas);
            newButton.GetComponentInChildren<TMP_Text>().text = (i + 1).ToString();
            newButton.onClick.AddListener(() => { SceneManager.LoadScene(sceneIndex); });
        }
    }
}
