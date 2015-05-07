using System;
using System.Collections.Generic;
using System.IO;
using System.Security.AccessControl;

namespace SystemHost.IO
{
    public interface IDirectory
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
        System.Security.AccessControl.DirectorySecurity GetAccessControl(string path);
        System.Security.AccessControl.DirectorySecurity GetAccessControl(string path, AccessControlSections includeSections);
        DateTime GetCreationTime(string path);
        DateTime GetCreationTimeUtc(string path);
        DateTime GetLastAccessTime(string path);
        DateTime GetLastAccessTimeUtc(string path);
        DateTime GetLastWriteTime(string path);
        DateTime GetLastWriteTimeUtc(string path);
        System.IO.DirectoryInfo GetParent(string path);
        void Move(string source, string destination);
        void SetAccessControl(string path, System.Security.AccessControl.DirectorySecurity directorySecurity);
        void SetCreationTime(string path, DateTime newDateTime);
        void SetCreationTimeUtc(string path, DateTime newDateTime);
        void SetCurrentDirectory(string path);
        void SetLastAccessTime(string path, DateTime newDateTime);
        void SetLastAccessTimeUtc(string path, DateTime newDateTime);
        void SetLastWriteTime(string path, DateTime newDateTime);
    }

    public class Directory : IDirectory
    {
        public bool Exists(string path)
        {
            return System.IO.Directory.Exists(path);
        }

        public IEnumerable<string> EnumerateFileSystemEntries(string path)
        {
            return System.IO.Directory.EnumerateFileSystemEntries(path);
        }

        public IEnumerable<string> EnumerateFileSystemEntries(string path, string searchPattern)
        {
            return System.IO.Directory.EnumerateFileSystemEntries(path, searchPattern);
        }

        public IEnumerable<string> EnumerateFileSystemEntries(string path, string searchPattern, SearchOption searchOption)
        {
            return System.IO.Directory.EnumerateFileSystemEntries(path, searchPattern, searchOption);
        }

        public IEnumerable<string> EnumerateFiles(string path)
        {
            return System.IO.Directory.EnumerateFiles(path);
        }

        public IEnumerable<string> EnumerateFiles(string path, string searchPattern)
        {
            return System.IO.Directory.EnumerateFiles(path, searchPattern);
        }

        public IEnumerable<string> EnumerateFiles(string path, string searchPattern, SearchOption searchOption)
        {
            return System.IO.Directory.EnumerateFiles(path, searchPattern, searchOption);
        }

        public IEnumerable<string> GetDirectories(string path)
        {
            return System.IO.Directory.GetDirectories(path);
        }

        public IEnumerable<string> GetDirectories(string path, string searchPattern)
        {
            return System.IO.Directory.GetDirectories(path, searchPattern);
        }

        public IEnumerable<string> GetDirectories(string path, string searchPattern, SearchOption searchOption)
        {
            return System.IO.Directory.GetDirectories(path, searchPattern, searchOption);
        }

        public IEnumerable<string> GetFileSystemEntries(string path)
        {
            return System.IO.Directory.GetFileSystemEntries(path);
        }

        public IEnumerable<string> GetFileSystemEntries(string path, string searchPattern)
        {
            return System.IO.Directory.GetFileSystemEntries(path, searchPattern);
        }
        public IEnumerable<string> GetFileSystemEntries(string path, string searchPattern, SearchOption searchOption)
        {
            return System.IO.Directory.GetFileSystemEntries(path, searchPattern, searchOption);
        }

        public IEnumerable<string> GetFiles(string path)
        {
            return System.IO.Directory.GetFiles(path);
        }

        public IEnumerable<string> GetFiles(string path, string searchPattern)
        {
            return System.IO.Directory.GetFiles(path, searchPattern);
        }

        public IEnumerable<string> GetFiles(string path, string searchPattern, SearchOption searchOption)
        {
            return System.IO.Directory.GetFiles(path, searchPattern, searchOption);
        }

        public IEnumerable<string> GetLogicalDrives(string path)
        {
            return System.IO.Directory.GetLogicalDrives();
        }

        public void CreateDirectory(string path)
        {
            System.IO.Directory.CreateDirectory(path);
        }

        public void CreateDirectory(string path, DirectorySecurity directorySecurity)
        {
            System.IO.Directory.CreateDirectory(path, directorySecurity);
        }

        public void Delete(string path)
        {
            System.IO.Directory.Delete(path);
        }

        public void Delete(string path, bool recursive)
        {
            System.IO.Directory.Delete(path, recursive);
        }

        public IEnumerable<string> EnumerateDirectories(string path)
        {
            return System.IO.Directory.EnumerateDirectories(path);
        }

        public IEnumerable<string> EnumerateDirectories(string path, string searchPattern)
        {
            return System.IO.Directory.EnumerateDirectories(path, searchPattern);
        }

        public IEnumerable<string> EnumerateDirectories(string path, string searchPattern, SearchOption searchOption)
        {
            return System.IO.Directory.EnumerateDirectories(path, searchPattern, searchOption);
        }

        public System.Security.AccessControl.DirectorySecurity GetAccessControl(string path)
        {
            return System.IO.Directory.GetAccessControl(path);
        }

        public System.Security.AccessControl.DirectorySecurity GetAccessControl(string path, AccessControlSections includeSections)
        {
            return System.IO.Directory.GetAccessControl(path, includeSections);
        }

        public DateTime GetCreationTime(string path)
        {
            return System.IO.Directory.GetCreationTime(path);
        }

        public DateTime GetCreationTimeUtc(string path)
        {
            return System.IO.Directory.GetCreationTimeUtc(path);
        }

        public DateTime GetLastAccessTime(string path)
        {
            return System.IO.Directory.GetLastAccessTime(path);
        }

        public DateTime GetLastAccessTimeUtc(string path)
        {
            return System.IO.Directory.GetLastAccessTimeUtc(path);
        }

        public DateTime GetLastWriteTime(string path)
        {
            return System.IO.Directory.GetLastWriteTime(path);
        }

        public DateTime GetLastWriteTimeUtc(string path)
        {
            return System.IO.Directory.GetLastWriteTimeUtc(path);
        }

        public System.IO.DirectoryInfo GetParent(string path)
        {
            return System.IO.Directory.GetParent(path);
        }

        public void Move(string source, string destination)
        {
            System.IO.Directory.Move(source, destination);
        }

        public void SetAccessControl(string path, System.Security.AccessControl.DirectorySecurity directorySecurity)
        {
            System.IO.Directory.SetAccessControl(path, directorySecurity);
        }

        public void SetCreationTime(string path, DateTime newDateTime)
        {
            System.IO.Directory.SetCreationTime(path, newDateTime);
        }

        public void SetCreationTimeUtc(string path, DateTime newDateTime)
        {
            System.IO.Directory.SetCreationTimeUtc(path, newDateTime);
        }

        public void SetCurrentDirectory(string path)
        {
            System.IO.Directory.SetCurrentDirectory(path);
        }

        public void SetLastAccessTime(string path, DateTime newDateTime)
        {
            System.IO.Directory.SetLastAccessTime(path, newDateTime);
        }

        public void SetLastAccessTimeUtc(string path, DateTime newDateTime)
        {
            System.IO.Directory.SetLastAccessTimeUtc(path, newDateTime);
        }

        public void SetLastWriteTime(string path, DateTime newDateTime)
        {
            System.IO.Directory.SetLastWriteTime(path, newDateTime);
        }
    }
}
