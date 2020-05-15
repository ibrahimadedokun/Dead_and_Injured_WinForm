using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace MyClassLibrary
{
    class SerializeData
    {
        Stream stream = null;
        BinaryFormatter bf = null;
        string _filePathname = "";

        //Constructor 
        public SerializeData(string filePathname)
        {
            _filePathname = filePathname;
            stream = File.Open(_filePathname, FileMode.Create);
            bf = new BinaryFormatter();
        }

        public void SerializeObject(Object objectToSerialize)
        {
            bf.Serialize(stream, objectToSerialize);
        }

        public void DeserializeObject()
        {
            Object objectToDeserialize = null;
            stream = File.Open(_filePathname, FileMode.Open);
            try
            {
                while (stream.CanSeek)
                {
                    objectToDeserialize = (Object)bf.Deserialize(stream);
                }
            }
            catch (SerializationException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("End of File");
            }
        }

        public void CloseStream()
        {
            stream.Close();
        }
    }
}
