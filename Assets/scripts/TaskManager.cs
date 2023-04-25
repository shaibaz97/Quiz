using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskManager : MonoBehaviour
{
    public static TaskManager taskManager;
    public GameObject[] tasks;
    public bool taskCompleted;
    public int id;
    public int NextTask;
    public int points;
    public int maxPoints;
    public GameObject currentTask;
    // Start is called before the first frame update
    private void Awake()
    {
        taskManager = this;
    }
    void Start()
    {
       
         
        
    }

    // Update is called once per frame
    void Update()
    {
       if(points >= maxPoints)
        {
            UIManager.instance.completedPanel.SetActive(true);
        
            if (taskCompleted)
            {
                UIManager.instance.nextTaskButton.SetActive(false);
                UIManager.instance.completed.text = "You have completed all Tasks";
            }  
        }
    }

    public void increasePoints()
    {
        points++;
    }

    public void instanitateTask()
    {
        points = 0;
        maxPoints = 100;
        if(currentTask != null)
        {
            Destroy(currentTask);
        }
        if (!taskCompleted)
        {
            UIManager.instance.completedPanel.SetActive(false);
            currentTask = Instantiate(tasks[NextTask]);
        }
     
    }
}


