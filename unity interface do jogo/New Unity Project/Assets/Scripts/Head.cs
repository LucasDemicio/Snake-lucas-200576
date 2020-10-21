using UnityEngine;

public class Head : MonoBehaviour
{
    public GameController gameController;

    private void OnTriggerEnter2D(Collider2D col)
    {
        switch (col.gameObject.tag)
        {
            case "food":
                gameController.Eat();
                break;

        }
    }



}
