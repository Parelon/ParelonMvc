//TODO: tradurre XmlDocument  in .net core (XDocuemnt)
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.Linq;

namespace ParelonCore.Core
{
    public class Document
    {
        public static Document instance { get; set; }

        public XDocument toXml()
        {
            return new XDocument();
        }


        public Document(String text)
        {

            int id = 1;
            doc = new XDocument();
            XDeclaration xmlDeclaration = new XDeclaration("1.0", "UTF-8", null);  //doc.CreateXmlDeclaration("1.0", "UTF-8", null);
            XElement root = new XElement("root"); // doc.CreateElement("root");
            XAttribute idAttr = new XAttribute("id", id++.ToString()); // doc.CreateAttribute("id");
            //idAttr.Value = id++.ToString();
            //root.Attributes.Append(idAttr);            
            root.SetAttributeValue(idAttr.Name, idAttr.Value);
            doc.Declaration = xmlDeclaration;
            doc.Add(root);
            //doc.InsertBefore(xmlDeclaration, root);

            String separator = @"\r\n";
            String[] strings = Regex.Split(text, separator);
            XElement lastContainer = null, lastArticle = null, lastParagraph = null, lastList = null;
            bool isInArticle = false;
            for (int idx = 0; idx < strings.Length; idx++)
            {
                if (strings[idx].StartsWith(@"\titolo"))
                {
                    lastContainer = new XElement("title", new XAttribute("id", id++.ToString())); // doc.CreateElement("title");
                    //idAttr = new XAttribute("id", id++.ToString()); //doc.CreateAttribute("id");
                    //idAttr.Value = id++.ToString();
                    //lastContainer.Attributes.Append(idAttr);
                    //lastContainer.SetAttributeValue(idAttr.Name, idAttr.Value);
                    //root.AppendChild(lastContainer);
                    root.Add(lastContainer);
                    XElement element = new XElement("p", new XAttribute("id", id++.ToString())); // doc.CreateElement("p");
                    //idAttr = new XAttribute("id", id++.ToString());  //doc.CreateAttribute("id");
                    //idAttr.Value = id++.ToString();
                    //element.Attributes.Append(idAttr);
                    //element.SetAttributeValue(idAttr.Name, idAttr.Value);
                    //element.InnerText = strings[idx].Replace(@"\titolo", @"").Trim();
                    element.Value = strings[idx].Replace(@"\titolo", @"").Trim();
                    //lastContainer.AppendChild(element);
                    lastContainer.Add(element);
                    isInArticle = false;
                }
                else if (strings[idx].StartsWith(@"\sottotitolo"))
                {
                    lastContainer = new XElement("subtitle", new XAttribute("id", id++.ToString())); // doc.CreateElement("subtitle");
                    //root.AppendChild(lastContainer);
                    root.Add(lastContainer);
                    //idAttr = doc.CreateAttribute("id");
                    //idAttr.Value = id++.ToString();
                    //lastContainer.Attributes.Append(idAttr);
                    //lastContainer.SetAttributeValue(idAttr.Name, idAttr.Value);

                    XElement element = new XElement("p", new XAttribute("id", id++.ToString())); // doc.CreateElement("p");
                    //idAttr = doc.CreateAttribute("id");
                    //idAttr.Value = id++.ToString();
                    //element.Attributes.Append(idAttr);
                    //element.SetAttributeValue(idAttr.Name, idAttr.Value);
                    //element.InnerText = strings[idx].Replace(@"\sottotitolo", @"").Trim();
                    element.Value = strings[idx].Replace(@"\sottotitolo", @"").Trim();
                    //lastContainer.AppendChild(element);
                    lastContainer.Add(element);
                    isInArticle = false;
                }
                else if (strings[idx].StartsWith(@"\introduzione"))
                {
                    lastContainer = new XElement("introduction", new XAttribute("id", id++.ToString())); // doc.CreateElement("introduction");
                    root.Add(lastContainer);
                    //idAttr = doc.CreateAttribute("id");
                    //idAttr.Value = id++.ToString();
                    //lastContainer.SetAttributeValue(idAttr.Name, idAttr.Value);
                    XElement element = new XElement("p", new XAttribute("id", id++.ToString())); //doc.CreateElement("p");
                    //idAttr = doc.CreateAttribute("id");
                    //idAttr.Value = id++.ToString();
                    //element.SetAttributeValue(idAttr.Name, idAttr.Value);
                    element.Value = strings[idx].Replace(@"\introduzione", @"").Trim();
                    lastContainer.Add(element);
                    isInArticle = false;
                }
                else if (strings[idx].StartsWith(@"\testo"))
                {
                    lastContainer = new XElement("text", new XAttribute("id", id++.ToString())); //doc.CreateElement("text");
                    root.Add(lastContainer);
                    //idAttr = doc.CreateAttribute("id");
                    //idAttr.Value = id++.ToString();
                    //lastContainer.SetAttributeValue(idAttr.Name, idAttr.Value);
                    XElement element = new XElement("p", new XAttribute("id", id++.ToString())); //doc.CreateElement("p");
                    //idAttr = doc.CreateAttribute("id");
                    //idAttr.Value = id++.ToString();
                    //element.SetAttributeValue(idAttr.Name, idAttr.Value);
                    element.Value = strings[idx].Replace(@"\testo", @"").Trim();
                    lastContainer.Add(element);
                    isInArticle = false;
                }
                else if (strings[idx].StartsWith(@"\conclusioni"))
                {
                    lastContainer = new XElement("conclusions", new XAttribute("id", id++.ToString())); //doc.CreateElement("conclusions");
                    root.Add(lastContainer);
                    //idAttr = doc.CreateAttribute("id");
                    //idAttr.Value = id++.ToString();
                    //lastContainer.SetAttributeValue(idAttr.Name, idAttr.Value);
                    XElement element = new XElement("p", new XAttribute("id", id++.ToString())); //doc.CreateElement("p");
                    //idAttr = doc.CreateAttribute("id");
                    //idAttr.Value = id++.ToString();
                    //element.SetAttributeValue(idAttr.Name, idAttr.Value);
                    element.Value = strings[idx].Replace(@"\conclusioni", @"").Trim();
                    lastContainer.Add(element);
                    isInArticle = false;
                }
                else if (strings[idx].StartsWith(@"\articolo"))
                {
                    lastArticle = new XElement("article", new XAttribute("id", id++.ToString())); //doc.CreateElement("article");
                    lastContainer.Add(lastArticle);
                    //idAttr = doc.CreateAttribute("id");
                    //idAttr.Value = id++.ToString();
                    //lastArticle.SetAttributeValue(idAttr.Name, idAttr.Value);
                    XElement articleTitle = new XElement("p", new XAttribute("id", id++.ToString())); //doc.CreateElement("p");
                    articleTitle.Value = strings[idx].Replace(@"\articolo", @"").Trim();
                    //idAttr = doc.CreateAttribute("id");
                    //idAttr.Value = id++.ToString();
                    //articleTitle.SetAttributeValue(idAttr.Name, idAttr.Value);
                    lastArticle.Add(articleTitle);
                    isInArticle = true;
                }
                else if (strings[idx].StartsWith(@"\elenco"))
                {
                    lastList = new XElement("ul", new XAttribute("id", id++.ToString())); //doc.CreateElement("ul");
                    //idAttr = doc.CreateAttribute("id");
                    //idAttr.Value = id++.ToString();
                    //lastList.SetAttributeValue(idAttr.Name, idAttr.Value);
                    if (lastParagraph != null)
                        lastParagraph.Add(lastList);
                    isInArticle = true;
                }
                else if (strings[idx].StartsWith(@"-") && lastList != null)
                {
                    XElement element = new XElement("il", new XAttribute("id", id++.ToString())); //doc.CreateElement("il");
                    //idAttr = doc.CreateAttribute("id");
                    //idAttr.Value = id++.ToString();
                    //element.SetAttributeValue(idAttr.Name, idAttr.Value);
                    XElement element2 = new XElement("p", new XAttribute("id", id++.ToString()));
                    element2.Value = strings[idx].Replace(@"-", @"").Trim();
                    element.Add(element2);

                    lastList.Add(element);


                    //element.Add(doc.CreateElement("p"));
                    //idAttr = doc.CreateAttribute("id");
                    //idAttr.Value = id++.ToString();
                    //element.LastChild.Attributes.Append(idAttr);
                    //element.LastChild.InnerText = strings[idx].Replace(@"-", @"").Trim();
                }
                else
                {
                    XElement element;
                    if (isInArticle)
                    {
                        element = new XElement("paragraph", new XAttribute("id", id++.ToString())); //doc.CreateElement("paragraph");
                        //idAttr = doc.CreateAttribute("id");
                        //idAttr.Value = id++.ToString();
                        //element.SetAttributeValue(idAttr.Name, idAttr.Value);

                        XElement element2 = new XElement("p", new XAttribute("id", id++.ToString()));
                        element2.Value = strings[idx].Trim();
                        element.Add(element2);

                        lastArticle.Add(element);
                        lastParagraph = element;

                        //element.Add(doc.CreateElement("p"));
                        //idAttr = doc.CreateAttribute("id");
                        //idAttr.Value = id++.ToString();
                        //element.LastChild.Attributes.Append(idAttr);
                        //element.LastChild.InnerText = strings[idx].Trim();
                    }
                    else if (!strings[idx].Trim().Equals(@""))
                    {
                        element = new XElement("p", new XAttribute("id", id++.ToString())); //doc.CreateElement("p");
                        element.Value = strings[idx].Trim();
                        //idAttr = doc.CreateAttribute("id");
                        //idAttr.Value = id++.ToString();
                        //element.SetAttributeValue(idAttr.Name, idAttr.Value);
                        if (lastContainer != null)
                            lastContainer.Add(element);
                    }
                }
            }
        }

        private XDocument doc;

        public XDocument getDocument { get { return doc; } }

        public XElement findNodeById(string id)
        {
            foreach (XElement node in doc.Root.Elements())
            {
                XElement result = findNodeById(node, id);
                if (result != null)
                    return result;
            }
            return null;
        }

        public XElement findNodeById(XElement node, string id)
        {
            var t = doc.Descendants("Move").Last();

            if (node.Name.LocalName == "p")
                return null;
            if (node.Attribute("id").Value.Equals(id))
                return node;
            if (node.Elements().Count() > 1)
            {
                //for (int i = 0; i < node.ChildNodes.Count; i++)
                foreach (XElement _child in node.Elements())
                {
                    XElement result = findNodeById(_child, id);
                    if (result != null)
                        return result;
                }
            }
            return null;
        }
    }


}