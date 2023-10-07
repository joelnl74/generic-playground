using Core.Interfaces;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IGatchaView : IView
{
    void DidLoadData(BaseEntity baseEntity);
    void DidComplete();
}
