using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FertDisplay : MonoBehaviour
{
    [SerializeField] int fertilizer = 75;
    TextMeshProUGUI fertText;

    // Start is called before the first frame update
    void Start()
    {
        fertText = GetComponent<TextMeshProUGUI>();
        UpdateDisplay();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void UpdateDisplay()
    {
        fertText.text = fertilizer.ToString();
    }

    public void AddFertilizer(int amount)
    {
        fertilizer += amount;
        UpdateDisplay();
    }

    public void SpendFertilizer(int amount)
    {
        if(fertilizer>=amount)
        {
            fertilizer -= amount;
            UpdateDisplay();
        }
    }

    public bool EnoughFert(int amount)
    {
        return fertilizer >= amount;
    }
}
