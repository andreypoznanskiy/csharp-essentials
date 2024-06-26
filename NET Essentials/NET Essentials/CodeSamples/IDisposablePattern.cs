using System;
using System.IO;
using System.Windows;

namespace NET_Essentials.CodeSamples
{
    public static class IDisposablePattern
    {
        public static void TestIDisposable()
        {
            try
            {
                using (var reader = new ReaderFromDisk("C:\\Users\\andre\\Documents\\text.txt"))
                {
                    var firstLine = reader.ReadLine();
                    MessageBox.Show(firstLine, "File first line");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error");
            }
        }
    }

    public class ReaderFromDisk : IDisposable
    {
        private bool _disposed = false;
        private StreamReader _streamReader;

        public ReaderFromDisk(string filePath)
        {
            _streamReader = new StreamReader(filePath);
        }

        public string ReadLine()
        {
            return _streamReader.ReadLine();
        }

        public void Dispose()
        {
            Dispose(true);

            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (_disposed) return;

            if (disposing)
            {
                //Empty managed
            }

            _streamReader.Close();

            _disposed = true;
        }

        ~ReaderFromDisk()
        {
            Dispose(false);
        }
    }
}