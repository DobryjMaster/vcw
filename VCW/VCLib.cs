﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using System.Runtime.Serialization.Json;
using VCW.BigFights;
using VCW.Users;
using VCW.CityElections;
using VCW.PrestigeWars;
using VCW.Newspapers;
using VCW.Quests;
using VCW.UserItems;

namespace VCW
{
    class VCLib
    {
        private string _USERAGENT = null;
        private string _HOST = "api.vircities.com";

        private CookieContainer _COOKIE = new CookieContainer();

        private Uri _usersAppAuthUri = new Uri("http://api.vircities.com/users/app_auth.json");
        private Uri _usersShortInfosUri = new Uri("http://api.vircities.com/users/short_infos.json");
        private Uri _bigFightsSilentViewUri = new Uri("http://api.vircities.com/big_fights/silent_view.json");
        private Uri _cityElectionsSilentViewUri = new Uri("http://api.vircities.com/city_elections/silent_view.json");
        private Uri _prestigeWarsSilentViewUri = new Uri("http://api.vircities.com/prestige_wars/silent_view.json");
        private Uri _newspapersLatestSubscriptionsPostUri = new Uri("http://api.vircities.com/newspapers/latest_subscriptions_post.json");
        private Uri _questsUserQuestsUri = new Uri("http://api.vircities.com/quests/quests/user_quests.json");
        private Uri _usersCheckUri = new Uri("http://api.vircities.com/users/check.json");
        private Uri _userItemsStorageUri = new Uri("http://api.vircities.com/user_items/storage.json");
        private Uri _userItemsGetInfoUri = new Uri("http://api.vircities.com/user_items/get_info"); //Base Uri, in function add itemId
        private Uri _userItemsEatUserItemUri = new Uri("http://api.vircities.com/user_items/eat_user_item.json");

        // fight now unavailable
        // private Uri _fightUri = new Uri("http://api.vircities.com/military/pve/gangs/1/fight");



        public VCLib(string useragent)
        {
            if (null == useragent)
                throw new ArgumentNullException("useragent");
            _USERAGENT = useragent;
        }

        private UsersAppAuthResult usersAppAuth(string username, string password)
        {

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(_usersAppAuthUri);
            request.Host = _HOST;
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            request.UserAgent = _USERAGENT;
            request.CookieContainer = _COOKIE;

            string postData = String.Format("data%5BUser%5D%5Busername%5D={0}&data%5BUser%5D%5Bpassword%5D={1}", username, password);
            byte[] byteArray = Encoding.ASCII.GetBytes(postData);
            request.ContentLength = byteArray.Length;
            using (Stream dataStream = request.GetRequestStream())
            {
                dataStream.Write(byteArray, 0, byteArray.Length);
            }

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            UsersAppAuthResult rootobj;
            DataContractJsonSerializer json = new DataContractJsonSerializer(typeof(UsersAppAuthResult));
            using (Stream dataStream = response.GetResponseStream())
            {
                rootobj = (UsersAppAuthResult)json.ReadObject(dataStream);
            }
            response.Close();

            return rootobj;
        }

        private UsersShortInfosResult usersShortInfos()
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(_usersShortInfosUri);
            request.Host = _HOST;
            request.Method = "GET";
            request.ContentType = "application/x-www-form-urlencoded";
            request.UserAgent = _USERAGENT;
            request.CookieContainer = _COOKIE;

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            UsersShortInfosResult rootobj;
            DataContractJsonSerializer json = new DataContractJsonSerializer(typeof(UsersShortInfosResult));
            using (Stream dataStream = response.GetResponseStream())
            {
                rootobj = (UsersShortInfosResult)json.ReadObject(dataStream);
            }
            response.Close();

            return rootobj;
        }

        private BigFightsSilentViewResult bigFightsSilentView()
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(_bigFightsSilentViewUri);
            request.Host = _HOST;
            request.Method = "GET";
            request.ContentType = "application/x-www-form-urlencoded";
            request.UserAgent = _USERAGENT;
            request.CookieContainer = _COOKIE;

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            BigFightsSilentViewResult rootobj;
            DataContractJsonSerializer json = new DataContractJsonSerializer(typeof(BigFightsSilentViewResult));
            using (Stream dataStream = response.GetResponseStream())
            {
                rootobj = (BigFightsSilentViewResult)json.ReadObject(dataStream);
            }
            response.Close();

