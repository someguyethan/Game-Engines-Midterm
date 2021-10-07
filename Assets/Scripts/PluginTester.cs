using UnityEngine;
using System;
using System.Runtime.InteropServices;

public class PluginTester : MonoBehaviour
{
    public GameObject player;
    public int damage = -2;
    public int heal = 1;
    int health;
    bool isRestore = false;

    [DllImport("GameEnginesMidterm")]
    private static extern int AlterHealth(int h, int v);

    [DllImport("GameEnginesMidterm")]
    private static extern int DamageHealth(int h, int v);

    [DllImport("GameEnginesMidterm")]
    private static extern int HealHealth(int h, int v);

    [DllImport("RestoreDLL")]
    private static extern int AlterHealth();

    [DllImport("RestoreDLL")]
    private static extern int DamageHealth();

    [DllImport("RestoreDLL")]
    private static extern int HealHealth();

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            isRestore = false;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            isRestore = true;
        }

        if (!isRestore)
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                player.GetComponent<PlayerContainer>().health = AlterHealth(player.GetComponent<PlayerContainer>().health, damage);
            }
            else if (Input.GetKeyDown(KeyCode.Mouse1))
            {
                player.GetComponent<PlayerContainer>().health = AlterHealth(player.GetComponent<PlayerContainer>().health, heal);
            }
            else if (Input.GetKeyDown(KeyCode.Q))
            {
                player.GetComponent<PlayerContainer>().health = DamageHealth(player.GetComponent<PlayerContainer>().health, damage);
            }
            else if (Input.GetKeyDown(KeyCode.E))
            {
                player.GetComponent<PlayerContainer>().health = HealHealth(player.GetComponent<PlayerContainer>().health, heal);
            }
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                player.GetComponent<PlayerContainer>().health = AlterHealth();
            }
            else if (Input.GetKeyDown(KeyCode.Mouse1))
            {
                player.GetComponent<PlayerContainer>().health = AlterHealth();
            }
            else if (Input.GetKeyDown(KeyCode.Q))
            {
                player.GetComponent<PlayerContainer>().health = DamageHealth();
            }
            else if (Input.GetKeyDown(KeyCode.E))
            {
                player.GetComponent<PlayerContainer>().health = HealHealth();
            }
        }
    }
}
