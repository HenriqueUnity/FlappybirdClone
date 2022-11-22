using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Discord;

public class DiscordController : MonoBehaviour
{
    public Discord.Discord discord;
   
    void Start()
    {
        discord = new Discord.Discord(1044422447568539800,(System.UInt64)Discord.CreateFlags.Default);   
        var activityManager = discord.GetActivityManager();
        var activity = new Discord.Activity
        {
            Details = "Farming Pipes",
            State = "Flying",
        };
        activityManager.UpdateActivity(activity, (res) =>
        {
           if (res == Discord.Result.Ok)
               Debug.Log("Discord bombo");
           else
               Debug.LogError("deu ruim discord");
        });
        
    }

    // Update is called once per frame
    void Update()
    {
        discord.RunCallbacks();  
    }
}
