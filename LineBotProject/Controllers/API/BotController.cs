using isRock.LineBot;
using LineBotProject.Infrastructure.MessageTemplate.FlexMessage;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;

namespace LineBotProject.Controllers.API
{
    public class BotController : LineWebHookControllerBase
    {
        private string UserID = "Your User ID";
        public BotController()
        {
            this.ChannelAccessToken = ConfigurationManager.AppSettings["ChannelAccessToken"];

        }
        [HttpPost]
        [Route("~/api/bot")]
        public IHttpActionResult BotService()
        {
            try
            {
                //取得Line Event
                var LineEvent = this.ReceivedMessage.events.FirstOrDefault();
                //配合Line verify 
                if (LineEvent.replyToken == "00000000000000000000000000000000") return Ok();

                if (LineEvent.type == "join")
                {

                }

                if (LineEvent.type == "message")
                {
                    if (LineEvent.message.text == "test")
                    {
                        var sb = new StringBuilder();
                        sb.AppendLine($"ID:{LineEvent.source.userId}");
                        sb.AppendLine($"Echo Msg:{LineEvent.message.text}");
                        this.ReplyMessage(LineEvent.replyToken, sb.ToString());
                    }
                    
                    if (LineEvent.message.text == "flex") //收Flex Messages
                    {
                        var flexMsg = ShoppingFlexMessage.Template;
                        this.ReplyMessageWithJSON(LineEvent.replyToken, flexMsg);
                    }

                    if (LineEvent.message.text == "text") //收到文字
                        this.ReplyMessage(LineEvent.replyToken, "你說了:" + LineEvent.message.text);

                    if (LineEvent.message.text == "sticker") //收到貼圖
                        this.ReplyMessage(LineEvent.replyToken, 1, 2);
                }
            }
            catch (Exception ex)
            {
                //將錯誤資訊Push給 Admin
                this.PushMessage(UserID, ex.Message);
            }
            return Ok();
        }
    }
}