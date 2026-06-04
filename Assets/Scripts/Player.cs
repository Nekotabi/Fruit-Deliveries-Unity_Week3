using UnityEngine;

public class Player : MonoBehaviour
{
    private Transform myTrans;
    private Vector3 moveVect;
    private const float speed = 10.0f;
    private bool isPauseMode;

    void Start()
    {
        myTrans = this.GetComponent<Transform>();
        moveVect = Vector3.zero;
        isPauseMode = false;
    }

    void Update()
    {
        moveVect = Vector3.zero;

        if(Input.GetKeyDown(KeyCode.Escape))
        {
            isPauseMode = !isPauseMode;
            Time.timeScale = isPauseMode? 0.0f:1.0f;
        }

        if(Input.GetKey(KeyCode.W))
            moveVect += Vector3.forward;

        if(Input.GetKey(KeyCode.S))
            moveVect += Vector3.back;

        if(Input.GetKey(KeyCode.A))
            moveVect += Vector3.left;

        if(Input.GetKey(KeyCode.D))
            moveVect += Vector3.right;

        if(moveVect != Vector3.zero)
        {
            myTrans.position += moveVect * (speed * Time.deltaTime);
        }
    }
}
