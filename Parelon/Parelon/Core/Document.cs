using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Xml;

namespace Parelon.Core
{
    public class Document
    {
        public static Document instance { get; set; }

        public XmlDocument toXml ( )
        {
            return new XmlDocument();
        }


        public Document ( String text )
        {
            int id = 1;
            doc = new XmlDocument();
            XmlDeclaration xmlDeclaration = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
            XmlElement root = doc.CreateElement("root");
            XmlAttribute idAttr = doc.CreateAttribute("id");
            idAttr.Value = id++.ToString();
            root.Attributes.Append(idAttr);
            doc.AppendChild(root);
            doc.InsertBefore(xmlDeclaration, root);

            String separator = @"\r\n";
            String[] strings = Regex.Split(text, separator);
            XmlElement lastContainer = null, lastArticle = null, lastParagraph = null, lastList = null;
            bool isInArticle = false;
            for (int idx = 0; idx < strings.Length; idx++)
            {
                if (strings[idx].StartsWith(@"\titolo"))
                {
                    lastContainer = doc.CreateElement("title");
                    idAttr = doc.CreateAttribute("id");
                    idAttr.Value = id++.ToString();
                    lastContainer.Attributes.Append(idAttr);
                    root.AppendChild(lastContainer);
                    XmlElement element = doc.CreateElement("p");
                    idAttr = doc.CreateAttribute("id");
                    idAttr.Value = id++.ToString();
                    element.Attributes.Append(idAttr);
                    element.InnerText = strings[idx].Replace(@"\titolo", @"").Trim();
                    lastContainer.AppendChild(element);
                    isInArticle = false;
                }
                else if (strings[idx].StartsWith(@"\sottotitolo"))
                {
                    lastContainer = doc.CreateElement("subtitle");
                    root.AppendChild(lastContainer);
                    idAttr = doc.CreateAttribute("id");
                    idAttr.Value = id++.ToString();
                    lastContainer.Attributes.Append(idAttr);
                    XmlElement element = doc.CreateElement("p");
                    idAttr = doc.CreateAttribute("id");
                    idAttr.Value = id++.ToString();
                    element.Attributes.Append(idAttr);
                    element.InnerText = strings[idx].Replace(@"\sottotitolo", @"").Trim();
                    lastContainer.AppendChild(element);
                    isInArticle = false;
                }
                else if (strings[idx].StartsWith(@"\introduzione"))
                {
                    lastContainer = doc.CreateElement("introduction");
                    root.AppendChild(lastContainer);
                    idAttr = doc.CreateAttribute("id");
                    idAttr.Value = id++.ToString();
                    lastContainer.Attributes.Append(idAttr);
                    XmlElement element = doc.CreateElement("p");
                    idAttr = doc.CreateAttribute("id");
                    idAttr.Value = id++.ToString();
                    element.Attributes.Append(idAttr);
                    element.InnerText = strings[idx].Replace(@"\introduzione", @"").Trim();
                    lastContainer.AppendChild(element);
                    isInArticle = false;
                }
                else if (strings[idx].StartsWith(@"\testo"))
                {
                    lastContainer = doc.CreateElement("text");
                    root.AppendChild(lastContainer);
                    idAttr = doc.CreateAttribute("id");
                    idAttr.Value = id++.ToString();
                    lastContainer.Attributes.Append(idAttr);
                    XmlElement element = doc.CreateElement("p");
                    idAttr = doc.CreateAttribute("id");
                    idAttr.Value = id++.ToString();
                    element.Attributes.Append(idAttr);
                    element.InnerText = strings[idx].Replace(@"\testo", @"").Trim();
                    lastContainer.AppendChild(element);
                    isInArticle = false;
                }
                else if (strings[idx].StartsWith(@"\conclusioni"))
                {
                    lastContainer = doc.CreateElement("conclusions");
                    root.AppendChild(lastContainer);
                    idAttr = doc.CreateAttribute("id");
                    idAttr.Value = id++.ToString();
                    lastContainer.Attributes.Append(idAttr);
                    XmlElement element = doc.CreateElement("p");
                    idAttr = doc.CreateAttribute("id");
                    idAttr.Value = id++.ToString();
                    element.Attributes.Append(idAttr);
                    element.InnerText = strings[idx].Replace(@"\conclusioni", @"").Trim();
                    lastContainer.AppendChild(element);
                    isInArticle = false;
                }
                else if (strings[idx].StartsWith(@"\articolo"))
                {
                    lastArticle = doc.CreateElement("article");
                    lastContainer.AppendChild(lastArticle);
                    idAttr = doc.CreateAttribute("id");
                    idAttr.Value = id++.ToString();
                    lastArticle.Attributes.Append(idAttr);
                    XmlElement articleTitle = doc.CreateElement("p");
                    articleTitle.InnerText = strings[idx].Replace(@"\articolo", @"").Trim();
                    idAttr = doc.CreateAttribute("id");
                    idAttr.Value = id++.ToString();
                    articleTitle.Attributes.Append(idAttr);
                    lastArticle.AppendChild(articleTitle);
                    isInArticle = true;
                }
                else if (strings[idx].StartsWith(@"\elenco"))
                {
                    lastList = doc.CreateElement("ul");
                    idAttr = doc.CreateAttribute("id");
                    idAttr.Value = id++.ToString();
                    lastList.Attributes.Append(idAttr);
                    if (lastParagraph != null)
                        lastParagraph.AppendChild(lastList);
                    isInArticle = true;
                }
                else if (strings[idx].StartsWith(@"-") && lastList != null)
                {
                    XmlElement element = doc.CreateElement("il");
                    idAttr = doc.CreateAttribute("id");
                    idAttr.Value = id++.ToString();
                    element.Attributes.Append(idAttr);
                    lastList.AppendChild(element);
                    element.AppendChild(doc.CreateElement("p"));
                    idAttr = doc.CreateAttribute("id");
                    idAttr.Value = id++.ToString();
                    element.LastChild.Attributes.Append(idAttr);
                    element.LastChild.InnerText = strings[idx].Replace(@"-", @"").Trim();
                }
                else
                {
                    XmlElement element;
                    if (isInArticle)
                    {
                        element = doc.CreateElement("paragraph");
                        idAttr = doc.CreateAttribute("id");
                        idAttr.Value = id++.ToString();
                        element.Attributes.Append(idAttr);
                        lastArticle.AppendChild(element);
                        lastParagraph = element;
                        element.AppendChild(doc.CreateElement("p"));
                        idAttr = doc.CreateAttribute("id");
                        idAttr.Value = id++.ToString();
                        element.LastChild.Attributes.Append(idAttr);
                        element.LastChild.InnerText = strings[idx].Trim();
                    }
                    else if (!strings[idx].Trim().Equals(@""))
                    {
                        element = doc.CreateElement("p");
                        element.InnerText = strings[idx].Trim();
                        idAttr = doc.CreateAttribute("id");
                        idAttr.Value = id++.ToString();
                        element.Attributes.Append(idAttr);
                        if (lastContainer != null)
                            lastContainer.AppendChild(element);
                    }
                }
            }
        }

        private XmlDocument doc;

        public XmlDocument getDocument { get { return doc; } }

        public XmlNode findNodeById ( string id )
        {
            foreach (XmlNode node in doc.LastChild)
            {
                XmlNode result = findNodeById(node, id);
                if (result != null)
                    return result;
            }
            return null;
        }

        public XmlNode findNodeById ( XmlNode node, string id )
        {
            if (node.Name.Equals("p"))
                return null;
            if (node.Attributes.GetNamedItem("id").Value.Equals(id))
                return node;
            if (node.HasChildNodes)
            {
                for (int i = 0; i < node.ChildNodes.Count; i++)
                {
                    XmlNode result = findNodeById(node.ChildNodes[i], id);
                    if (result != null)
                        return result;
                }
            }
            return null;
        }
    }
}