using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CharterSampleApp.Helpers
{
    public interface IFileHelper
    {
        string GetLocalFilePath(string fileName);

        string GetLocalFilePath(Stream stream);
        string GetLocalFilePath(Stream stream, String filePath);
        string GetImagesFolder(string folderName);
        string GetImagesFilePath();
    }
}
