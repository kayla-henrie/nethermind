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

using System.Collections.Generic;
using Nethermind.Blockchain;
using Nethermind.Core;
using Nethermind.Logging;

namespace Nethermind.Merge.Plugin.Synchronization;

public interface IChainLevelHelper
{
    BlockHeader[] GetNextHeaders(int maxCount);

    Block[] GetNextBlocks(int maxCount);
}

public class ChainLevelHelper : IChainLevelHelper
{
    private readonly IBlockTree _blockTree;
    private readonly ILogger _logger;

    public ChainLevelHelper(
        IBlockTree blockTree,
        ILogManager logManager)
    {
        _blockTree = blockTree;
        _logger = logManager.GetClassLogger();
    }
    
    public BlockHeader[] GetNextHeaders(int maxCount)
    {
        List<BlockHeader> headers = new(maxCount);
        int i = 0;
        long currentNumber = _blockTree.BestKnownNumber;
        while (i < maxCount)
        {
            ChainLevelInfo? level = _blockTree.FindLevel(currentNumber);
            if (level == null)
            {
                if (_logger.IsTrace) _logger.Trace($"ChainLevelHelper.GetNextHeaders - level {currentNumber} not found");
                break;
            }

            for (int j = 0; j < level.BlockInfos.Length; ++j)
            {
                BlockHeader? newHeader = _blockTree.FindHeader(level.BlockInfos[j].BlockHash, BlockTreeLookupOptions.TotalDifficultyNotNeeded);

                if (newHeader == null)
                {
                    if (_logger.IsTrace) _logger.Trace($"ChainLevelHelper - header {currentNumber} not found");
                    continue;
                }
                
                newHeader.TotalDifficulty = level.BlockInfos[j].TotalDifficulty == 0 ? null : level.BlockInfos[j].TotalDifficulty;
                if (_logger.IsTrace) _logger.Trace($"ChainLevelHelper - A new block header {newHeader.ToString(BlockHeader.Format.FullHashAndNumber)}");
                headers.Add(newHeader);
                ++i;
                if (i >= maxCount)
                    break;
            }
            
            ++currentNumber;
        }

        return headers.ToArray();
    }
    
    public Block[] GetNextBlocks(int maxCount)
    {
        List<Block> blocks = new(maxCount);
        int i = 0;
        long currentNumber = _blockTree.BestKnownNumber;
        while (i < maxCount)
        {
            ChainLevelInfo? level = _blockTree.FindLevel(currentNumber);
            if (level == null)
            {
                if (_logger.IsTrace) _logger.Trace($"ChainLevelHelper.GetNextBlocks - level {currentNumber} not found");
                break;
            }

            for (int j = 0; j < level.BlockInfos.Length; ++j)
            {
                Block? newBlock = _blockTree.FindBlock(level.BlockInfos[j].BlockHash);
                if (newBlock == null)
                {
                    if (_logger.IsTrace) _logger.Trace($"ChainLevelHelper - block {currentNumber} not found");
                    continue;
                }
                
                newBlock.Header.TotalDifficulty = level.BlockInfos[j].TotalDifficulty == 0 ? null : level.BlockInfos[j].TotalDifficulty;
                if (_logger.IsTrace) _logger.Trace($"ChainLevelHelper - A new block block {newBlock.ToString(Block.Format.FullHashAndNumber)}");
                blocks.Add(newBlock);
                ++i;
                if (i >= maxCount)
                    break;
            }
            
            ++currentNumber;
        }

        return blocks.ToArray();
    }
}