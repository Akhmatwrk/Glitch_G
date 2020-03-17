using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnDefender : MonoBehaviour
{
    [SerializeField] GameObject cactus;

    private void OnMouseDown()
    {

        SpawndDefender(GetSquareClicked());
    }

    public Vector2 GetSquareClicked()
    {
        Vector2 clickPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        Vector2 worldPos = Camera.main.ScreenToWorldPoint(clickPos);

        //Debug.Log(worldPos);
        return SnapToGrid(worldPos);
    }

    private Vector2 SnapToGrid(Vector2 rawWorldPos)
    {
        float newX = Mathf.RoundToInt(rawWorldPos.x);
        float newY = Mathf.RoundToInt(rawWorldPos.y);
       // Debug.Log(newX + " " + newY);
        return new Vector2(newX, newY);
    }


    private void SpawndDefender(Vector2 position)
    {
        GameObject defender = Instantiate(cactus, position, Quaternion.identity) as GameObject;
    }
}
