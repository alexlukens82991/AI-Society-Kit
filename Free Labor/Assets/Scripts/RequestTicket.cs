using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RequestTicket : ActionTicket
{
    public TicketType RequestType;

    public void SetRequestType(TicketType ticketRequestType)
    {
        RequestType = ticketRequestType;
    }
    
    public override void SendTicket()
    {

    }
}

