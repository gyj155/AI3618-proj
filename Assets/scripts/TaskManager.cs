using System.Collections.Generic;
using UnityEngine;

public class TaskManager : MonoBehaviour
{
    public static TaskManager Instance;

    public int totalTaskCount = 3;
    private int finishedCount = 0;

    private HashSet<string> finishedItems = new HashSet<string>();

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        Debug.Log("任务开始：请整理房间。进度 0 / " + totalTaskCount);
    }

    public void CheckItem(string itemName, string targetName)
    {
        if (finishedItems.Contains(itemName))
        {
            return;
        }

        if (itemName == targetName)
        {
            finishedItems.Add(itemName);
            finishedCount++;

            Debug.Log("放置正确：" + itemName + "，当前进度：" + finishedCount + " / " + totalTaskCount);

            if (finishedCount >= totalTaskCount)
            {
                Debug.Log("任务完成！房间已经整理好了。");
            }
        }
        else
        {
            Debug.Log("放错位置：" + itemName + "，这里应该放：" + targetName);
        }
    }
}