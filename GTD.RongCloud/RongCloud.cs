﻿using GTD.RongCloud.methods;
using System;
using System.Collections.Generic;

namespace GTD.RongCloud
{
    public class RongCloud
    {

        private static Dictionary<String, RongCloud> rongCloud = new Dictionary<String, RongCloud>();
        public static String RONGCLOUDURI = "http://api.cn.ronghub.com";
        public static String RONGCLOUDSMSURI = "http://api.sms.ronghub.com";
        //确保线程同步
        private static readonly object locker = new object();

        public User user;
        public Message message;
        public Wordfilter wordfilter;
        public Group group;
        public Chatroom chatroom;
        public Push push;
        public SMS sms;

        private RongCloud(String appKey, String appSecret)
        {
            user = new User(appKey, appSecret);
            message = new Message(appKey, appSecret);
            wordfilter = new Wordfilter(appKey, appSecret);
            group = new Group(appKey, appSecret);
            chatroom = new Chatroom(appKey, appSecret);
            push = new Push(appKey, appSecret);
            sms = new SMS(appKey, appSecret);

        }

        public static RongCloud GetInstance(String appKey, String appSecret)
        {
            lock (locker)
            {
                if (!rongCloud.ContainsKey(appKey))
                {
                    rongCloud.Add(appKey, new RongCloud(appKey, appSecret));
                }
            }
            return rongCloud[appKey];
        }
    }
}
