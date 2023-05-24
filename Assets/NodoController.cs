using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodoController : MonoBehaviour
{
    public List<NodoController> NodoList;
    public int factorPeso;
    [SerializeField] PlayerController player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public NodoController SelectNextNode()
    {
        int nodeSelected = Random.Range(0, NodoList.Count);
        return NodoList[nodeSelected];

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            other.GetComponent<PlayerController>().ChangePosition(SelectNextNode().gameObject.transform.position);
            player.estamina = player.estamina - factorPeso;
        }
    }
}
