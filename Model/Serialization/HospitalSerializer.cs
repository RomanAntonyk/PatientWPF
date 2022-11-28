using System.IO;
using System.Runtime.Serialization;

namespace Lab_2.Model.Serialization
{
    public class HospitalSerializer
    {
        public static void Serialize(string fileName, Hospital hospital)
        {
            var serializer = new DataContractSerializer(typeof(Hospital));
            var stream = new FileStream(fileName, FileMode.Create);
            serializer.WriteObject(stream, hospital);
            stream.Close();
        }

        public static Hospital Deserialize(string fileName)
        {
            var deserializer = new DataContractSerializer(typeof(Hospital));
            var stream = new FileStream(fileName, FileMode.Open);
            return (Hospital)deserializer.ReadObject(stream);
        }
    }
}
