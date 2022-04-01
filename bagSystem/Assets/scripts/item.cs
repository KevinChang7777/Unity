using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "New Item", menuName = "Inventory/New Item")]  //������ݴ�������
public class item : ScriptableObject
{
    public Sprite itemImage;
    public string itemName;
    public int itemNub;
    [TextArea]
    public string itemInfo;
}
