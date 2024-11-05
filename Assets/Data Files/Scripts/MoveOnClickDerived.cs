using UnityEngine;
using UnityEngine.UI;

public class MoveOnClickDerived : MonoBehaviour
{
    public GameObject target;
    private MoveOnClick mov;
    private LMNTSpeakOnClick lmnt;

    void Start()
    {
        mov = target.GetComponent<MoveOnClick>();
        lmnt = target.GetComponent<LMNTSpeakOnClick>();
        
        Button button = GetComponent<Button>();
        button.onClick.AddListener(OnButtonClick);
    }

    public void OnButtonClick()
    {
        lmnt.OnMouseDown();
        mov.OnMouseDown();
    }
}
