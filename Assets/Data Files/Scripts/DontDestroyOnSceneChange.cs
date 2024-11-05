using UnityEngine;

public class DontDestroyOnSceneChange : MonoBehaviour
{
    private void Awake()
    {
        // Check if there's already an instance of this GameObject
        DontDestroyOnLoad(this.gameObject);
    }
}
