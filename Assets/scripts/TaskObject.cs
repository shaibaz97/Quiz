using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskObject : MonoBehaviour
{
    public string Question;
    public int id;
    public int nextTask;
    public bool lastTask;
    public int maxPoints;

    // Start is called before the first frame update
    void Start()
    {
        TaskManager.taskManager.currentTask = this.gameObject;
        UIManager.instance.question.text = Question;
        TaskManager.taskManager.id = id;
        TaskManager.taskManager.NextTask = nextTask;
        TaskManager.taskManager.maxPoints = maxPoints;
        TaskManager.taskManager.taskCompleted = lastTask;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
