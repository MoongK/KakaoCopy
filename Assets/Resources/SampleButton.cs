using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class SampleButton : MonoBehaviour {

    public Text nameLabel;
    public Image iconImage;
    public Text priceText;

    Item item;
    ShopScrollList scrollList;

    public void Setup(Item currentItem, ShopScrollList currentScrollist)
    {
        item = currentItem;
        nameLabel.text = item.itemName;
        iconImage.sprite = item.icon;
        priceText.text = item.price.ToString() + " $ ";
        scrollList = currentScrollist;

        GetComponent<Button>().onClick.AddListener(HandleClick);
    }

    private void HandleClick()
    {
        print("clicked!");
        scrollList.TryTransferItemToOtherShop(item);
    }
}
