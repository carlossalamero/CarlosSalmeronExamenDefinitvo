using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private Player_movement knight;
    private Animator bombanimator;
    private Animator staranimator;
    private BoxCollider2D bombcollider;

    public GameObject[] hearts;
    public GameObject victoria;
    public GameObject derrota;
    int contmonedas;

    public Text numcoin;
    
   
    // Start is called before the first frame update
    void Awake()
    {

        knight = GameObject.Find("knight").GetComponent<Player_movement>();
        
        
    }
    void Start() 
    {

        victoria.SetActive(false);
        derrota.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void cogerestrella(GameObject estrella, GameObject character)
    {

        staranimator = estrella.GetComponent<Animator>();        
        ganar(character);       

    }
    public void muerte(GameObject character)
    {

        derrota.SetActive(true);
        Destroy(character, 0.3f);

    }

    void ganar(GameObject character)
    {

        victoria.SetActive(true);
        Destroy(character, 0.3f);

        
    }  
}
