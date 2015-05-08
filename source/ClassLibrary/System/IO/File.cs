using System.Collections.Generic;
using System.Security.AccessControl;
using System.Text;

namespace System.IO
{
    public interface IFileProxy
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
        StreamWriter CreateText(string path);
        void Decrypt(string path);
        void Delete(string path);
        void Encrypt(string path);
        FileSecurity GetAccessControl(string path);
        FileSecurity GetAccessControl(string path, AccessControlSections includeSections);
        DateTime GetCreationTime(string path);
        DateTime GetCreationTimeUtc(string path);
        DateTime GetLastAccessTime(string path);
        DateTime GetLastAccessTimeUtc(string path);
        DateTime GetLastWriteTime(string path);
        DateTime GetLastWriteTimeUtc(string path);
        void Move(string source, string destination);
        FileStream Open(string path, FileMode mode);
        FileStream Open(string path, FileMode mode, FileAccess access);
        FileStream Open(string path, FileMode mode, FileAccess access, FileShare share);
        void SetAccessControl(string path, FileSecurity fileSecurity);
        void SetCreationTime(string path, DateTime newDateTime);
        void SetCreationTimeUtc(string path, DateTime newDateTime);
        void SetLastAccessTime(string path, DateTime newDateTime);
        void SetLastAccessTimeUtc(string path, DateTime newDateTime);
        void SetLastWriteTime(string path, DateTime newDateTime);
    }

    public class FileProxy : IFileProxy
    {
        public bool Exists(string path)
        {
            return File.Exists(path);
        }

        public void AppendAllLines(string path, IEnumerable<string> content)
        {
            File.AppendAllLines(path, content);
        }

        public void AppendAllLines(string path, IEnumerable<string> content, Encoding encoding)
        {
            File.AppendAllLines(path, content, encoding);
        }

        public void AppendAllText(string path, string contents)
        {
            File.AppendAllText(path, contents);
        }

        public void AppendAllText(string path, string contents, Encoding encoding)
        {
            File.AppendAllText(path, contents, encoding);
        }

        public StreamWriter AppendText(string path)
        {
            return File.AppendText(path);
        }

        public string ReadAllText(string path)
        {
            return File.ReadAllText(path);
        }

        public string ReadAllText(string path, Encoding encoding)
        {
            return File.ReadAllText(path, encoding);
        }

        public byte[] ReadAllBytes(string path)
        {
            return File.ReadAllBytes(path);
        }

        public string[] ReadAllLines(string path)
        {
            return File.ReadAllLines(path);
        }

        public string[] ReadAllLines(string path, Encoding encoding)
        {
            return File.ReadAllLines(path, encoding);
        }

        public void Create(string path)
        {
            File.Create(path);
        }

        public void Create(string path, int bufferSize)
        {
            File.Create(path, bufferSize);
        }

        public void Create(string path, int bufferSize, FileOptions options)
        {
            File.Create(path, bufferSize, options);
        }

        public void Create(string path, int bufferSize, FileOptions options, FileSecurity security)
        {
            File.Create(path, bufferSize, options, security);
        }

        public StreamWriter CreateText(string path)
        {
            return File.CreateText(path);
        }

        public void Decrypt(string path)
        {
            File.Decrypt(path);
        }

        public void Delete(string path)
        {
            File.Delete(path);
        }

        public void Encrypt(string path)
        {
            File.Encrypt(path);
        }

        public FileSecurity GetAccessControl(string path)
        {
            return File.GetAccessControl(path);
        }

        public FileSecurity GetAccessControl(string path, AccessControlSections includeSections)
        {
            return File.GetAccessControl(path, includeSections);
        }

        public DateTime GetCreationTime(string path)
        {
            return File.GetCreationTime(path);
        }

        public DateTime GetCreationTimeUtc(string path)
        {
            return File.GetCreationTimeUtc(path);
        }

        public DateTime GetLastAccessTime(string path)
        {
            return File.GetLastAccessTime(path);
        }

        public DateTime GetLastAccessTimeUtc(string path)
        {
            return File.GetLastAccessTimeUtc(path);
        }

        public DateTime GetLastWriteTime(string path)
        {
            return File.GetLastWriteTime(path);
        }

        public DateTime GetLastWriteTimeUtc(string path)
        {
            return File.GetLastWriteTimeUtc(path);
        }
       
        public void Move(string source, string destination)
        {
            File.Move(source, destination);
        }

        public FileStream Open(string path, FileMode mode)
        {
            return File.Open(path, mode);
        }

        public FileStream Open(string path, FileMode mode, FileAccess access)
        {
            return File.Open(path,mode, access);
        }

        public FileStream Open(string path, FileMode mode, FileAccess access, FileShare share)
        {
            return File.Open(path, mode, access, share);
        }

        public void SetAccessControl(string path, FileSecurity fileSecurity)
        {
            File.SetAccessControl(path, fileSecurity);
        }

        public void SetCreationTime(string path, DateTime newDateTime)
        {
            File.SetCreationTime(path, newDateTime);
        }

        public void SetCreationTimeUtc(string path, DateTime newDateTime)
        {
            File.SetCreationTimeUtc(path, newDateTime);
        }

        public void SetLastAccessTime(string path, DateTime newDateTime)
        {
            File.SetLastAccessTime(path, newDateTime);
        }

        public void SetLastAccessTimeUtc(string path, DateTime newDateTime)
        {
            File.SetLastAccessTimeUtc(path, newDateTime);
        }

        public void SetLastWriteTime(string path, DateTime newDateTime)
        {
            File.SetLastWriteTime(path, newDateTime);
        }
    }
}
