using TMPro;
using UnityEngine;
using System.Collections;

public class InventoryUI : MonoBehaviour
{
    private TextMeshProUGUI tomatoText;

    void Start()
    {
        tomatoText = GetComponent<TextMeshProUGUI>();
    }

    public void UpdateTomatoText(PlayerInventory playerInventory)
    {
        tomatoText.text = playerInventory.NumberOfTomatoes.ToString();
    }



}
