using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderButton : MonoBehaviour
{
    SpriteRenderer m_SpriteRenderer;

    [SerializeField] Defender defender;


    private void OnMouseDown()
    {
        var buttons = FindObjectsOfType<DefenderButton>();
        foreach (DefenderButton button in buttons)
        {
            button.GetComponent<SpriteRenderer>().color = new Color32(58, 58, 58, 255);
        }
        m_SpriteRenderer = this.GetComponent<SpriteRenderer>();
        m_SpriteRenderer.color = Color.white;

        FindObjectOfType<SpawnDefender>().SetDefender(defender);
    }
    


}
