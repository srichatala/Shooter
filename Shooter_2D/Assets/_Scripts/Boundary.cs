/*
Author: Sri Chatala
File : Boundary.cs
Created Date: Spe 24,2015
Descriptopn: Boundary controller script controll the boundaries of gameObjects
Laster Updated: Oct 01,2015
*/

using UnityEngine;
using System.Collections;

public class Boundary : MonoBehaviour
{

    void OnTriggerExit(Collider other)
    {
        Destroy(other.gameObject);
    }
}