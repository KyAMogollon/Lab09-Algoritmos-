using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Vector2 vectorToMove;
    public int speed = 1;
    public int estamina;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, vectorToMove,speed * Time.deltaTime);
        if(estamina <= 0)
        {
            StartCoroutine(MissEnergy());
        }
    }
    IEnumerator MissEnergy()
    {
        speed = 0;
        yield return new WaitForSecondsRealtime(2);
        speed = 5;
        estamina = 50;
    }
    public void ChangePosition(Vector2 destiny)
    {
        vectorToMove = destiny;
    }
}
