using DBPMessanger.Forms;
using DBPMessanger.infos;
using DBPMessanger.JSON.recevie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ChatForm = DBPMessanger.Forms.ChatForm;

namespace DBPMessanger.Managers
{
    public static class NotifcationManager
    {
        public static void Initialize()
        {
            WebSocketManager.Instance.OnMessageReceived += OnMessageReceived;
        }


        private static void OnMessageReceived(RChatJSON msg)
        {
            ChatForm? form = ChatFormManager.Instance.serachForm(msg.From);

            // 현재 채팅창이 대화창이라면 알람 X
            if (form != null)
                return;


            if (msg.Type == Constants.Chat) 
            {
                var user = (DBManager.Instance.Query<UserInfo>(
                    q => q.Where(u => u.Id == msg.From)) 
                    ?? Enumerable.Empty<UserInfo>()).FirstOrDefault();

                if (user == null) 
                    return;

                var thread = new Thread(() =>
                {
                    Application.Run(new AlertForm(user.Name, msg.Message));
                });
                thread.SetApartmentState(ApartmentState.STA); // 필수
                thread.Start();
            }

        }
    }
}
