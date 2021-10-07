using UnityEngine;
using System;
using System.Runtime.InteropServices;

public class PluginTester : MonoBehaviour
{
    public GameObject player;
    public int damage = -2;
    public int heal = 1;
    int health;

    [DllImport("GameEnginesMidterm")]
    private static extern int AlterHealth(int h, int v);

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            player.GetComponent<PlayerContainer>().health = AlterHealth(player.GetComponent<PlayerContainer>().health, damage);
        }
        else if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            player.GetComponent<PlayerContainer>().health = AlterHealth(player.GetComponent<PlayerContainer>().health, heal);
        }
    }
}
