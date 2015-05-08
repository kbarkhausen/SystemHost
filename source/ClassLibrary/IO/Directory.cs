﻿using System.Collections.Generic;
using System.Security.AccessControl;

namespace System.IO
{
    public interface IDirectoryProxy
    {
        bool Exists(string path);
        IEnumerable<string> EnumerateFileSystemEntries(string path);
        IEnumerable<string> EnumerateFileSystemEntries(string path, string searchPattern);
        IEnumerable<string> EnumerateFileSystemEntries(string path, string searchPattern, SearchOption searchOption);
        IEnumerable<string> EnumerateFiles(string path);
        IEnumerable<string> EnumerateFiles(string path, string searchPattern);
        IEnumerable<string> EnumerateFiles(string path, string searchPattern, SearchOption searchOption);
        IEnumerable<string> GetDirectories(string path);
        IEnumerable<string> GetDirectories(string path, string searchPattern);
        IEnumerable<string> GetDirectories(string path, string searchPattern, SearchOption searchOption);
        IEnumerable<string> GetFileSystemEntries(string path);
        IEnumerable<string> GetFileSystemEntries(string path, string searchPattern);
        IEnumerable<string> GetFileSystemEntries(string path, string searchPattern, SearchOption searchOption);
        IEnumerable<string> GetFiles(string path);
        IEnumerable<string> GetFiles(string path, string searchPattern);
        IEnumerable<string> GetFiles(string path, string searchPattern, SearchOption searchOption);
        IEnumerable<string> GetLogicalDrives(string path);
        void CreateDirectory(string path);
        void CreateDirectory(string path, DirectorySecurity directorySecurity);
        void Delete(string path);
        void Delete(string path, bool recursive);
        IEnumerable<string> EnumerateDirectories(string path);
        IEnumerable<string> EnumerateDirectories(string path, string searchPattern);
        IEnumerable<string> EnumerateDirectories(string path, string searchPattern, SearchOption searchOption);
        DirectorySecurity GetAccessControl(string path);
        DirectorySecurity GetAccessControl(string path, AccessControlSections includeSections);
        DateTime GetCreationTime(string path);
        DateTime GetCreationTimeUtc(string path);
        DateTime GetLastAccessTime(string path);
        DateTime GetLastAccessTimeUtc(string path);
        DateTime GetLastWriteTime(string path);
        DateTime GetLastWriteTimeUtc(string path);
        DirectoryInfo GetParent(string path);
        void Move(string source, string destination);
        void SetAccessControl(string path, DirectorySecurity directorySecurity);
        void SetCreationTime(string path, DateTime newDateTime);
        void SetCreationTimeUtc(string path, DateTime newDateTime);
        void SetCurrentDirectory(string path);
        void SetLastAccessTime(string path, DateTime newDateTime);
        void SetLastAccessTimeUtc(string path, DateTime newDateTime);
        void SetLastWriteTime(string path, DateTime newDateTime);
    }

    public class DirectoryProxy : IDirectoryProxy
    {
        public bool Exists(string path)
        {
            return Directory.Exists(path);
        }

        public IEnumerable<string> EnumerateFileSystemEntries(string path)
        {
            return Directory.EnumerateFileSystemEntries(path);
        }

        public IEnumerable<string> EnumerateFileSystemEntries(string path, string searchPattern)
        {
            return Directory.EnumerateFileSystemEntries(path, searchPattern);
        }

        public IEnumerable<string> EnumerateFileSystemEntries(string path, string searchPattern, SearchOption searchOption)
        {
            return Directory.EnumerateFileSystemEntries(path, searchPattern, searchOption);
        }

        public IEnumerable<string> EnumerateFiles(string path)
        {
            return Directory.EnumerateFiles(path);
        }

        public IEnumerable<string> EnumerateFiles(string path, string searchPattern)
        {
            return Directory.EnumerateFiles(path, searchPattern);
        }

        public IEnumerable<string> EnumerateFiles(string path, string searchPattern, SearchOption searchOption)
        {
            return Directory.EnumerateFiles(path, searchPattern, searchOption);
        }

        public IEnumerable<string> GetDirectories(string path)
        {
            return Directory.GetDirectories(path);
        }

        public IEnumerable<string> GetDirectories(string path, string searchPattern)
        {
            return Directory.GetDirectories(path, searchPattern);
        }

