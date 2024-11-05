using UnityEngine;

public class MoveOnClick : MonoBehaviour
{
    private bool isMoving = false, atFinal = false;
    public Transform originalPosition, finalPosition;
    private Vector3 targetPosition;
    public float moveSpeed = 5f;
    public GameObject[] toToggle, toReset;

    void Update()
    {
        if (isMoving)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);

            if (transform.position == targetPosition)
                isMoving = false;
        }
    }

    public void OnMouseDown()
    {
        if (atFinal)
        {
            for(int i=0; i<toToggle.Length; i++) toToggle[i].SetActive(false);
            // ResetOthers();
            atFinal = false;
            MoveTo(originalPosition.position);
        }
        else
        {
            for(int i=0; i<toToggle.Length; i++) toToggle[i].SetActive(true);
            atFinal = true;
            MoveTo(finalPosition.position);
        }
    }

    private void MoveTo(Vector3 destination)
    {
        targetPosition = destination;
        isMoving = true;
    }

    // public void ResetOthers()
    // {
    //     for(int i=0; i<toReset.Length; i++)
    //     {
    //         if(toReset[i] != gameObject)
    //         {
    //             MoveOnClick mov = toReset[i].GetComponent<MoveOnClick>();
    //             mov.OnMouseDown();
    //         }
    //     }
    // }
}
