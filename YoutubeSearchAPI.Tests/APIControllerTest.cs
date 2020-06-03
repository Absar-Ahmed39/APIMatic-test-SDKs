/*
 * YoutubeSearchAPI.Tests
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io ).
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Threading.Tasks;
using Newtonsoft.Json.Converters;
using YoutubeSearchAPI.Standard;
using YoutubeSearchAPI.Standard.Utilities; 
using YoutubeSearchAPI.Standard.Http.Client;
using YoutubeSearchAPI.Standard.Http.Response;
using YoutubeSearchAPI.Tests.Helpers;
using NUnit.Framework;
using YoutubeSearchAPI.Standard;
using YoutubeSearchAPI.Standard.Controllers;
using YoutubeSearchAPI.Standard.Exceptions;

namespace YoutubeSearchAPI.Tests
{
    [TestFixture]
    public class APIControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests)
        /// </summary>
        private static APIController controller;

        /// <summary>
        /// Setup test class
        /// </summary>
        [SetUp]
        public static void SetUpClass()
        {
            controller = GetClient().Client;
        }

        /// <summary>
        /// A Standard search test for Youtube Search list API 
        /// </summary>
        [Test]
        public async Task TestStandardSearchTest() 
        {
            // Parameters for the API call
            string part = "snippet";
            string q = "every youtube video ever";
            string type = "video";

            // Perform API call
            Standard.Models.YoutubeJSONMasterObject result = null;

            try
            {
                result = await controller.SearchEndpointAsync(part, q, type);
            }
            catch(APIException) {};

            // Test response code
            Assert.AreEqual(200, httpCallBackHandler.Response.StatusCode,
                    "Status should be 200");

            // Test whether the captured response is as we expected
            Assert.IsNotNull(result, "Result should exist");

            Assert.IsTrue(TestHelper.IsJsonObjectProperSubsetOf(
                    "{\n	\"kind\": \"youtube#searchListResponse\",\n	\"etag\": \"4x7mZPHx94uO9CWEaN9wgqZPp2w\",\n	\"nextPageToken\": \"CAUQAA\",\n	\"regionCode\": \"PK\",\n	\"pageInfo\": {\n		\"totalResults\": 291499,\n		\"resultsPerPage\": 5\n	},\n	\"items\": [{\n			\"kind\": \"youtube#searchResult\",\n			\"etag\": \"zsmDmaw8lyTp7WWBBDb-Ggd57Xg\",\n			\"id\": {\n				\"kind\": \"youtube#video\",\n				\"videoId\": \"YYRaJ6X-Onc\"\n			},\n			\"snippet\": {\n				\"publishedAt\": \"2020-06-02T15:12:07Z\",\n				\"channelId\": \"UCiWFHBP-d3GNxg_U3NYJKyg\",\n				\"title\": \"478 Arms Warrior 39-0 Silvershard Mines Madness - WoW BFA 8.3 Season 4 PvP\",\n				\"description\": \"Twitch - http://www.twitch.tv/bajheera Twitter - https://twitter.com/BajheeraWoW Instagram - https://Instagram.com/BajheeraWoW Facebook ...\",\n				\"thumbnails\": {\n					\"default\": {\n						\"url\": \"https://i.ytimg.com/vi/YYRaJ6X-Onc/default.jpg\",\n						\"width\": 120,\n						\"height\": 90\n					},\n					\"medium\": {\n						\"url\": \"https://i.ytimg.com/vi/YYRaJ6X-Onc/mqdefault.jpg\",\n						\"width\": 320,\n						\"height\": 180\n					},\n					\"high\": {\n						\"url\": \"https://i.ytimg.com/vi/YYRaJ6X-Onc/hqdefault.jpg\",\n						\"width\": 480,\n						\"height\": 360\n					}\n				},\n				\"channelTitle\": \"Bajheera\",\n				\"liveBroadcastContent\": \"none\",\n				\"publishTime\": \"2020-06-02T15:12:07Z\"\n			}\n		},\n		{\n			\"kind\": \"youtube#searchResult\",\n			\"etag\": \"0ceJ0nEWChcBSg-8e8mQqTTfUoo\",\n			\"id\": {\n				\"kind\": \"youtube#video\",\n				\"videoId\": \"-T30h4zwp5Y\"\n			},\n			\"snippet\": {\n				\"publishedAt\": \"2020-06-01T14:58:35Z\",\n				\"channelId\": \"UCiWFHBP-d3GNxg_U3NYJKyg\",\n				\"title\": \"2400+ Arms Warrior / Holy Paladin 2v2 Arena (478 iLvl) - WoW BFA Season 4 PvP\",\n				\"description\": \"Twitch - http://www.twitch.tv/bajheera Twitter - https://twitter.com/BajheeraWoW Instagram - https://Instagram.com/BajheeraWoW Facebook ...\",\n				\"thumbnails\": {\n					\"default\": {\n						\"url\": \"https://i.ytimg.com/vi/-T30h4zwp5Y/default.jpg\",\n						\"width\": 120,\n						\"height\": 90\n					},\n					\"medium\": {\n						\"url\": \"https://i.ytimg.com/vi/-T30h4zwp5Y/mqdefault.jpg\",\n						\"width\": 320,\n						\"height\": 180\n					},\n					\"high\": {\n						\"url\": \"https://i.ytimg.com/vi/-T30h4zwp5Y/hqdefault.jpg\",\n						\"width\": 480,\n						\"height\": 360\n					}\n				},\n				\"channelTitle\": \"Bajheera\",\n				\"liveBroadcastContent\": \"none\",\n				\"publishTime\": \"2020-06-01T14:58:35Z\"\n			}\n		},\n		{\n			\"kind\": \"youtube#searchResult\",\n			\"etag\": \"au-BD0Bidf3QqgAziNxuE3aovU4\",\n			\"id\": {\n				\"kind\": \"youtube#video\",\n				\"videoId\": \"YNkjZFhJab0\"\n			},\n			\"snippet\": {\n				\"publishedAt\": \"2019-08-25T18:59:35Z\",\n				\"channelId\": \"UCiWFHBP-d3GNxg_U3NYJKyg\",\n				\"title\": \"Bajheera - 6 Year Natural Bodybuilding Transformation - Musclemania Physique Pro Jackson Bliton\",\n				\"description\": \"Twitch - http://www.twitch.tv/bajheera Twitter - https://twitter.com/BajheeraWoW Instagram - https://Instagram.com/BajheeraWoW Facebook ...\",\n				\"thumbnails\": {\n					\"default\": {\n						\"url\": \"https://i.ytimg.com/vi/YNkjZFhJab0/default.jpg\",\n						\"width\": 120,\n						\"height\": 90\n					},\n					\"medium\": {\n						\"url\": \"https://i.ytimg.com/vi/YNkjZFhJab0/mqdefault.jpg\",\n						\"width\": 320,\n						\"height\": 180\n					},\n					\"high\": {\n						\"url\": \"https://i.ytimg.com/vi/YNkjZFhJab0/hqdefault.jpg\",\n						\"width\": 480,\n						\"height\": 360\n					}\n				},\n				\"channelTitle\": \"Bajheera\",\n				\"liveBroadcastContent\": \"none\",\n				\"publishTime\": \"2019-08-25T18:59:35Z\"\n			}\n		},\n		{\n			\"kind\": \"youtube#searchResult\",\n			\"etag\": \"S0AAEZjVdiJOAnzgxdStE0Ru5r8\",\n			\"id\": {\n				\"kind\": \"youtube#video\",\n				\"videoId\": \"ZtiQB4gDX10\"\n			},\n			\"snippet\": {\n				\"publishedAt\": \"2020-05-24T13:16:10Z\",\n				\"channelId\": \"UCiWFHBP-d3GNxg_U3NYJKyg\",\n				\"title\": \"2400+ Arms Warrior / Holy Paladin 2v2 Arena Session (477 iLvl) - WoW BFA 8.3 Season 4 PvP\",\n				\"description\": \"Twitch - http://www.twitch.tv/bajheera Twitter - https://twitter.com/BajheeraWoW Instagram - https://Instagram.com/BajheeraWoW Facebook ...\",\n				\"thumbnails\": {\n					\"default\": {\n						\"url\": \"https://i.ytimg.com/vi/ZtiQB4gDX10/default.jpg\",\n						\"width\": 120,\n						\"height\": 90\n					},\n					\"medium\": {\n						\"url\": \"https://i.ytimg.com/vi/ZtiQB4gDX10/mqdefault.jpg\",\n						\"width\": 320,\n						\"height\": 180\n					},\n					\"high\": {\n						\"url\": \"https://i.ytimg.com/vi/ZtiQB4gDX10/hqdefault.jpg\",\n						\"width\": 480,\n						\"height\": 360\n					}\n				},\n				\"channelTitle\": \"Bajheera\",\n				\"liveBroadcastContent\": \"none\",\n				\"publishTime\": \"2020-05-24T13:16:10Z\"\n			}\n		},\n		{\n			\"kind\": \"youtube#searchResult\",\n			\"etag\": \"_hutX23ew3_MkQ7nZF_ch_UFetc\",\n			\"id\": {\n				\"kind\": \"youtube#video\",\n				\"videoId\": \"VrHBiPKtTF0\"\n			},\n			\"snippet\": {\n				\"publishedAt\": \"2019-12-17T14:23:31Z\",\n				\"channelId\": \"UCiWFHBP-d3GNxg_U3NYJKyg\",\n				\"title\": \"Bajheera - CLASSIC ARMS WARRIOR IS INSANE!!! - WoW Classic Phase 2 PvP\",\n				\"description\": \"Twitch - http://www.twitch.tv/bajheera Twitter - https://twitter.com/BajheeraWoW Instagram - https://Instagram.com/BajheeraWoW Facebook ...\",\n				\"thumbnails\": {\n					\"default\": {\n						\"url\": \"https://i.ytimg.com/vi/VrHBiPKtTF0/default.jpg\",\n						\"width\": 120,\n						\"height\": 90\n					},\n					\"medium\": {\n						\"url\": \"https://i.ytimg.com/vi/VrHBiPKtTF0/mqdefault.jpg\",\n						\"width\": 320,\n						\"height\": 180\n					},\n					\"high\": {\n						\"url\": \"https://i.ytimg.com/vi/VrHBiPKtTF0/hqdefault.jpg\",\n						\"width\": 480,\n						\"height\": 360\n					}\n				},\n				\"channelTitle\": \"Bajheera\",\n				\"liveBroadcastContent\": \"none\",\n				\"publishTime\": \"2019-12-17T14:23:31Z\"\n			}\n		}\n	]\n}", 
                    TestHelper.ConvertStreamToString(httpCallBackHandler.Response.RawBody), 
                    false, true, false),
                    "Response body should have matching keys");
        }

    }
}