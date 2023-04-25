using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class dragChagneValue : MonoBehaviour
{
    public int value;
    public GameObject f;
    private bool moving;
    private bool finish;

    float startPosX,startPosY;
    Vector3 resetPosition;
    private void Start()
    {
        resetPosition = this.transform.localPosition;
    }

    private void Update()
    {
        if (finish == false) 
        { 
            if (moving)
            {
                Vector3 mpos;
                mpos = Input.mousePosition;
                mpos = Camera.main.ScreenToWorldPoint(mpos);
                this.gameObject.transform.localPosition = new Vector3(mpos.x - startPosX, mpos.y - startPosY, this.gameObject.transform.localPosition.z);
            }
        }
    }

    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mpos;
            mpos = Input.mousePosition;
            mpos = Camera.main.ScreenToWorldPoint(mpos);

            startPosX = mpos.x - this.transform.localPosition.x;
            startPosY = mpos.y - this.transform.localPosition.y;

            moving = true;
        }
    }

    private void OnMouseUp()
    {
        moving = false;

        if(Mathf.Abs(this.transform.localPosition.x - f.transform.localPosition.x) <= 0.25f && Mathf.Abs(this.transform.localPosition.y - f.transform.localPosition.y) <=0.25f)
        {
            this.transform.localPosition = new Vector3(f.transform.localPosition.x, f.transform.localPosition.y, f.transform.localPosition.z);
            TaskManager.taskManager.increasePoints();
            f.GetComponent<PlaceHolder>().canChange = true;
            f.GetComponent<SpriteRenderer>().color = Color.green;
            finish = true;
        }else 
        {
            this.transform.localPosition = new Vector3(resetPosition.x,resetPosition.y,resetPosition.z);
        }

    }
}