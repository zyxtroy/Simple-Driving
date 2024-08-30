using System;
using System.Collections;
using System.Collections.Generic;
#if UNITY_ANDROID
using Unity.Notifications.Android;
#endif
using UnityEngine;

public class AndroidNotificationHandler : MonoBehaviour
{
    #if UNITY_ANDROID
    private const string ChannelId = "notification_channel";
        // Start is called before the first frame update
    public void ScheduleNotification(DateTime dateTime){
        AndroidNotificationChannel notificationChannel = new AndroidNotificationChannel(){
            Id = ChannelId,
            Name = "Notification Channel",
            Importance = Importance.Default,
            Description = "Generic notifications",
        };

        AndroidNotificationCenter.RegisterNotificationChannel(notificationChannel);

        AndroidNotification notification = new AndroidNotification(){
            Title = "Energy Recharged",
            Text = "Your energy has been recharged and you can play again!",
            SmallIcon = "default",
            LargeIcon = "default",
            FireTime = dateTime,
        };

        AndroidNotificationCenter.SendNotification(notification, ChannelId);
    }

    #endif

}
