﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Text;

namespace Dev2.Data.Storage
{
    /// <summary>
    /// Used to store index data ;)
    /// </summary>
    public class BinaryDataListIndexStorage : IBinaryDataListIndexStorage
    {

        #region Fields

        private static readonly string _compactExt = ".compact";
        private static readonly int _compactKeyCnt = 10000;
        private static readonly double _compactFactor = 0.7; // 30% fragmentation
        private static readonly int _pageLen = (1024*1024);
        private static readonly int keyLen = 36;
        private readonly string _idxPath;
        private FileStream _fileStream;
        private readonly int _packedKeyLen = 48;
        private int _totalIndexs;
        private int _peekIndexs;

        private static readonly string _rootPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
        private const string _savePath = @"Dev2\DataListServer\";

        #endregion

        #region Properties

        public int Count
        {
            get { return _totalIndexs; }
        }

        public ICollection<string> Keys
        {
            get
            {
                ICollection<string> result = new Collection<string>();

                int pos = 0;
                long readMax = (_totalIndexs * _packedKeyLen);

                byte[] buffer = new byte[_packedKeyLen];

                while (pos < readMax)
                {
                    _fileStream.Seek(pos, SeekOrigin.Begin);
                    _fileStream.Read(buffer, 0, _packedKeyLen);

                    SBinaryDataListIndex idx = BytesToStruct(buffer);

                    if (idx.length != 0)
                    {
                        // found a canidate key
                        result.Add(new string(idx.uniqueKey));
                    }

                    pos += _packedKeyLen; // move index long
                }

                return result;
            }
        }

        public string IndexFilePath
        {
            get { return _idxPath; }
        }

        #endregion


        public BinaryDataListIndexStorage(string fileName)
        {
            _idxPath = Path.Combine(_rootPath, _savePath) + fileName + ".idx";
            File.Create(_idxPath, 1).Close();

            _fileStream = new FileStream(_idxPath, FileMode.OpenOrCreate, FileAccess.ReadWrite);

        }

        /// <summary>
        /// Determines whether the specified key contains key.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <returns>
        ///   <c>true</c> if the specified key contains key; otherwise, <c>false</c>.
        /// </returns>
        public bool ContainsKey(string key)
        {
            SBinaryDataListIndex idx = new SBinaryDataListIndex();
            InitIdx(ref idx);

            return (FindIndex(ref idx, key) >= 0);

        }

        /// <summary>
        /// Gets the length of the position.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <param name="position">The position.</param>
        /// <param name="length">The length.</param>
        /// <exception cref="System.Exception"></exception>
        public bool GetPositionLength(string key, out long position, out int length)
        {
            SBinaryDataListIndex idx = new SBinaryDataListIndex();
            InitIdx(ref idx);

            bool res = true;

            if (FindIndex(ref idx, key) >= 0)
            {
                position = idx.position;
                length = idx.length;
            }
            else
            {
                position = -1;
                length = 0;
                res = false;
                //throw new Exception(string.Format("Key '{0}' doesn't exist in index.", key));
            }


            return res;
        }

        /// <summary>
        /// Adds the index.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <param name="position">The position.</param>
        /// <param name="length">The length.</param>
        public void AddIndex(string key, long position, int length)
        {
            // init index
            SBinaryDataListIndex idx = new SBinaryDataListIndex();
            InitIdx(ref idx);


            // first find the key if it exist ;)
            long loc = FindIndex(ref idx, key);

            idx.position = position;
            idx.length = length;

            if (loc >= 0)
            {
                byte[] bytes = ConvertIndexToBytes(ref idx);
                // we have a hit, update in place ;)
                _fileStream.Seek(loc, SeekOrigin.Begin);
                _fileStream.Write(bytes, 0, _packedKeyLen);
            }
            else
            {
                // it is a new add ;)
                
                idx.uniqueKey = key.ToCharArray();
                byte[] bytes = ConvertIndexToBytes(ref idx);
                _fileStream.Seek(0, SeekOrigin.End);
                _fileStream.Write(bytes, 0, _packedKeyLen);

                _totalIndexs++;
                _peekIndexs++;
            }
        }

        public void RemoveIndex(string key)
        {
            SBinaryDataListIndex idx = new SBinaryDataListIndex();
            InitIdx(ref idx);

            long idxLoc = FindIndex(ref idx, key);

            if ( idxLoc >= 0)
            {
                // we have a match ;)
                InitIdx(ref idx); // clean it, the push back ;)
                long pos = (idxLoc * _packedKeyLen);
                byte[] bytes = ConvertIndexToBytes(ref idx);
                _fileStream.Seek(pos, SeekOrigin.Begin);
                _fileStream.Write(bytes, 0, _packedKeyLen);
                _totalIndexs--;

                // do we need to compact ?
                if (((_peekIndexs - _totalIndexs) / (double)_peekIndexs <= _compactFactor) && _totalIndexs >= _compactKeyCnt)
                {
                    // if over 30% can be reclaimed and there are more then 10 000 keys to compact
                    Compact();
                }
            }
         }


        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        void Dispose(bool disposing)
        {
            if (!disposing) return;
            // clean up ;)
            _fileStream.Close();
            _fileStream.Dispose();

            // remove file system resources
            File.Delete(_idxPath);
        }

        /// <summary>
        /// Indexes the idx.
        /// </summary>
        /// <param name="idx">The idx.</param>
        private void InitIdx(ref SBinaryDataListIndex idx)
        {
            idx.uniqueKey = new char[keyLen];
            idx.length = 0;
            idx.position = 0;
        }


