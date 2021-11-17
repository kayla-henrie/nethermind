﻿//  Copyright (c) 2021 Demerzel Solutions Limited
//  This file is part of the Nethermind library.
// 
//  The Nethermind library is free software: you can redistribute it and/or modify
//  it under the terms of the GNU Lesser General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
// 
//  The Nethermind library is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
//  GNU Lesser General Public License for more details.
// 
//  You should have received a copy of the GNU Lesser General Public License
//  along with the Nethermind. If not, see <http://www.gnu.org/licenses/>.
// 

using DotNetty.Buffers;
using Nethermind.Serialization.Rlp;

namespace Nethermind.Network.P2P.Subprotocols.Snap.Messages
{
    public class GetStorageRangesMessageSerializer : IZeroInnerMessageSerializer<GetStorageRangesMessage>
    {
        public static GetStorageRangesMessage Deserialize(RlpStream rlpStream)
        {
            GetStorageRangesMessage message = new ();
            rlpStream.ReadSequenceLength();

            message.RequestId = rlpStream.DecodeLong();
            var t = rlpStream.DecodeArray(_ => rlpStream.DecodeKeccak(), false);
            message.AccountHashes = t;
            message.RootHash = rlpStream.DecodeKeccak();
            message.StartingHash = rlpStream.DecodeKeccak();
            message.LimitHash = rlpStream.DecodeKeccak();
            message.ResponseBytes = rlpStream.DecodeLong();

            return message;
        }
        
        public void Serialize(IByteBuffer byteBuffer, GetStorageRangesMessage message)
        {
            int length = GetLength(message, out int contentLength);
            byteBuffer.EnsureWritable(length, true);
            NettyRlpStream rlpStream = new (byteBuffer);
            rlpStream.StartSequence(contentLength);
            
            rlpStream.Encode(message.RequestId);
            rlpStream.Encode(message.AccountHashes);
            rlpStream.Encode(message.RootHash);
            rlpStream.Encode(message.StartingHash);
            rlpStream.Encode(message.LimitHash);
            rlpStream.Encode(message.ResponseBytes);
        }

        public GetStorageRangesMessage Deserialize(IByteBuffer byteBuffer)
        {
            NettyRlpStream rlpStream = new (byteBuffer);
            return Deserialize(rlpStream);
        }

        public int GetLength(GetStorageRangesMessage message, out int contentLength)
        {
            contentLength = Rlp.LengthOf(message.RequestId);
            contentLength += Rlp.LengthOf(message.AccountHashes);
            contentLength += Rlp.LengthOf(message.RootHash);
            contentLength += Rlp.LengthOf(message.StartingHash);
            contentLength += Rlp.LengthOf(message.LimitHash);
            contentLength += Rlp.LengthOf(message.ResponseBytes);

            return Rlp.LengthOfSequence(contentLength);
        }
    }
}