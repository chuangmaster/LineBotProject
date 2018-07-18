using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LineBotProject.Infrastructure.MessageTemplate.FlexMessage
{
    /// <summary>
    /// class Flex Messages
    /// </summary>
    public class FlexMessages
    {
        //定義Flex Message
        public static readonly string SalonTemplate = @"
[
    {
      ""type"": ""flex"",
      ""altText"": ""This is a Flex Message"",
      ""contents"": 
{
  ""type"": ""bubble"",
  ""hero"": {
    ""type"": ""image"",
    ""url"": ""https://www.secretwarehousetw.com/wp-content/uploads/36478203_1767209919992643_5355889132247711744_o.jpg"",
    ""size"": ""full"",
    ""aspectRatio"": ""20:13"",
    ""aspectMode"": ""cover"",
    ""action"": {
      ""type"": ""uri"",
      ""uri"": ""http://linecorp.com/""
    }
  },
  ""body"": {
    ""type"": ""box"",
    ""layout"": ""vertical"",
    ""spacing"": ""md"",
    ""contents"": [
      {
        ""type"": ""text"",
        ""text"": ""秘密沙龍"",
        ""wrap"": true,
        ""weight"": ""bold"",
        ""gravity"": ""center"",
        ""size"": ""xl""
      },
      {
        ""type"": ""box"",
        ""layout"": ""vertical"",
        ""margin"": ""lg"",
        ""spacing"": ""sm"",
        ""contents"": [
          {
            ""type"": ""box"",
            ""layout"": ""baseline"",
            ""spacing"": ""sm"",
            ""contents"": [
              {
                ""type"": ""text"",
                ""text"": ""Date"",
                ""color"": ""#aaaaaa"",
                ""size"": ""sm"",
                ""flex"": 2
              },
              {
                ""type"": ""text"",
                ""text"": ""Sun. July 29 2018"",
                ""wrap"": true,
                ""size"": ""sm"",
                ""color"": ""#666666"",
                ""flex"": 4
              }
            ]
          },
          {
            ""type"": ""box"",
            ""layout"": ""baseline"",
            ""spacing"": ""sm"",
            ""contents"": [
              {
                ""type"": ""text"",
                ""text"": ""Time"",
                ""color"": ""#aaaaaa"",
                ""size"": ""sm"",
                ""flex"": 2
              },
              {
                ""type"": ""text"",
                ""text"": ""2:00 PM - 4:00 PM"",
                ""wrap"": true,
                ""size"": ""sm"",
                ""color"": ""#666666"",
                ""flex"": 4
              }
            ]
          },
          {
            ""type"": ""box"",
            ""layout"": ""baseline"",
            ""spacing"": ""sm"",
            ""contents"": [
              {
                ""type"": ""text"",
                ""text"": ""Location"",
                ""color"": ""#aaaaaa"",
                ""size"": ""sm"",
                ""flex"": 2
              },
              {
                ""type"": ""text"",
                ""text"": ""沐樂咖啡忠孝店(近忠孝新生捷運站2號出口7-11旁巷子)"",
                ""wrap"": true,
                ""color"": ""#666666"",
                ""size"": ""sm"",
                ""flex"": 4
              }
            ]
          },
          {
            ""type"": ""box"",
            ""layout"": ""baseline"",
            ""spacing"": ""sm"",
            ""contents"": [
              {
                ""type"": ""text"",
                ""text"": ""Note"",
                ""color"": ""#aaaaaa"",
                ""size"": ""sm"",
                ""flex"": 1
              },
              {
                ""type"": ""text"",
                ""text"": ""建議各位提前15分鐘到場喔!"",
                ""wrap"": true,
                ""color"": ""#666666"",
                ""size"": ""sm"",
                ""flex"": 4
              }
            ]
          }
        ]
      },
      
      {
        ""type"": ""box"",
        ""layout"": ""vertical"",
        ""margin"": ""xxl"",
        ""contents"": [
          {
            ""type"": ""spacer""
          },
          {
            ""type"": ""button"",
            ""action"": {
              ""type"": ""uri"",
              ""label"": ""Click Me To Open Map "",
              ""uri"": ""https://goo.gl/d5PHrJ""
            }
          },
          {
            ""type"": ""button"",
            ""action"": {
              ""type"": ""uri"",
              ""label"": ""更多訊息"",
              ""uri"": ""https://goo.gl/jEnRtM""
            }
          }
        ]
      }
    ]
  }
}
  
    }
  ]
";
    }
}