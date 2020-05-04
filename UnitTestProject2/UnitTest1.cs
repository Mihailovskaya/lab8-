using Microsoft.VisualStudio.TestTools.UnitTesting;
using sofxml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Linq;
using System.Threading.Tasks;
/*
namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        List<string> columnsList = new List<string>{
                "name",
                "n_zach",
                "group",
                "subject",
                "mark",
                "Course"
                };
        string actual = "";
        [TestMethod]
        public void TestMethod1()
        {
            string expected = "XmlException";
            try
            {
                XDocument xdoc = XDocument.Load("test1.xml");
                if (xdoc.Element("Students") == null)
                {
                    throw new System.Xml.XmlException();
                }
                var items = from xe in xdoc.Element("students").Elements("student")
                            select new 
                            {
                                Name = xe.Attribute("name").Value,
                                Mark = xe.Element("mark").Value,
                                Group = xe.Element("group").Value,
                                N_zach = xe.Element("n_zach").Value,
                                Subject = xe.Element("subject").Value,
                                Course = xe.Element("Course").Value
                            };

            }
            catch (NullReferenceException)
            {
                actual = "NullReferenceException";
            }
            catch (FileNotFoundException)
            {
                actual = "FileNotFoundException";
            }
            catch (System.Xml.XmlException)
            {
                actual = "XmlException";
            }
            catch (Exception ex)
            {
                actual = ex.Message;
            }
            Assert.AreEqual(expected, actual);
            Console.WriteLine(actual);

        }
        [TestMethod]
        public void TestMethod2()
        {
            string expected = "FileNotFoundException";
            actual = "";
            try
            {
                XDocument xdoc = XDocument.Load("test2.xml");
                if (xdoc.Element("Students") == null)
                {
                    throw new System.Xml.XmlException();
                }
                var items = from xe in xdoc.Element("students").Elements("student")
                            select new
                            {
                                Name = xe.Attribute("student name").Value,
                                Mark = xe.Element("mark").Value,
                                Group = xe.Element("group").Value,
                                N_zach = xe.Element("n_zach").Value,
                                Subject = xe.Element("subject").Value,
                                Course = xe.Element("Course").Value
                            };




            }
            catch (NullReferenceException)
            {
                actual = "NullReferenceException";
            }
            catch (FileNotFoundException)
            {
                actual = "FileNotFoundException";
            }
            catch (System.Xml.XmlException)
            {
                actual = "XmlException";
            }
            catch (Exception ex)
            {
                actual = ex.Message;
            }
            Assert.AreEqual(expected, actual);
            Console.WriteLine(actual);

        }
        [TestMethod]
        public void TestMethod3()
        {
            string expected = "XmlException";
            actual = "";
            try
            {
                
                XDocument xdoc = XDocument.Load("test3.xml");
                if (xdoc.Element("Students") == null)
                {
                    throw new System.Xml.XmlException();
                }
                var items = from xe in xdoc.Element("students").Elements("student")
                            select new
                            {
                                Name = xe.Attribute("name").Value,
                                Mark = xe.Element("mark").Value,
                                Group = xe.Element("group").Value,
                                N_zach = xe.Element("n_zach").Value,
                                Subject = xe.Element("subject").Value,
                                Course = xe.Element("Course").Value
                            };

            
            }
            catch (NullReferenceException)
            {
                actual = "NullReferenceException";
            }
            catch (FileNotFoundException)
            {
                actual = "FileNotFoundException";
            }
            catch (System.Xml.XmlException)
            {
                actual = "XmlException";
            }
            catch (Exception ex)
            {
                actual = ex.Message;
            }
            Assert.AreEqual(expected, actual);
            Console.WriteLine(actual);

        }
        [TestMethod]
        public void TestMethod4()
        {
            string expected = "XmlException";
            actual = "";
            try
            {
                XDocument xdoc = XDocument.Load("test4.xml");
                if (xdoc.Element("Students") == null)
                {
                    throw new System.Xml.XmlException();
                }
                var items = from xe in xdoc.Element("students").Elements("student")
                            select new
                            {
                                Name = xe.Attribute("name").Value,
                                Mark = xe.Element("mark").Value,
                                Group = xe.Element("group").Value,
                                N_zach = xe.Element("n_zach").Value,
                                Subject = xe.Element("subject").Value,
                                Course = xe.Element("Course").Value
                            };

            }
            catch (NullReferenceException)
            {
                actual = "NullReferenceException";
            }
            catch (FileNotFoundException)
            {
                actual = "FileNotFoundException";
            }
            catch (System.Xml.XmlException)
            {
                actual = "XmlException";
            }
            catch (Exception ex)
            {
                actual = ex.Message;
            }
            Assert.AreEqual(expected, actual);
            Console.WriteLine(actual);

        }
       
        [TestMethod]
        public void TestMethod6()
        {
            string expected = "XmlException";
            actual = "";
            try
            {
                XDocument xdoc = XDocument.Load("test6.xml");
                if (xdoc.Element("Students") == null)
                {
                    throw new System.Xml.XmlException();
                }
                var items = from xe in xdoc.Element("students").Elements("student")
                            select new
                            {
                                Name = xe.Attribute("name").Value,
                                Mark = xe.Element("mark").Value,
                                Group = xe.Element("group").Value,
                                N_zach = xe.Element("n_zach").Value,
                                Subject = xe.Element("subject").Value,
                                Course = xe.Element("Course").Value
                            };

            }
            catch (NullReferenceException)
            {
                actual = "NullReferenceException";
            }
            catch (FileNotFoundException)
            {
                actual = "FileNotFoundException";
            }
            catch (System.Xml.XmlException)
            {
                actual = "XmlException";
            }
            catch (Exception ex)
            {
                actual = ex.Message;
            }
            Assert.AreEqual(expected, actual);
            Console.WriteLine(actual);

        }
        [TestMethod]
        public void TestMethod7()
        {
            string expected = "XmlException";
            actual = "";
            try
            {
                XDocument xdoc = XDocument.Load("test7.xml");
                if (xdoc.Element("Students") == null)
                {
                    throw new System.Xml.XmlException();
                }
                var items = from xe in xdoc.Element("students").Elements("student")
                            select new
                            {
                                Name = xe.Attribute("name").Value,
                                Mark = xe.Element("mark").Value,
                                Group = xe.Element("group").Value,
                                N_zach = xe.Element("n_zach").Value,
                                Subject = xe.Element("subject").Value,
                                Course = xe.Element("Course").Value
                            };

            }
            catch (NullReferenceException)
            {
                actual = "NullReferenceException";
            }
            catch (FileNotFoundException)
            {
                actual = "FileNotFoundException";
            }
            catch (System.Xml.XmlException)
            {
                actual = "XmlException";
            }
            catch (Exception ex)
            {
                actual = ex.Message;
            }
            Assert.AreEqual(expected, actual);
            Console.WriteLine(actual);

        }
        [TestMethod]
        public void TestMethod8()
        {
            string expected = "XmlException";
            actual = "";
            try
            {
                XDocument xdoc = XDocument.Load("test8.xml");
                if (xdoc.Element("Students") == null)
                {
                    throw new System.Xml.XmlException();
                }
                var items = from xe in xdoc.Element("students").Elements("student")
                            select new
                            {
                                Name = xe.Attribute("name").Value,
                                Mark = xe.Element("mark").Value,
                                Group = xe.Element("group").Value,
                                N_zach = xe.Element("n_zach").Value,
                                Subject = xe.Element("subject").Value,
                                Course = xe.Element("Course").Value
                            };

            }
            catch (NullReferenceException)
            {
                actual = "NullReferenceException";
            }
            catch (FileNotFoundException)
            {
                actual = "FileNotFoundException";
            }
            catch (System.Xml.XmlException)
            {
                actual = "XmlException";
            }
            catch (Exception ex)
            {
                actual = ex.Message;
            }
            Assert.AreEqual(expected, actual);
            Console.WriteLine(actual);

        }
        [TestMethod]
        public void TestMethod9()
        {
            string expected = "XmlException";
            actual = "";
            try
            {
                XDocument xdoc = XDocument.Load("test9.xml");
                if (xdoc.Element("Students") == null)
                {
                    throw new System.Xml.XmlException();
                }
                var items = from xe in xdoc.Element("students").Elements("student")
                            select new
                            {
                                Name = xe.Attribute("name").Value,
                                Mark = xe.Element("mark").Value,
                                Group = xe.Element("group").Value,
                                N_zach = xe.Element("n_zach").Value,
                                Subject = xe.Element("subject").Value,
                                Course = xe.Element("Course").Value
                            };

            }
            catch (NullReferenceException)
            {
                actual = "NullReferenceException";
            }
            catch (FileNotFoundException)
            {
                actual = "FileNotFoundException";
            }
            catch (System.Xml.XmlException)
            {
                actual = "XmlException";
            }
            catch (Exception ex)
            {
                actual = ex.Message;
            }
            Assert.AreEqual(expected, actual);
            Console.WriteLine(actual);

        }
        [TestMethod]
        public void TestMethod10()
        {
            string expected = "XmlException";
            actual = "";
            try
            {
                XDocument xdoc = XDocument.Load("test11.xml");
                if (xdoc.Element("Students") == null)
                {
                    throw new System.Xml.XmlException();
                }
                var items = from xe in xdoc.Element("students").Elements("student")
                            select new
                            {
                                Name = xe.Attribute("name").Value,
                                N_zach = xe.Element("n_zach").Value,
                                Group = xe.Element("group").Value,
                                Subject = xe.Element("subject").Value,
                                Mark = xe.Element("mark").Value,
                                Course = xe.Element("Course").Value
                            };

            }
            catch (NullReferenceException)
            {
                actual = "NullReferenceException";
            }
            catch (FileNotFoundException)
            {
                actual = "FileNotFoundException";
            }
            catch (System.Xml.XmlException)
            {
                actual = "XmlException";
            }
            catch (Exception ex)
            {
                actual = ex.Message;
            }
            Assert.AreEqual(expected, actual);
            Console.WriteLine(actual);

        }
        [TestMethod]
        public void TestMethod11()
        {
            string expected = "";
            try
            {
                actual = "";
                XDocument xdoc = XDocument.Load("test10.xml");
                if (xdoc.Element("Subscribers") == null)
                {
                    throw new System.Xml.XmlException();
                }
                var subscribers = from subscriber in xdoc.Descendants("Subscriber")
                                  select new
                                  {
                                      Name = subscriber.Attribute(columnsList[0]).Value,
                                      N_zach = subscriber.Element(columnsList[1]).Value,
                                      Group = subscriber.Element(columnsList[2]).Value,
                                      Subject = subscriber.Element(columnsList[3]).Value,
                                      Mark = subscriber.Element(columnsList[4]).Value,
                                      Course = subscriber.Element(columnsList[5]).Value
                                      
                                  };

            }
            catch (NullReferenceException)
            {
                actual = "NullReferenceException";
            }
            catch (FileNotFoundException)
            {
                actual = "FileNotFoundException";
            }
            catch (System.Xml.XmlException)
            {
                actual = "XmlException";
            }
            catch (Exception ex)
            {
                actual = ex.Message;
            }
            Assert.AreEqual(expected, actual);
            Console.WriteLine(actual);

        }
        [TestMethod]
        public void TestMethod1s()
        {
            string expected = "";
            actual = "";
            try
            {
                actual = "";
                XDocument xdoc = XDocument.Load("test10.xml");
                if (xdoc.Element("Subscribers") == null)
                {
                    throw new System.Xml.XmlException();
                }
                var s = from sss in xdoc.Descendants("Subscriber")
                                  select new
                                  {
                                      Name = sss.Element("Номер_договора").Value,
                                      Contract = sss.Element(columnsList[1]).Value,
                                      District = sss.Element(columnsList[2]).Value,
                                      Address = sss.Element(columnsList[3]).Value,
                                      Telephone = sss.Element(columnsList[4]).Value,
                                      ContractDate = sss.Element(columnsList[5]).Value,
                                      EquipmentPayment = sss.Element(columnsList[6]).Value,
                                      SubscriptionFee = sss.Element(columnsList[7]).Value,
                                      LastPayment = sss.Element(columnsList[8]).Value

                                  };

            }
            catch (NullReferenceException)
            {
                actual = "NullReferenceException";
            }
            catch (FileNotFoundException)
            {
                actual = "FileNotFoundException";
            }
            catch (System.Xml.XmlException)
            {
                actual = "XmlException";
            }
            catch (Exception ex)
            {
                actual = ex.Message;
            }
            Assert.AreEqual(expected, actual);
            Console.WriteLine(actual);

        }
    }
}
*/

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        List<string> columnsList = new List<string>{
                "name",
                "n_zach",
                "group",
                "subject",
                "mark",
                "Course"
                };
        string actual = "";
        [TestMethod]
        public void TestMethod1()
        {
            string expected = "XmlException";
            try
            {
                XDocument xdoc = XDocument.Load("test1.xml");
                if (xdoc.Element("students") == null)
                {
                    throw new System.Xml.XmlException();
                }
                var ss = from s in xdoc.Descendants("student")
                         select new
                         {
                             Name = s.Attribute(columnsList[0]).Value,
                             N_zach = s.Element(columnsList[1]).Value,
                             Group = s.Element(columnsList[2]).Value,
                             Subject = s.Element(columnsList[3]).Value,
                             Mark = s.Element(columnsList[4]).Value,
                             Course = s.Element(columnsList[5]).Value

                         };


            }
            catch (NullReferenceException)
            {
                actual = "NullReferenceException";
            }
            catch (FileNotFoundException)
            {
                actual = "FileNotFoundException";
            }
            catch (System.Xml.XmlException)
            {
                actual = "XmlException";
            }
            catch (Exception ex)
            {
                actual = ex.Message;
            }
            Assert.AreEqual(expected, actual);
            Console.WriteLine(actual);

        }
        [TestMethod]
        public void TestMethod2()
        {
            string expected = "FileNotFoundException";
            actual = "";
            try
            {
                XDocument xdoc = XDocument.Load("test2.xml");
                if (xdoc.Element("students") == null)
                {
                    throw new System.Xml.XmlException();
                }
                var ss = from s in xdoc.Descendants("student")
                         select new
                         {
                             Name = s.Attribute(columnsList[0]).Value,
                             N_zach = s.Element(columnsList[1]).Value,
                             Group = s.Element(columnsList[2]).Value,
                             Subject = s.Element(columnsList[3]).Value,
                             Mark = s.Element(columnsList[4]).Value,
                             Course = s.Element(columnsList[5]).Value

                         };




            }
            catch (NullReferenceException)
            {
                actual = "NullReferenceException";
            }
            catch (FileNotFoundException)
            {
                actual = "FileNotFoundException";
            }
            catch (System.Xml.XmlException)
            {
                actual = "XmlException";
            }
            catch (Exception ex)
            {
                actual = ex.Message;
            }
            Assert.AreEqual(expected, actual);
            Console.WriteLine(actual);

        }
        [TestMethod]
        public void TestMethod3()
        {
            string expected = "";
            actual = "";
            try
            {

                XDocument xdoc = XDocument.Load("test3.xml");
                if (xdoc.Element("students") == null)
                {
                    throw new System.Xml.XmlException();
                }
                var ss = from s in xdoc.Descendants("student")
                         select new
                         {
                             Name = s.Attribute(columnsList[0]).Value,
                             N_zach = s.Element(columnsList[1]).Value,
                             Group = s.Element(columnsList[2]).Value,
                             Subject = s.Element(columnsList[3]).Value,
                             Mark = s.Element(columnsList[4]).Value,
                             Course = s.Element(columnsList[5]).Value

                         };

            }
            catch (NullReferenceException)
            {
                actual = "NullReferenceException";
            }
            catch (FileNotFoundException)
            {
                actual = "FileNotFoundException";
            }
            catch (System.Xml.XmlException)
            {
                actual = "XmlException";
            }
            catch (Exception ex)
            {
                actual = ex.Message;
            }
            Assert.AreEqual(expected, actual);
            Console.WriteLine(actual);

        }
        [TestMethod]
        public void TestMethod4()
        {
            string expected = "XmlException";
            actual = "";
            try
            {
                XDocument xdoc = XDocument.Load("test4.xml");
                if (xdoc.Element("students") == null)
                {
                    throw new System.Xml.XmlException();
                }
                var ss = from s in xdoc.Descendants("student")
                         select new
                         {
                             Name = s.Attribute(columnsList[0]).Value,
                             N_zach = s.Element(columnsList[1]).Value,
                             Group = s.Element(columnsList[2]).Value,
                             Subject = s.Element(columnsList[3]).Value,
                             Mark = s.Element(columnsList[4]).Value,
                             Course = s.Element(columnsList[5]).Value

                         };


            }
            catch (NullReferenceException)
            {
                actual = "NullReferenceException";
            }
            catch (FileNotFoundException)
            {
                actual = "FileNotFoundException";
            }
            catch (System.Xml.XmlException)
            {
                actual = "XmlException";
            }
            catch (Exception ex)
            {
                actual = ex.Message;
            }
            Assert.AreEqual(expected, actual);
            Console.WriteLine(actual);

        }

        [TestMethod]
        public void TestMethod6()
        {
            string expected = "XmlException";
            actual = "";
            try
            {
                XDocument xdoc = XDocument.Load("test6.xml");
                if (xdoc.Element("students") == null)
                {
                    throw new System.Xml.XmlException();
                }
                var ss = from s in xdoc.Descendants("student")
                         select new
                         {
                             Name = s.Attribute(columnsList[0]).Value,
                             N_zach = s.Element(columnsList[1]).Value,
                             Group = s.Element(columnsList[2]).Value,
                             Subject = s.Element(columnsList[3]).Value,
                             Mark = s.Element(columnsList[4]).Value,
                             Course = s.Element(columnsList[5]).Value

                         };


            }
            catch (NullReferenceException)
            {
                actual = "NullReferenceException";
            }
            catch (FileNotFoundException)
            {
                actual = "FileNotFoundException";
            }
            catch (System.Xml.XmlException)
            {
                actual = "XmlException";
            }
            catch (Exception ex)
            {
                actual = ex.Message;
            }
            Assert.AreEqual(expected, actual);
            Console.WriteLine(actual);

        }
        [TestMethod]
        public void TestMethod7()
        {
            string expected = "";
            actual = "";
            try
            {
                XDocument xdoc = XDocument.Load("test7.xml");
                if (xdoc.Element("students") == null)
                {
                    throw new System.Xml.XmlException();
                }
                var ss = from s in xdoc.Descendants("student")
                         select new
                         {
                             Name = s.Attribute(columnsList[0]).Value,
                             N_zach = s.Element(columnsList[1]).Value,
                             Group = s.Element(columnsList[2]).Value,
                             Subject = s.Element(columnsList[3]).Value,
                             Mark = s.Element(columnsList[4]).Value,
                             Course = s.Element(columnsList[5]).Value

                         };


            }
            catch (NullReferenceException)
            {
                actual = "NullReferenceException";
            }
            catch (FileNotFoundException)
            {
                actual = "FileNotFoundException";
            }
            catch (System.Xml.XmlException)
            {
                actual = "XmlException";
            }
            catch (Exception ex)
            {
                actual = ex.Message;
            }
            Assert.AreEqual(expected, actual);
            Console.WriteLine(actual);

        }
        [TestMethod]
        public void TestMethod8()
        {
            string expected = "XmlException";
            actual = "";
            try
            {
                XDocument xdoc = XDocument.Load("test8.xml");
                if (xdoc.Element("students") == null)
                {
                    throw new System.Xml.XmlException();
                }
                var ss = from s in xdoc.Descendants("student")
                         select new
                         {
                             Name = s.Attribute(columnsList[0]).Value,
                             N_zach = s.Element(columnsList[1]).Value,
                             Group = s.Element(columnsList[2]).Value,
                             Subject = s.Element(columnsList[3]).Value,
                             Mark = s.Element(columnsList[4]).Value,
                             Course = s.Element(columnsList[5]).Value

                         };

            }
            catch (NullReferenceException)
            {
                actual = "NullReferenceException";
            }
            catch (FileNotFoundException)
            {
                actual = "FileNotFoundException";
            }
            catch (System.Xml.XmlException)
            {
                actual = "XmlException";
            }
            catch (Exception ex)
            {
                actual = ex.Message;
            }
            Assert.AreEqual(expected, actual);
            Console.WriteLine(actual);

        }
       
        [TestMethod]
        public void TestMethod10()
        {
            string expected = "XmlException";
            actual = "";
            try
            {
                XDocument xdoc = XDocument.Load("test10.xml");
                if (xdoc.Element("students") == null)
                {
                    throw new System.Xml.XmlException();
                }
                var ss = from s in xdoc.Descendants("student")
                         select new
                         {
                             Name = s.Attribute(columnsList[0]).Value,
                             N_zach = s.Element(columnsList[1]).Value,
                             Group = s.Element(columnsList[2]).Value,
                             Subject = s.Element(columnsList[3]).Value,
                             Mark = s.Element(columnsList[4]).Value,
                             Course = s.Element(columnsList[5]).Value

                         };


            }
            catch (NullReferenceException)
            {
                actual = "NullReferenceException";
            }
            catch (FileNotFoundException)
            {
                actual = "FileNotFoundException";
            }
            catch (System.Xml.XmlException)
            {
                actual = "XmlException";
            }
            catch (Exception ex)
            {
                actual = ex.Message;
            }
            Assert.AreEqual(expected, actual);
            Console.WriteLine(actual);

        }
        
        [TestMethod]
        public void TestMethod1s()
        {
            string expected = "XmlException";
            actual = "";
            try
            {
                
                XDocument xdoc = XDocument.Load("test10.xml");
                if (xdoc.Element("students") == null)
                {
                    throw new System.Xml.XmlException();
                }
                var ss = from s in xdoc.Descendants("student")
                         select new
                         {
                             Name = s.Attribute(columnsList[0]).Value,
                             N_zach = s.Element(columnsList[1]).Value,
                             Group = s.Element(columnsList[2]).Value,
                             Subject = s.Element(columnsList[3]).Value,
                             Mark = s.Element(columnsList[4]).Value,
                             Course = s.Element(columnsList[5]).Value

                         };

            }
            catch (NullReferenceException)
            {
                actual = "NullReferenceException";
            }
            catch (FileNotFoundException)
            {
                actual = "FileNotFoundException";
            }
            catch (System.Xml.XmlException)
            {
                actual = "XmlException";
            }
            catch (Exception ex)
            {
                actual = ex.Message;
            }
            Assert.AreEqual(expected, actual);
            Console.WriteLine(actual);

        }
    }
}