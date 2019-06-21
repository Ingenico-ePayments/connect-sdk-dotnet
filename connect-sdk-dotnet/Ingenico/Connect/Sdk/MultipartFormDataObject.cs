using System;
using System.Collections.Generic;
using System.Collections.Immutable;

namespace Ingenico.Connect.Sdk
{
    /// <summary>
    /// A representation of a multipart/form-data object.
    /// </summary>
    public class MultipartFormDataObject
    {
        public MultipartFormDataObject()
        {
            Boundary = Guid.NewGuid().ToString();
            ContentType = "multipart/form-data; boundary=" + Boundary;
            values = new Dictionary<string, string>();
            files = new Dictionary<string, UploadableFile>();
        }

        public string Boundary { get; private set; }

        public string ContentType { get; private set; }

        public IDictionary<string, string> Values
        {
            get
            {
                return ImmutableDictionary.ToImmutableDictionary(values);
            }
        }

        public IDictionary<string, UploadableFile> Files
        {
            get
            {
                return ImmutableDictionary.ToImmutableDictionary(files);
            }
        }

        public void AddValue(string parameterName, string value)
        {
            if (string.IsNullOrWhiteSpace(parameterName))
            {
                throw new ArgumentException("Parameter name is required");
            }
            if (value == null)
            {
                throw new ArgumentException("value is required");
            }
            if (values.ContainsKey(parameterName) || files.ContainsKey(parameterName))
            {
                throw new ArgumentException("Duplicate parameter name: " + parameterName);
            }
            values.Add(parameterName, value);
        }

        public void AddFile(string parameterName, UploadableFile file)
        {
            if (string.IsNullOrWhiteSpace(parameterName))
            {
                throw new ArgumentException("Parameter name is required");
            }
            if (file == null)
            {
                throw new ArgumentException("file is required");
            }
            if (values.ContainsKey(parameterName) || files.ContainsKey(parameterName))
            {
                throw new ArgumentException("Duplicate parameter name: " + parameterName);
            }
            files.Add(parameterName, file);
        }

        readonly IDictionary<string, string> values;
        readonly IDictionary<string, UploadableFile> files;
    }
}
