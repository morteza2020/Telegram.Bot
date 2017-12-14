﻿using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Telegram.Bot.Types.ReplyMarkups.Buttons
{
    /// <summary>
    /// This object represents one button of an inline keyboard that asks the user to switch to a chat
    /// and starts an inline query there
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn,
        NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class InlineKeyboardSwitchInlineQueryButton : InlineKeyboardButton
    {
        ///  <summary>
        /// Initializes a new instance of the <see cref="InlineKeyboardSwitchInlineQueryButton"/> class
        ///  </summary>
        /// <param name="switchInlineQuery">Input query that will be inserted with the bot's username. Can be empty, in which case just the bot’s username will be inserted.</param>
        /// <param name="text"></param>
        public InlineKeyboardSwitchInlineQueryButton(string text, string switchInlineQuery = "")
            : base(text)
        {
            SwitchInlineQuery = switchInlineQuery;
        }

        /// <summary>
        /// If set, pressing the button will prompt the user to select one of their chats, open that chat and insert the bot's username and the specified <see cref="InlineQuery"/> in the input field. Can be empty, in which case just the bot's username will be inserted.
        /// </summary>
        /// <remarks>
        /// Note: This offers an easy way for users to start using your bot in inline mode when they are currently in a private chat with it. Especially useful when combined with switchPm[...] parameters (see <see cref="TelegramBotClient.AnswerInlineQueryAsync"/>)  – in this case the user will be automatically returned to the chat they switched from, skipping the chat selection screen.
        /// </remarks>
        [JsonProperty]
        public string SwitchInlineQuery { get; set; }
    }
}
