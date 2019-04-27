﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Prism;
using Microsoft.Practices.Prism.Mvvm;

namespace ASync
{
    public class SearchItemResult : BindableBase
    {
        private string title;
        private string url;
        private string thumbnaiUrl;
        private string source;

        public string Title
        {
            get
            {
                return title;
            }

            set
            {
                SetProperty(ref title, value);
            }
        }

        public string Url
        {
            get
            {
                return url;
            }

            set
            {
                SetProperty(ref url, value);
            }
        }

        public string ThumbnaiUrl
        {
            get
            {
                return thumbnaiUrl;
            }

            set
            {
                SetProperty(ref thumbnaiUrl, value);
            }
        }

        public string Source
        {
            get
            {
                return source;
            }

            set
            {
                SetProperty(ref source, value);
            }
        }
    }
}
