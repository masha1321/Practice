using Task1.Interfaces;
using System.Xml;
using Microsoft.Extensions.Logging;
using Task1.Models;

namespace Task1.Share
{
    public class XmlDocumentWorker : IXmlWorker
    {
        private readonly XmlDocument _xmlDocument;
        private readonly ILogger _logger;
        private string _xmlFilePath;
        private List<Sweet> sweet;

        public XmlDocumentWorker(ILogger logger)
        {
            _logger = logger;
            _xmlDocument = new XmlDocument();
        }

        public void Add(Sweet sweet)
        {
            var xRoot = _xmlDocument.DocumentElement;

            XmlElement sweetElem = _xmlDocument.CreateElement("Sweet");

            XmlAttribute typeAttribute = _xmlDocument.CreateAttribute("Type");
            XmlText typeText = _xmlDocument.CreateTextNode(sweet.Type);
            typeAttribute.AppendChild(typeText);
           

            XmlElement priceElem = _xmlDocument.CreateElement("Price");
            XmlText priceText = _xmlDocument.CreateTextNode(sweet.Price.ToString());
            priceElem.AppendChild(priceText);

            sweetElem.AppendChild(priceElem);

            xRoot.AppendChild(sweetElem);
            _xmlDocument.Save(_xmlFilePath);
        }

        public void Delete(string type)
        {
            var xRoot = _xmlDocument.DocumentElement;
            foreach (XmlNode xNode in xRoot)
            {
                if (xNode.Attributes.Count > 0)
                {
                    var attributeType = xNode.Attributes.GetNamedItem("Type");
                    try
                    {
                        var attributeTypeText = attributeType?.InnerText;
                        if (attributeTypeText.Equals(type))
                        {
                            xRoot.RemoveChild(xNode);
                            _xmlDocument.Save(_xmlFilePath);
                        }
                    }
                    catch (Exception ex) when (ex is XmlException || ex is NullReferenceException)
                    {
                        _logger.LogWarning(ex.Message, nameof(attributeType));
                    }
                }
            }
        }

        public Sweet FindBy(string type)
        {
            Sweet sweet = null;
            var xRoot = _xmlDocument.DocumentElement;
            foreach (XmlNode xNode in xRoot)
            {
                sweet = GetSweet(xNode);
                if (sweet.Type.Equals(type))
                {
                    return sweet;
                }
            }

            return sweet;
        }

        public List<Sweet> GetAll()
        {
            List<Sweet> flowers = new List<Sweet>();
            var xRoot = _xmlDocument.DocumentElement;
            foreach (XmlNode xNode in xRoot)
            {
                var sweet = GetSweet(xNode);
                sweet.Add(sweet);
            }

            return sweet;
        }

        public void Load(string xmlFilePath)
        {
            _xmlFilePath = xmlFilePath;
            _xmlDocument.Load(xmlFilePath);
        }

        private Sweet GetSweet(XmlNode xNode)
        {
            var sweet = new Sweet();
            if(xNode.Attributes.Count > 0)
            {
                var attributeType = xNode.Attributes.GetNamedItem("Type");
                sweet.Type = attributeType?.Value;
            }
            foreach (XmlNode childNode in xNode.ChildNodes)
            {
                try
                {
                    if (childNode.Name == "Price")
                    {
                        sweet.Price = double.Parse(childNode.InnerText);
                    }
                }
                catch (Exception ex) when (ex is FormatException || ex is NullReferenceException)
                {
                    _logger.LogError(ex.Message, ex.StackTrace, nameof(childNode.InnerText));
                }
            }
            return sweet;
        }
    }
}