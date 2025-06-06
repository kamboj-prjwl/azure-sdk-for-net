// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Communication.Messages
{
    /// <summary> The message content of type text information. </summary>
    public partial class TextMessageContent : MessageContent
    {
        /// <summary> Initializes a new instance of <see cref="TextMessageContent"/>. </summary>
        /// <param name="text"> The text value. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="text"/> is null. </exception>
        public TextMessageContent(string text)
        {
            Argument.AssertNotNull(text, nameof(text));

            Kind = MessageContentKind.Text;
            Text = text;
        }

        /// <summary> Initializes a new instance of <see cref="TextMessageContent"/>. </summary>
        /// <param name="kind"> Kind of MessageContent. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="text"> The text value. </param>
        internal TextMessageContent(MessageContentKind kind, IDictionary<string, BinaryData> serializedAdditionalRawData, string text) : base(kind, serializedAdditionalRawData)
        {
            Text = text;
        }

        /// <summary> Initializes a new instance of <see cref="TextMessageContent"/> for deserialization. </summary>
        internal TextMessageContent()
        {
        }

        /// <summary> The text value. </summary>
        public string Text { get; }
    }
}
