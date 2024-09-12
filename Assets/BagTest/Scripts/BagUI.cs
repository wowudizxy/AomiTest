using DG.Tweening;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BagUI : MonoBehaviour
{
    [SerializeField] private BagItemListSO BagItemList;
    [SerializeField] private ItemControl Item;
    [SerializeField] private Transform Parent;

    private Dictionary<int, ItemControl> itemDic = new Dictionary<int, ItemControl>();
    private void Start()
    {
        ShowAllItem();
    }

    private void ShowAllItem()
    {
        foreach (var bagItem in BagItemList.BagItems)
        {
            ItemControl newItem =  Instantiate(Item, Parent);
            newItem.SetSprite(bagItem.icon);
            newItem.SetID(bagItem.id);

            itemDic.TryAdd(bagItem.id, newItem);
        }
    }

    public void HighlightItem(int id)
    {
         if(itemDic.ContainsKey(id))
        {
            itemDic[id].gameObject.transform.DOScale(1.2f, 1).SetLoops(2,LoopType.Yoyo);
            print("找到此id:"+ id);
        }
        else
        {
            print("不存在此id:"+ id);
        }
    }
}
