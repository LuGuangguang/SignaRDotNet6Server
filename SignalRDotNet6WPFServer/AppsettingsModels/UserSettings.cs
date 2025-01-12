﻿using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Text;

namespace SignalRDotNet6WPFServer.AppsettingsModels
{
    public class UserSettings : IOptions<UserSettings>, INotifyPropertyChanged
    {
        public UserSettings()
        {

        }
        public UserSettings Value => null;
        /// <summary>
        /// 是否是第一次打开此软件
        /// </summary>
        public bool IsFirstLaunch { get; set; }
        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
