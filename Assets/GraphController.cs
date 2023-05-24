using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GraphController : MonoBehaviour
{
    public List<NodoController> allListNodes;
    public NodoController currentNodeControl;
    [SerializeField] PlayerController player;
    // Start is called before the first frame update
    void Start()
    {
        player.ChangePosition(currentNodeControl.gameObject.transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
