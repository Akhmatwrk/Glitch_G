using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderButton : MonoBehaviour
{
    SpriteRenderer m_SpriteRenderer;


    private void OnMouseDown()
    {
        var buttons = FindObjectsOfType<DefenderButton>();
        foreach (DefenderButton button in buttons)
        {
            button.GetComponent<SpriteRenderer>().color = new Color32(58, 58, 58, 255);
        }
        m_SpriteRenderer = this.GetComponent<SpriteRenderer>();
        m_SpriteRenderer.color = Color.white;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