            return rootobj;
        }

        private CityElectionsSilentViewResult cityElectionsSilentView()
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(_cityElectionsSilentViewUri);
            request.Host = _HOST;
            request.Method = "GET";
            request.ContentType = "application/x-www-form-urlencoded";
            request.UserAgent = _USERAGENT;
            request.CookieContainer = _COOKIE;

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            CityElectionsSilentViewResult rootobj;
            DataContractJsonSerializer json = new DataContractJsonSerializer(typeof(CityElectionsSilentViewResult));
            using (Stream dataStream = response.GetResponseStream())
            {
                rootobj = (CityElectionsSilentViewResult)json.ReadObject(dataStream);
            }
            response.Close();

            return rootobj;
        }

        private PrestigeWarsSilentViewResult prestigeWarsSilentView()
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(_prestigeWarsSilentViewUri);
            request.Host = _HOST;
            request.Method = "GET";
            request.ContentType = "application/x-www-form-urlencoded";
            request.UserAgent = _USERAGENT;
            request.CookieContainer = _COOKIE;

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            PrestigeWarsSilentViewResult rootobj;
            DataContractJsonSerializer json = new DataContractJsonSerializer(typeof(PrestigeWarsSilentViewResult));
            using (Stream dataStream = response.GetResponseStream())
            {
                rootobj = (PrestigeWarsSilentViewResult)json.ReadObject(dataStream);
            }
            response.Close();

            return rootobj;
        }

        private NewspapersLatestSubscriptionsPostResult newspapersLatestSubscriptionsPost()
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(_newspapersLatestSubscriptionsPostUri);
            request.Host = _HOST;
            request.Method = "GET";
            request.ContentType = "application/x-www-form-urlencoded";
            request.UserAgent = _USERAGENT;
            request.CookieContainer = _COOKIE;

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            NewspapersLatestSubscriptionsPostResult rootobj;
            DataContractJsonSerializer json = new DataContractJsonSerializer(typeof(NewspapersLatestSubscriptionsPostResult));
            using (Stream dataStream = response.GetResponseStream())
            {
                rootobj = (NewspapersLatestSubscriptionsPostResult)json.ReadObject(dataStream);
            }
            response.Close();

            return rootobj;
        }

        private QuestsUserQuestsResult questsUserQuests()
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(_questsUserQuestsUri);
            request.Host = _HOST;
            request.Method = "GET";
            request.ContentType = "application/x-www-form-urlencoded";
            request.UserAgent = _USERAGENT;
            request.CookieContainer = _COOKIE;

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            QuestsUserQuestsResult rootobj;
            DataContractJsonSerializer json = new DataContractJsonSerializer(typeof(QuestsUserQuestsResult));
            using (Stream dataStream = response.GetResponseStream())
            {
                rootobj = (QuestsUserQuestsResult)json.ReadObject(dataStream);
            }
            response.Close();

            return rootobj;
        }

        private UsersCheckResult usersCheck()
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(_usersCheckUri);
            request.Host = _HOST;
            request.Method = "GET";
            request.ContentType = "application/x-www-form-urlencoded";
            request.UserAgent = _USERAGENT;
            request.CookieContainer = _COOKIE;

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            UsersCheckResult rootobj;
            DataContractJsonSerializer json = new DataContractJsonSerializer(typeof(UsersCheckResult));
            using (Stream dataStream = response.GetResponseStream())
            {
                rootobj = (UsersCheckResult)json.ReadObject(dataStream);
            }
            response.Close();

            return rootobj;
        }

        private UserItemsStorageResult userItemsStorage()
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(_userItemsStorageUri);
            request.Host = _HOST;
            request.Method = "GET";
            request.ContentType = "application/x-www-form-urlencoded";
            request.UserAgent = _USERAGENT;
            request.CookieContainer = _COOKIE;

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            UserItemsStorageResult rootobj;
            DataContractJsonSerializer json = new DataContractJsonSerializer(typeof(UserItemsStorageResult));
            using (Stream dataStream = response.GetResponseStream())
            {
                rootobj = (UserItemsStorageResult)json.ReadObject(dataStream);
            }
            response.Close();

            return rootobj;
        }

        private UserItemsGetInfoResult userItemsGetInfo(int itemId)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(new Uri(_userItemsGetInfoUri, itemId.ToString() + ".json"));
            request.Host = _HOST;
            request.Method = "GET";
            request.ContentType = "application/x-www-form-urlencoded";
            request.UserAgent = _USERAGENT;
            request.CookieContainer = _COOKIE;

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            UserItemsGetInfoResult rootobj;
            DataContractJsonSerializer json = new DataContractJsonSerializer(typeof(UserItemsGetInfoResult));
            using (Stream dataStream = response.GetResponseStream())
            {
                rootobj = (UserItemsGetInfoResult)json.ReadObject(dataStream);
            }
            response.Close();

            return rootobj;
        }

        private UserItemsEatUserItemResult userItemsEatUserItem(int itemId)
        {

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(_userItemsEatUserItemUri);
            request.Host = _HOST;
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            request.UserAgent = _USERAGENT;
            request.CookieContainer = _COOKIE;

            string postData = String.Format("data%5BUserItem%5D%5Bitem_id%5D={0}", itemId);
            byte[] byteArray = Encoding.ASCII.GetBytes(postData);
            request.ContentLength = byteArray.Length;
            using (Stream dataStream = request.GetRequestStream())
            {
                dataStream.Write(byteArray, 0, byteArray.Length);
            }

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            UserItemsEatUserItemResult rootobj;
            DataContractJsonSerializer json = new DataContractJsonSerializer(typeof(UserItemsEatUserItemResult));
            using (Stream dataStream = response.GetResponseStream())
            {
                rootobj = (UserItemsEatUserItemResult)json.ReadObject(dataStream);
            }
            response.Close();

            return rootobj;
        }
    }
}
