using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnManager : MonoBehaviour
{
    public Character_Controller[] players = new Character_Controller[4];

    public Transform respawnpos;

    private void Start()
    {
        players = FindObjectsOfType<Character_Controller>();
    }

    private void Update()
    {
        if(players.Length < 4)
        {
            players = FindObjectsOfType<Character_Controller>();
        }
    }

    public IEnumerator RespawnPlayer(Character_Controller player, float time)
    {
        yield return new WaitForSeconds(time);
        player.isAlive = true;
        player.transform.position = respawnpos.position;
    }
}
