using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnDefender : MonoBehaviour
{
    Defender defender;

    private void OnMouseDown()
    {

        AttemptToPlaceDefenderAt(GetSquareClicked());
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
    public void SetDefender(Defender currentDefender)
    {
        defender = currentDefender;
    }

    private void SpawndDefender(Vector2 position)
    {
        Defender defenderOnScene = Instantiate(defender, position, Quaternion.identity) as Defender;
    }

    private void AttemptToPlaceDefenderAt(Vector2 gridPos)
    {
        var StarDisplay = FindObjectOfType<StarDisplay>();
        int defenderCost = defender.GetStarCost();

        if (StarDisplay.HaveEnoughStars(defenderCost))
        {
            SpawndDefender(gridPos);
            StarDisplay.SpendStars(defenderCost);
        }
        else
        {

        }

    }
}
