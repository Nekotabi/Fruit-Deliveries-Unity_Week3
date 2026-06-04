using System;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] Arrays arrays;
    private Transform myTrans;
    private Vector3 moveVect;
    private const float speed = 10.0f;
    private int haveIndex;
    private bool isPauseMode;

    void Start()
    {
        myTrans = this.GetComponent<Transform>();
        moveVect = Vector3.zero;
        haveIndex = -1;
        isPauseMode = false;
    }

    void Update()
    {
        moveVect = Vector3.zero;

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isPauseMode = !isPauseMode;
            Time.timeScale = isPauseMode ? 0.0f : 1.0f;
        }

        if (Input.GetKey(KeyCode.W))
            moveVect += Vector3.forward;

        if (Input.GetKey(KeyCode.S))
            moveVect += Vector3.back;

        if (Input.GetKey(KeyCode.A))
            moveVect += Vector3.left;

        if (Input.GetKey(KeyCode.D))
            moveVect += Vector3.right;

        if (moveVect != Vector3.zero)
        {
            myTrans.position += moveVect * (speed * Time.deltaTime);
        }
    }

    private void OnTriggerEnter(Collider collider)
    {
        switch (collider.gameObject.tag)
        {
            case "package":
                if (haveIndex == -1)
                {
                    haveIndex = Array.IndexOf(arrays.packages, collider.gameObject);
                    if (haveIndex == -1)
                    {
                        Debug.LogError("配列に無い荷物です。");
                        return;
                    }
                    collider.gameObject.SetActive(false);
                }
                else
                    Debug.Log("荷物は取得済みです。");
                break;
        }

    }
}
