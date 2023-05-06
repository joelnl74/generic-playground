using Messaging.Interfaces;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToastMessage : IMessage
{
    public string title;
    public string message;
}
