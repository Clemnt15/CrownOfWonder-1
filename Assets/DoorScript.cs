using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Porte : MonoBehaviour{
    public GameObject connectedPorte;
    public bool teleported = false;
    private GameObject player;

    // Start is called before the first frame update
    void Start(){
        player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update(){
        if(teleported && Input.GetAxisRaw("Vertical") < 1){
            teleported = false;
        }
    }
    private void OnTriggerStay2D(Collider2D collision) {
        if(collision.gameObject.tag == "Player" && Input.GetAxisRaw("Vertical") == 1) {
            if(Input.GetAxisRaw("Vertical") == 1 && !teleported){
                player.transform.position = connectedPorte.transform.position;
                connectedPorte.GetComponent<Porte>().teleported = true;
            }
        }
    }
}