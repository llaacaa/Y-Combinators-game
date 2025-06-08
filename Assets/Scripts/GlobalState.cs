using UnityEngine;
using System.Collections.Generic;

public class GlobalState
{
    public static bool isGunActive = false;

    public static bool isGameOver = false;

    public static List<GameObject> portals = new List<GameObject>();


    public static void toggleActiveWeapon()
    {
        isGunActive = !isGunActive;
    }

    public static void ClearPortals()
    {
        // Destroy each GameObject
        foreach (GameObject portal in portals)
        {
            if (portal != null)
            {
                GameObject.Destroy(portal);
            }
        }

        portals.Clear(); // Correct way to empty a List
    }

    public static void linkPortals()
    {
        if (portals.Count < 2) return;

        GameObject portalA = portals[0];
        GameObject portalB = portals[1];

        if (portalA != null && portalB != null)
        {
            // Get the scripts on the children you want to link
            Transform childA = portalA.transform.Find("Plane.004");
            Transform childB = portalB.transform.Find("Plane.004");

            if (childA != null && childB != null)
            {
                Portal scriptA = childA.GetComponent<Portal>();
                Portal scriptB = childB.GetComponent<Portal>();

                if (scriptA != null && scriptB != null)
                {
                    scriptA.destinationPortal = childB;
                    scriptB.destinationPortal = childA;
                }
                else
                {
                    Debug.LogWarning("One of the Portal scripts is missing!");
                }
            }
            else
            {
                Debug.LogWarning("One of the children 'Plane.004' not found!");
            }
        }
    }




}
