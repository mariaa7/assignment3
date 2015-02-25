using Microsoft.WindowsAzure.Storage.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace WorkerRole6
{
    public class URL : TableEntity
    {
        public string Url { get; set; }
        public string Title { get; set; }
        //public string Date { get; set; }

        public URL() { }

        public URL(string url, string title, string partition)
        {
            this.PartitionKey = partition;
            this.RowKey = HttpUtility.UrlEncode(url);

            this.Url = url;
            this.Title = title;
            //this.Date = date;
        }
    }

}

