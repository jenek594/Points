using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Text.Json;
using System.Xml;
using System.Xml.Serialization;
using YamlDotNet.Serialization.NamingConventions;
using YamlDotNet.Serialization;
namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private PointLib.Point[] points = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            points = new PointLib.Point[5];

            var rnd = new Random();

            for (int i = 0; i < points.Length; i++)
                points[i] = rnd.Next(3) % 2 == 0 ? new PointLib.Point() : new Point3D();

            listBox.DataSource = points;
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            if (points == null)
                return;

            Array.Sort(points);

            listBox.DataSource = null;
            listBox.DataSource = points;
        }

        private void btnSerialize_Click(object sender, EventArgs e)
        {
            var dlg = new SaveFileDialog();
            dlg.Filter = "SOAP|*.soap|XML|*.xml|JSON|*.json|Binary|*.bin";

            if (dlg.ShowDialog() != DialogResult.OK)
                return;

            using (var fs = new FileStream(dlg.FileName, FileMode.Create, FileAccess.Write))
            {
                switch (Path.GetExtension(dlg.FileName))
                {
                    case ".soap":
                        var serializer = new DataContractSerializer(typeof(PointLib.Point[]));
                        var writer = XmlDictionaryWriter.CreateTextWriter(fs, Encoding.UTF8);
                        writer.WriteStartElement("ArrayOfPoint", "http://schemas.datacontract.org/2004/07/YourNamespace");
                        serializer.WriteObject(writer, points);
                        writer.WriteEndElement();
                        writer.Flush();
                        break;
                    case ".xml":
                        var xf = new XmlSerializer(typeof(PointLib.Point[]), new[] { typeof(Point3D) });
                        var xmlWriterSettings = new XmlWriterSettings { Indent = true };
                        using (var xmlWriter = XmlWriter.Create(fs, xmlWriterSettings))
                            xf.Serialize(xmlWriter, points);
                        break;
                    case ".json":
                        var options = new JsonSerializerOptions { WriteIndented = true };
                        using (var jsonWriter = new Utf8JsonWriter(fs, new JsonWriterOptions { Indented = true }))
                        {
                            JsonSerializer.Serialize(jsonWriter, points, options);
                        }
                        break;
                    case ".yaml":
                        var yamlSerializer = new SerializerBuilder()
                            .WithNamingConvention(CamelCaseNamingConvention.Instance)
                            .Build();
                        var yaml = yamlSerializer.Serialize(points);
                        using (var yamlWriter = new StreamWriter(fs))
                        {
                            yamlWriter.Write(yaml);
                        }
                        break;

                }
            }
        }

        private void btnDeserialize_Click(object sender, EventArgs e)
        {
            var dlg = new OpenFileDialog();
            dlg.Filter = "SOAP|*.soap|XML|*.xml|JSON|*.json|Binary|*.bin";

            if (dlg.ShowDialog() != DialogResult.OK)
                return;

            using (var fs = new FileStream(dlg.FileName, FileMode.Open, FileAccess.Read))
            {
                switch (Path.GetExtension(dlg.FileName))
                {
                    case ".soap":
                        var serializer = new DataContractSerializer(typeof(PointLib.Point[]));
                        var reader = XmlDictionaryReader.CreateTextReader(fs, new XmlDictionaryReaderQuotas());
                        reader.ReadStartElement("ArrayOfPoint", "http://schemas.datacontract.org/2004/07/YourNamespace");
                        points = (PointLib.Point[])serializer.ReadObject(reader);
                        reader.Close();
                        break;
                    case ".xml":
                        var xf = new XmlSerializer(typeof(PointLib.Point[]));
                        points = (PointLib.Point[])xf.Deserialize(fs);
                        break;
                    case ".json":
                        points = JsonSerializer.Deserialize<PointLib.Point[]>(fs);
                        break;
                    case ".yaml":
                        var deserializer = new DeserializerBuilder()
                            .WithNamingConvention(CamelCaseNamingConvention.Instance)
                            .Build();
                        using (var yamlReader = new StreamReader(fs))
                        {
                            var yaml = yamlReader.ReadToEnd();
                            points = deserializer.Deserialize<PointLib.Point[]>(yaml);
                        }
                        break;
                }
            }

            listBox.DataSource = null;
            listBox.DataSource = points;
        }
    }
}
