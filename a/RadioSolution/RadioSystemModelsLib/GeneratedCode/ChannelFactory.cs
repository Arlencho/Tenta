﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class ChannelFactory
{
	public static IChannel CreateChanel(string ChannelName)
	{
        IChannel channel = null;
        switch(ChannelName)
        {
            case "RixFm":
                channel = new RixFm();
                break;
            case "P3":
                channel = new P3();
                break;
        }
        return channel;
	}

}

