/*
 * YoutubeSearchAPI.Standard
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io ).
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using YoutubeSearchAPI.Standard;
using YoutubeSearchAPI.Standard.Utilities;


namespace YoutubeSearchAPI.Standard.Models
{
    public class Id : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string kind;
        private string videoId;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("kind")]
        public string Kind 
        { 
            get 
            {
                return this.kind; 
            } 
            set 
            {
                this.kind = value;
                onPropertyChanged("Kind");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("videoId")]
        public string VideoId 
        { 
            get 
            {
                return this.videoId; 
            } 
            set 
            {
                this.videoId = value;
                onPropertyChanged("VideoId");
            }
        }
    }
} 