//  Copyright (c) 2018 Demerzel Solutions Limited
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

using System.Collections.Generic;

namespace Nethermind.Db
{
    public class MemDbProvider : IDbProvider
    {
        private List<IDb> _otherDbs = new List<IDb>();
        public ISnapshotableDb StateDb { get; } = new StateDb();
        public ISnapshotableDb CodeDb { get; } = new StateDb();
        public IColumnsDb<ReceiptsColumns> ReceiptsDb { get; } = new MemColumnsDb<ReceiptsColumns>();
        public IDb BlocksDb { get; } = new MemDb();
        public IDb HeadersDb { get; } = new MemDb();
        public IDb BlockInfosDb { get; } = new MemDb();
        public IDb PendingTxsDb { get; } = new MemDb();
        public IDb ConfigsDb { get; } = new MemDb();
        public IDb EthRequestsDb { get; } = new MemDb();
        public IDb BloomDb { get; } = new MemDb();
        public IDb ChtDb { get; } = new MemDb();
        public IDb BeamStateDb { get; } = new MemDb();

        public IEnumerable<IDb> OtherDbs => throw new System.NotImplementedException();

        public void Dispose()
        {
            StateDb?.Dispose();
            CodeDb?.Dispose();
            ReceiptsDb?.Dispose();
            BlocksDb?.Dispose();
            BlockInfosDb?.Dispose();
            PendingTxsDb?.Dispose();
            ConfigsDb?.Dispose();
            EthRequestsDb?.Dispose();
            BloomDb?.Dispose();
            ChtDb?.Dispose();

            if (_otherDbs != null)
            {
                foreach (var otherDb in _otherDbs)
                {
                    otherDb?.Dispose();
                }
            }
        }

        public IDb RegisterDb(string name, IPlugableDbConfig config)
        {
            var newDb = new MemDb();
            _otherDbs.Add(newDb);
            return newDb;
        }
    }
}
