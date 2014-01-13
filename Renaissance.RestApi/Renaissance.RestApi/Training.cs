using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.XPath;
using umbraco.cms.businesslogic.web;

namespace Renaissance.RestApi
{
    public class Training
    {

        public static string HelloWorld()
        {
            return "Hi";
        }

        public static string Hello(string name)
        {
            return "Hi" + name;
        }

        public static XPathNodeIterator  GetDataById(int id)
        {
          return umbraco.library.GetXmlNodeById(id.ToString());
        }

        public static string Create(int parentId, string name)
        {
            DocumentType dt = DocumentType.GetByAlias("Textpage");
            Document d = Document.MakeNew(name, dt, new umbraco.BusinessLogic.User(0), parentId);
            d.Publish(new umbraco.BusinessLogic.User(0));
            d.Save();

            umbraco.library.PublishSingleNode(d.Id);
            return umbraco.library.NiceUrl(d.Id);
        }




    }
}
