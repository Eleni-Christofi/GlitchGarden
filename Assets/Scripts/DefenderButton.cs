using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DefenderButton : MonoBehaviour
{
    [SerializeField] Defender defenderPrefab;
    [SerializeField] Text healthText;

    private void Start()
    {
        LabelButtonWithCost();
    }

    private void OnMouseDown()
    {
        var buttons = FindObjectsOfType<DefenderButton>();
        foreach(DefenderButton button in buttons)
        {
            button.GetComponent<SpriteRenderer>().color = new Color32(41, 41, 41, 225);
        }
        GetComponent<SpriteRenderer>().color = Color.white;
        FindObjectOfType<DefenderSpawner>().SetSelectedDefender(defenderPrefab);
    }

    private void LabelButtonWithCost()
    {
        float defenderHealth = defenderPrefab.GetComponent<Health>().GetHealth();
        Text costText = GetComponentInChildren<Text>();
        if(!costText)
        {
            Debug.LogError(name + "has no cost text");
        }
        else
        {
            costText.text = defenderPrefab.GetFertCost().ToString();
            healthText.text = defenderHealth.ToString();
        }
    }
}
