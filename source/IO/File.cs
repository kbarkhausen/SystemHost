using System;
using System.Collections.Generic;
using System.IO;
using System.Security.AccessControl;
using System.Text;


namespace SystemHost.IO
{
    public interface IFile
    {
        bool Exists(string path);
        void AppendAllLines(string path, IEnumerable<string> content);
        void AppendAllLines(string path, IEnumerable<string> content, Encoding encoding);
        void AppendAllText(string path, string contents);
        void AppendAllText(string path, string contents, Encoding encoding);
        StreamWriter AppendText(string path);
        string ReadAllText(string path);
        string ReadAllText(string path, Encoding encoding);
        byte[] ReadAllBytes(string path);
        string[] ReadAllLines(string path);
        string[] ReadAllLines(string path, Encoding encoding);
        void Create(string path);
        void Create(string path, int bufferSize);
        void Create(string path, int bufferSize, FileOptions options);
        void Create(string path, int bufferSize, FileOptions options, FileSecurity security);
        System.IO.StreamWriter CreateText(string path);
        void Decrypt(string path);
        void Delete(string path);
        void Encrypt(string path);
        System.Security.AccessControl.FileSecurity GetAccessControl(string path);
        System.Security.AccessControl.FileSecurity GetAccessControl(string path, System.Security.AccessControl.AccessControlSections includeSections);
        DateTime GetCreationTime(string path);
        DateTime GetCreationTimeUtc(string path);
        DateTime GetLastAccessTime(string path);
        DateTime GetLastAccessTimeUtc(string path);
        DateTime GetLastWriteTime(string path);
        DateTime GetLastWriteTimeUtc(string path);
        void Move(string source, string destination);
        System.IO.FileStream Open(string path, System.IO.FileMode mode);
        System.IO.FileStream Open(string path, System.IO.FileMode mode, System.IO.FileAccess access);
        System.IO.FileStream Open(string path, System.IO.FileMode mode, System.IO.FileAccess access, System.IO.FileShare share);
        void SetAccessControl(string path, System.Security.AccessControl.FileSecurity fileSecurity);
        void SetCreationTime(string path, DateTime newDateTime);
        void SetCreationTimeUtc(string path, DateTime newDateTime);
        void SetLastAccessTime(string path, DateTime newDateTime);
        void SetLastAccessTimeUtc(string path, DateTime newDateTime);
        void SetLastWriteTime(string path, DateTime newDateTime);
    }

    public class File : IFile
    {
        public bool Exists(string path)
        {
            return System.IO.File.Exists(path);
        }

        public void AppendAllLines(string path, IEnumerable<string> content)
        {
            System.IO.File.AppendAllLines(path, content);
        }

        public void AppendAllLines(string path, IEnumerable<string> content, Encoding encoding)
        {
            System.IO.File.AppendAllLines(path, content, encoding);
        }

        public void AppendAllText(string path, string contents)
        {
            System.IO.File.AppendAllText(path, contents);
        }

        public void AppendAllText(string path, string contents, Encoding encoding)
        {
            System.IO.File.AppendAllText(path, contents, encoding);
        }

        public StreamWriter AppendText(string path)
        {
            return System.IO.File.AppendText(path);
        }

        public string ReadAllText(string path)
        {
            return System.IO.File.ReadAllText(path);
        }

        public string ReadAllText(string path, Encoding encoding)
        {
            return System.IO.File.ReadAllText(path, encoding);
        }

        public byte[] ReadAllBytes(string path)
        {
            return System.IO.File.ReadAllBytes(path);
        }

        public string[] ReadAllLines(string path)
        {
            return System.IO.File.ReadAllLines(path);
        }

        public string[] ReadAllLines(string path, Encoding encoding)
        {
            return System.IO.File.ReadAllLines(path, encoding);
        }

        public void Create(string path)
        {
            System.IO.File.Create(path);
        }

        public void Create(string path, int bufferSize)
        {
            System.IO.File.Create(path, bufferSize);
        }

        public void Create(string path, int bufferSize, FileOptions options)
        {
            System.IO.File.Create(path, bufferSize, options);
        }

        public void Create(string path, int bufferSize, FileOptions options, FileSecurity security)
        {
            System.IO.File.Create(path, bufferSize, options, security);
        }

        public System.IO.StreamWriter CreateText(string path)
        {
            return System.IO.File.CreateText(path);
        }

        public void Decrypt(string path)
        {
            System.IO.File.Decrypt(path);
        }

        public void Delete(string path)
        {
            System.IO.File.Delete(path);
        }

        public void Encrypt(string path)
        {
            System.IO.File.Encrypt(path);
        }

        public System.Security.AccessControl.FileSecurity GetAccessControl(string path)
        {
            return System.IO.File.GetAccessControl(path);
        }

        public System.Security.AccessControl.FileSecurity GetAccessControl(string path, System.Security.AccessControl.AccessControlSections includeSections)
        {
            return System.IO.File.GetAccessControl(path, includeSections);
        }

        public DateTime GetCreationTime(string path)
        {
            return System.IO.File.GetCreationTime(path);
        }

        public DateTime GetCreationTimeUtc(string path)
        {
            return System.IO.File.GetCreationTimeUtc(path);
        }

        public DateTime GetLastAccessTime(string path)
        {
            return System.IO.File.GetLastAccessTime(path);
        }

        public DateTime GetLastAccessTimeUtc(string path)
        {
            return System.IO.File.GetLastAccessTimeUtc(path);
        }

        public DateTime GetLastWriteTime(string path)
        {
            return System.IO.File.GetLastWriteTime(path);
        }

        public DateTime GetLastWriteTimeUtc(string path)
        {
            return System.IO.File.GetLastWriteTimeUtc(path);
        }
       
        public void Move(string source, string destination)
        {
            System.IO.File.Move(source, destination);
        }

        public System.IO.FileStream Open(string path, System.IO.FileMode mode)
        {
            return System.IO.File.Open(path, mode);
        }

        public System.IO.FileStream Open(string path, System.IO.FileMode mode, System.IO.FileAccess access)
        {
            return System.IO.File.Open(path,mode, access);
        }

        public System.IO.FileStream Open(string path, System.IO.FileMode mode, System.IO.FileAccess access, System.IO.FileShare share)
        {
            return System.IO.File.Open(path, mode, access, share);
        }

        public void SetAccessControl(string path, System.Security.AccessControl.FileSecurity fileSecurity)
        {
            System.IO.File.SetAccessControl(path, fileSecurity);
        }

        public void SetCreationTime(string path, DateTime newDateTime)
        {
            System.IO.File.SetCreationTime(path, newDateTime);
        }

        public void SetCreationTimeUtc(string path, DateTime newDateTime)
        {
            System.IO.File.SetCreationTimeUtc(path, newDateTime);
        }

        public void SetLastAccessTime(string path, DateTime newDateTime)
        {
            System.IO.File.SetLastAccessTime(path, newDateTime);
        }

        public void SetLastAccessTimeUtc(string path, DateTime newDateTime)
        {
            System.IO.File.SetLastAccessTimeUtc(path, newDateTime);
        }

        public void SetLastWriteTime(string path, DateTime newDateTime)
        {
            System.IO.File.SetLastWriteTime(path, newDateTime);
        }
    }
}
