using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IClickable{
    void OnbuttonPlayClick();
}

public interface ICountable<T>
{
    void Increase(T increasesIn);
}