using System;
using System.Collections.Generic;
using System.Web.Script.Serialization;


namespace SerializationDemos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Lizard> lizards = Lizard.GetLizards();
            SerializeOneLizard("one.json", lizards[0]);
            SerializeLizards("many.json", lizards);

        }

        static void SerializeOneLizard(string filename , Lizard lizard)
        {
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            using (System.IO.TextWriter writer = new System.IO.StreamWriter(filename))
            {
                string result = serializer.Serialize(lizard);
                writer.Write(result);
            }
        }

        static void SerializeLizards(string filename, List<Lizard>lizards)
        {
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            using (System.IO.TextWriter writer = new System.IO.StreamWriter(filename))
            {
                string result = serializer.Serialize(lizards);
                writer.Write(result);
            }
        }
    }
}
