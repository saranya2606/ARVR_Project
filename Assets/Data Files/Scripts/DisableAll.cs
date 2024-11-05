using UnityEngine;
using System.Linq;

public class DisableAll : MonoBehaviour
{
    public GameObject[] target;
    public GameObject[] toDisable;
    
    public void DisableAllGO()
    {
        for(int i = 0; i < toDisable.Length; i++)
        {
            if(!target.Contains(toDisable[i]))
                toDisable[i].SetActive(false);
        }
    }
}
