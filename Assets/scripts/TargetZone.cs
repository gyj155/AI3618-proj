using UnityEngine;

public class TargetZone : MonoBehaviour
{
    public string targetItemName;

    private void OnTriggerEnter(Collider other)
    {
        ItemObject item = other.GetComponent<ItemObject>();

        if (item != null)
        {
            TaskManager.Instance.CheckItem(item.itemName, targetItemName);
        }
    }
}