        /// <summary>
        /// Compacts this instance.
        /// </summary>
        private void Compact()
        {

            //// _fileStream.Read(buffer, pos, _keyObjLen);
            //// BytesToStruct(buffer, typeof(SBinaryDataListIndex), 0, ref idx);

            //FileStream tmpAV = new FileStream(_idxPath + _compactExt, FileMode.OpenOrCreate, FileAccess.ReadWrite);

            //int pos = 0;
            //int movePos = 0;
            //long readMax = (_peekIndexs * _packedKeyLen);

            //byte[] buffer = new byte[_packedKeyLen];

            //while (pos < readMax)
            //{
            //    _fileStream.Seek(pos, SeekOrigin.Begin);
            //    _fileStream.Read(buffer, 0, _packedKeyLen);
            //    SBinaryDataListIndex idx = BytesToStruct(buffer);

            //    if (idx.length != 0 && idx.position != 0)
            //    {
            //        // found a canidate to move
            //        tmpAV.Write(buffer, pos, _packedKeyLen);
            //        movePos += _packedKeyLen;
            //    }
            //    pos += _packedKeyLen; // move index long
            //}

            //// make the swap ;)
            //tmpAV.Close();
            //tmpAV.Dispose();

            //// swap the files ;)
            //_fileStream.Close();
            //_fileStream.Dispose();
            //File.Delete(_idxPath);

            //File.Move((_idxPath + _compactExt), _idxPath);

            //// re-init ;)
            //_fileStream = new FileStream(_idxPath, FileMode.OpenOrCreate, FileAccess.ReadWrite);

        }

        private byte[] ConvertIndexToBytes(ref SBinaryDataListIndex idx)
        {

            byte[] bytes = new byte[_packedKeyLen];
            byte[] locBytes = BitConverter.GetBytes(idx.position);
            byte[] lengthBytes = BitConverter.GetBytes(idx.length);

            Array.ConstrainedCopy(locBytes, 0, bytes, 0, locBytes.Length);
            Array.ConstrainedCopy(lengthBytes, 0, bytes, 8, lengthBytes.Length);


            byte[] tmp = new byte[keyLen];
            for (int i = 0; i < keyLen; i++)
            {
                tmp[i] = (byte)idx.uniqueKey[i];
            }

            Array.ConstrainedCopy(tmp, 0, bytes, 12, keyLen);


            return bytes;

        }

        /// <summary>
        /// Bytes to struct.
        /// </summary>
        /// <param name="bytes">The bytes.</param>
        /// <param name="idx">The idx.</param>
        private SBinaryDataListIndex BytesToStruct(byte[] bytes)
        {

            SBinaryDataListIndex idx = new SBinaryDataListIndex();
            InitIdx(ref idx);

            // 0 -7
            long pos = BitConverter.ToInt64(SubRangeOfBytes(bytes,0, 8),0);
            // 8 - 11
            int len = BitConverter.ToInt32(SubRangeOfBytes(bytes, 8, 4), 0);
            
            idx.length = len;
            idx.position = pos;

            byte[] bkey = new byte[keyLen];
            // 12 - 48
            Array.ConstrainedCopy(bytes, 12, bkey, 0, keyLen);

            char[] tmp = Encoding.UTF8.GetChars(bkey);
            if (tmp.Length > 0)
            {
                Array.ConstrainedCopy(tmp, 0, idx.uniqueKey, 0, keyLen);
            }

            return idx;
        }

        private byte[] SubRangeOfBytes(byte[] bytes, int start, int len)
        {
            byte[] result = new byte[len];

            Array.ConstrainedCopy(bytes, start, result, 0, len);

            return result;
        }

        /// <summary>
        /// Finds the index.
        /// </summary>
        /// <param name="idx">The idx.</param>
        /// <param name="searchKey">The search key.</param>
        /// <returns></returns>
        private long FindIndex(ref SBinaryDataListIndex idx, string searchKey)
        {
            long pos = 0;
            long readMax = (_totalIndexs * _packedKeyLen);

            char[] toMatch = searchKey.ToCharArray();

            while (pos < readMax)
            {
                byte[] readBuffer = new byte[_packedKeyLen];
                _fileStream.Seek(pos, SeekOrigin.Begin);

                long readLen;

                // Page in 1MB at a time or len if less ~ 21,800 keys at a time ;)
                if (_fileStream.Length <= _pageLen)
                {
                    // take it all ;)
                    readLen = (int)_fileStream.Length;
                    readBuffer = new byte[readLen];
                }
                else
                {
                    // we need to page 1MB / to end at a time ;)
                    readLen = _pageLen;
                    readBuffer = new byte[readLen];
                }

                _fileStream.Read(readBuffer, 0, (int)readLen);

                // Now break up into smaller parts for manip ;)
                int offset = 0;

                while (offset < readLen)
                {
                    byte[] buffer = SubRangeOfBytes(readBuffer, offset, _packedKeyLen);

                    // now unpack into the idx object ;)
                    idx = BytesToStruct(buffer);

                    if (KeysMatch(idx.uniqueKey, toMatch))
                    {
                        return pos;
                    }

                    offset += _packedKeyLen;
                }

                pos += readLen; // move index long
            }

            return -1;
        }

        private bool KeysMatch(char[] toExamine, char[] target)
        {
            bool result = true;
            int pos = 0;
            while (pos < keyLen && result)
            {
                if (toExamine[pos] != target[pos])
                {
                    result = false;
                    break;
                }
                pos++;
            }

            return result;
        }
    }


}
