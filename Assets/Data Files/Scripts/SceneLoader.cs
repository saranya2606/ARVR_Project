using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneLoader : MonoBehaviour
{
    [Tooltip("Write Reset if you want to re-load the current scene")]
    public string scene = "Reset";
    private UnityAction ev;
    void Start()
    {
        Button button = gameObject.GetComponent<Button>();
        if(scene == "Reset") ev = ReloadScene;
        else ev = LoadScene;
        button.onClick.AddListener(ev);
    }

    void LoadScene()
    {
        SceneManager.LoadScene(scene);
    }
    void ReloadScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);
    }
}
