using System.Xml;
using System.Xml.Xsl;

var xslFile = "xsl/fdl2proto.xsl";
var inputFile = args[0];
var outputFile = args[1];

var xslt = new XslCompiledTransform();
xslt.Load(xslFile, new XsltSettings(), new XmlUrlResolver());
xslt.Transform(inputFile, outputFile);