        public IEnumerable<string> GetDirectories(string path, string searchPattern, SearchOption searchOption)
        {
            return Directory.GetDirectories(path, searchPattern, searchOption);
        }

        public IEnumerable<string> GetFileSystemEntries(string path)
        {
            return Directory.GetFileSystemEntries(path);
        }

        public IEnumerable<string> GetFileSystemEntries(string path, string searchPattern)
        {
            return Directory.GetFileSystemEntries(path, searchPattern);
        }
        public IEnumerable<string> GetFileSystemEntries(string path, string searchPattern, SearchOption searchOption)
        {
            return Directory.GetFileSystemEntries(path, searchPattern, searchOption);
        }

        public IEnumerable<string> GetFiles(string path)
        {
            return Directory.GetFiles(path);
        }

        public IEnumerable<string> GetFiles(string path, string searchPattern)
        {
            return Directory.GetFiles(path, searchPattern);
        }

        public IEnumerable<string> GetFiles(string path, string searchPattern, SearchOption searchOption)
        {
            return Directory.GetFiles(path, searchPattern, searchOption);
        }

        public IEnumerable<string> GetLogicalDrives(string path)
        {
            return Directory.GetLogicalDrives();
        }

        public void CreateDirectory(string path)
        {
            Directory.CreateDirectory(path);
        }

        public void CreateDirectory(string path, DirectorySecurity directorySecurity)
        {
            Directory.CreateDirectory(path, directorySecurity);
        }

        public void Delete(string path)
        {
            Directory.Delete(path);
        }

        public void Delete(string path, bool recursive)
        {
            Directory.Delete(path, recursive);
        }

        public IEnumerable<string> EnumerateDirectories(string path)
        {
            return Directory.EnumerateDirectories(path);
        }

        public IEnumerable<string> EnumerateDirectories(string path, string searchPattern)
        {
            return Directory.EnumerateDirectories(path, searchPattern);
        }

        public IEnumerable<string> EnumerateDirectories(string path, string searchPattern, SearchOption searchOption)
        {
            return Directory.EnumerateDirectories(path, searchPattern, searchOption);
        }

        public DirectorySecurity GetAccessControl(string path)
        {
            return Directory.GetAccessControl(path);
        }

        public DirectorySecurity GetAccessControl(string path, AccessControlSections includeSections)
        {
            return Directory.GetAccessControl(path, includeSections);
        }

        public DateTime GetCreationTime(string path)
        {
            return Directory.GetCreationTime(path);
        }

        public DateTime GetCreationTimeUtc(string path)
        {
            return Directory.GetCreationTimeUtc(path);
        }

        public DateTime GetLastAccessTime(string path)
        {
            return Directory.GetLastAccessTime(path);
        }

        public DateTime GetLastAccessTimeUtc(string path)
        {
            return Directory.GetLastAccessTimeUtc(path);
        }

        public DateTime GetLastWriteTime(string path)
        {
            return Directory.GetLastWriteTime(path);
        }

        public DateTime GetLastWriteTimeUtc(string path)
        {
            return Directory.GetLastWriteTimeUtc(path);
        }

        public DirectoryInfo GetParent(string path)
        {
            return Directory.GetParent(path);
        }

        public void Move(string source, string destination)
        {
            Directory.Move(source, destination);
        }

        public void SetAccessControl(string path, DirectorySecurity directorySecurity)
        {
            Directory.SetAccessControl(path, directorySecurity);
        }

        public void SetCreationTime(string path, DateTime newDateTime)
        {
            Directory.SetCreationTime(path, newDateTime);
        }

        public void SetCreationTimeUtc(string path, DateTime newDateTime)
        {
            Directory.SetCreationTimeUtc(path, newDateTime);
        }

        public void SetCurrentDirectory(string path)
        {
            Directory.SetCurrentDirectory(path);
        }

        public void SetLastAccessTime(string path, DateTime newDateTime)
        {
            Directory.SetLastAccessTime(path, newDateTime);
        }

        public void SetLastAccessTimeUtc(string path, DateTime newDateTime)
        {
            Directory.SetLastAccessTimeUtc(path, newDateTime);
        }

        public void SetLastWriteTime(string path, DateTime newDateTime)
        {
            Directory.SetLastWriteTime(path, newDateTime);
        }
    }
}
