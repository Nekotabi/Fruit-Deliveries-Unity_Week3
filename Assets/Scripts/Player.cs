using UnityEngine;

public class Player : MonoBehaviour
{
    private Transform myTrans;
    private Vector3 moveVect;
    private const float speed = 5.0f;
    private bool isPauseMode;

    void Start()
    {
        myTrans = this.GetComponent<Transform>();
        moveVect = Vector3.zero;
    }

    void FixedUpdate()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            isPauseMode = !isPauseMode;
            Time.timeScale = isPauseMode? 0.0f:1.0f;
        }

        if(Input.GetKeyDown(KeyCode.W))
            moveVect += Vector3.forward;

        if(Input.GetKeyDown(KeyCode.S))
            moveVect += Vector3.back;

        if(Input.GetKeyDown(KeyCode.A))
            moveVect += Vector3.left;

        if(Input.GetKeyDown(KeyCode.D))
            moveVect += Vector3.right;

        if(moveVect != Vector3.zero)
        {
            myTrans.position += moveVect * speed * Time.deltaTime;
        }
    }
}
