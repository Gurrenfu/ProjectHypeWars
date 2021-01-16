using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPlayerService 
{
    PlayerStats playerStats { get; set; }
    void setDefaultValues();

}
